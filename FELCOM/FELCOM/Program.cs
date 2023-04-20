using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FELCOM.Controlador;
using FELCOM.Vista;
namespace FELCOM
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmPantallaPrincipal pr = new frmPantallaPrincipal();
            ctrlFrmPantallaPrincipal ctr = new  ctrlFrmPantallaPrincipal(pr);
            Application.Run(pr);
        }
    }
}
