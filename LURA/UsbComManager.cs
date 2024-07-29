using System;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace LURA
{
    public class UsbComManager
    {
        private SerialPort serialPortGPS;
        private SerialPort serialPortEncoder;
        private Timer portCheckTimer;
        private ComboBox list_gps;
        private ComboBox list_usb_encoder;
        private Button btn_conectar_gps;
        private Button btn_conectar_enc;
        private GPSProcessor gpsProcessor;

        public event EventHandler<GPSDataReceivedEventArgs> GPSDataReceived;
        public event EventHandler<EncUpdEncoderEventArgs> ENCDataReceived;

        public UsbComManager(ComboBox comboBoxGPS, Button connectButtonGPS, ComboBox comboBoxEncoder, Button connectButtonEncoder)
        {
            list_gps = comboBoxGPS;
            btn_conectar_gps = connectButtonGPS;
            list_usb_encoder = comboBoxEncoder;
            btn_conectar_enc = connectButtonEncoder;

            gpsProcessor = new GPSProcessor(); // Initialize the GPSProcessor instance

            LoadAvailablePorts();

            // Configure the Timer to check available COM ports
            portCheckTimer = new Timer
            {
                Interval = 1000 // Check every 5 seconds
            };
            portCheckTimer.Tick += PortCheckTimer_Tick;
            portCheckTimer.Start();
        }

        private void PortCheckTimer_Tick(object sender, EventArgs e)
        {
            LoadAvailablePorts();
        }

        private void LoadAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();

            if (!ports.SequenceEqual(list_gps.Items.Cast<string>().ToArray()))
            {
                list_gps.Items.Clear(); // Clear the ComboBox
                list_gps.Items.AddRange(ports); // Add new ports

                if (ports.Length > 0)
                {
                    list_gps.SelectedIndex = 0; // Select the first port by default
                }
                else
                {
                    list_gps.Text = "No COM.";
                }
            }

            if (!ports.SequenceEqual(list_usb_encoder.Items.Cast<string>().ToArray()))
            {
                list_usb_encoder.Items.Clear(); // Clear the ComboBox
                list_usb_encoder.Items.AddRange(ports); // Add new ports

                if (ports.Length > 0)
                {
                    list_usb_encoder.SelectedIndex = 0; // Select the first port by default
                }
                else
                {
                    list_usb_encoder.Text = "No COM.";
                }
            }
        }



        public void ToggleGPSConnection()
        {
            if (serialPortGPS == null || !serialPortGPS.IsOpen)
            {
                ConnectToGPS();
            }
            else
            {
                DisconnectGPS();
            }
        }

        public void ToggleEncoderConnection()
        {
            if (serialPortEncoder == null || !serialPortEncoder.IsOpen)
            {
                ConnectToEncoder();
            }
            else
            {
                DisconnectEncoder();
            }
        }

        private void ConnectToGPS()
        {
            if (list_gps.SelectedItem != null)
            {
                string selectedPort = list_gps.SelectedItem.ToString();
                try
                {
                    serialPortGPS = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                    serialPortGPS.Open();
                    serialPortGPS.DataReceived += SerialPortGPS_DataReceived;
                    //serialPortGPS.ErrorReceived += SerialPortGPS_ErrorReceived;
                    portCheckTimer.Stop();
                    list_gps.Enabled = false;
                    btn_conectar_gps.Text = "Desconectar";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar GPS: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un puerto COM para GPS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConnectToEncoder()
        {
            if (list_usb_encoder.SelectedItem != null)
            {
                string selectedPort = list_usb_encoder.SelectedItem.ToString();
                try
                {
                    serialPortEncoder = new SerialPort(selectedPort, 115200, Parity.None, 8, StopBits.One);
                    serialPortEncoder.Open();
                    serialPortEncoder.DataReceived += SerialPortEncoder_DataReceived;
                    //serialPortEncoder.ErrorReceived += SerialPortEncoder_ErrorReceived;
                    portCheckTimer.Stop();
                    list_usb_encoder.Enabled = false;
                    btn_conectar_enc.Text = "Desconectar";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar encoder: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un puerto COM para el encoder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisconnectGPS()
        {
            if (serialPortGPS != null && serialPortGPS.IsOpen)
            {
                serialPortGPS.Close();
                btn_conectar_gps.Text = "Conectar";
                //serialPortGPS = null;
                portCheckTimer.Start();
                list_gps.Enabled = true;               
            }
        }

        private void DisconnectEncoder()
        {
            if (serialPortEncoder != null && serialPortEncoder.IsOpen)
            {
                serialPortEncoder.Close();
                btn_conectar_enc.Text = "Conectar";
                //serialPortEncoder = null;
                portCheckTimer.Start();
                list_usb_encoder.Enabled = true;             
            }
        }

        private void SerialPortGPS_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPortGPS.ReadLine();
                gpsProcessor.ProcessNMEAData(data);
                OnGPSDataReceived(gpsProcessor.Latitude, gpsProcessor.Longitude, gpsProcessor.Altitude);
            }
            catch
            {
                //MessageBox.Show("Error al recibir datos del GPS: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisconnectGPS(); // Attempt to disconnect on error
            }
        }

        private void SerialPortEncoder_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPortEncoder.ReadExisting();
                Odometro.Instance.CalcularDistanciaCorregida(data);
                OnENCDataReceived(Odometro.Instance.DistanciaTotalCorregida, Odometro.Instance.PulsosContados);

            }
            catch
            {
                //MessageBox.Show("Error al recibir datos del encoder: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisconnectEncoder(); // Attempt to disconnect on error
            }
        }


        protected virtual void OnGPSDataReceived(double latitude, double longitude, double altitude)
        {
            GPSDataReceived?.Invoke(this, new GPSDataReceivedEventArgs(latitude, longitude, altitude));
        }

        protected virtual void OnENCDataReceived(double medida, double pulsos)
        {
            ENCDataReceived?.Invoke(this, new EncUpdEncoderEventArgs(medida, pulsos));
        }
    }

    public class GPSDataReceivedEventArgs : EventArgs
    {
        public double Latitude { get; }
        public double Longitude { get; }
        public double Altitude { get; }

        public GPSDataReceivedEventArgs(double latitude, double longitude, double altitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            Altitude = altitude;
        }
    }

    public class EncUpdEncoderEventArgs : EventArgs
    {
        public double DistanciaTotalCorregida { get; private set; }
        public double PulsosContados { get; private set; }

        public EncUpdEncoderEventArgs(double medida, double pulsos)
        {
            DistanciaTotalCorregida = medida;
            PulsosContados = pulsos;
        }
    }
}
