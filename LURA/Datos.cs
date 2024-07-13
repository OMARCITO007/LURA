using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using Windows.Media.Capture;
using System.Diagnostics;
using System.IO;

namespace LURA
{
    public partial class Datos : UserControl
    {
        private MongoDBHelper _mongoDBHelper;
        public Datos()
        {
            InitializeComponent();
            _mongoDBHelper = new MongoDBHelper();
            LoadFotos();
            // Vincular el evento DataBindingComplete
            fotosDataGridView.DataBindingComplete += FotosDataGridView_DataBindingComplete;
        }

        private void LoadFotos()
        {
            List<Foto> fotos = _mongoDBHelper.GetFotos();
            var bindingList = new BindingList<Foto>(fotos);
            var source = new BindingSource(bindingList, null);
            fotosDataGridView.DataSource = source;

          
        }

        private void FotosDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Opcional: Formatea las columnas del DataGridView según tus necesidades
            fotosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Asegúrate de que todas las columnas existen antes de configurarlas
            if (fotosDataGridView.Columns.Contains("_id"))
            {
                fotosDataGridView.Columns["_id"].HeaderText = "ID";
            }
            if (fotosDataGridView.Columns.Contains("fecha"))
            {
                fotosDataGridView.Columns["fecha"].HeaderText = "Fecha";
            }
            if (fotosDataGridView.Columns.Contains("latitud"))
            {
                fotosDataGridView.Columns["latitud"].HeaderText = "Latitud";
            }
            if (fotosDataGridView.Columns.Contains("longitud"))
            {
                fotosDataGridView.Columns["longitud"].HeaderText = "Longitud";
            }
            if (fotosDataGridView.Columns.Contains("distancia"))
            {
                fotosDataGridView.Columns["distancia"].HeaderText = "Distancia";
            }
            if (fotosDataGridView.Columns.Contains("nombre_archivo"))
            {
                fotosDataGridView.Columns["nombre_archivo"].HeaderText = "Nombre de Archivo";
            }
        }

        private void ver_foto_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in fotosDataGridView.SelectedRows)
            {
                // Obtener el nombre del archivo de la celda correspondiente
                string nombreArchivo = row.Cells["NombreArchivo"].Value.ToString();
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
        }
    }
}
