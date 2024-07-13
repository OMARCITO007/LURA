using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
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

        public event EventHandler<string> GPSDataReceived;
        public event EventHandler<string> EncoderDataReceived;

        public UsbComManager(ComboBox comboBoxGPS, Button connectButtonGPS, ComboBox comboBoxEncoder, Button connectButtonEncoder)
        {
            list_gps = comboBoxGPS;
            btn_conectar_gps = connectButtonGPS;
            list_usb_encoder = comboBoxEncoder;
            btn_conectar_enc = connectButtonEncoder;

            LoadAvailablePorts();

            // Configure the Timer to check available COM ports
            portCheckTimer = new Timer();
            portCheckTimer.Interval = 5000; // Check every 5 seconds
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
                    portCheckTimer.Stop(); // Stop the Timer when connected
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
                    serialPortEncoder = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                    serialPortEncoder.Open();
                    serialPortEncoder.DataReceived += SerialPortEncoder_DataReceived;
                    portCheckTimer.Stop(); // Stop the Timer when connected
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
                serialPortGPS = null;
                portCheckTimer.Start(); // Restart the Timer when disconnected
                list_gps.Enabled = true;
                btn_conectar_gps.Text = "Conectar";
            }
        }

        private void DisconnectEncoder()
        {
            if (serialPortEncoder != null && serialPortEncoder.IsOpen)
            {
                serialPortEncoder.Close();
                serialPortEncoder = null;
                portCheckTimer.Start(); // Restart the Timer when disconnected
                list_usb_encoder.Enabled = true;
                btn_conectar_enc.Text = "Conectar";
            }
        }

        private void SerialPortGPS_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPortGPS.ReadExisting();
            GPSDataReceived?.Invoke(this, data);
        }

        private void SerialPortEncoder_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPortEncoder.ReadExisting();
            EncoderDataReceived?.Invoke(this, data);
        }
    }
}
