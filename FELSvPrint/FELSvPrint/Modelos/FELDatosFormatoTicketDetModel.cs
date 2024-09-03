using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELSvPrint.Modelos
{
    public class FELDatosFormatoTicketDetModel
    {
        public string CodPais { get; set; }
        public int Dealer { get; set; }
        public string Tda { get; set; }
        public string TipoDoc { get; set; }
        public string Serie { get; set; }
        public int DocNo { get; set; }
        public string Tipo { get; set; }
        public string Codigo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Importe { get; set; }
        public string Descripcion { get; set; }
        public string Unidad { get; set; }
        public bool? impresa { get; set; }
    }
}
