using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Drawing.Imaging;
using MongoDB.Bson;
using MongoDB.Driver;
using static System.Net.Mime.MediaTypeNames;

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
                    if (videoSource != null && videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource.WaitForStop();
                    }

                    var selectedDeviceIndex = list_gp.SelectedIndex;
                    var selectedDevice = videoDevices[selectedDeviceIndex];
                    btn_conectar_gp.Text = "Desconectar";
                    list_gp.Enabled = false;

                    videoSource = new VideoCaptureDevice(selectedDevice.MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                    videoSource.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar con la cámara: " + ex.Message);
                }
            }
            else if (btn_conectar_gp.Text == "Desconectar")
            {
                DetenerCaptura();
                btn_conectar_gp.Text = "Conectar";
                list_gp.Enabled = true;
            }
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                gp_camera.Invoke(new Action(() =>
                {
                    if (gp_camera.Image != null)
                    {
                        gp_camera.Image.Dispose();
                    }

                    gp_camera.Image = bitmap;
                }));
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
                videoSource.SignalToStop();
                videoSource.WaitForStop();
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
                    string distancia = PANEL.Instance.distancia.Text + " Metros";
                    string altitud = GPSProcessor.Instance.Altitude.ToString("F2") + " Metros";

                    Bitmap bitmap = new Bitmap(gp_camera.Image);
                    string fileName = $"captura_{DateTime.Now:yyyyMMddHHmmss}.jpg";
                    string fullPath = Path.Combine(folderPath, fileName);
                     
                    string[] texto = new string[]
                    {
                $"Fecha: {DateTime.Now:yyyy-MM-dd HH:mm:ss}",
                $"Latitud: {latitud}",
                $"Longitud: {longitud}",
                $"Distancia: {distancia}",
                $"Altitud: {altitud}"
                    };

                    // Agregar texto a la imagen usando la clase EditarFoto
                    AgregarTexto(bitmap, texto);

                    // Verificar que la carpeta de destino exista
                    Directory.CreateDirectory(folderPath);

                    // Guardar imagen
                    bitmap.Save(fullPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bitmap.Dispose();

                    // Llamada a la base de datos y mensaje de confirmación en el hilo de UI

                    _mongoDBHelper.InsertDocument(DateTime.UtcNow, latitud, longitud, altitud, fileName);
                    MessageBox.Show($"Imagen capturada y guardada en: {fullPath}", "Captura Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Mostrar error en el hilo de UI
                        MessageBox.Show("Error al capturar y guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
