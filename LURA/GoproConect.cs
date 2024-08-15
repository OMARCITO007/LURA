using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;


namespace LURA
{


    public class GoproConect
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private PictureBox gp_camera;
        private ComboBox list_gp;
        private string folderPath;
        private MongoDBHelper _mongoDBHelper;

        private DateTime _lastFrameTime = DateTime.MinValue;
        private readonly int _frameIntervalMs = 100; // Actualiza cada 100ms (~10 FPS)

        public GoproConect(PictureBox pictureBox, ComboBox comboBox)
        {
            gp_camera = pictureBox;
            list_gp = comboBox;
            folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fotos");
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            LoadAvailableCameras();
        }
         

        private void LoadAvailableCameras()
        {
            if (videoDevices.Count > 0)
            {
                foreach (FilterInfo device in videoDevices)
                {
                    list_gp.Items.Add(device.Name);
                }

                list_gp.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No se encontraron cámaras de video disponibles.");
            }
        }

        public void ConnectCamera(Button btn_conectar_gp)
        {
            if (btn_conectar_gp.Text == "Conectar")
            {
                try
                {
                    // Detener cualquier cámara que esté en ejecución antes de iniciar una nueva conexión
                    if (videoSource != null && videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource.WaitForStop();
                    }

                    // Verificar que el usuario haya seleccionado un dispositivo
                    if (list_gp.SelectedIndex == -1)
                    {
                        MessageBox.Show("Por favor, selecciona un dispositivo de cámara.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Obtener el dispositivo seleccionado
                    var selectedDeviceIndex = list_gp.SelectedIndex;
                    var selectedDevice = videoDevices[selectedDeviceIndex];

                    // Actualizar la interfaz de usuario
                    btn_conectar_gp.Text = "Desconectar";
                    list_gp.Enabled = false;

                    // Iniciar la cámara con el dispositivo seleccionado
                    videoSource = new VideoCaptureDevice(selectedDevice.MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                    videoSource.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la cámara: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btn_conectar_gp.Text == "Desconectar")
            {
                try
                {
                    DetenerCaptura();
                    btn_conectar_gp.Text = "Conectar";
                    list_gp.Enabled = true;

                    // Restaurar imagen predeterminada cuando se desconecta la cámara
                    gp_camera.Image = LURA.Properties.Resources.Group_245;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al desconectar la cámara: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                var currentTime = DateTime.Now;
                if ((currentTime - _lastFrameTime).TotalMilliseconds < _frameIntervalMs)
                    return; // Saltar frames si no ha pasado suficiente tiempo

                _lastFrameTime = currentTime;  // Actualiza el tiempo del último frame procesado

                // Clonar el frame actual de la cámara
                using (Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone())
                {
                    // Actualizar la imagen de la interfaz gráfica en el hilo principal
                    gp_camera.Invoke(new Action(() =>
                    {
                        if (gp_camera.Image != null)
                        {
                            gp_camera.Image.Dispose();  // Liberar la imagen anterior
                        }

                        gp_camera.Image = (Bitmap)bitmap.Clone();  // Asignar la nueva imagen
                    }));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al procesar el frame: " + ex.Message);
            }
        }


        public void DetenerCaptura()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                Task.Run(() =>
                {
                    try
                    {
                        videoSource.SignalToStop();
                        videoSource.WaitForStop();
                    }
                    catch (Exception ex)
                    {
                            MessageBox.Show("Error al detener la captura de video: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
        }


        public void CaptureImage()
        {
            if (gp_camera.Image == null)
            {
                MessageBox.Show("No hay imagen para capturar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Task.Run(() =>
            {
                try
                {
                    // Procesar imagen
                    _mongoDBHelper = new MongoDBHelper(); //conectar a la base de datos
                    string latitud = GPSProcessor.Instance.Latitude.ToString("F6");
                    string longitud = GPSProcessor.Instance.Longitude.ToString("F6");
                    string distancia = PANEL.Instance.distancia.Text;
                    string distancia_total = PANEL.Instance.dist_total.Text + " Km";
                    //string altitud = GPSProcessor.Instance.Altitude.ToString("F2") + " Metros";

                    Bitmap bitmap = new Bitmap(gp_camera.Image);
                    string fileName = $"captura_{DateTime.Now:yyyyMMddHHmmss}.jpg";
                    string fullPath = Path.Combine(folderPath, fileName);
                    /* 
                    string[] texto = new string[]
                    {
                $"Fecha: {DateTime.Now:yyyy-MM-dd HH:mm:ss}",
                $"Latitud: {latitud}",
                $"Longitud: {longitud}",
                $"Distancia Total: {distancia_total}",
                $"Altitud: {altitud}"
                    };

                    // Agregar texto a la imagen usando la clase EditarFoto
                    AgregarTexto(bitmap, texto);
                    */
                    // Verificar que la carpeta de destino exista
                    Directory.CreateDirectory(folderPath);

                    // Guardar imagen
                    bitmap.Save(fullPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bitmap.Dispose();

                    // Llamada a la base de datos y mensaje de confirmación en el hilo de UI

                    _mongoDBHelper.InsertDocument(DateTime.UtcNow, latitud, longitud, distancia_total, fileName);
                    //MessageBox.Show($"Imagen capturada y guardada en: {fullPath}", "Captura Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //catch (Exception ex)
                catch (Exception)
                {
                    // Mostrar error en el hilo de UI
                        //MessageBox.Show("Error al capturar y guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }





        private void AgregarTexto(Bitmap bitmap, string[] lineasDeTexto, float x = 10, float y = -1)
        {
            try
            {
                // Crear un objeto Graphics a partir del bitmap
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    // Definir la fuente y el pincel
                    Font font = new Font("Arial", 20, FontStyle.Bold);
                    Brush brush = new SolidBrush(Color.White);

                    // Ajustar la coordenada y para que el texto aparezca en la esquina inferior izquierda si no se proporciona
                    if (y == -1)
                    {
                        y = bitmap.Height - 40 * lineasDeTexto.Length;
                    }

                    // Dibujar cada línea de texto en el bitmap
                    foreach (string linea in lineasDeTexto)
                    {
                        graphics.DrawString(linea, font, brush, new PointF(x, y));
                        y += 40; // Ajustar la posición para la siguiente línea de texto
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar texto a la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
