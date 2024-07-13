using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace LURA
{
    public partial class PANEL : Form
    {

        public PANEL()
        {
            InitializeComponent();
            ControlUss(new Inicio());
        }
      
        private void ControlUss (UserControl userControl) 
        {
            pantallas.Controls.Clear();
            userControl.Dock = DockStyle.Fill; 
            pantallas.Controls.Add(userControl);
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            ControlUss(new Inicio());
        }

        private void btn_datos_Click(object sender, EventArgs e)
        {
            ControlUss(new Datos());
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            ControlUss(new Configuracion());
        }
        private void PANEL_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Aquí puedes realizar las acciones que deseas antes de que el formulario se cierre
            DialogResult result = MessageBox.Show("¿Seguro que quieres cerrar la aplicación?", "Confirmar cierre", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                // Cancela el cierre si el usuario elige No
                e.Cancel = true;
            }
            else
            {
            }

        }

    }
}

