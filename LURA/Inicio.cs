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

namespace LURA
{
    public partial class Inicio : UserControl
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        // Ruta donde se guardará la carpeta de fotos
        private string folderPath;


        public Inicio()
        {
            InitializeComponent();
            // Obtener la ruta de la carpeta "fotos" en la misma ubicación que la aplicación
            folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fotos");       
        }


        private void Inicio_Load(object sender, EventArgs e)
        {
            // Enumerar todas las cámaras de video disponibles
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count > 0)
            {
                // Llenar el ComboBox con las cámaras disponibles
                foreach (FilterInfo device in videoDevices)
                {
                    list_gp.Items.Add(device.Name);
                }

                // Seleccionar la primera cámara por defecto
                list_gp.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No se encontraron cámaras de video disponibles.");
            }
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                // Obtener el frame de video
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

                // Actualizar el PictureBox en el hilo de la interfaz de usuario
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

        private void btn_conectar_gp_Click(object sender, EventArgs e)
        {
            try
            {
                // Detener la captura de video actual si ya estaba en ejecución
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }

                // Obtener el dispositivo seleccionado en el ComboBox
                var selectedDeviceIndex = list_gp.SelectedIndex;
                var selectedDevice = videoDevices[selectedDeviceIndex];

                // Configurar VideoCaptureDevice para la cámara seleccionada
                videoSource = new VideoCaptureDevice(selectedDevice.MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar con la cámara: " + ex.Message);
            }
        }
        private void DetenerCaptura()
        {
            // Detener la captura de video si está en ejecución
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void btn_capture_Click(object sender, EventArgs e)
        {
            try
            {
                if (gp_camera.Image != null)
                {
                    // Capturar la imagen actual del PictureBox
                    Bitmap bitmap = new Bitmap(gp_camera.Image);

                    // Generar un nombre de archivo único para la imagen
                    string fileName = $"captura_{DateTime.Now:yyyyMMddHHmmss}.jpg";

                    // Guardar la imagen en la carpeta específica
                    string fullPath = Path.Combine(folderPath, fileName);

                    // Guardar la imagen en disco
                    bitmap.Save(fullPath, System.Drawing.Imaging.ImageFormat.Jpeg);

                    // Mostrar mensaje de éxito
                    MessageBox.Show($"Imagen capturada y guardada en: {fullPath}", "Captura Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Liberar recursos
                    bitmap.Dispose();
                }
                else
                {
                    MessageBox.Show("No hay imagen para capturar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al capturar y guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}
