using FELCOM.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FELCOM.Vista
{
    public partial class frmConfiguraciones : DevComponents.DotNetBar.Office2007Form
    {
        public frmConfiguraciones()
        {
            InitializeComponent();
            ctrlFrmConfiguraciones ctrl = new ctrlFrmConfiguraciones(this);
        }
    }
}
