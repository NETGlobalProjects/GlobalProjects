using DevComponents.DotNetBar.SuperGrid.Style;
using FELSvPrint.Datos;
using PrintQRCode;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ZXing.QrCode;

namespace FELSvPrint
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form
    {
        NetDataEntitie db;
        static List<HilosModel> hiloss = new List<HilosModel>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarListado();
            for (int i = 1; i <= Properties.Settings.Default.hilos; i++)
            {
                hiloss.Add(new HilosModel { hilo = i, estado = 0 });
                if (!Directory.Exists(Properties.Settings.Default.directorioPDF + i.ToString()))
                {
                    Directory.CreateDirectory(Properties.Settings.Default.directorioPDF + i.ToString());
                }
            }
            int a = 0;
        }
        void cargarListado()
        {
            try
            {
                NetDataEntitie db = new NetDataEntitie();
                var datos = db.FELPDFs.OrderByDescending(a => a.FechaImpresion).Take(100).ToList();
                superGridControl1.PrimaryGrid.AutoGenerateColumns = false;
                superGridControl1.PrimaryGrid.DataSource = datos;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar Listado: " + ex.Message, ex.InnerException);
            }
        }
        void reportarProgreso(int hilo, int progreso, string estatusText)
        {
            if (hilo == 1)
            {
                this.progressBarH1.Text = estatusText;
                this.progressBarH1.Value = progreso;
                if (progreso == 100)
                {
                    this.progressBarH1.Value = 0;
                    this.progressBarH1.Text = "H1";
                }
            }
            if (hilo == 2)
            {
                this.progressBarH2.Text = estatusText;
                this.progressBarH2.Value = progreso;
                if (progreso == 100)
                {
                    this.progressBarH2.Value = 0;
                    this.progressBarH2.Text = "H2";
                }
            }
            if (hilo == 3)
            {
                this.progressBarH3.Text = estatusText;
                this.progressBarH3.Value = progreso;
                if (progreso == 100)
                {
                    this.progressBarH3.Value = 0;
                    this.progressBarH3.Text = "H3";
                }
            }
            if (hilo == 4)
            {
                this.progressBarH4.Text = estatusText;
                this.progressBarH4.Value = progreso;
                if (progreso == 100)
                {
                    this.progressBarH4.Value = 0;
                    this.progressBarH4.Text = "H4";
                }
            }
            if (hilo == 5)
            {
                this.progressBarH5.Text = estatusText;
                this.progressBarH5.Value = progreso;
                if (progreso == 100)
                {
                    this.progressBarH5.Value = 0;
                    this.progressBarH5.Text = "H5";
                }
            }
        }
        void iniciar()
        {
            try
            {

                timer1.Enabled = false;
                DirectoryInfo d = new DirectoryInfo(Properties.Settings.Default.directorioPDF);
                List<ConfigPBS> printers = new List<ConfigPBS>();
                List<ArchivoModel> archvos = new List<ArchivoModel>();
                int x = 0;
                foreach (var file in d.GetFiles("*.pdf"))
                {
                    string[] x_archivo = file.Name.Split('-');
                    string impresora = x_archivo[2];
                    archvos.Add(new ArchivoModel { id = x + 1, Name = file.Name, FullName = file.FullName });

                    if (x == Properties.Settings.Default.hilos)
                    {
                        break;
                    }
                    x++;
                }

                foreach (var file in d.GetFiles("*.txt"))
                {
                    string[] x_archivo = file.Name.Split('_');
                    string impresora = "";
                    if (x_archivo[0] == "LC" || x_archivo[0] == "I")
                    {
                        impresora = x_archivo[2];
                    }
                    else if (x_archivo[0] == "LP" || x_archivo[0] == "LR")
                    {
                        impresora = x_archivo[3];
                    }


                    //archvos.Add(new ArchivoModel { id = x + 1, Name = file.Name, FullName = file.FullName });

                    string[] x_archivo2 = file.Name.ToString().Split('_');
                    string codigoGen = "";
                    string impresora2 = "";
                    string consolidado = "";
                    string tipoImpresora = "";
                    string placa = "";
                    string ruta = "";
                    DateTime? fecha = null;
                    if (x_archivo[0] == "LC" || x_archivo2[0] == "I")
                    {
                        impresora2 = x_archivo2[2].ToUpper().Replace(".TXT", "");
                        if (x_archivo2[0] == "I")
                        {
                            codigoGen = x_archivo2[1];
                        }
                        if (x_archivo2[0] == "LC")
                        {
                            consolidado = x_archivo2[1];
                        }
                    }
                    else if (x_archivo2[0] == "LP" || x_archivo2[0] == "LR")
                    {
                        impresora2 = x_archivo2[2].ToUpper().Replace(".TXT", "");
                        if (x_archivo2[0] == "LP")
                        {
                            placa = x_archivo2[1];
                        }
                        if (x_archivo2[0] == "LR")
                        {
                            ruta = x_archivo2[1];
                        }
                        fecha = Convert.ToDateTime(x_archivo2[2]);
                    }
                    tipoImpresora = (impresora2.Contains("T") ? "T" : "M");

                    if (x_archivo2[0] != "LD")
                    {
                        try
                        {
                            string filtado = x_archivo2[0];


                            var encabezados = FELDatosFormatoTicket.instancia.getFELDatosFormatoTicket(filtado, placa, consolidado, fecha, codigoGen, ruta);
                            foreach (var i in encabezados)
                            {
                                string textToEncode = i.CodigoQR;

                                QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
                                Bitmap qrCodeImage = qrCodeGenerator.GenerateQRCode(textToEncode);
                                var det = FELDatosFormatoTicket.instancia.getFELDatosFormatoTicketDet(i.CodPais, i.Dealer, i.Tda, i.TipoDoc, i.Serie, i.DocNo);
                                PrintTicket ticket = new PrintTicket(qrCodeImage, i, det);
                                ticket.Print("Consolas", 7, impresora2, tipoImpresora);

                                //string file_txt2 = Properties.Settings.Default.directorioPDF + file.Name.ToString();
                                //File.Delete(file_txt2);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " " + ex.InnerException, "Error al imprimir ticket venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }



                    string file_txt = file.FullName;
                    File.Delete(file_txt);

                    //if (x == Properties.Settings.Default.hilos)
                    //{
                    //    break;
                    //}
                    //x++;
                }
               

                int hilos = Properties.Settings.Default.hilos;
                if (x == 1)
                {
                    //if (archvos.Count > 0)
                    //{
                    string archivo1 = archvos.Where(a => a.id == 1).Select(a => a.Name).Single();
                    if (archivo1 != null && hiloss.Where(a => a.hilo == 1).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo1);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo1);
                        Thread.Sleep(100);

                        Thread hilo1 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo1);
                        Thread.Sleep(100);


                        hilo1.Start(archivo1 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : "") );

                        reportarProgreso(x, 100, archivo1);
                        Thread.Sleep(100);
                    }
                    //}
                }
                if (x == 2)
                {
                    //if (archvos.Count > 0)
                    //{
                    string archivo1 = archvos.Where(a => a.id == 1).Select(a => a.Name).Single();
                    if (archivo1 != null && hiloss.Where(a => a.hilo == 1).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo1);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo1);
                        Thread.Sleep(100);

                        Thread hilo1 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo1);
                        Thread.Sleep(100);


                        hilo1.Start(archivo1 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : ""));

                        reportarProgreso(x, 100, archivo1);
                        Thread.Sleep(100);
                    }
                    //}
                    //if (archvos.Count > 1)
                    //{
                    string archivo2 = archvos.Where(a => a.id == 2).Select(a => a.Name).Single();
                    if (archivo2 != null && hiloss.Where(a => a.hilo == 2).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo2);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo2);
                        Thread.Sleep(100);

                        Thread hilo2 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo2);
                        Thread.Sleep(100);


                        hilo2.Start(archivo2 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : ""));

                        reportarProgreso(x, 100, archivo2);
                        Thread.Sleep(100);
                    }
                    //}
                }
                if (x == 3)
                {
                    //if (archvos.Count > 0)
                    //{
                    string archivo1 = archvos.Where(a => a.id == 1).Select(a => a.Name).Single();
                    if (archivo1 != null && hiloss.Where(a => a.hilo == 1).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo1);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo1);
                        Thread.Sleep(100);

                        Thread hilo1 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo1);
                        Thread.Sleep(100);


                        hilo1.Start(archivo1 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : ""));

                        reportarProgreso(x, 100, archivo1);
                        Thread.Sleep(100);
                    }
                    //}
                    //if (archvos.Count > 1)
                    //{
                    string archivo2 = archvos.Where(a => a.id == 2).Select(a => a.Name).Single();
                    if (archivo2 != null && hiloss.Where(a => a.hilo == 2).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo2);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo2);
                        Thread.Sleep(100);

                        Thread hilo2 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo2);
                        Thread.Sleep(100);


                        hilo2.Start(archivo2 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : ""));

                        reportarProgreso(x, 100, archivo2);
                        Thread.Sleep(100);
                    }
                    //}
                    //if (archvos.Count > 2)
                    //{
                    string archivo3 = archvos.Where(a => a.id == 3).Select(a => a.Name).Single();
                    if (archivo3 != null && hiloss.Where(a => a.hilo == 3).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo3);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo3);
                        Thread.Sleep(100);

                        Thread hilo3 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo3);
                        Thread.Sleep(100);


                        hilo3.Start(archivo3 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : ""));

                        reportarProgreso(x, 100, archivo3);
                        Thread.Sleep(100);
                    }
                    //}
                }
                if (x == 4)
                {
                    //if (archvos.Count > 0)
                    //{
                    string archivo1 = archvos.Where(a => a.id == 1).Select(a => a.Name).Single();
                    if (archivo1 != null && hiloss.Where(a => a.hilo == 1).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo1);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo1);
                        Thread.Sleep(100);

                        Thread hilo1 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo1);
                        Thread.Sleep(100);


                        hilo1.Start(archivo1 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : ""));

                        reportarProgreso(x, 100, archivo1);
                        Thread.Sleep(100);
                    }
                    //}
                    //if (archvos.Count > 1)
                    //{
                    string archivo2 = archvos.Where(a => a.id == 2).Select(a => a.Name).Single();
                    if (archivo2 != null && hiloss.Where(a => a.hilo == 2).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo2);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo2);
                        Thread.Sleep(100);

                        Thread hilo2 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo2);
                        Thread.Sleep(100);


                        hilo2.Start(archivo2 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : ""));

                        reportarProgreso(x, 100, archivo2);
                        Thread.Sleep(100);
                    }
                    //}
                    //if (archvos.Count > 2)
                    //{
                    string archivo3 = archvos.Where(a => a.id == 3).Select(a => a.Name).Single();
                    if (archivo3 != null && hiloss.Where(a => a.hilo == 3).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo3);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo3);
                        Thread.Sleep(100);

                        Thread hilo3 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo3);
                        Thread.Sleep(100);


                        hilo3.Start(archivo3 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : ""));

                        reportarProgreso(x, 100, archivo3);
                        Thread.Sleep(100);
                    }
                    //}
                    //if (archvos.Count > 3)
                    //{
                    string archivo4 = archvos.Where(a => a.id == 4).Select(a => a.Name).Single();
                    if (archivo4 != null && hiloss.Where(a => a.hilo == 4).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo4);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo4);
                        Thread.Sleep(100);

                        Thread hilo4 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo4);
                        Thread.Sleep(100);


                        hilo4.Start(archivo4 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : ""));

                        reportarProgreso(x, 100, archivo4);
                        Thread.Sleep(100);
                    }
                }
                //}
                if (x == 5)
                {
                    //if (archvos.Count > 0)
                    //{
                    string archivo1 = archvos.Where(a => a.id == 1).Select(a => a.Name).Single();
                    if (archivo1 != null && hiloss.Where(a => a.hilo == 1).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo1);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo1);
                        Thread.Sleep(100);

                        Thread hilo1 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo1);
                        Thread.Sleep(100);


                        hilo1.Start(archivo1 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : ""));

                        reportarProgreso(x, 100, archivo1);
                        Thread.Sleep(100);
                    }
                    //}
                    //if (archvos.Count > 1)
                    //{
                    string archivo2 = archvos.Where(a => a.id == 2).Select(a => a.Name).Single();
                    if (archivo2 != null && hiloss.Where(a => a.hilo == 2).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo2);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo2);
                        Thread.Sleep(100);

                        Thread hilo2 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo2);
                        Thread.Sleep(100);


                        hilo2.Start(archivo2 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : ""));

                        reportarProgreso(x, 100, archivo2);
                        Thread.Sleep(100);
                    }
                    //}
                    //if (archvos.Count > 2)
                    //{
                    string archivo3 = archvos.Where(a => a.id == 3).Select(a => a.Name).Single();
                    if (archivo3 != null && hiloss.Where(a => a.hilo == 3).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo3);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo3);
                        Thread.Sleep(100);

                        Thread hilo3 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo3);
                        Thread.Sleep(100);


                        hilo3.Start(archivo3 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : ""));

                        reportarProgreso(x, 100, archivo3);
                        Thread.Sleep(100);
                    }
                    //}
                    //if (archvos.Count > 3)
                    //{
                    string archivo4 = archvos.Where(a => a.id == 4).Select(a => a.Name).Single();
                    if (archivo4 != null && hiloss.Where(a => a.hilo == 4).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo4);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo4);
                        Thread.Sleep(100);

                        Thread hilo4 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo4);
                        Thread.Sleep(100);


                        hilo4.Start(archivo4 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : ""));

                        reportarProgreso(x, 100, archivo4);
                        Thread.Sleep(100);
                    }
                    //}
                    //if (archvos.Count > 4)
                    //{
                    string archivo5 = archvos.Where(a => a.id == 5).Select(a => a.Name).Single();
                    if (archivo5 != null && hiloss.Where(a => a.hilo == 5).Select(a => a.estado).Single() == 0)
                    {
                        reportarProgreso(x, 10, archivo5);
                        Thread.Sleep(100);
                        reportarProgreso(x, 25, archivo5);
                        Thread.Sleep(100);

                        Thread hilo5 = new Thread(ejecutar);

                        reportarProgreso(x, 65, archivo5);
                        Thread.Sleep(100);


                        hilo5.Start(archivo5 + (archivo1.ToUpper().Contains(".PDF") ? ":" + x : ""));

                        reportarProgreso(x, 100, archivo5);
                        Thread.Sleep(100);
                    }
                }
                //}
                if (x > 0)
                {
                    cargarListado();
                }
                timer1.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (switchButtonItem2.Value == true)
            {
                int segs = 0;
                segs += 1;
                if (segs == Properties.Settings.Default.tiempoEscaneo)
                {
                    iniciar();
                }
            }
        }
        static void ejecutar(object oArchivo)
        {
            if (oArchivo.ToString().ToUpper().Contains(".PDF"))
            {
                string[] parametros = oArchivo.ToString().Split(':');
                string archivo = parametros[0].ToString();
                string[] x_archivo = archivo.Split('-');
                int hilo = Convert.ToInt32(parametros[1]);
                NetDataEntitie db = new NetDataEntitie();
                db = new NetDataEntitie();
                string file_pdf = Properties.Settings.Default.directorioPDF + hilo.ToString() + "\\" + archivo;
                string impresora = x_archivo[2];
                string usuario = x_archivo[3];
                try
                {
                    hiloss.Where(a => a.hilo == hilo).Single().estado = 1;

                    File.Copy(Properties.Settings.Default.directorioPDF + archivo, Properties.Settings.Default.directorioPDF + hilo.ToString() + "\\" + archivo, true);
                    File.Delete(Properties.Settings.Default.directorioPDF + archivo);

                    DirectoryInfo d = new DirectoryInfo(Properties.Settings.Default.directorioPDF);

                    PdfDocument pdf = new PdfDocument();
                    pdf.LoadFromFile(file_pdf.Replace("\r\n", "").Replace("\n", "").Replace("\r", ""));
                    pdf.PrintSettings.PrinterName = impresora;
                    //pdf.PrintSettings.SetPaperMargins(Properties.Settings.Default.marginTop, Properties.Settings.Default.marginBottom, Properties.Settings.Default.marginLeft, Properties.Settings.Default.marginRigh);
                    pdf.PrintSettings.PaperSize = Spire.Pdf.Print.PdfPaperSizes.Letter;
                    pdf.PrintSettings.PrinterResolutionKind = Spire.Pdf.Print.PdfPrinterResolutionKind.Medium;
                    pdf.Print();

                    File.Copy(file_pdf, Properties.Settings.Default.destinoPDF + archivo, true);
                    File.Delete(file_pdf);

                    db.FELPDFs.Add(new FELPDFs { Archivo = archivo, Ubicacion = Properties.Settings.Default.directorioPDF + archivo, Impresora = impresora, Usuario = usuario, FechaImpresion = DateTime.Now, Resultado = "EXITOSO" });
                    db.SaveChanges();
                    hiloss.Where(a => a.hilo == hilo).Single().estado = 0;
                }
                catch (Exception ex)
                {
                    try
                    {
                        if (File.Exists(file_pdf))
                        {
                            File.Copy(file_pdf, Properties.Settings.Default.destinoErrores + archivo, true);
                            File.Delete(file_pdf);
                        };

                        db.FELPDFs.Add(new FELPDFs { Archivo = archivo, Ubicacion = Properties.Settings.Default.directorioPDF + archivo, Impresora = impresora, Usuario = usuario, FechaImpresion = DateTime.Now, Resultado = "ERROR: " + ex.Message });
                        db.SaveChanges();
                    }
                    catch (Exception ex1)
                    {
                        throw new Exception(ex1.Message);
                    }
                }
                finally
                {
                    hiloss.Where(a => a.hilo == hilo).Single().estado = 0;
                }
            }
            else if (oArchivo.ToString().ToUpper().Contains(".TXT"))
            {
                string[] x_archivo = oArchivo.ToString().Split('_');
                string codigoGen = "";
                string impresora = "";
                string consolidado = "";
                string tipoImpresora = "";
                string placa = "";
                string ruta = "";
                DateTime? fecha = null;
                if (x_archivo[0] == "LC" || x_archivo[0] == "I")
                {
                    impresora = x_archivo[2].ToUpper().Replace(".TXT", "");
                    if (x_archivo[0] == "I") 
                    {
                        codigoGen = x_archivo[1];
                    }
                    if(x_archivo[0] == "LC"){
                        consolidado = x_archivo[1];
                    }
                }
                else if (x_archivo[0] == "LP" || x_archivo[0] == "LR")
                {
                    impresora = x_archivo[2].ToUpper().Replace(".TXT", "");
                    if (x_archivo[0] == "LP")
                    {
                        placa = x_archivo[1];
                    }
                    if (x_archivo[0] == "LR")
                    {
                        ruta = x_archivo[1];
                    }
                    fecha = Convert.ToDateTime( x_archivo[2]);
                }
                tipoImpresora = (impresora.Contains("T") ? "T" : "M"); 

                if(x_archivo[0] != "LD")
                {
                    try
                    {
                        string filtado = x_archivo[0];


                        var encabezados = FELDatosFormatoTicket.instancia.getFELDatosFormatoTicket(filtado, placa, consolidado, fecha, codigoGen, ruta);
                        foreach (var i in encabezados)
                        {
                            string textToEncode = i.CodigoQR;

                            QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
                            Bitmap qrCodeImage = qrCodeGenerator.GenerateQRCode(textToEncode);
                            var det = FELDatosFormatoTicket.instancia.getFELDatosFormatoTicketDet(i.CodPais, i.Dealer, i.Tda, i.TipoDoc, i.Serie, i.DocNo);
                            PrintTicket ticket = new PrintTicket(qrCodeImage, i, det);
                            ticket.Print("Consolas", 7, impresora, tipoImpresora);

                            string file_txt = Properties.Settings.Default.directorioPDF +  oArchivo.ToString();
                            File.Delete(file_txt);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " " + ex.InnerException, "Error al imprimir ticket venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                

            }

        }
        private void buttonItem2_Click(object sender, EventArgs e)
        {
            frmAjustes frm = new frmAjustes();
            frm.ShowDialog();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            cargarListado();
            timer2.Enabled = false;
        }
        private void buttonItem3_Click(object sender, EventArgs e)
        {
            cargarListado();
        }

        private void superGridControl1_GetRowCellStyle(object sender, DevComponents.DotNetBar.SuperGrid.GridGetRowCellStyleEventArgs e)
        {
            if (e.GridRow.ToString().Contains("ERROR:"))
            {
                e.Style.TextColor = Color.Red;
            }
            if (e.GridRow.ToString().Contains("EXITOSO"))
            {
                e.Style.TextColor = Color.Green;
            }
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            frmTempPrintTicket frm = new frmTempPrintTicket();
            frm.ShowDialog();
        }
    }
}
