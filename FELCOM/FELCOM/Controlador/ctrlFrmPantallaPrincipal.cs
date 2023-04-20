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
        }
        private void frmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
            this.vista.NombreLbl.Text = "Hola Mundo";
        }

            
    }
}
