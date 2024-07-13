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
            try
            {
                if (gp_camera.Image != null)
                {
                    _mongoDBHelper = new MongoDBHelper(); //conectar a la base de datos
                    //procesar imagen
                    Bitmap bitmap = new Bitmap(gp_camera.Image);
                    string fileName = $"captura_{DateTime.Now:yyyyMMddHHmmss}.jpg";
                    string fullPath = Path.Combine(folderPath, fileName);
                    bitmap.Save(fullPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //guardar datos en base de datos
                    _mongoDBHelper.InsertDocument(DateTime.UtcNow, "19.4326", "-99.1332", "10 km", fileName);
                    //mensaje de confirmacion
                    MessageBox.Show($"Imagen capturada y guardada en: {fullPath}", "Captura Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
