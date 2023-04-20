using FELCOM.Logica;
using FELCOM.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FELCOM.Controlador
{
    public class ctrlFrmPantallaPrincipal
    {
        private frmPantallaPrincipal vista;
       
        public ctrlFrmPantallaPrincipal(frmPantallaPrincipal v)
        {
            this.vista = v;
            this.vista.Load += frmPantallaPrincipal_Load;
            this.vista.AjustesToolStripMenuItem.Click += ajustesMenuStrip_Click;
        }
        private void frmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            
           
        }
        private void ajustesMenuStrip_Click(object sender, EventArgs e)
        {
            frmConfiguraciones config = new frmConfiguraciones();
            ctrlFrmConfiguraciones ctrl = new ctrlFrmConfiguraciones(config);
            config.WindowState = FormWindowState.Normal;
            config.StartPosition = FormStartPosition.CenterScreen;
            config.ShowDialog();
        }
            
    }
}
