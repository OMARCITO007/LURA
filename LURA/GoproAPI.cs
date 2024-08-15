using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;


namespace LURA
{
    public class GoproAPI
    {
        private static readonly Lazy<GoproAPI> instance = new Lazy<GoproAPI>(() => new GoproAPI());
        private readonly string goproIp = "http://10.5.5.9";
        private readonly HttpClient client;
        private MongoDBHelper _mongoDBHelper;

        // Ruta flexible en la carpeta Documentos del usuario
        private string downloadPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fotos");

        private GoproAPI()
        {
            client = new HttpClient();
            // Asegúrate de que la carpeta exista
            if (!Directory.Exists(downloadPath))
            {
                Directory.CreateDirectory(downloadPath);
            }
        }

        public static GoproAPI Instance => instance.Value;

        public void SetDownloadPath(string path)
        {
            downloadPath = path;
            if (!Directory.Exists(downloadPath))
            {
                Directory.CreateDirectory(downloadPath);
            }
        }
        public async Task ConnectCamera(Button btn_conectar_gp)
        {
            if (btn_conectar_gp.Text == "Conectar")
            {
                try
                {
                    await ConnectAsync();
                    btn_conectar_gp.Text = "Desconectar";
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
                    Disconnect();
                    btn_conectar_gp.Text = "Conectar";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al desconectar la cámara: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public async Task ConnectAsync()
        {
            Console.WriteLine("Conectando a la GoPro...");
            var response = await client.GetAsync($"{goproIp}/gp/gpControl/status");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Conexión exitosa a la GoPro.");
            }
            else
            {
                Console.WriteLine("Error al conectar a la GoPro.");
                throw new Exception("No se pudo conectar a la GoPro.");
            }
        }

        public void Disconnect()
        {
            Console.WriteLine("Desconectando de la GoPro...");
            client.Dispose();
        }

        public async Task TakePhotoAsync()
        {
            Console.WriteLine("Tomando foto...");
            await client.GetAsync($"{goproIp}/gp/gpControl/command/shutter?p=1");
            await Task.Delay(1000);
        }

        public async Task DownloadAndRenamePhotoAsync(string fileName)
        {
            Console.WriteLine("Descargando y renombrando la foto...");

            HttpResponseMessage response = await client.GetAsync($"{goproIp}/gp/gpMediaList");
            string jsonResponse = await response.Content.ReadAsStringAsync();
            JObject mediaList = JObject.Parse(jsonResponse);

            var lastMedia = mediaList["media"].Last;
            var lastFile = lastMedia["fs"].Last;
            string fileUrl = $"{goproIp}/videos/DCIM/{lastMedia["d"]}/{lastFile["n"]}";
            string filePath = Path.Combine(downloadPath, fileName);

            using (HttpResponseMessage fileResponse = await client.GetAsync(fileUrl, HttpCompletionOption.ResponseHeadersRead))
            using (Stream fileStream = await fileResponse.Content.ReadAsStreamAsync())
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
            {
                await fileStream.CopyToAsync(fs);
            }

            Console.WriteLine($"Foto descargada y renombrada como: {fileName}");
        }

        public void CaptureImage()
        {
            Task.Run(async () =>
            {
                try
                {
                    // Crear el nombre del archivo basado en la fecha y hora actual
                    string fileName = $"captura_{DateTime.Now:yyyyMMddHHmmss}.jpg";

                    // Conectar a la base de datos
                    _mongoDBHelper = new MongoDBHelper();

                    // Obtener datos del GPS y del panel
                    string latitud = GPSProcessor.Instance.Latitude.ToString("F6");
                    string longitud = GPSProcessor.Instance.Longitude.ToString("F6");
                    string distancia = PANEL.Instance.distancia.Text;
                    string distancia_total = PANEL.Instance.dist_total.Text + " Km";

                    // Insertar los datos en la base de datos
                    _mongoDBHelper.InsertDocument(DateTime.UtcNow, latitud, longitud, distancia_total, fileName);

                    // Capturar la imagen y descargarla con el nombre especificado
                    await TakePhotoAsync();
                    await DownloadAndRenamePhotoAsync(fileName);

                    // Mensaje de confirmación (en UI thread si es necesario)
                    Console.WriteLine("Imagen capturada y guardada con éxito.");
                }
                catch (Exception ex)
                {
                    // Manejo de error (en UI thread si es necesario)
                    Console.WriteLine($"Error al capturar la imagen: {ex.Message}");
                }
            });
        }
    }
}
