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
    public partial class Configuracion : UserControl
    {

        private ConfigManager configManager;

        public Configuracion()
        {
            InitializeComponent();
            configManager = ConfigManager.Instance;
            LoadConfigValues();
            Odometro.Instance.DataReceived += Odometro_DataReceived;
        }



        private void LoadConfigValues()
        {
            ppr_enc.Text = configManager.PPR.ToString();
            diametro_rueda.Text = configManager.DiametroRueda.ToString();
            factor_escala.Text = configManager.FactorEscala.ToString();
        }


        private void save_conf_Click(object sender, EventArgs e)
        {
            double.TryParse(ppr_enc.Text, out double ppr);
            double.TryParse(diametro_rueda.Text, out double diametroRueda);
            double.TryParse(factor_escala.Text, out double factorEscala);

            configManager.PPR = ppr;
            configManager.DiametroRueda = diametroRueda;
            configManager.FactorEscala = factorEscala;

            configManager.SaveConfig();
            LoadConfigValues();
            MessageBox.Show("Configuración guardada correctamente.");
        }


        private void Odometro_DataReceived(object sender, UpdateEncoderEventArgs e)
        {
            // Actualiza los TextBox en el UserControl
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    DistanciaCorregida.Text = e.DistanciaTotalCorregida.ToString();
                    pulsos_encoder.Text = e.PulsosContados.ToString();
                }));
            }
            else
            {
                DistanciaCorregida.Text = e.DistanciaTotalCorregida.ToString();
                pulsos_encoder.Text = e.PulsosContados.ToString();
            }
        }
    }
}
