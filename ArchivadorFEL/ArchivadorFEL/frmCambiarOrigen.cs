using ArchivadorFEL.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivadorFEL
{
    public partial class frmCambiarOrigen : Form
    {
        string nuevoDirectorio = "";
        public frmCambiarOrigen()
        {
            InitializeComponent();
        }

        private void frmCambiarOrigen_Load(object sender, EventArgs e)
        {
            this.label2.Text = Settings.Default.directorioOrigen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevoDirectorio = "";
            if (FD.ShowDialog() == DialogResult.OK)
            {
                nuevoDirectorio = FD.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(nuevoDirectorio != "")
            {
               Properties.Settings.Default.directorioOrigen = this.nuevoDirectorio;
                this.label2.Text = nuevoDirectorio;
                Settings.Default.Save();

                this.Close();
            }
        }
    }
}
