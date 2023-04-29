using FELCOM.Controlador;
using FELCOM.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FELCOM
{
    public partial class frmMenu : DevComponents.DotNetBar.Office2007Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            frmPantallaPrincipal hilo = new frmPantallaPrincipal();
            ctrlFrmPantallaPrincipal crl = new ctrlFrmPantallaPrincipal(hilo);
            hilo.MdiParent  = this;
            hilo.Show();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
