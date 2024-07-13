using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LURA
{
    public partial class Inicio : UserControl
    {
        private GoproConect goproConect;
        private UsbComManager usbComManager;

        public Inicio()
        {
            InitializeComponent();
            goproConect = new GoproConect(gp_camera, list_gp);
            usbComManager = new UsbComManager(list_gps, btn_conectar_gps, list_usb_encoder, btn_conectar_enc);
            usbComManager.GPSDataReceived += UsbComManager_GPSDataReceived;
            usbComManager.EncoderDataReceived += UsbComManager_EncoderDataReceived;
        }


        private void Inicio_Load(object sender, EventArgs e)
        {

            iniciar_medida.Enabled = false;
            zero_pulsos.Enabled = false;

        }

 

        private void btn_conectar_gp_Click(object sender, EventArgs e)
        {
            goproConect.ConnectCamera(btn_conectar_gp);
        }


        private void btn_capture_Click(object sender, EventArgs e)
        {
            goproConect.CaptureImage();
        }

        private void btn_conectar_enc_Click(object sender, EventArgs e)
        {
            usbComManager.ToggleEncoderConnection();

        }



        private void btn_conectar_gps_Click(object sender, EventArgs e)
        {
            usbComManager.ToggleGPSConnection();
        }

        private void UsbComManager_GPSDataReceived(object sender, string data)
        {
            // Handle GPS data received from the USB COM manager
        }

        private void UsbComManager_EncoderDataReceived(object sender, string data)
        {
            // Handle encoder data received from the USB COM manager
        }



    }
}
