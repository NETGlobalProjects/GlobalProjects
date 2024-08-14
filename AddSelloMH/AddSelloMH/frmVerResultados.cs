using AddSelloMH.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddSelloMH
{
    public partial class frmVerResultados : Form
    {
        public List<rFELSV> rFELSVs;
        public frmVerResultados()
        {
            InitializeComponent();
        }

        private void frmVerResultados_Load(object sender, EventArgs e)
        {
            if(rFELSVs != null) 
                {
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = rFELSVs;
                } 
        }
    }
}
