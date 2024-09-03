using FELSvPrint.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FELSvPrint.Datos
{
    public class PrintTicket
    {
        private Bitmap qrCodeImage;
        private PrintDocument PD = new PrintDocument();
        private List<string> lineas;
        private int lineaActual;
        private int conteoLineas = 0;
        private int ticketHeight;
        int conteoLineasGeneral = 0;
        string _tipoImpresora = "";
        bool impresoEnc = false;

        //Font printFont = new Font("Arial", 10);
        FELDatosFormatoTicketModel enc;
        List<FELDatosFormatoTicketDetModel> det;

        string font = "";
        int tamanioFont;
        string printerName;
        private PrintPreviewDialog PPD = new PrintPreviewDialog();
        private int longpapper;

        public PrintTicket(Bitmap qrCodeImage, FELDatosFormatoTicketModel encabezado, List<FELDatosFormatoTicketDetModel> detalles)
        {
            this.qrCodeImage = qrCodeImage;

            PD.BeginPrint += PD_BeginPrint;
            PD.PrintPage += PD_PrintPage;


            enc = new FELDatosFormatoTicketModel();
            det = new List<FELDatosFormatoTicketDetModel>();
            enc = encabezado;
            det = detalles;

            lineas = new List<string>();
        }
        private void BeginPrint(object sender, PrintEventArgs e)
        {
            lineaActual = 0;
        }
        public void Print(string Fuente, int tamanioFuente, string impresora, string tipoImpresora)
        {
            font = Fuente;
            tamanioFont = tamanioFuente;
            printerName = impresora;
            _tipoImpresora  =tipoImpresora;
            changelongpapper(det.Count * 30);
            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            printPreview.Document = PD;
            //printPreview.Show();

            try
            {
                PD.PrinterSettings.PrinterName = printerName;
                PD.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al imprimir: " + ex.Message);
            }
        }
        public void AgregarLinea(string linea)
        {
            lineas.Add(linea);
        }
        public void changelongpapper(int cantidadFilas)
        {
            int rowcount = cantidadFilas;
            longpapper = (rowcount );
        }
        private void PD_BeginPrint(object sender, PrintEventArgs e)
        {
            PageSettings pagesetup = new PageSettings();

            pagesetup.PaperSize = new PaperSize("Custom", 300, longpapper);
            PD.DefaultPageSettings = pagesetup;
        }
        private List<string> WrapText(string text, Font font, int maxWidth, Graphics g, string etiqueta)
        {
            List<string> lines = new List<string>();
            string[] words = text.Split(' ');
            StringBuilder currentLine = new StringBuilder();
            int cont = 0;
            foreach (string word in words)
            {
                string tempLine = currentLine.Length == 0 ? word : currentLine + " " + word;
                SizeF size = g.MeasureString(tempLine, font);

                if (size.Width > maxWidth)
                {
                    lines.Add(currentLine.ToString());
                    currentLine.Clear();
                    currentLine.Append(word);
                }
                else
                {
                    currentLine.Append(currentLine.Length == 0 ? etiqueta + " " + word : " " + word);
                }
               
                cont++;
            }

            if (currentLine.Length > 0)
            {
                lines.Add(currentLine.ToString());
            }

            return lines;
        }
        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 90;
            int espacioLinea = 0;
            //string font = FON;
            string font2 = "Consolas";

            Font f6 = new Font(font, tamanioFont, (_tipoImpresora == "M") ?  FontStyle.Regular: FontStyle.Bold);
            Font f6b = new Font(font, (_tipoImpresora == "M") ? tamanioFont : tamanioFont + 2, FontStyle.Bold);
            Font f10 = new Font(font, 10, FontStyle.Regular);
            Font f8b = new Font(font, 8, FontStyle.Bold);
            Font f11 = new Font(font, 11, FontStyle.Regular);
            Font fb11 = new Font(font, 11, FontStyle.Bold);
            Font f14 = new Font(font, 14, FontStyle.Regular);
            Font fb14 = new Font(font, 14, FontStyle.Bold);
            Font fb18 = new Font(font, 18, FontStyle.Bold);

            int leftmargin = 5;
            int centermargin = PD.DefaultPageSettings.PaperSize.Width / 2;
            int rightmargin = PD.DefaultPageSettings.PaperSize.Width - 5;

            StringFormat right = new StringFormat();
            StringFormat left = new StringFormat();
            StringFormat center = new StringFormat();
            right.Alignment = StringAlignment.Far;
            left.Alignment = StringAlignment.Near;
            center.Alignment = StringAlignment.Center;

            string line = "=========================================";
            string division = "---------------------------------------------------------------------------------------------";
            string divisionCorta = "---------------------------";

            conteoLineasGeneral += 1;
          

            if(impresoEnc == false)
            {
               
                espacioLinea += 6;
                if(enc.Orden > 0)
                {
                    e.Graphics.DrawString(enc.Orden.ToString(), fb18, Brushes.Black, centermargin, espacioLinea, center);
                    espacioLinea += 25;
                }
                e.Graphics.DrawString(enc.NombreTipoDoc, fb11, Brushes.Black, centermargin, espacioLinea, center);
                espacioLinea += 13;
                e.Graphics.DrawString(division, f8b, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;

                /*DTE*/
                e.Graphics.DrawString("DTE", fb11, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 16;
                e.Graphics.DrawString("CÓDIGO GENERACIÓN: ", f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString(enc.CodigoGeneracion, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("NÚMERO DE CONTROL: ", f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString(enc.NumeroControl, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("SELLO DE RECEPCIÓN: ", f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString(enc.SelloRecibido, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString(division, f8b, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 20;

                /*EMISOR*/
                e.Graphics.DrawString("EMISOR", fb11, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 16;
                e.Graphics.DrawString("DOCUMENTO INTERNO: " + enc.TipoDoc.Trim() + "-" + enc.Serie.Trim() + "-" + enc.DocNo.ToString(), f6b, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("PEDIDO #: " + enc.EmisorPedidoVta.Trim(), f6b, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("ORDEN COMPRA #: " + enc.OrdenCompra.Trim(), f6b, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("CONSOLIDADO #: " + enc.Consolidado.Trim(), f6b, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                foreach (string text in WrapText(enc.EmisorNombreRazonSocial, f6, 290, e.Graphics, "NOMBRE/RAZON SOCIAL:"))
                {
                    e.Graphics.DrawString(text, f6, Brushes.Black, leftmargin, espacioLinea, left);
                    espacioLinea += 13;
                }
                e.Graphics.DrawString("SUCURSAL: " + enc.EmisorSucursal, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("NIT: " + enc.EmisorNIT, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("NRC: " + enc.EmisorNRC, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                foreach (string text in WrapText(enc.EmisorGiroActividadEconomica, f6, 290, e.Graphics, "GIRO O ACTIVIDAD:"))
                {
                    e.Graphics.DrawString(text, f6, Brushes.Black, leftmargin, espacioLinea, left);
                    espacioLinea += 13;
                }
                foreach (string text in WrapText(enc.EmisorDireccion, f6, 290, e.Graphics, "DIRECCIÓN:"))
                {
                    e.Graphics.DrawString(text, f6, Brushes.Black, leftmargin, espacioLinea, left);
                    espacioLinea += 13;
                }
                e.Graphics.DrawString("TELÉFONO: " + enc.EmisorTelefono, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("CORREO: " + enc.EmisorCorreo, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("FECHA EMISIÓN: " + enc.Fecha.ToString("dd-MM-yyyy"), f6b, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("COND. DE PAGO: " + enc.EmisorFormaPago , f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("IDTRANS: " + enc.IdTrans, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("BODEGA: " + enc.EmisorBodega, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("VENDEDOR: " + enc.EmisorVendedor, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                foreach (string text in WrapText(enc.EmisorNotas, f6, 290, e.Graphics, "NOTA(S):"))
                {
                    e.Graphics.DrawString(text, f6, Brushes.Black, leftmargin, espacioLinea, left);
                    espacioLinea += 13;
                }
                e.Graphics.DrawString(division, f8b, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 20;



                /*RECEPTOR*/
                e.Graphics.DrawString("RECEPTOR", fb11, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 16;
                foreach (string text in WrapText(enc.ReceptorNombre, f6, 290, e.Graphics, "NOMBRE:"))
                {
                    e.Graphics.DrawString(text, f6, Brushes.Black, leftmargin, espacioLinea, left);
                    espacioLinea += 13;
                }
                foreach (string text in WrapText(enc.ReceptorRazonSocial, f6, 290, e.Graphics, "RAZON SOCIAL:"))
                {
                    e.Graphics.DrawString(text, f6, Brushes.Black, leftmargin, espacioLinea, left);
                    espacioLinea += 13;
                }
                e.Graphics.DrawString("NIT: " + enc.ReceptorNIT, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("NRC: " + enc.ReceptorNRC, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                foreach (string text in WrapText(enc.ReceptorActividadEconomica, f6, 290, e.Graphics, "GIRO O ACTIVIDAD:"))
                {
                    e.Graphics.DrawString(text, f6, Brushes.Black, leftmargin, espacioLinea, left);
                    espacioLinea += 13;
                }
                e.Graphics.DrawString("DEPARTAMENTO: " + enc.Departamento, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("MUNICIPIO: " + enc.Municipio, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                //e.Graphics.DrawString("DIRECCIÓN: ", f6, Brushes.Black, leftmargin, espacioLinea, left);
                //espacioLinea += 13;
                foreach (string text in WrapText(enc.ReceptorDireccion, f6, 290, e.Graphics, "DIRECCIÓN:"))
                {
                    e.Graphics.DrawString(text, f6, Brushes.Black, leftmargin, espacioLinea, left);
                    espacioLinea += 13;
                }
                e.Graphics.DrawString("CORREO: " + enc.ReceptorCorreo, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("TELÉFONO: " + enc.ReceptorTelefono, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString(division, f8b, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 20;
                conteoLineas += 45;
            }

            impresoEnc = true;

            foreach (var item in det.Where(a=>a.impresa == false).ToList())
            {
                conteoLineas += 1;
                e.Graphics.DrawString(item.Codigo.Trim(), f6, Brushes.Black, leftmargin, espacioLinea, left);
                e.Graphics.DrawString(item.Descripcion, f6, Brushes.Black, 60, espacioLinea, left);
                espacioLinea += 13;

                e.Graphics.DrawString(item.Cantidad.ToString("N"), f6, Brushes.Black, leftmargin, espacioLinea, left);
                e.Graphics.DrawString(item.Unidad.Trim().ToUpper(), f6, Brushes.Black, 50, espacioLinea, left);
                e.Graphics.DrawString("X", f6, Brushes.Black, 80, espacioLinea, left);
                e.Graphics.DrawString("$", f6, Brushes.Black,100, espacioLinea, left);
                e.Graphics.DrawString(item.PrecioUnitario.ToString("N2"), f6, Brushes.Black, 110, espacioLinea, left);
                
                e.Graphics.DrawString("$", f6, Brushes.Black, 160, espacioLinea, left);
                e.Graphics.DrawString(item.Importe.ToString("N2"), f6, Brushes.Black, 240, espacioLinea, right);
                e.Graphics.DrawString(item.Tipo.ToString(), f6, Brushes.Black, 241, espacioLinea, left);
                item.impresa = true;

                if (conteoLineas < 50)
                {
                    e.HasMorePages = false;
                    espacioLinea += 13;
                }
                else
                {
                    conteoLineas = 0;
                    e.HasMorePages = true;
                    return;
                }

            }
            e.Graphics.DrawString(division, f8b, Brushes.Black, rightmargin, espacioLinea, right);
            espacioLinea += 10;
            e.Graphics.DrawString("Sub Total Exentos:", f6, Brushes.Black, 50, espacioLinea, left);
            e.Graphics.DrawString("$", f6, Brushes.Black, 160, espacioLinea, left);
            e.Graphics.DrawString(string.Format("{0}", Convert.ToString(Math.Round(Convert.ToDouble(enc.Exentas), 2).ToString("N2"))), f6, Brushes.Black, 240, espacioLinea, right);
            espacioLinea += 13;
            e.Graphics.DrawString("Sub Total Gravado:", f6, Brushes.Black, 50, espacioLinea, left);
            e.Graphics.DrawString("$", f6, Brushes.Black, 160, espacioLinea, left);
            e.Graphics.DrawString(string.Format("{0}", Convert.ToString(Math.Round(Convert.ToDouble(enc.Gravadas), 2).ToString("N2"))), f6, Brushes.Black, 240, espacioLinea, right);
            espacioLinea += 13;
            e.Graphics.DrawString("Descuento:", f6, Brushes.Black, 50, espacioLinea, left);
            e.Graphics.DrawString("$", f6, Brushes.Black, 160, espacioLinea, left);
            e.Graphics.DrawString(string.Format("{0}", Convert.ToString(Math.Round(Convert.ToDouble(enc.Descuento), 2).ToString("N2"))), f6, Brushes.Black, 240, espacioLinea, right);
            espacioLinea += 13;
            e.Graphics.DrawString("Total IVA:", f6, Brushes.Black, 50, espacioLinea, left);
            e.Graphics.DrawString("$", f6, Brushes.Black, 160, espacioLinea, left);
            e.Graphics.DrawString(string.Format("{0}", Convert.ToString(Math.Round(Convert.ToDouble(enc.IVA), 2).ToString("N2"))), f6, Brushes.Black, 240, espacioLinea, right);
            espacioLinea += 13;
            e.Graphics.DrawString("Retención:", f6, Brushes.Black, 50, espacioLinea, left);
            e.Graphics.DrawString("$", f6, Brushes.Black, 160, espacioLinea, left);
            e.Graphics.DrawString(string.Format("{0}", Convert.ToString(Math.Round(Convert.ToDouble(enc.Retencion), 2).ToString("N2"))), f6, Brushes.Black, 240, espacioLinea, right);
            espacioLinea += 13;
            e.Graphics.DrawString("Percepción:", f6, Brushes.Black, 50, espacioLinea, left);
            e.Graphics.DrawString("$", f6, Brushes.Black, 160, espacioLinea, left);
            e.Graphics.DrawString(string.Format("{0}", Convert.ToString(Math.Round(Convert.ToDouble(enc.Percepcion), 2).ToString("N2"))), f6, Brushes.Black, 240, espacioLinea, right);
            espacioLinea += 13;
            e.Graphics.DrawString("Ventas no Sujetas:", f6, Brushes.Black, 50, espacioLinea, left);
            e.Graphics.DrawString("$", f6, Brushes.Black, 160, espacioLinea, left);
            e.Graphics.DrawString(string.Format("{0}", Convert.ToString(Math.Round(Convert.ToDouble(enc.NoSujetas), 2).ToString("N2"))), f6, Brushes.Black, 240, espacioLinea, right);
            espacioLinea += 13;
            e.Graphics.DrawString("Total Venta:", f6, Brushes.Black, 50, espacioLinea, left);
            e.Graphics.DrawString("$", f6, Brushes.Black, 160, espacioLinea, left);
            e.Graphics.DrawString(string.Format("{0}", Convert.ToString(Math.Round(Convert.ToDouble(enc.Total), 2).ToString("N2"))), f6, Brushes.Black, 240, espacioLinea, right);
            espacioLinea += 13;
            e.Graphics.DrawString(division, f8b, Brushes.Black, leftmargin, espacioLinea, left);
            espacioLinea += 7;
            e.Graphics.DrawString("SON:", f6, Brushes.Black, centermargin, espacioLinea, center);
            espacioLinea += 15;
            e.Graphics.DrawString(enc.TotalLetras, f6, Brushes.Black, centermargin, espacioLinea, center);
            espacioLinea += 16;
            e.Graphics.DrawString("PESO NETO:", f6, Brushes.Black, 50, espacioLinea, left);
            e.Graphics.DrawString("KGS", f6, Brushes.Black, 170, espacioLinea, left);
            e.Graphics.DrawString(string.Format("{0}", Convert.ToString(Math.Round(Convert.ToDouble(enc.PesoNeto), 6).ToString("N6"))), f6, Brushes.Black, 240, espacioLinea, right);
            espacioLinea += 13;
            e.Graphics.DrawString("PESO BRUTO:", f6, Brushes.Black, 50, espacioLinea, left);
            e.Graphics.DrawString("KGS", f6, Brushes.Black, 170, espacioLinea, left);
            e.Graphics.DrawString(string.Format("{0}", Convert.ToString(Math.Round(Convert.ToDouble(enc.PesoBruto), 6).ToString("N6"))), f6, Brushes.Black, 240, espacioLinea, right);
            espacioLinea += 20;

            e.Graphics.DrawString("GRACIAS POR SU COMPRA", f6b, Brushes.Black, centermargin, espacioLinea, center);
            espacioLinea += 13;

            e.Graphics.DrawImage(qrCodeImage, x, espacioLinea + 10, 120, 120);
            
            conteoLineas += 20;


        }
    }
}
