using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace FELSvPrint.Datos
{
    public class PrintTicketDev
    {
        private PrintDocument PD = new PrintDocument();
        private List<string> lineas;
        private int lineaActual;
        private int conteoLineas = 0;
        private int ticketHeight;
        int conteoLineasGeneral = 0;

        bool impresoEnc = false;

        Font printFont = new Font("Arial", 10);
        string font = "";
        int tamanioFont;
        string printerName;
        DatosFormatoTicketDevModel enc;
        List<DatosFormatoTicketDevDetModel> det;


        private PrintPreviewDialog PPD = new PrintPreviewDialog();
        private int longpapper;

        public PrintTicketDev( DatosFormatoTicketDevModel encabezado, List<DatosFormatoTicketDevDetModel> detalles)
        {
           

            PD.BeginPrint += PD_BeginPrint;
            PD.PrintPage += PD_PrintPage;


            enc = new DatosFormatoTicketDevModel();
            det = new List<DatosFormatoTicketDevDetModel>();
            enc = encabezado;
            det = detalles;

            lineas = new List<string>();
        }
        private void BeginPrint(object sender, PrintEventArgs e)
        {
            lineaActual = 0;
        }
        public void Print(string Fuente, int tamanioFuente, string impresora)
        {

            font = Fuente;
            tamanioFont = tamanioFuente;
            printerName = impresora;
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
            longpapper = (rowcount);
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
            //string font = "Courier New";
            string font2 = "Courier New";

            Font f6 = new Font(font, tamanioFont, FontStyle.Regular);
            Font f6b = new Font(font, tamanioFont, FontStyle.Bold);
            Font f10 = new Font(font, 7, FontStyle.Regular);
            Font f8b = new Font(font, 8, FontStyle.Regular);
            Font f11 = new Font(font, 8, FontStyle.Regular);
            Font fb11 = new Font(font, 9, FontStyle.Regular);
            Font f14 = new Font(font, 14, FontStyle.Regular);
            Font fb14 = new Font(font, 14, FontStyle.Regular);
            Font fb18 = new Font(font, 18, FontStyle.Regular);

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

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;

            if (impresoEnc == false)
            {

                espacioLinea += 6;
            
                e.Graphics.DrawString(enc.NombreEmpresa, f6, Brushes.Black, centermargin, espacioLinea, center);
                espacioLinea += 13;
                e.Graphics.DrawString("INGRESO A BODEGA", f6, Brushes.Black, centermargin, espacioLinea, center);
                espacioLinea += 13;
                e.Graphics.DrawString(division, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;

                e.Graphics.DrawString("INGRESO #", f6, Brushes.Black, centermargin, espacioLinea, center);
                espacioLinea += 13;
                e.Graphics.DrawString(enc.IngresoBodega.ToString(), f6, Brushes.Black, centermargin, espacioLinea, center);
                espacioLinea += 17;
                e.Graphics.DrawString("Fecha: " + enc.FechaCreacion.ToString("dd-MM-yyyy"), f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("Cod. Cliente: " + enc.ClienteNo, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                foreach (string text in WrapText(enc.NombreCliente, f6, 290, e.Graphics, "Cliente: "))
                {
                    e.Graphics.DrawString(text, f6, Brushes.Black, leftmargin, espacioLinea, left);
                    espacioLinea += 13;
                }
                foreach (string text in WrapText(enc.NombreMotorista, f6, 290, e.Graphics, "Motorista: "))
                {
                    e.Graphics.DrawString(text, f6, Brushes.Black, leftmargin, espacioLinea, left);
                    espacioLinea += 13;
                }
                e.Graphics.DrawString("Doc. Venta: " + enc.DocumentoVta, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("Tipo Dev.: " + enc.MotivoDevolucion, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("Motivo.: " + enc.MotivoDevolucion, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("Bodega: " + enc.DescripcionBodega, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("Consolidado: " + enc.NoConsolidado, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("Placa: " + enc.Placa, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("Despacho: " + enc.DespachoNo, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("Pedido: " + enc.PedidoNo, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString("Tipo: " + enc.TipoCuadro, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                conteoLineas += 20;
            }

            impresoEnc = true;

            e.Graphics.DrawString(division, f6, Brushes.Black, leftmargin, espacioLinea, left);
            espacioLinea += 20;


            e.Graphics.DrawString("SKU", f6, Brushes.Black, leftmargin, espacioLinea, left);
            e.Graphics.DrawString("CANT. ENVIADA", f6, Brushes.Black, 80, espacioLinea, left);
            e.Graphics.DrawString("CANT. RECIBIDA", f6, Brushes.Black, 190, espacioLinea, left);
            espacioLinea += 20;


            foreach (var item in det.Where(a => a.impresa == false).ToList())
            {
                conteoLineas += 1;
                e.Graphics.DrawString(item.Descripción, f6, Brushes.Black, leftmargin, espacioLinea, left);
                espacioLinea += 13;
                e.Graphics.DrawString(item.ITE_ID.Trim(), f6, Brushes.Black, leftmargin, espacioLinea, left);
               
                e.Graphics.DrawString(item.QTY_PRE.ToString(), f6, Brushes.Black, 130, espacioLinea, left);
              
                e.Graphics.DrawString(item.QTY_DEV.ToString(), f6, Brushes.Black, 240, espacioLinea, left);
                
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


            espacioLinea += 25;
            e.Graphics.DrawString(division, f6, Brushes.Black, leftmargin, espacioLinea, left);
            espacioLinea += 15;
            e.Graphics.DrawString("Autorizado por: ", f6, Brushes.Black, leftmargin, espacioLinea, left);
            espacioLinea += 40;


            e.Graphics.DrawString(division, f6, Brushes.Black, leftmargin, espacioLinea, left);
            espacioLinea += 15;
            e.Graphics.DrawString("Entregado por: ", f6, Brushes.Black, leftmargin, espacioLinea, left);
            espacioLinea += 40;

            conteoLineas += 20;


        }
    }
}
