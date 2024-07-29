using System;


namespace LURA
{
    public class GPSProcessor
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public double Altitude { get; private set; }

        // Evento para notificar cuando los datos cambian
        public event EventHandler<DataReceivedEventArgs> DataReceived;

        public void ProcessNMEAData(string data)
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

                    if (double.TryParse(latitudeStr, out double latitude) &&
                        double.TryParse(longitudeStr, out double longitude) &&
                        double.TryParse(altitudeStr, out double altitude))
                    {
                        Latitude = ConvertToDecimalDegrees(latitude, latitudeDirection);
                        Longitude = ConvertToDecimalDegrees(longitude, longitudeDirection);
                        Altitude = altitude;

                        // Notificar que se recibieron nuevos datos
                        DataReceived?.Invoke(this, new DataReceivedEventArgs(Latitude, Longitude, Altitude));
                    }
                }
            }
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
