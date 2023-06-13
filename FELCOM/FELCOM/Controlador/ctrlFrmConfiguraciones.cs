using FELCOM.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FELCOM.Controlador
{
    public class ctrlFrmConfiguraciones
    {
        private frmConfiguraciones vista;
        public ctrlFrmConfiguraciones(frmConfiguraciones v)
        {
            this.vista = v;
            this.vista.Load += frmConfiguraciones_Load;
            this.vista.Cancelarbutton1.Click += cancelarButton_Click;
            this.vista.ExplorarRaizbutton1.Click += explorarRaizbutton1_Click;
            this.vista.ExplorarProcesadosbutton2.Click += explorarProcesadosbutton2_Click;
            this.vista.ExplorarRespuestasbutton3.Click += respuestastextBox3_Click;
            this.vista.ExplorarErroresbutton4.Click += errorestextBox4_Click;
            this.vista.Aceptarbutton21.Click += aceptarButton_Click;
            this.vista.Proceasandobutton1 .Click += procesandoBtn_Click;
            this.vista.ExplorarToPrinterbutton1.Click += toPrinterBtn_Click;
            this.vista.ExplorarPDFbutton3.Click += pdfBtn_Click;
            this.vista.ExplorarImpresosbutton2 .Click += impresosBtn_Click;
        }
        private void frmConfiguraciones_Load(object sender, EventArgs e)
        {
            this.vista.RaiztextBox1.Text = Properties.Settings.Default.CarpetaRaiz;
            this.vista.ProcesadostextBox2.Text = Properties.Settings.Default.CarpetaProcesados;
            this.vista.RespuestastextBox3.Text = Properties.Settings.Default.CarpetaRespuestas;
            this.vista.ErrorestextBox4.Text = Properties.Settings.Default.CarpetaErrores;
            this.vista.TiemponumericUpDown1.Value =  Properties.Settings.Default.TiempoSegundosEscaneo;
            this.vista.UrlWStextBox5.Text = Properties.Settings.Default.FELCOM_ekomercio_WSFEBuilder;
            this.vista.UsuarioWStextBox6.Text = Properties.Settings.Default.UsuarioWS;
            this.vista.ContraseñaWStextBox7.Text = Properties.Settings.Default.PassWS;
            this.vista.CorreotextBox2.Text = Properties.Settings.Default.CuentaCorreo;
            this.vista.UsuarioCorreotextBox3.Text = Properties.Settings.Default.UsuarioCorreo;
            this.vista.ContraseñaCorreotextBox1 .Text = Properties.Settings.Default.PassCorreo;
            this.vista.ServidorSMTPtextBox4.Text = Properties.Settings.Default.ServidorSMTP;
            this.vista.PuertoSMTPtextBox5.Text = Properties.Settings.Default.PuertoSMTP;
            this.vista.PeticionesParalelasnumericUpDown1.Value = Properties.Settings.Default.PeticionesParalelas;
            this.vista.ProcesandotextBox1.Text = Properties.Settings.Default.CarpetaProcesando;
            this.vista.ToPrintertextBox1.Text = Properties.Settings.Default.CarpetaToPrinter;
            this.vista.ImpresostextBox2.Text = Properties.Settings.Default.CarpetaImpresos;
            this.vista.PdftextBox3.Text = Properties.Settings.Default.CarpetaPDF;
            this.vista.EscribirTablaRespuestacheckBoxX1.Checked = Properties.Settings.Default.EscribirEnTabla;
            this.vista.CadenaConexionTxt.Text = Properties.Settings.Default.cString;
            this.vista.UTF8checkBoxX11.Checked = Properties.Settings.Default.UTF8;
            this.vista.ImprimircheckBoxX1.Checked = Properties.Settings.Default.imprimir;
        }
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.vista.Close();
        }

        private void explorarRaizbutton1_Click(object sender, EventArgs e)
        {
            if(this.vista.ExplorarfolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
               if(this.vista.ExplorarfolderBrowserDialog1.SelectedPath != "")
                {
                    this.vista.RaiztextBox1.Text = this.vista.ExplorarfolderBrowserDialog1.SelectedPath + "\\";
                }
            }
        }
        private void explorarProcesadosbutton2_Click(object sender, EventArgs e)
        {
            if (this.vista.ExplorarfolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                
                if (this.vista.ExplorarfolderBrowserDialog1.SelectedPath != "")
                {
                    this.vista.ProcesadostextBox2.Text = this.vista.ExplorarfolderBrowserDialog1.SelectedPath + "\\";
                }
            }
        }
        private void respuestastextBox3_Click(object sender, EventArgs e)
        {
            if (this.vista.ExplorarfolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                if (this.vista.ExplorarfolderBrowserDialog1.SelectedPath != "")
                {
                    this.vista.RespuestastextBox3.Text = this.vista.ExplorarfolderBrowserDialog1.SelectedPath + "\\";
                }
            }
        }
        private void errorestextBox4_Click(object sender, EventArgs e)
        {
            if (this.vista.ExplorarfolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                if (this.vista.ExplorarfolderBrowserDialog1.SelectedPath != "")
                {
                    this.vista.ErrorestextBox4.Text = this.vista.ExplorarfolderBrowserDialog1.SelectedPath + "\\";
                }
            }
        }
        private void procesandoBtn_Click(object sender, EventArgs e)
        {
            if (this.vista.ExplorarfolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                if (this.vista.ExplorarfolderBrowserDialog1.SelectedPath != "")
                {
                    this.vista.ProcesandotextBox1.Text = this.vista.ExplorarfolderBrowserDialog1.SelectedPath + "\\";
                }
            }
        }
        private void toPrinterBtn_Click(object sender, EventArgs e)
        {
            if (this.vista.ExplorarfolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                if (this.vista.ExplorarfolderBrowserDialog1.SelectedPath != "")
                {
                    this.vista.ToPrintertextBox1.Text = this.vista.ExplorarfolderBrowserDialog1.SelectedPath + "\\";
                }
            }
        }
        private void pdfBtn_Click(object sender, EventArgs e)
        {
            if (this.vista.ExplorarfolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                if (this.vista.ExplorarfolderBrowserDialog1.SelectedPath != "")
                {
                    this.vista.PdftextBox3.Text = this.vista.ExplorarfolderBrowserDialog1.SelectedPath + "\\";
                }
            }
        }
        private void impresosBtn_Click(object sender, EventArgs e)
        {
            if (this.vista.ExplorarfolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                if (this.vista.ExplorarfolderBrowserDialog1.SelectedPath != "")
                {
                    this.vista.ImpresostextBox2.Text = this.vista.ExplorarfolderBrowserDialog1.SelectedPath + "\\";
                }
            }
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.CarpetaRaiz = this.vista.RaiztextBox1.Text;
                Properties.Settings.Default.CarpetaProcesados = this.vista.ProcesadostextBox2.Text;
                Properties.Settings.Default.CarpetaRespuestas = this.vista.RespuestastextBox3.Text;
                Properties.Settings.Default.CarpetaErrores = this.vista.ErrorestextBox4.Text;
                Properties.Settings.Default.TiempoSegundosEscaneo = Convert.ToInt32( this.vista.TiemponumericUpDown1.Value);
                Properties.Settings.Default.FELCOM_ekomercio_WSFEBuilder = this.vista.UrlWStextBox5.Text;
                Properties.Settings.Default.UsuarioWS = this.vista.UsuarioWStextBox6.Text;
                Properties.Settings.Default.PassWS = this.vista.ContraseñaWStextBox7.Text;
                Properties.Settings.Default.CuentaCorreo = this.vista.CorreotextBox2.Text;
                Properties.Settings.Default.UsuarioCorreo = this.vista.UsuarioCorreotextBox3.Text;
                Properties.Settings.Default.PassCorreo = this.vista.ContraseñaCorreotextBox1.Text;
                Properties.Settings.Default.ServidorSMTP = this.vista.ServidorSMTPtextBox4.Text;
                Properties.Settings.Default.PuertoSMTP = this.vista.PuertoSMTPtextBox5.Text;
                Properties.Settings.Default.PeticionesParalelas = Convert.ToInt32( this.vista.PeticionesParalelasnumericUpDown1.Value);
                Properties.Settings.Default.CarpetaProcesando = this.vista.ProcesandotextBox1.Text;
                Properties.Settings.Default.CarpetaPDF = this.vista.PdftextBox3.Text;
                Properties.Settings.Default.CarpetaImpresos = this.vista.ImpresostextBox2.Text;
                Properties.Settings.Default.CarpetaToPrinter = this.vista.ToPrintertextBox1.Text;
                Properties.Settings.Default.EscribirEnTabla = this.vista.EscribirTablaRespuestacheckBoxX1.Checked;
                Properties.Settings.Default.cString = this.vista.CadenaConexionTxt.Text;
                Properties.Settings.Default.UTF8 = this.vista.UTF8checkBoxX11.Checked;
                Properties.Settings.Default.imprimir = this.vista.ImprimircheckBoxX1.Checked;
                Properties.Settings.Default.Save();
                this.vista.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
