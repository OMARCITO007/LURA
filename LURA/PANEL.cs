using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Media;
using System.Runtime.InteropServices;
using Amazon.Auth.AccessControlPolicy;


namespace LURA
{
    public partial class PANEL : Form
    {
        private static PANEL _instance;

        // Declaraciones de la API de Windows
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private const int DefaultPort = 3921;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Propiedad para obtener la instancia única
        public static PANEL Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new PANEL();
                }
                return _instance;
            }
        }

        private GoproConect goproConect;
        private Control[] initialControls;
        //private ConfigManager configManager;
        private Timer Tiempo;

        // Constructor privado para evitar la creación de instancias externas
        private PANEL()
        {
            InitializeComponent();
            goproConect = new GoproConect(gp_camera, list_gp);
            UsbComManager.Instance.Initialize(list_gps, btn_conectar_gps, list_usb_encoder, btn_conectar_enc);
            UsbComManager.Instance.GPSDataReceived += OnGPSDataReceived;
            Odometro.Instance.DataReceived += Odometro_DataReceived;

            this.Load += new EventHandler(Form_Load);
            iniciar_medida.Enabled = false;
            zero_pulsos.Enabled = false;
            btn_capture.Enabled = false;

            InitializeTimer();
            // Configurar eventos de mouse para el panel
            panel1.MouseDown += Panel1_MouseDown;
            panel3.MouseDown += Panel1_MouseDown;
        }

        private void InitializeTimer()
        {
            Tiempo = new Timer();
            Tiempo.Interval = 50; // Intervalo de 100 ms (0.1 segundo)
            Tiempo.Tick += new EventHandler(Tiempo_Tick);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            initialControls = new Control[pantallas.Controls.Count];
            pantallas.Controls.CopyTo(initialControls, 0);
        }

        private void ControlUss(UserControl userControl)
        {
            pantallas.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pantallas.Controls.Add(userControl);
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            pantallas.Controls.Clear();
            pantallas.Controls.AddRange(initialControls);
        }

        private void btn_datos_Click(object sender, EventArgs e)
        {
            ControlUss(new Datos());
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            ControlUss(new Configuracion());
        }

        private void PANEL_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cerrar la aplicación?", "Confirmar cierre", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_conectar_enc_Click(object sender, EventArgs e)
        {
            UsbComManager.Instance.ToggleEncoderConnection();
            if (btn_conectar_enc.Text == "Desconectar")
            {
                iniciar_medida.Enabled = true;
                zero_pulsos.Enabled = true;
                btn_conectar_enc.BackColor = Color.Tomato;
            }
            else
            {
                iniciar_medida.Enabled = false;
                zero_pulsos.Enabled = false;
                btn_conectar_enc.BackColor = Color.FromArgb(0, 163, 88);
            }
        }

        private void btn_conectar_gps_Click(object sender, EventArgs e)
        {
            UsbComManager.Instance.ToggleGPSConnection();
            if (btn_conectar_gps.Text == "Desconectar")
            {
                btn_conectar_gps.BackColor = Color.Tomato;
            }
            else
            {
                btn_conectar_gps.BackColor = Color.FromArgb(0, 163, 88);
            }
        }

        private void btn_conectar_gp_Click(object sender, EventArgs e)
        {
            goproConect.ConnectCamera(btn_conectar_gp);
            if (btn_conectar_gp.Text == "Desconectar")
            {
                btn_conectar_gp.BackColor = Color.Tomato;
                btn_capture.Enabled = true;
            }
            else
            {
                btn_conectar_gp.BackColor = Color.FromArgb(0, 163, 88);
                btn_capture.Enabled = false;
            }
        }

        private void OnGPSDataReceived(object sender, GPSDataReceivedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                latitud_gps.Text = e.Latitude.ToString("F6");
                longitud_gps.Text = e.Longitude.ToString("F6");
                altura_gps.Text = e.Altitude.ToString("F2");
            }));
        }

        private void OnENCDataReceived(object sender, EncUpdEncoderEventArgs e)
        {
            Invoke(new Action(() =>
            {
                lblDistanciaCorregida.Text = e.DistanciaTotalCorregida.ToString("F3");
                pulsos_encoder.Text = e.PulsosContados.ToString("F0");
            }));
        }

        private void Odometro_DataReceived(object sender, UpdateEncoderEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    lblDistanciaCorregida.Text = e.DistanciaTotalCorregida.ToString("F3");
                    pulsos_encoder.Text = e.PulsosContados.ToString();
                }));
            }
            else
            {
                lblDistanciaCorregida.Text = e.DistanciaTotalCorregida.ToString("F3");
                pulsos_encoder.Text = e.PulsosContados.ToString();
            }
        }

        private void btn_capture_Click(object sender, EventArgs e)
        {
            if (double.TryParse(dist_total.Text, out double distancia_total) &&
                double.TryParse(distancia.Text, out double distanciaIngresada))
            {
                // Sumar la distancia ingresada a la distancia total
                distancia_total += distanciaIngresada;

                // Actualizar el texto del TextBox con el nuevo valor
                dist_total.Text = distancia_total.ToString();
            }
            goproConect.CaptureImage();
        }

        private void zero_pulsos_Click(object sender, EventArgs e)
        {
            UsbComManager.Instance.SendCommand("ZERO");
        }

        private void iniciar_medida_Click(object sender, EventArgs e)
        {
            if (Tiempo.Enabled)
            {
                Tiempo.Stop();
                iniciar_medida.Text = "INICIAR";
                iniciar_medida.BackColor = Color.FromArgb(0, 163, 88);
            }
            else
            {
                Tiempo.Start();
                iniciar_medida.Text = "PARAR";
                iniciar_medida.BackColor = Color.Tomato;
            }
        }

        private void Tiempo_Tick(object sender, EventArgs e) //Timer de captura de imagen por distancia
        {
            if (double.TryParse(lblDistanciaCorregida.Text, out double distanciaCorregida) &&
                double.TryParse(distancia.Text, out double distanciaIngresada))
            {
                if (distanciaCorregida == distanciaIngresada)
                {
                    if (double.TryParse(dist_total.Text, out double distancia_total))
                    {
                        // Sumar la distancia ingresada a la distancia total
                        distancia_total += distanciaIngresada;

                        // Actualizar el texto del TextBox con el nuevo valor
                        dist_total.Text = distancia_total.ToString();
                    }
                    // Enviar comando "ZERO" a través de UsbComManager
                    UsbComManager.Instance.SendCommand("ZERO");

                    // Reproducir un sonido beep
                    SystemSounds.Beep.Play();

                    // Capturar imagen usando la GoPro conectada
                    goproConect.CaptureImage();
                }
            }
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            OnFormClosing(null);
            Application.Exit();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            goproConect.DetenerCaptura();
        }


    }
}
