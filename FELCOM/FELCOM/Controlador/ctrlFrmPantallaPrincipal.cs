using DevComponents.DotNetBar.Controls;
using FELCOM.Logica;
using FELCOM.Modelo;
using FELCOM.Vista;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
using static FELCOM.Logica.PrincipalLogica;

namespace FELCOM.Controlador
{
    public class ctrlFrmPantallaPrincipal
    {
        private frmPantallaPrincipal vista;
         int segundos;
        List<ProcesandoModel> procesando = new List<ProcesandoModel>();
        List<TipoDocumentoFE> tiposDocsFe;
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
            this.vista.SuperTabItem2.Click += superTabItem2_Click;
            //this.vista.Label1.DoubleClick += label1_DobleClic; solo fue para hacer pruebas
        }
        void cargarTiposDocsFE()
        {
            tiposDocsFe = new List<TipoDocumentoFE>();
            tiposDocsFe = PrincipalLogica.Instancia.listadoTiposDocs();


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
            if (!Directory.Exists(Properties.Settings.Default.CarpetaPDF))
            {
                Directory.CreateDirectory(Properties.Settings.Default.CarpetaPDF);
            }
            if (!Directory.Exists(Properties.Settings.Default.CarpetaToPrinter))
            {
                Directory.CreateDirectory(Properties.Settings.Default.CarpetaToPrinter);
            }
            if (!Directory.Exists(Properties.Settings.Default.CarpetaImpresos))
            {
                Directory.CreateDirectory(Properties.Settings.Default.CarpetaImpresos);
            }
        }
        private void frmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            cargarTiposDocsFE();
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
                        File.Copy(file.FullName, directorioProcesando + file.Name, true);
                        File.Delete(file.FullName);
                        //File.Move(file.FullName, directorioProcesando + file.Name);

                        string[] nombreArchivo = file.Name.Split('-');
                        procesando.Add(new ProcesandoModel { Archivo = file.Name, Estado = "Procesando...", TipoDocumento = tiposDocsFe.Where(a=>a.TipoDocFE == Convert.ToString(nombreArchivo[1])).Select(a=>a.Nombre).Single()});
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
                    escribirTxt(Properties.Settings.Default.CarpetaErrores + "Log_" + hilo + ".txt", "Fecha:" + DateTime.Now.ToString() + " | Error: " + ex.Message, false);
                    escribirLog("Error", ex.Message);
                }
            }
        }
        void escribirLog(string tipo, string mensaje)
        {
            try
            {
                PrincipalLogica.Instancia.escribirLog(new Logs { Fecha = DateTime.Now, Mensaje = mensaje, Tipo = tipo });
            }
            catch (Exception ex)
            {
                escribirTxt(Properties.Settings.Default.CarpetaErrores + "Log_" + hilo + ".txt", "Fecha:" + DateTime.Now.ToString() + " | Error: " + ex.Message, false);
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

                var textoPlano = "";
                if (Properties.Settings.Default.UTF8)
                {
                    textoPlano = File.ReadAllText(rutaArchivo, Encoding.GetEncoding("iso-8859-15"));
                }
                else
                {
                     textoPlano = File.ReadAllText(rutaArchivo);
                }
                

                string[] x_archivo = _archivo.Split('-');
               
                 Thread.Sleep(5);
                actualizarProgresos(10, _archivo, "Preparando archivo...");
                actualizarListado();

                string respuesta;
                string usuario = Properties.Settings.Default.UsuarioWS;
                string passw = Properties.Settings.Default.PassWS;
                string id = x_archivo[3];
                ekomercio.WSFEBuilder ws = new ekomercio.WSFEBuilder();
                if (_archivo.Contains("-INVALIDACION"))
                {
                    respuesta = ws.enviar_Invalidacion(usuario, passw, id,textoPlano);
                }
                else
                {
                    respuesta = ws.procesarTextoPlano(ref usuario, ref passw, ref id, ref textoPlano);
                }
               

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

                List<anioMesModel> anioMes = new List<anioMesModel>();
                anioMes = PrincipalLogica.Instancia.getAnioMes();

                string rutaDirectoriosPDF = Properties.Settings.Default.CarpetaPDF + x_archivo[3] +"\\"+ anioMes[0].Anio + "\\" + anioMes[0].Mes + "\\";
                if (!Directory.Exists(rutaDirectoriosPDF))
                {
                    Directory.CreateDirectory(rutaDirectoriosPDF);
                }

                string rutaCompletaDestinoPDF = rutaDirectoriosPDF + respuestaProcesarTextoPlano.ReturnUUID + ".pdf";

                if (respuesta.Contains("ErrorCode"))
                {
                    escribirTxt(Properties.Settings.Default.CarpetaErrores + "Log_" + hilo + ".txt", "Fecha: " + DateTime.Now.ToString() + " | Archivo: " + archivo + " | Respuesta: " + respuesta);
                    escribirLog("Error", archivo + " | " + respuesta);
                    //File.Move( directorioProcesando +  archivo, Properties.Settings.Default.CarpetaErrores);
                    File.Copy(directorioProcesando + archivo, Properties.Settings.Default.CarpetaErrores + archivo, true);
                    File.Delete(directorioProcesando + archivo);

                    Thread.Sleep(5);
                    actualizarProgresos(100, _archivo, "Finalizado con errores");
                    actualizarListado();
                }
                else
                {
                    if(Properties.Settings.Default.EscribirEnTabla)
                    {
                        try
                        {
                            //FacturaModel factura = new FacturaModel();
                            //factura = PrincipalLogica.Instancia.getFacturaInfo(x_archivo[4].Replace(".txt", ""));

                            Thread.Sleep(5);
                            actualizarProgresos(36, _archivo, "Escribiendo en tabla resp...");
                            actualizarListado();

                            string[] keyDoc = x_archivo[4].Split('!');
                            if (tiposDocsFe.Where(a=>a.TipoDocFE == x_archivo[1]).Select(a=>a.TablaRespuesta).Single() == "FacturaCorrFiscal")
                            {
                                string codPais = keyDoc[0];
                                int dealer = Convert.ToInt32( keyDoc[1]);
                                string tda = keyDoc[2];
                                string tipoDoc = keyDoc[3];
                                string serie = keyDoc[4];
                                int docNo = Convert.ToInt32(keyDoc[5].Replace(".txt", ""));
                                string tDocF = x_archivo[1];
                                string sDocF = respuestaProcesarTextoPlano.ReturnUUID;
                                string nDocF = respuestaProcesarTextoPlano.ReturnFolio;
                                string resolucion = respuestaProcesarTextoPlano.ReturnNumValidacion;
                                string idTrans = x_archivo[4].Replace("!", "").Replace(".txt", "");
                                DateTime fechaCreacion = DateTime.Now;
                                string origen = "FE";
                                string archivoTxt = _archivo;
                                string pdf = rutaCompletaDestinoPDF;
                                PrincipalLogica.Instancia.escribirRespuestaTablaFa(new FacturaCorrFiscalModel { CodPais = codPais, Dealer = dealer, Tda = tda, Serie = serie, TipoDoc = tipoDoc, DocNo = docNo, TDocF = tDocF, SDocF = sDocF, NDocF = nDocF, Archivo = archivoTxt, FechaCreacion = fechaCreacion, IdTrans = idTrans, Origen = origen, Resolucion = resolucion, PDF = pdf });
                            }
                            else if (tiposDocsFe.Where(a => a.TipoDocFE == x_archivo[1]).Select(a => a.TablaRespuesta).Single() == "NotaCreditoCorrFiscal")
                            {
                                string codPais = keyDoc[0];
                                int dealer = Convert.ToInt32(keyDoc[1]);
                                string tda = keyDoc[2];
                                bool notaAbono = false;
                                if (Convert.ToInt32(keyDoc[3].Replace(".txt", "")) == 1) { notaAbono = true; } else if (Convert.ToInt32(keyDoc[3].Replace(".txt", "")) == 0) { notaAbono = false; };
                                string tipoDoc = keyDoc[4];
                                string serie = keyDoc[5];
                                int docNo = Convert.ToInt32(keyDoc[6].Replace(".txt", ""));
                                string tDocF = x_archivo[1];
                                string sDocF = respuestaProcesarTextoPlano.ReturnUUID;
                                string nDocF = respuestaProcesarTextoPlano.ReturnFolio;
                                string resolucion = respuestaProcesarTextoPlano.ReturnNumValidacion;
                                string idTrans = x_archivo[4].Replace("!", "").Replace(".txt", "");
                                DateTime fechaCreacion = DateTime.Now;
                                string origen = "FE";
                                string archivoTxt = _archivo;
                                string pdf = rutaCompletaDestinoPDF;
                                PrincipalLogica.Instancia.escribirRespuestaTablaNC(new NotaCreditoCorrFiscalModel { CodPais = codPais, Dealer = dealer, Tda = tda, SerieNC = serie,  No = docNo, NotaAbono = notaAbono, TDocF = tDocF, SDocF = sDocF, NDocF = nDocF, Archivo = archivoTxt, FechaCreacion = fechaCreacion, IdTrans = idTrans, Origen = origen, Resolucion = resolucion, PDF = pdf });
                            }
                            else if (tiposDocsFe.Where(a => a.TipoDocFE == x_archivo[1]).Select(a => a.TablaRespuesta).Single() == "NotaRemisionCorrFiscal")
                            {
                                string codPais = keyDoc[0];
                                int dealer = Convert.ToInt16(keyDoc[1]);
                                string tda = keyDoc[2];
                               
                                int remisionNo = Convert.ToInt32(keyDoc[3].Replace(".txt", ""));
                                string tDocF = x_archivo[1];
                                string sDocF = respuestaProcesarTextoPlano.ReturnUUID;
                                string nDocF = respuestaProcesarTextoPlano.ReturnFolio;
                                string resolucion = respuestaProcesarTextoPlano.ReturnNumValidacion;
                                string idTrans = x_archivo[4].Replace("!", "").Replace(".txt", "");
                                DateTime fechaCreacion = DateTime.Now;
                                string origen = "FE";
                                string archivoTxt = _archivo;
                                string pdf = rutaCompletaDestinoPDF;
                                PrincipalLogica.Instancia.escribirRespuestaTablaNr(new NotaRemisionCorrFiscalModel { CodPais = codPais, Dealer = dealer, Tda = tda, RemisionNo = remisionNo, TDocF = tDocF, SDocF = sDocF, NDocF = nDocF, Archivo = archivoTxt, FechaCreacion = fechaCreacion, IdTrans = idTrans, Origen = origen, Resolucion = resolucion, PDF = pdf });
                            }
                            else if (tiposDocsFe.Where(a => a.TipoDocFE == x_archivo[1]).Select(a => a.TablaRespuesta).Single() == "RetencionIvaCorrFiscal")
                            {
                                string codPais = keyDoc[0];
                                int dealer = Convert.ToInt32(keyDoc[1]);
                                string tda = keyDoc[2];
                                string proveedor = keyDoc[3];
                                string serie = keyDoc[4];
                                int Comprobante = Convert.ToInt32(keyDoc[5].Replace(".txt", ""));
                                string tDocF = x_archivo[1];
                                string sDocF = respuestaProcesarTextoPlano.ReturnUUID;
                                string nDocF = respuestaProcesarTextoPlano.ReturnFolio;
                                string resolucion = respuestaProcesarTextoPlano.ReturnNumValidacion;
                                string idTrans = x_archivo[4].Replace("!", "").Replace(".txt", "");
                                DateTime fechaCreacion = DateTime.Now;
                                string origen = "FE";
                                string archivoTxt = _archivo;
                                string pdf = rutaCompletaDestinoPDF;
                                PrincipalLogica.Instancia.escribirRespuestaTablaRi(new RetencionIvaCorrFiscalModel { CodPais = codPais, Dealer = dealer, Tda = tda,Proveedor = proveedor, Serie  =serie, Comprobante = Comprobante, TDocF = tDocF, SDocF = sDocF, NDocF = nDocF, Archivo = archivoTxt, FechaCreacion = fechaCreacion, IdTrans = idTrans, Origen = origen, Resolucion = resolucion, PDF = pdf });
                            }
                            else if (tiposDocsFe.Where(a => a.TipoDocFE == x_archivo[1]).Select(a => a.TablaRespuesta).Single() == "CompraCorrFiscal")
                            {
                                string codPais = keyDoc[0];
                                int dealer = Convert.ToInt32(keyDoc[1]);
                                string tda = keyDoc[2];
                                int CompraNo = Convert.ToInt32(keyDoc[3].Replace(".txt", ""));
                                string tDocF = x_archivo[1];
                                string sDocF = respuestaProcesarTextoPlano.ReturnUUID;
                                string nDocF = respuestaProcesarTextoPlano.ReturnFolio;
                                string resolucion = respuestaProcesarTextoPlano.ReturnNumValidacion;
                                string idTrans = x_archivo[4].Replace("!", "").Replace(".txt", "");
                                DateTime fechaCreacion = DateTime.Now;
                                string origen = "FE";
                                string archivoTxt = _archivo;
                                string pdf = rutaCompletaDestinoPDF;
                                PrincipalLogica.Instancia.escribirRespuestaTablaCo(new CompraCorrFiscalModel { CodPais = codPais, Dealer = dealer, Tda = tda,  CompraNo = CompraNo, TDocF = tDocF, SDocF = sDocF, NDocF = nDocF, Archivo = archivoTxt, FechaCreacion = fechaCreacion, IdTrans = idTrans, Origen = origen, Resolucion = resolucion, PDF = pdf });
                            }
                        }
                        catch (Exception ex)
                        {
                            escribirTxt(Properties.Settings.Default.CarpetaErrores + "Log_" + hilo + ".txt", "Fecha: " + DateTime.Now.ToString() + " | Error: " + ex.Message);
                            escribirLog("Error", archivo + " | " + ex.Message);
                        }
                    }
                    
                    string pathRespuestaTxt = Properties.Settings.Default.CarpetaRespuestas + "_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "_" + archivo  ;
                    escribirTxt(pathRespuestaTxt, respuesta);
                  
                    Thread.Sleep(5);
                    actualizarProgresos(40, _archivo, "Obteniendo respuesta PDF...");
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
                        escribirLog("Error", archivo + " | " + respuesta);
                        Thread.Sleep(5);
                        actualizarProgresos(100, _archivo, "Finalizado (No se pudo crear el PDF)");
                        actualizarListado();
                    }
                    else
                    {
                        Thread.Sleep(5);
                        actualizarProgresos(85, _archivo, "Obtiendo respuesta PDF...");
                        actualizarListado();

                        using (FileStream stream = File.Create(rutaCompletaDestinoPDF))
                        {
                            Byte[] byteArray = Convert.FromBase64String(respGetPDF.ReturnBase64);
                            stream.Write(byteArray, 0, byteArray.Length);
                        }

                        Thread.Sleep(5);
                        actualizarProgresos(95, _archivo, "Creando archivo en Carpeta...");
                        actualizarListado();

                        if (!Directory.Exists(Properties.Settings.Default.CarpetaToPrinter))
                        {
                            Directory.CreateDirectory(Properties.Settings.Default.CarpetaToPrinter);
                        }
                        if (!Directory.Exists(Properties.Settings.Default.CarpetaToPrinter + "\\Temp\\"))
                        {
                            Directory.CreateDirectory(Properties.Settings.Default.CarpetaToPrinter + "\\Temp\\");
                        }
                        escribirTxt(Properties.Settings.Default.CarpetaToPrinter + "\\Temp\\" + _archivo, rutaCompletaDestinoPDF);
                        File.Copy(Properties.Settings.Default.CarpetaToPrinter + "\\Temp\\" + _archivo, Properties.Settings.Default.CarpetaToPrinter + _archivo, true);
                        File.Delete(Properties.Settings.Default.CarpetaToPrinter + "\\Temp\\" + _archivo);
                        Thread.Sleep(5);

                        if (Properties.Settings.Default.imprimir)
                        {
                            string file_pdf = File.ReadAllText(Properties.Settings.Default.CarpetaToPrinter + _archivo);
                            string impresora = x_archivo[2];
                            PdfDocument pdf = new PdfDocument();
                            pdf.LoadFromFile(file_pdf.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""));
                            pdf.PrintSettings.PrinterName = impresora;
                            pdf.Print();

                            File.Copy(Properties.Settings.Default.CarpetaToPrinter + _archivo, Properties.Settings.Default.CarpetaImpresos + _archivo, true);
                            File.Delete(Properties.Settings.Default.CarpetaToPrinter + _archivo);
                            Thread.Sleep(5);
                            actualizarProgresos(98, _archivo, "Enviando a impresión...");
                            actualizarListado();
                        }

                        actualizarProgresos(98, _archivo, "Enviando a ToPrinter");
                    }
                    

                    File.Move(directorioProcesando + _archivo, Properties.Settings.Default.CarpetaProcesados + _archivo);
                    Thread.Sleep(5);
                    actualizarProgresos(100, _archivo, "Finalizado");
                    actualizarListado();

                    escribirLog("Exito", archivo + " | Finalizado exitosamente" );
                }
            }
            catch (Exception ex)
            {
                Thread.Sleep(5);
                actualizarProgresos(100, _archivo, "Finalizado con errores");
                actualizarListado();
                escribirTxt(Properties.Settings.Default.CarpetaErrores + "log_" + hilo + ".txt", "Fecha: "+ DateTime.Now.ToString() + " | Error: " + ex.Message + " | Archivo: " + archivo);
                escribirLog("Error", archivo + " | " + ex.Message);
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
                this.vista.Label1.Text = string.Format("Lector: {0} ",   directorioProcesando);
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
        private void label1_DobleClic(object sender, EventArgs e)
        {
            using(SqlConnection cn = new SqlConnection(ConexionDB.instancia.getString()))
            {
                string q = @"select top 100 
                            CONCAT('DTE-', t.TipoDocFE, '-XEROXINFO-06141210830014-', CONCAT(f.codpais, ';', f.Dealer, ';', rtrim(f.Tda), ';', rtrim(f.TipoDoc), ';', rtrim(f.serie), ';', f.docno))
                            from factura f left join TipoDocumentoFE t on t.TipoDoc = f.TipoDoc
                            where f.Dealer = 15 and f.TipoDoc <> ''  and f.DocNo >0 order by f.Fecha desc";
                SqlCommand cmd = new SqlCommand(q, cn);
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataReader leer;
                int correlativo = 1;
                cn.Open();
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    escribirTxt("C:\\FELCOM\\" + Convert.ToString(leer[0]) + ".txt", "~[Folio]|Nombre Emisor|06141210830014|||||| EL  SALVADOR|14|06|9300||00000000||||||||||||3||||2023-02-20|15:20:59|||||||||||Nombre Receptor|06081712710012||||||SAN SALVADOR|08|06|9300||100.00000|13.00000|113.00000||03|||||||113.00000||||00000011|0009|Nombre Tienda Prueba|||||| EL  SALVADOR|14|06||||USD|0||0.00000|1|2224|132|1.00|||||||1|||CIENTO TRECE DOLARES CON 0/100|||||00000000|Nombre Emisor|||0.00000||||||||Elaboración de productos alimenticios ncp|SAN SALVADOR.MEJICANOS.SAN SALVADOR||||||||||||||||||||||||||||||||||||||emisor12@hotmail.com|0.00000|0.00|0.00000|0.00||||0.00|10799|||||||36|00|||receptor@hotmail.com|1.00000|1|2|Nombre Receptor|0.00000|1|" + correlativo.ToString("000000000000000") + "|0.00000||0.00000|100.00000|02|||1|100.00000|0.00000\r\n¬Producto Prueba30|1.00|59|100|100.00000|||||||||||15279|||0.00|||||13.00000||||0||||||||||||||||||||||||||||||||||||||||||||||||||||||||||0|||1||||0.00|||  |||15279\\I|20|13|13.00000|||||\r\n¬*FP|Formas de pago de la factura|01|undefined||113.00000||01||||||||||\r\nCA|Códigos de actividad económica del emisor|10104| ELABORACIÓN Y CONSERVACIÓN DE EMBUTIDOS Y TRIPAS NATURALES||||||||||||||");
                    correlativo ++;
                }
                cn.Close();    
            }
        }
        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EscanerSwitch = this.vista.SwitchButton1.Value;
            Properties.Settings.Default.Save();
            cargarTiposDocsFE();
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
        void cargarLogs()
        {
            this.vista.LogsDgv.AutoGenerateColumns = false;
            this.vista.LogsDgv.DataSource = PrincipalLogica.Instancia.getLogs();
        }
        private void superTabItem2_Click(object sender, EventArgs e)
        {
            if (this.vista.SuperTabControl1.SelectedTabIndex == 1)
            {
                cargarLogs();
            }
        }
    }
}
