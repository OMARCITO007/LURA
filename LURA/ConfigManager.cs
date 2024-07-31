using System;
using System.IO;
using System.Reflection;
using IniParser;
using IniParser.Model;

namespace LURA
{
    public class ConfigManager
    {
        private static ConfigManager _instance;
        private readonly string configFilePath;

        public double PPR { get; set; }
        public double DiametroRueda { get; set; }
        public double DiametroRuedaMetros { get; set; }
        public double FactorEscala { get; set; }
        public double CircunferenciaRueda { get; private set; }
        public double DistanciaPorPulso { get; private set; }

        private ConfigManager()
        {
            string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            configFilePath = Path.Combine(assemblyFolder, "config.ini");

            // Leer los valores del archivo INI al inicializar
            LoadConfig();
        }

        public static ConfigManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigManager();
                }
                return _instance;
            }
        }

        public void LoadConfig()
        {
            if (File.Exists(configFilePath))
            {
                try
                {
                    var parser = new FileIniDataParser();
                    var data = parser.ReadFile(configFilePath);

                    PPR = double.Parse(data["Settings"]["PPR"]);
                    DiametroRueda = double.Parse(data["Settings"]["Diametro_rueda"]);
                    FactorEscala = double.Parse(data["Settings"]["Factor_escala"]);

                    DiametroRuedaMetros = DiametroRueda / 100;
                    CircunferenciaRueda = Math.PI * DiametroRuedaMetros;
                    DistanciaPorPulso = CircunferenciaRueda / PPR;
                }
                catch (Exception ex)
                {
                    // Manejar errores de lectura o conversión
                    Console.WriteLine($"Error al cargar la configuración: {ex.Message}");
                    SetDefaults();
                }
            }
            else
            {
                // Si el archivo no existe, establecer valores predeterminados y crear el archivo
                SetDefaults();
                SaveConfig();
            }
        }

        private void SetDefaults()
        {
            PPR = 2000.0;
            DiametroRueda = 65.39; // Rueda 255/55 R16
            FactorEscala = 1.0;
            DiametroRuedaMetros = DiametroRueda / 100;
            CircunferenciaRueda = Math.PI * DiametroRuedaMetros;
            DistanciaPorPulso = CircunferenciaRueda / PPR;
        }

        public void SaveConfig()
        {
            var parser = new FileIniDataParser();
            var data = new IniData();

            data["Settings"]["PPR"] = PPR.ToString();
            data["Settings"]["Diametro_rueda"] = DiametroRueda.ToString();
            data["Settings"]["Factor_escala"] = FactorEscala.ToString();

            parser.WriteFile(configFilePath, data);
        }
    }

    public class Odometro
    {

        // Instancia privada estática de la clase Odometro
        private static Odometro _instance;

        // Propiedad pública estática que proporciona el punto de acceso global
        public static Odometro Instance => _instance ?? (_instance = new Odometro());

        // Evento para notificar cuando los datos cambian
        public event EventHandler<UpdateEncoderEventArgs> DataReceived;

        private ConfigManager configManager;
        private double pulsosContados;

        public double DistanciaTotalCorregida { get; private set; }
        public double DistanciaTotal { get; private set; }
        public double PulsosContados => pulsosContados;

        private Odometro()
        {
            configManager = ConfigManager.Instance;
        }

        public void CalcularDistanciaCorregida(string datos)
        {
            if (datos.StartsWith("Pulsos:")) // Pulsos: 123456
            {
                string[] parts = datos.Split(' ');
                if (parts.Length >= 2 && double.TryParse(parts[1], out pulsosContados))
                {
                    DistanciaTotal = pulsosContados * configManager.DistanciaPorPulso;
                    DistanciaTotalCorregida = DistanciaTotal * configManager.FactorEscala;
                    // Notificar que se recibieron nuevos datos
                    DataReceived?.Invoke(this, new UpdateEncoderEventArgs(DistanciaTotalCorregida, pulsosContados, DistanciaTotal));
                }
            }
        }
    }

    public class UpdateEncoderEventArgs : EventArgs
    {
        public double DistanciaTotalCorregida { get; private set; }
        public double PulsosContados { get; private set; }
        public double DistanciaTotal { get; private set; }

        public UpdateEncoderEventArgs(double medida, double pulsos, double distanciaTotal)
        {
            DistanciaTotalCorregida = medida;
            PulsosContados = pulsos;
            DistanciaTotal = distanciaTotal;
        }
    }
}
