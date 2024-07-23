using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivadorFEL.Modelos
{
    public class datosFELArchivadorModel
    {
        public string CodPais { get; set; }
        public int  Dealer { get; set; }
        public string  nombreCortoEmpresa { get; set; }
        public string  Surursal { get; set; }
        public int Anio { get; set; }
        public string Mes { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoGeneracion { get; set; }
        public string TipoDoc { get; set; }
        public string Tipo { get; set; }
        public string dia { get; set; }
        public string completoRutaDestino { get; set; }
        public string Serie { get; set; }
        public int DocNo { get; set; }
    }
}
