using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;


namespace LURA
{
    public partial class Datos : UserControl
    {
        private MongoDBHelper _mongoDBHelper;
        private List<Foto> _fotos;
        private ExportadorPDF _exportadorPDF;

        public Datos()
        {
            InitializeComponent();
            _mongoDBHelper = new MongoDBHelper();

            if (_mongoDBHelper.IsServerActive())
            {
                _fotos = _mongoDBHelper.GetFotos(); // Obtener todas las fotos al inicio
                LoadFotos();
                _exportadorPDF = new ExportadorPDF(fotosDataGridView);
            }
            else
            {
                MessageBox.Show("El servidor de base de datos no está activo. Por favor, active el servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFotos()
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Today;
            // Filtrar las fotos por la fecha actual
            var fotosFechaActual = _fotos.Where(f => f.Fecha.Date == fechaActual).ToList();
            //var bindingList = new BindingList<Foto>(_fotos); //este es para que muestre datos de todas las fechas
            // Crear el BindingList y BindingSource con las fotos filtradas
            var bindingList = new BindingList<Foto>(fotosFechaActual);
            var source = new BindingSource(bindingList, null);
            fotosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            fotosDataGridView.DataSource = source;
        }

        private void filtro_fecha_ValueChanged(object sender, EventArgs e)
        {
            if (_mongoDBHelper.IsServerActive())
            {
                DateTime fechaSeleccionada = filtro_fecha.Value.Date;
                // Filtrar las fotos por la fecha seleccionada
                var fotosFiltradas = _fotos.Where(f => f.Fecha.Date == fechaSeleccionada).ToList();
                // Actualizar el DataGridView con las fotos filtradas
                var bindingList = new BindingList<Foto>(fotosFiltradas);
                var source = new BindingSource(bindingList, null);
                fotosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                fotosDataGridView.DataSource = source;
            }
            else
            {
                MessageBox.Show("El servidor de base de datos no está activo. Por favor, active el servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ver_foto_Click(object sender, EventArgs e)
        {
            if (_mongoDBHelper.IsServerActive())
            {
                foreach (DataGridViewRow row in fotosDataGridView.SelectedRows)
                {
                    // Obtener el nombre del archivo de la celda correspondiente
                    string nombreArchivo = row.Cells["NombreArchivo"].Value?.ToString();

                    if (!string.IsNullOrEmpty(nombreArchivo))
                    {
                        // Construir la ruta completa del archivo en la carpeta "fotos"
                        string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fotos");
                        string imagePath = Path.Combine(folderPath, nombreArchivo);
                        // Verificar si el archivo existe
                        if (File.Exists(imagePath))
                        {
                            try
                            {
                                // Abrir la imagen en la aplicación de fotos de Windows
                                Process.Start("explorer.exe", imagePath);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al abrir la imagen: {ex.Message}", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La imagen no se encontró en la carpeta 'fotos'.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado una imagen válida.", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("El servidor de base de datos no está activo. Por favor, active el servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
        private void Exportar_Click(object sender, EventArgs e)
        {
            if (_mongoDBHelper.IsServerActive())
            {
                try
                {
                    // Verificar si la tabla tiene datos
                    if (fotosDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Archivo PDF (*.pdf)|*.pdf",
                        Title = "Guardar como PDF"
                    };
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        _exportadorPDF.Exportar(filePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar la tabla a PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El servidor de base de datos no está activo. Por favor, active el servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */
        private void Exportar_Click(object sender, EventArgs e)
        {
            if (_mongoDBHelper.IsServerActive())
            {
                try
                {
                    // Verificar si la tabla tiene datos
                    if (fotosDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Archivo Excel (*.xlsx)|*.xlsx",
                        Title = "Guardar como Excel"
                    };
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        var exportadorExcel = new ExportadorExcel(fotosDataGridView);
                        exportadorExcel.Exportar(filePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar la tabla a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El servidor de base de datos no está activo. Por favor, active el servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
