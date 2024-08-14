using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSelloMH.Datos
{
    public class CuerpoDocumento
    {
        public string descripcion { get; set; }
        public double montoDescu { get; set; }
        public string codigo { get; set; }
        public double ventaGravada { get; set; }
        public double ivaItem { get; set; }
        public double ventaNoSuj { get; set; }
        public double ventaExenta { get; set; }
        public object tributos { get; set; }
        public int numItem { get; set; }
        public double noGravado { get; set; }
        public int psv { get; set; }
        public int tipoItem { get; set; }
        public object codTributo { get; set; }
        public int uniMedida { get; set; }
        public object numeroDocumento { get; set; }
        public double cantidad { get; set; }
        public double precioUni { get; set; }
    }

    public class Direccion
    {
        public string complemento { get; set; }
        public string municipio { get; set; }
        public string departamento { get; set; }
    }

    public class Documento
    {
        public Extension extension { get; set; }
        public Receptor receptor { get; set; }
        public Identificacion identificacion { get; set; }
        public Resumen resumen { get; set; }
        public List<CuerpoDocumento> cuerpoDocumento { get; set; }
        public object otrosDocumentos { get; set; }
        public object ventaTercero { get; set; }
        public object apendice { get; set; }
        public object documentoRelacionado { get; set; }
        public Emisor emisor { get; set; }
    }

    public class Emisor
    {
        public string descActividad { get; set; }
        public string tipoEstablecimiento { get; set; }
        public Direccion direccion { get; set; }
        public string codEstable { get; set; }
        public string codPuntoVenta { get; set; }
        public string nombre { get; set; }
        public string codActividad { get; set; }
        public string codEstableMH { get; set; }
        public string correo { get; set; }
        public string nit { get; set; }
        public string nombreComercial { get; set; }
        public string telefono { get; set; }
        public string nrc { get; set; }
        public string codPuntoVentaMH { get; set; }
    }

    public class Extension
    {
        public object docuEntrega { get; set; }
        public object placaVehiculo { get; set; }
        public object observaciones { get; set; }
        public object nombRecibe { get; set; }
        public object nombEntrega { get; set; }
        public object docuRecibe { get; set; }
    }

    public class Identificacion
    {
        public string codigoGeneracion { get; set; }
        public object tipoContingencia { get; set; }
        public string numeroControl { get; set; }
        public int tipoOperacion { get; set; }
        public string ambiente { get; set; }
        public string fecEmi { get; set; }
        public int tipoModelo { get; set; }
        public string tipoDte { get; set; }
        public int version { get; set; }
        public string tipoMoneda { get; set; }
        public object motivoContin { get; set; }
        public string horEmi { get; set; }
    }

    public class Receptor
    {
        public object descActividad { get; set; }
        public object tipoDocumento { get; set; }
        public object numDocumento { get; set; }
        public object codActividad { get; set; }
        public object correo { get; set; }
        public object direccion { get; set; }
        public object telefono { get; set; }
        public string nombre { get; set; }
        public object nrc { get; set; }
    }

    public class Resumen
    {
        public double totalNoSuj { get; set; }
        public double descuNoSuj { get; set; }
        public double totalIva { get; set; }
        public string totalLetras { get; set; }
        public double ivaRete1 { get; set; }
        public double subTotalVentas { get; set; }
        public double subTotal { get; set; }
        public double reteRenta { get; set; }
        public object tributos { get; set; }
        public object pagos { get; set; }
        public double descuExenta { get; set; }
        public double totalDescu { get; set; }
        public object numPagoElectronico { get; set; }
        public double descuGravada { get; set; }
        public double porcentajeDescuento { get; set; }
        public double totalGravada { get; set; }
        public double montoTotalOperacion { get; set; }
        public double totalNoGravado { get; set; }
        public double saldoFavor { get; set; }
        public double totalExenta { get; set; }
        public double totalPagar { get; set; }
        public int condicionOperacion { get; set; }
    }

    public class responseConsultaDTE
    {
        public string estadoDoc { get; set; }
        public string estadoDocInc { get; set; }
        public bool reporteInc { get; set; }
        public object descripcionEstado { get; set; }
        public string fechaEmi { get; set; }
        public string horaEmi { get; set; }
        public string fechaProcesado { get; set; }
        public string codGen { get; set; }
        public string selloVal { get; set; }
        public object numeIdenRecep { get; set; }
        public string action { get; set; }
        public string tipoDte { get; set; }
        public string nombDte { get; set; }
        public object ajustes { get; set; }
        public object reportDte { get; set; }
        public object observaciones { get; set; }
        public Documento documento { get; set; }
        public object invalidacion { get; set; }
    }
}
