using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELSvPrint.Datos
{
    public class DatosFormatoTicketDevDetModel
    {
        public string CIA_ID { get; set; }
        public string CONSOLIDADO_NO { get; set; }
        public string CONTROL_NO { get; set; }
        public string ITE_ID { get; set; }
        public string Descripción { get; set; }
        public decimal QTY_PRE { get; set; }
        public decimal QTY_DEV { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Importe { get; set; }
        public string ERPKEY { get; set; }
        public string CodPais { get; set; }
        public int Dealer { get; set; }
        public string Tda { get; set; }
        public string TipoDoc { get; set; }
        public string Serie { get; set; }
        public int DocNo { get; set; }
        public decimal Descuento { get; set; }
        public decimal Exentas { get; set; }
        public bool impresa { get; set; }
    }
}
