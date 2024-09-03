using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELSvPrint.Datos
{
    public class DatosFormatoTicketDevModel
    {
        public int Dealer { get; set; }
        public string NoConsolidado { get; set; }
        public string Bodega { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int PedidoNo { get; set; }
        public string DocumentoVta { get; set; }
        public string ClienteNo { get; set; }
        public string DescripcionBodega { get; set; }
        public string NombreCliente { get; set; }
        public string NombreMotorista { get; set; }
        public string MotivoDevolucion { get; set; }
        public string Placa { get; set; }
        public int? DespachoNo { get; set; }
        public string TipoCuadro { get; set; }
        public string Justificacion { get; set; }
        public string NombreEmpresa { get; set; }
        public decimal TotalINC { get; set; }
        public decimal SaldoDocVta { get; set; }
        public int? NoProductos { get; set; }
        public int? IngresoBodega { get; set; }
    }
}
