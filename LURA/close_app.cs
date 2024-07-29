using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.X509;


namespace LURA
{
    public class CierreVentanaDetector
    {
        private UserControl _userControl;
        private Action _onFormClosingAction;

        public CierreVentanaDetector(UserControl userControl, Action onFormClosingAction)
        {
            _userControl = userControl ?? throw new ArgumentNullException(nameof(userControl));
            _onFormClosingAction = onFormClosingAction ?? throw new ArgumentNullException(nameof(onFormClosingAction));

            // Obtener el formulario principal y suscribirse al evento FormClosing
            if (_userControl.FindForm() is Form form)
            {
                form.FormClosing += Form_FormClosing;
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ejecutar la acción al cerrar la ventana
            _onFormClosingAction.Invoke();
        }
    }
}
