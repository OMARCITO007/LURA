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
        private CierreVentanaDetector _cierreVentanaDetector;//detectar cierre de ventana para detener procesos
        private GoproConect goproConect;

        public Inicio(GoproConect goproConectInstance)
        {
            InitializeComponent();
            goproConect = goproConectInstance;
            // Crear una instancia de CierreVentanaDetector
            _cierreVentanaDetector = new CierreVentanaDetector(this, OnFormClosingAction);
        }


        private void Inicio_Load(object sender, EventArgs e)
        {
            iniciar_medida.Enabled = false;
            zero_pulsos.Enabled = false;
        }

        private void btn_capture_Click(object sender, EventArgs e)
        {
            goproConect.CaptureImage();
        }




        private void OnFormClosingAction()
        {
            // Acción a realizar al cerrar la ventana principal
            MessageBox.Show("La ventana principal se está cerrando", "Cierre de ventana", MessageBoxButtons.OK, MessageBoxIcon.Information);
            goproConect.DetenerCaptura();
        }

    }
}
