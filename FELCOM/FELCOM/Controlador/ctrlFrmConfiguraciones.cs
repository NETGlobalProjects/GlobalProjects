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
        }
        private void frmConfiguraciones_Load(object sender, EventArgs e)
        {
            this.vista.RaiztextBox1.Text = Properties.Settings.Default.CarpetaRaiz;
            this.vista.ProcesadostextBox2.Text = Properties.Settings.Default.CarpetaProcesados;
            this.vista.RespuestastextBox3.Text = Properties.Settings.Default.CarpetaRespuestas;
            this.vista.ErrorestextBox4.Text = Properties.Settings.Default.CarpetaErrores;
            this.vista.TiemponumericUpDown1.Value =  Properties.Settings.Default.TiempoSegundosEscaneo;
            this.vista.UrlWStextBox5.Text = Properties.Settings.Default.URLWS;
            this.vista.UsuarioWStextBox6.Text = Properties.Settings.Default.URLWS;
            this.vista.ContraseñaWStextBox7.Text = Properties.Settings.Default.UsuarioWS;
            this.vista.CorreotextBox2.Text = Properties.Settings.Default.CuentaCorreo;
            this.vista.UsuarioCorreotextBox3.Text = Properties.Settings.Default.UsuarioCorreo;
            this.vista.ContraseñaCorreotextBox1 .Text = Properties.Settings.Default.PassCorreo;
            this.vista.ServidorSMTPtextBox4.Text = Properties.Settings.Default.ServidorSMTP;
            this.vista.PuertoSMTPtextBox5.Text = Properties.Settings.Default.PuertoSMTP;
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
                    this.vista.RaiztextBox1.Text = this.vista.ExplorarfolderBrowserDialog1.SelectedPath;
                }
            }
        }
        private void explorarProcesadosbutton2_Click(object sender, EventArgs e)
        {
            if (this.vista.ExplorarfolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                
                if (this.vista.ExplorarfolderBrowserDialog1.SelectedPath != "")
                {
                    this.vista.ProcesadostextBox2.Text = this.vista.ExplorarfolderBrowserDialog1.SelectedPath;
                }
            }
        }
        private void respuestastextBox3_Click(object sender, EventArgs e)
        {
            if (this.vista.ExplorarfolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                if (this.vista.ExplorarfolderBrowserDialog1.SelectedPath != "")
                {
                    this.vista.RespuestastextBox3.Text = this.vista.ExplorarfolderBrowserDialog1.SelectedPath;
                }
            }
        }
        private void errorestextBox4_Click(object sender, EventArgs e)
        {
            if (this.vista.ExplorarfolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                if (this.vista.ExplorarfolderBrowserDialog1.SelectedPath != "")
                {
                    this.vista.ErrorestextBox4.Text = this.vista.ExplorarfolderBrowserDialog1.SelectedPath;
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
                Properties.Settings.Default.URLWS = this.vista.UrlWStextBox5.Text;
                Properties.Settings.Default.UsuarioWS = this.vista.UsuarioWStextBox6.Text;
                Properties.Settings.Default.PassWS = this.vista.ContraseñaWStextBox7.Text;
                Properties.Settings.Default.CuentaCorreo = this.vista.CorreotextBox2.Text;
                Properties.Settings.Default.UsuarioCorreo = this.vista.UsuarioCorreotextBox3.Text;
                Properties.Settings.Default.ServidorSMTP = this.vista.ServidorSMTPtextBox4.Text;
                Properties.Settings.Default.PuertoSMTP = this.vista.PuertoSMTPtextBox5.Text;
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
