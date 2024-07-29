using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LURA
{
    public partial class PANEL : Form
    {
        private UsbComManager usbComManager;
        //private CierreVentanaDetector _cierreVentanaDetector;//detectar cierre de ventana para detener procesos
        private GoproConect goproConect;
        private Control[] initialControls;
        private GPSProcessor gpsProcessor; // Instancia de la clase GPS
        private ConfigManager configManager;

        public PANEL()
        {

            InitializeComponent();
            gpsProcessor = new GPSProcessor();
            //pantallas.Controls.Add(inicio);
            goproConect = new GoproConect(gp_camera, list_gp);
            usbComManager = new UsbComManager(list_gps, btn_conectar_gps, list_usb_encoder, btn_conectar_enc);
            //usbComManager = new UsbComManager(list_gps, btn_conectar_gps, list_usb_encoder, btn_conectar_enc, latitud_gps, longitud_gps, altura_gps);
            usbComManager.GPSDataReceived += OnGPSDataReceived;
            //usbComManager.ENCDataReceived += OnENCDataReceived;
            Odometro.Instance.DataReceived += Odometro_DataReceived;

            this.Load += new EventHandler(Form_Load);
            //iniciar_medida.Enabled = false;
            //zero_pulsos.Enabled = false;

            configManager = ConfigManager.Instance;



        }



        private void Form_Load(object sender, EventArgs e)
        {
            // Almacena los controles actuales del panel ventanas
            initialControls = new Control[pantallas.Controls.Count];
            pantallas.Controls.CopyTo(initialControls, 0);
        }

        private void ControlUss (UserControl userControl) 
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
            // Aquí puedes realizar las acciones que deseas antes de que el formulario se cierre
            DialogResult result = MessageBox.Show("¿Seguro que quieres cerrar la aplicación?", "Confirmar cierre", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                // Cancela el cierre si el usuario elige No
                e.Cancel = true;
            }
            else
            {
            }

        }

        private void btn_conectar_enc_Click(object sender, EventArgs e)
        {
            usbComManager.ToggleEncoderConnection();
        }

        private void btn_conectar_gps_Click(object sender, EventArgs e)
        {
            usbComManager.ToggleGPSConnection();
        }

        private void btn_conectar_gp_Click(object sender, EventArgs e)
        {
            goproConect.ConnectCamera(btn_conectar_gp);
        }

        private void OnGPSDataReceived(object sender, GPSDataReceivedEventArgs e)
        {
            // Actualizar los controles del formulario con los datos GPS
            Invoke(new Action(() =>
            {
                latitud_gps.Text = e.Latitude.ToString("F6");
                longitud_gps.Text = e.Longitude.ToString("F6");
                altura_gps.Text = e.Altitude.ToString("F2");
            }));
        }


         private void OnENCDataReceived(object sender, EncUpdEncoderEventArgs e)
        {
            //  Actualizar la interfaz de usuario con la distancia corregida y los pulsos contados
            Invoke(new Action(() =>
            {
                lblDistanciaCorregida.Text = e.DistanciaTotalCorregida.ToString("F2");
                pulsos_encoder.Text = e.PulsosContados.ToString("F0");
            }));
        }

        private void Odometro_DataReceived(object sender, UpdateEncoderEventArgs e)
        {
            // Actualiza los TextBox en el UserControl
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    lblDistanciaCorregida.Text = e.DistanciaTotalCorregida.ToString();
                    pulsos_encoder.Text = e.PulsosContados.ToString();
                }));
            }
            else
            {
                lblDistanciaCorregida.Text = e.DistanciaTotalCorregida.ToString();
                pulsos_encoder.Text = e.PulsosContados.ToString();
            }
        }

        private void btn_capture_Click(object sender, EventArgs e)
        {
            goproConect.CaptureImage();
        }

        private void iniciar_medida_Click(object sender, EventArgs e)
        {
            string datos = "Pulsos: 123456"; // Ejemplo de datos
            Odometro.Instance.CalcularDistanciaCorregida(datos);
        }
    }
}

