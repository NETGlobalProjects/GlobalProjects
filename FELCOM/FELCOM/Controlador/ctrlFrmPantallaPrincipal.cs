using DevComponents.DotNetBar.Controls;
using FELCOM.Logica;
using FELCOM.Modelo;
using FELCOM.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;
using System.Xml;

namespace FELCOM.Controlador
{
    public class ctrlFrmPantallaPrincipal
    {
        private frmPantallaPrincipal vista;
         int segundos;
        List<ProcesandoModel> procesando = new List<ProcesandoModel>();
        string archivo;
        string directorioProcesando;
        string hilo;
        private TaskScheduler _scheduler;

        public ctrlFrmPantallaPrincipal(frmPantallaPrincipal v)
        {
            this.vista = v;
            this.vista.Load += frmPantallaPrincipal_Load;
            //this.vista.AjustesbuttonX1.Click += ajustesMenuStrip_Click;
            this.vista.Timer1.Tick += timer1_Tick;
            this.vista.TimerScanner.Tick += timerEscanner_Tick;
            this.vista.ListaProcesosdataGridViewX1.DataError += listaProcesosdataGridViewX1_DataError;
            this.vista.SwitchButton1.ValueChanged += switchButton1_ValueChanged;
            this.vista.FormClosing += frmPantallaPrincipal_FormClosing;
        }
        void escribirTxt(string path, string texto, bool reemplazar = false)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            else {
                if (reemplazar)
                {
                    File.Delete(path);
                    File.Create(path).Close();
                }
            
            }
            if (File.Exists(path))
            {
                using (var sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(texto);
                }
            }
        }
        void revisarCarpetas()
        {
            if (!Directory.Exists(Properties.Settings.Default.CarpetaRaiz))
            {
                Directory.CreateDirectory(Properties.Settings.Default.CarpetaRaiz);
            }
            if (!Directory.Exists(Properties.Settings.Default.CarpetaProcesando))
            {
                Directory.CreateDirectory(Properties.Settings.Default.CarpetaProcesando);
            }
            if (!Directory.Exists(Properties.Settings.Default.CarpetaProcesados))
            {
                Directory.CreateDirectory(Properties.Settings.Default.CarpetaProcesados);
            }
            if (!Directory.Exists(Properties.Settings.Default.CarpetaErrores))
            {
                Directory.CreateDirectory(Properties.Settings.Default.CarpetaErrores);
            }
            if (!Directory.Exists(Properties.Settings.Default.CarpetaRespuestas))
            {
                Directory.CreateDirectory(Properties.Settings.Default.CarpetaRespuestas);
            }
        }
        private void frmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            revisarCarpetas();
            _scheduler = TaskScheduler.FromCurrentSynchronizationContext();
            directorioProcesando = DateTime.Now.ToString("ddMMyyyyHHmmss");
            hilo = directorioProcesando;
            if(!Directory.Exists(Properties.Settings.Default.CarpetaProcesando + directorioProcesando))
            {
                Directory.CreateDirectory(Properties.Settings.Default.CarpetaProcesando + directorioProcesando);
            }
            directorioProcesando = Properties.Settings.Default.CarpetaProcesando + directorioProcesando + "\\";
            this.vista.SwitchButton1.Value = Properties.Settings.Default.EscanerSwitch;
        }
        void explorarRaiz()
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(Properties.Settings.Default.CarpetaRaiz);
                int contador = 1;
                int PeticionesParalelas = Properties.Settings.Default.PeticionesParalelas;

                Stopwatch stopWatch = new Stopwatch();

                stopWatch.Start();

                //List<Task> TaskList = new List<Task>();
                foreach (var file in d.GetFiles("*.txt"))
                {
                    if(contador <= PeticionesParalelas)
                    {
                        File.Move(file.FullName, directorioProcesando + file.Name);

                        string[] nombreArchivo = file.Name.Split('-');
                        procesando.Add(new ProcesandoModel { Archivo = file.Name, Estado = "Procesando...", TipoDocumento = nombreArchivo[1] });
                        //ejecutar(file.Name);
                        //var LastTask = Task.Factory.StartNew(() => procesarArchivo(file.Name), CancellationToken.None, TaskCreationOptions.None, _scheduler);
                        //LastTask.Start();
                        //TaskList.Add(LastTask);

                        procesarArchivo(file.Name);
                    }
                    else
                    {
                        break;
                    }
                    contador++;
                }
                stopWatch.Stop();

                //Task.WaitAll(TaskList.ToArray());
            }
            catch (Exception ex)
            {
                if(!ex.Message.Contains("No se pudo encontrar el archivo") && !ex.Message.Contains("Start no se puede invocar en una tarea que ya se ha iniciado"))
                {
                    escribirTxt(Properties.Settings.Default.CarpetaErrores + "Log_" + hilo + ".txt", "Fecha:" + DateTime.Now.ToString() + " | Errror: " + ex.Message, false);
                }
            }
        }
        private void listaProcesosdataGridViewX1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        void ejecutar(string _archivo)
        {
            Task.Factory.StartNew(() => procesarArchivo(_archivo), CancellationToken.None, TaskCreationOptions.None, _scheduler);
        }
        private void procesarArchivo(string _archivo)
        {
            archivo = _archivo;
            try
            {
                 Thread.Sleep(5);
                actualizarProgresos(10, _archivo, "Esperando...");
                actualizarListado();

                string rutaArchivo = directorioProcesando + _archivo;
                string textoPlano = File.ReadAllText(rutaArchivo);
               
               
                 Thread.Sleep(5);
                actualizarProgresos(10, _archivo, "Preparando archivo...");
                actualizarListado();

                string respuesta;
                string usuario = Properties.Settings.Default.UsuarioWS;
                string passw = Properties.Settings.Default.PassWS;
                string id = "06141210830014";
                ekomercio.WSFEBuilder ws = new ekomercio.WSFEBuilder();
                respuesta = ws.procesarTextoPlano(ref usuario, ref passw, ref id, ref textoPlano);

                 Thread.Sleep(5);
                actualizarProgresos(20, _archivo, "Consumiendo WS...");
                actualizarListado();

                XmlDocument xmlRespuesta = new XmlDocument();
                xmlRespuesta.LoadXml(respuesta);

                responseProcesarTextoPlano respuestaProcesarTextoPlano = new responseProcesarTextoPlano();
                responseErrorProcesarTextoPlano respuestaErrorProcesarTextoPlano = new responseErrorProcesarTextoPlano();

                if (respuesta.Contains("ErrorCode"))
                {
                    foreach (XmlNode node in xmlRespuesta.DocumentElement.ChildNodes)
                    {
                        if (node.Name == "ErrorCode")
                        {
                            respuestaErrorProcesarTextoPlano.ErrorCode = node.InnerText;
                        }
                        if (node.Name == "ErrorMessage")
                        {
                            respuestaErrorProcesarTextoPlano.ErrorMessage = node.InnerText;
                        }
                        if (node.Name == "ReturnDateTime")
                        {
                            respuestaErrorProcesarTextoPlano.ReturnDateTime = node.InnerText;
                        }
                    }
                }
                else
                {
                    foreach (XmlNode node in xmlRespuesta.DocumentElement.ChildNodes)
                    {
                        if (node.Name == "ReturnCode")
                        {
                            respuestaProcesarTextoPlano.ReturnCode = node.InnerText;
                        }
                        if (node.Name == "ReturnFolio")
                        {
                            respuestaProcesarTextoPlano.ReturnFolio = node.InnerText;
                        }
                        if (node.Name == "ReturnMessage")
                        {
                            respuestaProcesarTextoPlano.ReturnMessage = node.InnerText;
                        }
                        if (node.Name == "ReturnUUID")
                        {
                            respuestaProcesarTextoPlano.ReturnUUID = node.InnerText;
                        }
                        if (node.Name == "ReturnNumValidacion")
                        {
                            respuestaProcesarTextoPlano.ReturnNumValidacion = node.InnerText;
                        }
                        if (node.Name == "ReturnDatetTime")
                        {
                            respuestaProcesarTextoPlano.ReturnDateTime = Convert.ToString(node.InnerText);
                        }

                        
                    }
                }

                if (respuesta.Contains("ErrorCode"))
                {
                    escribirTxt(Properties.Settings.Default.CarpetaErrores + "Log_" + hilo + ".txt", "Fecha: " + DateTime.Now.ToString() + " | Archivo: " + archivo + " | Respuesta: " + respuesta);
                    File.Move( directorioProcesando +  archivo, Properties.Settings.Default.CarpetaErrores);

                    Thread.Sleep(5);
                    actualizarProgresos(100, _archivo, "Finalizado con errores");
                    actualizarListado();
                }
                else
                {
                    string pathRespuestaTxt = Properties.Settings.Default.CarpetaRespuestas + "_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "_" + archivo  ;
                    escribirTxt(pathRespuestaTxt, respuesta);
                  
                    Thread.Sleep(5);
                    actualizarProgresos(40, _archivo, "Obteniendo respuesta...");
                    actualizarListado();

                    string respPDFStr = ws.getPDF_SV(usuario, passw, respuestaProcesarTextoPlano.ReturnUUID);
                    Thread.Sleep(5);
                    actualizarProgresos(70, _archivo, "Generando PDF...");
                    actualizarListado();

                    XmlDocument xmlPDFRespuesta = new XmlDocument();
                    xmlPDFRespuesta.LoadXml(respPDFStr);

                    responseGetPDF respGetPDF = new responseGetPDF();
                    responseErrorGetPDF respErrorGetPDF = new responseErrorGetPDF();

                    if (respPDFStr.Contains("ErrorCode"))
                    {
                        foreach (XmlNode node in xmlPDFRespuesta.DocumentElement.ChildNodes)
                        {
                            if (node.Name == "ErrorCode")
                            {
                                respErrorGetPDF.ErrorCode = node.InnerText;
                            }

                            if (node.Name == "ReturnMessage")
                            {
                                respErrorGetPDF.ReturnMessage = node.InnerText;
                            }
                            if (node.Name == "ReturnURL")
                            {
                                respErrorGetPDF.ReturnURL = node.InnerText;
                            }
                            if (node.Name == "ReturnBase64")
                            {
                                respErrorGetPDF.ReturnBase64 = node.InnerText;
                            }
                            if (node.Name == "ReturnDateTime")
                            {
                                respErrorGetPDF.ReturnDateTime = Convert.ToString(node.InnerText);
                            }
                        }
                    }
                    else
                    {
                        foreach (XmlNode node in xmlPDFRespuesta.DocumentElement.ChildNodes)
                        {
                            if (node.Name == "ReturnCode")
                            {
                                respGetPDF.ReturnCode = node.InnerText;
                            }

                            if (node.Name == "ReturnMessage")
                            {
                                respGetPDF.ReturnMessage = node.InnerText;
                            }
                            if (node.Name == "ReturnURL")
                            {
                                respGetPDF.ReturnURL = node.InnerText;
                            }
                            if (node.Name == "ReturnBase64")
                            {
                                respGetPDF.ReturnBase64 = node.InnerText;
                            }
                            if (node.Name == "ReturnDateTime")
                            {
                                respGetPDF.ReturnDateTime = Convert.ToString(node.InnerText);
                            }
                        }
                    }
                    if (respPDFStr.Contains("ErrorCode"))
                    {
                        escribirTxt(Properties.Settings.Default.CarpetaErrores + "Log_" + hilo + ".txt", "Fecha: " + DateTime.Now.ToString() + " | Archivo: " + archivo + " | Respuesta: " + respuesta);
                        
                        Thread.Sleep(5);
                        actualizarProgresos(100, _archivo, "Finalizado (No se pudo crear el PDF)");
                        actualizarListado();
                    }
                    else
                    {
                        Thread.Sleep(5);
                        actualizarProgresos(85, _archivo, "Obtiendo respuesta PDF...");
                        actualizarListado();

                        using (FileStream stream = File.Create("c:\\FE_PDF\\" + respuestaProcesarTextoPlano.ReturnUUID + ".pdf"))
                        {
                            Byte[] byteArray = Convert.FromBase64String(respGetPDF.ReturnBase64);
                            stream.Write(byteArray, 0, byteArray.Length);
                        }

                        Thread.Sleep(5);
                        actualizarProgresos(95, _archivo, "Creando archivo en Carpeta...");
                        actualizarListado();
                    }
                   
                    File.Move(directorioProcesando + _archivo, Properties.Settings.Default.CarpetaProcesados + _archivo);
                    Thread.Sleep(5);
                    actualizarProgresos(100, _archivo, "Finalizado");
                    actualizarListado();
                }
            }
            catch (Exception ex)
            {
                Thread.Sleep(5);
                actualizarProgresos(100, _archivo, "Finalizado con errores");
                actualizarListado();
                escribirTxt(Properties.Settings.Default.CarpetaErrores + "log_" + hilo + ".txt", "Fecha: "+ DateTime.Now.ToString() + " | Error: " + ex.Message + " | Archivo: " + archivo);
                //File.Move(directorioProcesando + _archivo, Properties.Settings.Default.CarpetaErrores + _archivo);
            }
        }
        void actualizarListado()
        {
            this.vista.ListaProcesosdataGridViewX1.DataSource = null;
            this.vista.ListaProcesosdataGridViewX1.AutoGenerateColumns = false;
            this.vista.ListaProcesosdataGridViewX1.DataSource = procesando;
        }
        private void actualizarProgresos(int valor, string _archivo, string _estado)
        {
            for(int i =0; i<= procesando.Count -1; i++)
            {
              if(  procesando[i].Archivo == _archivo && procesando[i].Progreso < valor)
                {
                    procesando[i].Progreso = valor;
                    procesando[i].Estado = _estado;
                }
            }
            //this.vista.Timer1.Enabled = true;
            Application.DoEvents();
            
        }
        private void ajustesMenuStrip_Click(object sender, EventArgs e)
        {
            frmConfiguraciones config = new frmConfiguraciones();
           
            
            config.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.vista.ListaProcesosdataGridViewX1.DataSource = null;
            this.vista.ListaProcesosdataGridViewX1.AutoGenerateColumns = false;
            this.vista.ListaProcesosdataGridViewX1.DataSource = procesando;
            this.vista.ListaProcesosdataGridViewX1.Refresh();
            this.vista.Timer1.Enabled = false;
        }
        private void timerEscanner_Tick(object sender, EventArgs e)
        {
            if(this.vista.SwitchButton1.Value == true)
            {
                segundos += 1;
                this.vista.Label1.Text = directorioProcesando;
                if (segundos == Properties.Settings.Default.TiempoSegundosEscaneo)
                {
                    
                    for (int i = 0; i <= procesando.Count - 1; i++)
                    {
                        if (procesando[i].Estado.Contains("Finalizado"))
                        {
                            procesando.RemoveAt(i);
                        }
                    }
                    explorarRaiz();
                    segundos = 0;
                }
            }
        }
        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EscanerSwitch = this.vista.SwitchButton1.Value;
            Properties.Settings.Default.Save();
        }
        private void frmPantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(directorioProcesando);
                if (Directory.Exists(directorioProcesando))
                {
                    foreach (var file in d.GetFiles("*.txt"))
                    {
                        File.Move(file.FullName, Properties.Settings.Default.CarpetaRaiz + file.Name);
                    }
                    Directory.Delete(directorioProcesando);
                }
                
            }
            catch (Exception)
            {
                throw;
            }
           
        }
    }
}
