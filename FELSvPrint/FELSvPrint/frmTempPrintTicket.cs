using FELSvPrint.Datos;
using PrintQRCode;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace FELSvPrint
{
    public partial class frmTempPrintTicket : Form
    {
        public frmTempPrintTicket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filtado = "I";
                string codigoGen = "11C8E818-EA43-42F6-97E8-6EA969ECCBEE";
                string consolidado = this.textBox1.Text;
                DateTime fecha = Convert.ToDateTime("13/07/2024");

                var encabezados = FELDatosFormatoTicket.instancia.getFELDatosFormatoTicket(filtado, null, consolidado, fecha, codigoGen);
                foreach (var i in encabezados.Take(1))
                {
                    string textToEncode = i.CodigoQR;

                    QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
                    Bitmap qrCodeImage = qrCodeGenerator.GenerateQRCode(textToEncode);
                    var det = FELDatosFormatoTicket.instancia.getFELDatosFormatoTicketDet(i.CodPais, i.Dealer, i.Tda, i.TipoDoc, i.Serie, i.DocNo);
                    PrintTicket ticket = new PrintTicket(qrCodeImage, i, det);
                    ticket.Print(this.fuentecomboBox1.Text, (int)this.fuentenumericUpDown1.Value, this.impresorascomboBox1.Text, "T");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException, "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string printerName = this.impresorascomboBox1.Text;
            //string textToPrint = "Este es un texto que se imprimirá con la fuente por defecto de la impresora.";

            //// Comandos de control de la impresora Epson (opcional)
            //string initializePrinter = "\x1B\x40"; // Comando ESC @ para inicializar la impresora
            //string selectFontA = "\x1B\x4D"; // Comando ESC M para seleccionar la fuente A
            //string cutPaper = "\x1D\x56\x00";

            //// Enviar comandos y texto a la impresora
            //RawPrinterHelper.SendStringToPrinter(printerName, initializePrinter + selectFontA + textToPrint + cutPaper);


            try
            {

                string consolidado = this.textBox2.Text;

                var encabezados = FELDatosFormatoTicket.instancia.getDatosFormatoTicketDev(consolidado, null);
                foreach (var i in encabezados.Take(1))
                {
                    var det = FELDatosFormatoTicket.instancia.getDatosFormatoTicketDevDet(consolidado, i.PedidoNo.ToString());
                    PrintTicketDev ticket = new PrintTicketDev(i, det);
                    ticket.Print(this.fuentecomboBox1.Text, (int)this.fuentenumericUpDown1.Value, this.impresorascomboBox1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException, "Error al imprimir Dev.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTempPrintTicket_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                // Añade el nombre de la fuente al ComboBox
                fuentecomboBox1.Items.Add(font.Name);
            }
            LoadPrinters();
        }
        private void LoadPrinters()
        {
            // Obtén la lista de impresoras instaladas
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                // Agrega cada impresora al ComboBox
                impresorascomboBox1.Items.Add(printer);
            }

            // Selecciona la primera impresora si hay alguna en la lista
            if (impresorascomboBox1.Items.Count > 0)
            {
                impresorascomboBox1.SelectedIndex = 0;
            }
        }
    }
}
