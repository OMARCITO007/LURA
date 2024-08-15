using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.IO;
using MongoDB.Bson.Serialization.Attributes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace LURA
{

    public class Foto
    {
        public string Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Distancia_total { get; set; }
        public string NombreArchivo { get; set; }

    }

    public class MongoDBHelper
    {
        private readonly IMongoCollection<BsonDocument> _fotosCollection;
        private readonly MongoClient _client;
        private readonly string _connectionString = "mongodb://localhost:27017";
        private readonly string _databaseName = "lura";
        private readonly string _collectionName = "fotos";
        private readonly bool _isServerActive;

        public MongoDBHelper()
        {
            try
            {
                _client = new MongoClient(_connectionString);
                var database = _client.GetDatabase(_databaseName);
                _fotosCollection = database.GetCollection<BsonDocument>(_collectionName);
                _isServerActive = true;
            }
            catch 
            {
                _isServerActive = false;
            }
        }

        public List<Foto> GetFotos()
        {
            if (!_isServerActive)
            {
                throw new Exception("El servidor de base de datos no está activo. Por favor, active el servidor.");
            }

            try
            {
                var fotosBson = _fotosCollection.Find(new BsonDocument()).ToList();
                return fotosBson.Select(bson => new Foto
                {
                    Id = bson["_id"].AsObjectId.ToString(),
                    Fecha = bson["fecha"].ToLocalTime(),
                    Latitud = bson["latitud"].AsString,
                    Longitud = bson["longitud"].AsString,
                    Distancia_total = bson["distancia"].AsString,
                    NombreArchivo = bson["nombre_archivo"].AsString
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener fotos de la base de datos: " + ex.Message);
            }
        }
        public List<Foto> GetFotosPorFecha(DateTime fecha)
        {
            if (!_isServerActive)
            {
                throw new Exception("El servidor de base de datos no está activo. Por favor, active el servidor.");
            }

            var filtro = Builders<BsonDocument>.Filter.Eq("fecha", fecha);
            var fotosBson = _fotosCollection.Find(filtro).ToList();
            return fotosBson.Select(bson => new Foto
            {
                Id = bson["_id"].AsObjectId.ToString(),
                Fecha = bson["fecha"].ToLocalTime(),
                Latitud = bson["latitud"].AsString,
                Longitud = bson["longitud"].AsString,
                Distancia_total = bson["distancia"].AsString,
                NombreArchivo = bson["nombre_archivo"].AsString
            }).OrderByDescending(f => f.Fecha).ToList();
        }

        public void InsertDocument(DateTime fecha, string latitud, string longitud, string distancia, string nombreArchivo)
        {
            if (!_isServerActive)
            {
                throw new Exception("El servidor de base de datos no está activo. Por favor, active el servidor.");
            }

            var document = new BsonDocument
        {
            { "fecha", fecha },
            { "latitud", latitud },
            { "longitud", longitud },
            { "distancia", distancia },
            { "nombre_archivo", nombreArchivo }
        };

            _fotosCollection.InsertOne(document);
        }

        public bool IsServerActive() => _isServerActive;
    }

    public class ExportadorPDF
    {
        private readonly DataGridView _dataGridView;

        public ExportadorPDF(DataGridView dataGridView)
        {
            _dataGridView = dataGridView ?? throw new ArgumentNullException(nameof(dataGridView));
        }

        public void Exportar(string filePath)
        {
            try
            {
                // Crear un documento PDF
                Document doc = new Document();

                // Crear un escritor PDF para escribir en el archivo especificado
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                // Abrir el documento para escribir contenido
                doc.Open();

                // Crear una tabla PDF y establecer el número de columnas
                PdfPTable pdfTable = new PdfPTable(_dataGridView.Columns.Count);

                // Agregar los encabezados de columna de la DataGridView a la tabla PDF
                foreach (DataGridViewColumn column in _dataGridView.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }

                // Agregar filas y celdas de la DataGridView a la tabla PDF
                foreach (DataGridViewRow row in _dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value?.ToString() ?? "");
                    }
                }

                // Agregar la tabla PDF al documento
                doc.Add(pdfTable);

                // Cerrar el documento
                doc.Close();

                MessageBox.Show($"Tabla exportada exitosamente a:\n{filePath}", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar la tabla a PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class ExportadorExcel
    {
        private readonly DataGridView _dataGridView;

        public ExportadorExcel(DataGridView dataGridView)
        {
            _dataGridView = dataGridView ?? throw new ArgumentNullException(nameof(dataGridView));
        }

        public void Exportar(string filePath)
        {
            try
            {
                // Configurar el contexto de licencia de EPPlus
                ExcelPackage.LicenseContext = LicenseContext.Commercial; // O LicenseContext.NonCommercial

                // Crear un nuevo paquete de Excel
                using (var package = new ExcelPackage())
                {
                    // Agregar una nueva hoja al paquete
                    var worksheet = package.Workbook.Worksheets.Add("Datos");

                    // Agregar encabezados de columna
                    for (int i = 0; i < _dataGridView.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = _dataGridView.Columns[i].HeaderText;
                        worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                    }

                    // Agregar filas de datos
                    for (int i = 0; i < _dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < _dataGridView.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = _dataGridView.Rows[i].Cells[j].Value?.ToString() ?? "";
                        }
                    }

                    // Guardar el archivo
                    FileInfo fi = new FileInfo(filePath);
                    package.SaveAs(fi);
                }

                MessageBox.Show($"Tabla exportada exitosamente a:\n{filePath}", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar la tabla a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
