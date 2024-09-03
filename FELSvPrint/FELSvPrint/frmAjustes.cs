using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FELSvPrint
{
    public partial class frmAjustes : DevComponents.DotNetBar.Office2007Form
    {
        public frmAjustes()
        {
            InitializeComponent();
        }

        private void frmAjustes_Load(object sender, EventArgs e)
        {
            directorioPDFTxt.Text = Properties.Settings.Default.directorioPDF;
            destinoPDFTxt.Text = Properties.Settings.Default.destinoPDF;
            destinoErroresTxt.Text = Properties.Settings.Default.destinoErrores;
            marginTopTxt.Value = Properties.Settings.Default.marginTop;
            marginBottomTxt.Value = Properties.Settings.Default.marginBottom;
            marginLeftTxt.Value = Properties.Settings.Default.marginLeft;
            marginRighTxt.Value = Properties.Settings.Default.marginRigh;
            tiempoEscaneo.Value = Properties.Settings.Default.tiempoEscaneo;
            hilosTxt.Value = Properties.Settings.Default.hilos;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if(folderBrowserDialog1.SelectedPath != "")
                {
                    directorioPDFTxt.Text = folderBrowserDialog1.SelectedPath + "\\";
                    
                } 
            }
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.directorioPDF = directorioPDFTxt.Text;
            Properties.Settings.Default.destinoPDF = destinoPDFTxt.Text;
            Properties.Settings.Default.destinoErrores = destinoErroresTxt.Text;
            Properties.Settings.Default.tiempoEscaneo = tiempoEscaneo.Value;

            Properties.Settings.Default.marginBottom = marginBottomTxt.Value;
            Properties.Settings.Default.marginTop = marginTopTxt.Value;
            Properties.Settings.Default.marginLeft = marginLeftTxt.Value;
            Properties.Settings.Default.marginRigh =  marginRighTxt.Value;
            Properties.Settings.Default.tiempoEscaneo = tiempoEscaneo.Value;
            Properties.Settings.Default.hilos = hilosTxt.Value;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != "")
                {
                    destinoPDFTxt.Text = folderBrowserDialog1.SelectedPath + "\\";

                }
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != "")
                {
                    destinoErroresTxt.Text = folderBrowserDialog1.SelectedPath + "\\";

                }
            }
        }
    }
}
