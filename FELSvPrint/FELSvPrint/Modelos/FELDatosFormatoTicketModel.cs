using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELSvPrint.Modelos
{
    public class FELDatosFormatoTicketModel
    {
        public string CodPais { get; set; }
        public int Dealer { get; set; }
        public string Tda { get; set; }
        public string TipoDoc { get; set; }
        public string Serie { get; set; }
        public int DocNo { get; set; }
        public string CodigoGeneracion { get; set; }
        public string NumeroControl { get; set; }
        public string SelloRecibido { get; set; }
        public string Documento { get; set; }
        public string Cajero { get; set; }
        public string CodigoQR { get; set; }
        public string NombreTipoDoc { get; set; }
        public DateTime Fecha { get; set; }
        public string IdTrans { get; set; }
        public string EmisorNombreRazonSocial { get; set; }
        public string EmisorSucursal { get; set; }
        public string EmisorNIT { get; set; }
        public string EmisorNRC { get; set; }
        public string EmisorGiroActividadEconomica { get; set; }
        public string EmisorDireccion { get; set; }
        public string EmisorTelefono { get; set; }
        public string EmisorCorreo { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string EmisorVendedor { get; set; }
        public string EmisorBodega { get; set; }
        public string EmisorNotas { get; set; }
        public string EmisorFormaPago { get; set; }
        public string EmisorPedidoVta { get; set; }
        public string ReceptorNombre { get; set; }
        public string ReceptorRazonSocial { get; set; }
        public string ReceptorNIT { get; set; }
        public string ReceptorDUI { get; set; }
        public string ReceptorNRC { get; set; }
        public string ReceptorActividadEconomica { get; set; }
        public string ReceptorDireccion { get; set; }
        public string ReceptorTelefono { get; set; }
        public string ReceptorCorreo { get; set; }
        public string Placa { get; set; }
        public string Consolidado { get; set; }
        public int Orden { get; set; }
        public decimal Gravadas { get; set; }
        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Descuento { get; set; }
        public decimal Retencion { get; set; }
        public decimal Percepcion { get; set; }
        public decimal Total { get; set; }
        public decimal NoSujetas { get; set; }
        public decimal Exentas { get; set; }
        public string TotalLetras { get; set; }
        public decimal? PesoNeto { get; set; }
        public decimal? PesoBruto { get; set; }
        public string OrdenCompra { get; set; }
    }
}
