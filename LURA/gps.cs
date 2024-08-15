using System;
using System.Threading.Tasks;

namespace LURA
{
    public class GPSProcessor
    {
        private static readonly Lazy<GPSProcessor> _instance = new Lazy<GPSProcessor>(() => new GPSProcessor());

        // Propiedad para obtener la instancia única
        public static GPSProcessor Instance => _instance.Value;

        // Propiedades para los datos del GPS
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public double Altitude { get; private set; }

        // Evento para notificar cuando los datos cambian
        public event EventHandler<DataReceivedEventArgs> DataReceived;

        // Constructor privado para evitar la creación de instancias externas
        private GPSProcessor() { }

        public void ProcessNMEAData(string data)
        {
            // Ejecutar el procesamiento de datos en un hilo en segundo plano
            Task.Run(() =>
            {
                if (data.StartsWith("$GPGGA") || data.StartsWith("$GNGGA"))
                {
                    // Ejemplo de datos: $GPGGA,014401.000,1200.2674,S,07659.4726,W,1,11,0.80,270.0,M,8.5,M,,*5D
                    string[] parts = data.Split(',');

                    if (parts.Length >= 10)
                    {
                        string latitudeStr = parts[2];
                        string latitudeDirection = parts[3];
                        string longitudeStr = parts[4];
                        string longitudeDirection = parts[5];
                        string altitudeStr = parts[9];

                        // Parsear los datos NMEA en el hilo en segundo plano
                        if (double.TryParse(latitudeStr, out double latitude) &&
                            double.TryParse(longitudeStr, out double longitude) &&
                            double.TryParse(altitudeStr, out double altitude))
                        {
                            // Convertir las coordenadas a grados decimales
                            double convertedLatitude = ConvertToDecimalDegrees(latitude, latitudeDirection);
                            double convertedLongitude = ConvertToDecimalDegrees(longitude, longitudeDirection);

                            // Asignar los valores en el hilo principal
                            Latitude = convertedLatitude;
                            Longitude = convertedLongitude;
                            Altitude = altitude;

                            // Invocar el evento en el hilo principal para que la UI no tenga problemas
                            DataReceived?.Invoke(this, new DataReceivedEventArgs(Latitude, Longitude, Altitude));
                        }
                    }
                }
            });
        }

        private double ConvertToDecimalDegrees(double coord, string direction)
        {
            int degrees = (int)(coord / 100);
            double minutes = coord % 100;
            double decimalDegrees = degrees + (minutes / 60);

            if (direction == "S" || direction == "W")
            {
                decimalDegrees = -decimalDegrees;
            }

            return decimalDegrees;
        }

    }

    public class DataReceivedEventArgs : EventArgs
    {
        public double Latitude { get; }
        public double Longitude { get; }
        public double Altitude { get; }

        public DataReceivedEventArgs(double latitude, double longitude, double altitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            Altitude = altitude;
        }
    }
}
