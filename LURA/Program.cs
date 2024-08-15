using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace LURA
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configurar el contexto de licencia de EPPlus
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // O LicenseContext.NonCommercial
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PANEL());
            Application.Run(PANEL.Instance);
        }
    }
 
}
