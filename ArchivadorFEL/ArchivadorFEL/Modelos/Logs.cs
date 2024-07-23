using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivadorFEL.Modelos
{
    public class Logs
    {
        public string Tipo { get; set; }
        public string Mensaje { get; set; }
        public string archivo { get; set; }
        public string nombreCortoEmpresa { get; set; }
        public string Sucursal { get; set; }
        public string TipoDoc { get; set; }
        public string Serie { get; set; }
        public int DocNo { get; set; }
        public DateTime Fecha { get; set; }
        public string formatoArchivo { get; set; }
    }
}
