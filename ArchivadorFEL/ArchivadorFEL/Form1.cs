using ArchivadorFEL.Datos;
using ArchivadorFEL.Modelos;
using ArchivadorFEL.Properties;


namespace ArchivadorFEL
{
    public partial class Form1 : Form
    {
        private string rutaDestino = "";
        List<Logs> logss;
        List<datosFELArchivadorModel> datos;
        bool allDealers = false;
        string empresass = "";
        DateTime desde;
        DateTime hasta;
        public Form1()
        {
            InitializeComponent();
        }
        void validarSesion()
        {
            if (!string.IsNullOrEmpty(Conexion.instancia.Usuario))
            {
                this.cerrarSesionbutton1.Visible = true;
                habilitarCampos();
                this.infoUsuariolabel7.Text = "Usuario: " + Conexion.instancia.Usuario;
            }
            else
            {
                this.cerrarSesionbutton1.Visible = false;
                deshabilitarCampos();
                this.infoUsuariolabel7.Text = "Usuario: Desconectado";
                this.usuariotextBox1.Focus();
            }
        }
        void habilitarCampos()
        {
            this.controlpanel1.Visible = true;
            this.Loginpanel1.Visible = false;
            this.cambiarOrigenToolStripMenuItem.Enabled = true;
        }
        void deshabilitarCampos()
        {
            this.controlpanel1.Visible = false;
            this.Loginpanel1.Visible = true;
            this.cambiarOrigenToolStripMenuItem.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            validarSesion();
            logslinkLabel1.Text = "";
            var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var lastDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

            this.desdeDateTimePicker1.Value = firstDayOfMonth;
            this.hastaDateTimePicker2.Value = lastDayOfMonth;

            cargarEmpresa();
        }
        void cargarEmpresa()
        {
            try
            {
                this.empresasComboBox1.DataSource = accesoDatos.instancia.getDealers();
                this.empresasComboBox1.ValueMember = "Dealer";
                this.empresasComboBox1.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            empresasComboBox1.Enabled = (porEmpresacheckBox1.Checked ? true : false);
            if (porEmpresacheckBox1.Checked)
            {
                this.porSucursalcheckBox2.Enabled = true;
                //this.sucursalescomboBox1.Enabled = true;
            }
            else
            {
                this.porSucursalcheckBox2.Enabled = false;
                //this.sucursalescomboBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rutaDestino = "";
            if (FD.ShowDialog() == DialogResult.OK)
            {
                if (FD.SelectedPath != "")
                {
                    rutaDestino = FD.SelectedPath;
                    this.informacionLabel.Text = "Se guardarán en: " + FD.SelectedPath;
                }
            }
        }
        void reportarProgreso(int progreso)
        {
            progressBar1.Value = progreso;

            this.groupBox2.Text = string.Format("Archivando {0} de {1} documento(s)...", progreso, datos.Count);
        }
        void iniciarProceso()
        {
            this.progressBar1.Maximum = datos.Count;
            this.progressBar1.Value = 0;
            this.comenzarbutton3.Enabled = false;
            this.destinobutton1.Enabled = false;
            logslinkLabel1.Text = "";
            allDealers = this.porEmpresacheckBox1.Checked;
            empresass = (allDealers ? Convert.ToString(this.empresasComboBox1.SelectedText) : "Todas las Empresas");
            desde = this.desdeDateTimePicker1.Value;
            hasta = this.hastaDateTimePicker2.Value;
            BW.RunWorkerAsync();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (rutaDestino != "")
            {
                DialogResult = MessageBox.Show("¿Confirma que iniciará el proceso de archivado?", "Confirme operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    logss = new List<Logs>();
                    datos = new List<datosFELArchivadorModel>();
                    datos = accesoDatos.instancia.getDatosFElArchivador(this.desdeDateTimePicker1.Value, this.hastaDateTimePicker2.Value, this.porEmpresacheckBox1.Checked, porSucursalcheckBox2.Checked,(int)this.empresasComboBox1.SelectedValue, Convert.ToString( this.sucursalescomboBox1.SelectedValue));
                    if (datos != null)
                    {
                        iniciarProceso();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos, favor validar el rango de fecha que ha establecido y vuela a intentar", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un directorio donde se guardarán los archivos", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void cambiarOrigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarOrigen frm = new frmCambiarOrigen();

            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

        }

        private void logslinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogs frm = new frmLogs();
            frm.logs = logss;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void BW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var empresas = datos.DistinctBy(a => a.Dealer).ToList();

            /*Validar directorios y si no existen los creará*/
            foreach (var empresa in empresas)
            {
                string dirEmpresa = rutaDestino + "\\" + empresa.nombreCortoEmpresa;
                if (!Directory.Exists(dirEmpresa))
                {
                    Directory.CreateDirectory(dirEmpresa);
                }
                foreach (var sucursal in datos.Where(a => a.Dealer == empresa.Dealer).DistinctBy(a => a.Surursal))
                {
                    string dirSucursal = dirEmpresa + "\\" + sucursal.Surursal;
                    if (!Directory.Exists(dirSucursal))
                    {
                        Directory.CreateDirectory(dirSucursal);
                    }
                    foreach (var anio in datos.Where(a => a.Dealer == empresa.Dealer && a.Surursal == sucursal.Surursal).DistinctBy(a => a.Anio))
                    {
                        string dirAnio = dirSucursal + "\\" + anio.Anio;
                        if (!Directory.Exists(dirAnio))
                        {
                            Directory.CreateDirectory(dirAnio);
                        }
                        foreach (var mes in datos.Where(a => a.Dealer == empresa.Dealer && a.Surursal == sucursal.Surursal && a.Anio == anio.Anio).DistinctBy(a => a.Mes))
                        {
                            string dirMes = dirAnio + "\\" + mes.Mes;
                            if (!Directory.Exists(dirMes))
                            {
                                Directory.CreateDirectory(dirMes);
                            }
                            foreach (var tipoDoc in datos.Where(a => a.Dealer == empresa.Dealer && a.Surursal == sucursal.Surursal && a.Anio == anio.Anio && a.Mes == mes.Mes).DistinctBy(a => a.TipoDoc))
                            {
                                string dirTipoDoc = dirMes + "\\" + tipoDoc.TipoDoc;
                                if (!Directory.Exists(dirTipoDoc))
                                {
                                    Directory.CreateDirectory(dirTipoDoc);
                                }
                                foreach (var dia in datos.Where(a => a.Dealer == empresa.Dealer && a.Surursal == sucursal.Surursal && a.Anio == anio.Anio && a.Mes == mes.Mes && a.TipoDoc == tipoDoc.TipoDoc).DistinctBy(a => a.dia))
                                {
                                    string dirDia = dirTipoDoc + "\\" + dia.dia;
                                    if (!Directory.Exists(dirDia))
                                    {
                                        Directory.CreateDirectory(dirDia);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            /*Copia de archivos*/

            int contador = 0;
            int errores = 0;
            int exitosos = 0;
            foreach (var dato in datos)
            {
                string archivo = Settings.Default.directorioOrigen + "\\" + dato.Dealer + "\\" + dato.CodigoGeneracion.Trim() + ".pdf";
                string archivoJson = Settings.Default.directorioOrigen + "\\" + dato.Dealer + "\\" + dato.CodigoGeneracion.Trim() + ".json";
                string archivoJsonMH = Settings.Default.directorioOrigen + "\\" + dato.Dealer + "\\" + dato.CodigoGeneracion.Trim() + "_MH.json";
                string archivoDestino = rutaDestino + dato.completoRutaDestino + dato.CodigoGeneracion + ".pdf";
                string archivoDestinoJson = rutaDestino + dato.completoRutaDestino + dato.CodigoGeneracion + ".json";
                string archivoDestinoJsonMH = rutaDestino + dato.completoRutaDestino + dato.CodigoGeneracion + "_MH.json";
                if (!File.Exists(archivoDestino))
                {
                    try
                    {
                        File.Copy(archivo, archivoDestino);
                        logss.Add(new Logs { Tipo = "Exito", Mensaje = "Documento archivado exitosamente", archivo = dato.CodigoGeneracion + ".pdf", nombreCortoEmpresa = dato.nombreCortoEmpresa, DocNo = dato.DocNo, Fecha = dato.Fecha, Serie = dato.Serie, Sucursal = dato.Surursal, TipoDoc = dato.TipoDoc, formatoArchivo = "PDF" });
                        exitosos++;
                    }
                    catch (FileNotFoundException ex)
                    {
                        logss.Add(new Logs { Tipo = "Error", Mensaje = ex.Message + " " + ex.InnerException, archivo = dato.CodigoGeneracion + ".pdf", nombreCortoEmpresa = dato.nombreCortoEmpresa, DocNo = dato.DocNo, Fecha = dato.Fecha, Serie = dato.Serie, Sucursal = dato.Surursal, TipoDoc = dato.TipoDoc, formatoArchivo = "PDF" });
                        errores++;
                    }
                }

                if (!File.Exists(archivoDestinoJson))
                {
                    try
                    {
                        File.Copy(archivoJson, archivoDestinoJson);
                        logss.Add(new Logs { Tipo = "Exito", Mensaje = "Documento archivado exitosamente", archivo = dato.CodigoGeneracion + ".json", nombreCortoEmpresa = dato.nombreCortoEmpresa, DocNo = dato.DocNo, Fecha = dato.Fecha, Serie = dato.Serie, Sucursal = dato.Surursal, TipoDoc = dato.TipoDoc, formatoArchivo = "JSON" });
                        exitosos++;
                    }
                    catch (FileNotFoundException ex)
                    {
                        logss.Add(new Logs { Tipo = "Error", Mensaje = ex.Message + " " + ex.InnerException, archivo = dato.CodigoGeneracion + ".json", nombreCortoEmpresa = dato.nombreCortoEmpresa, DocNo = dato.DocNo, Fecha = dato.Fecha, Serie = dato.Serie, Sucursal = dato.Surursal, TipoDoc = dato.TipoDoc, formatoArchivo = "JSON" });
                        errores++;
                    }
                }

                if (!File.Exists(archivoDestinoJsonMH))
                {
                    try
                    {
                        File.Copy(archivoJsonMH, archivoDestinoJsonMH);
                        logss.Add(new Logs { Tipo = "Exito", Mensaje = "Documento archivado exitosamente", archivo = dato.CodigoGeneracion + "_MH.json", nombreCortoEmpresa = dato.nombreCortoEmpresa, DocNo = dato.DocNo, Fecha = dato.Fecha, Serie = dato.Serie, Sucursal = dato.Surursal, TipoDoc = dato.TipoDoc, formatoArchivo = "JSON" });
                        exitosos++;
                    }
                    catch (FileNotFoundException ex)
                    {
                        logss.Add(new Logs { Tipo = "Error", Mensaje = ex.Message + " " + ex.InnerException, archivo = dato.CodigoGeneracion + "_MH.json", nombreCortoEmpresa = dato.nombreCortoEmpresa, DocNo = dato.DocNo, Fecha = dato.Fecha, Serie = dato.Serie, Sucursal = dato.Surursal, TipoDoc = dato.TipoDoc, formatoArchivo = "JSON" });
                        errores++;
                    }
                }
                contador++;

                BW.ReportProgress(contador);
            }

            string detalles = "Desde: " + desde.ToString("dd-MM-yyyy") + ", Hasta: " + hasta.ToString("dd-MM-yyyy") + ", Empresa(s): " + empresass + ",  Total Documentos: " + datos.Count.ToString() + ", Exitosos: " + exitosos.ToString() + ", Errores: " + errores.ToString();
            accesoDatos.instancia.registrarAuditoriaTabla(Conexion.instancia.Usuario, "Archivado de documentos", detalles);

        }
        private void BW_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            reportarProgreso(e.ProgressPercentage);
        }

        private void BW_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.progressBar1.Value = 0;
            this.groupBox2.Text = "Proceso finalizado";
            logslinkLabel1.Text = string.Format("Hay {0} error(s), clic aqui para revisar", logss.Where(a => a.Tipo == "Error").ToList().Count());
            this.comenzarbutton3.Enabled = true;
            this.destinobutton1.Enabled = true;
        }
        void validarLogin()
        {
            try
            {
                if (string.IsNullOrEmpty(this.usuariotextBox1.Text))
                {
                    MessageBox.Show("Debe ingresar el usuario", "Datos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.usuariotextBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.usuariotextBox1.Text))
                {
                    MessageBox.Show("Debe ingresar la contraseña", "Datos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.contraseñatextBox2.Focus();
                    return;
                }
                if (accesoDatos.instancia.validarLogin(this.usuariotextBox1.Text, this.contraseñatextBox2.Text) > 0)
                {
                    Conexion.instancia.Usuario = this.usuariotextBox1.Text;
                    this.usuariotextBox1.Clear();
                    this.contraseñatextBox2.Clear();
                    validarSesion();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Datos rechazados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            validarLogin();
        }

        private void cerrarSesionbutton1_Click(object sender, EventArgs e)
        {
            Conexion.instancia.Usuario = "";
            this.usuariotextBox1.Focus();
            validarSesion();
        }

        private void contraseñatextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validarLogin();
            }
        }

        private void usuariotextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validarLogin();
            }
        }

        private void desdeDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (desdeDateTimePicker1.Focused)
            {
                SendKeys.Send(".");
            }
        }

        private void hastaDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (hastaDateTimePicker2.Focused)
            {
                SendKeys.Send(".");
            }
        }
        void cargarSucursales()
        {
            try
            {
                this.sucursalescomboBox1.DataSource = accesoDatos.instancia.getSucursales("SAL", (int)this.empresasComboBox1.SelectedValue);
                this.sucursalescomboBox1.DisplayMember = "Nombre";
                this.sucursalescomboBox1.ValueMember = "Sucursal";
            }
            catch (Exception ex)
            {

                throw new Exception("Error al cargar sucursales: " + ex.Message + " " + ex.InnerException);
            }
        }
        private void empresasComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarSucursales();
        }

        private void porSucursalcheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (porSucursalcheckBox2.Checked)
            {
                this.sucursalescomboBox1.Enabled = true;
            }
            else
            {
                this.sucursalescomboBox1.Enabled = false;
            }
        }
    }
}
