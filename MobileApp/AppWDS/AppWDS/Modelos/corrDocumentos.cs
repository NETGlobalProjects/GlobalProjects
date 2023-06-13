using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Modelos
{
    public class corrDocumentos
    {
        public int pai_id { get; set; }
        public int emp_id { get; set; }
        public string doc_serie { get; set; }
        public string doc_id { get; set; }
        public int doc_correlativo { get; set; }
        public string doc_estado { get; set; }
        public object usu_id_crea { get; set; }
        public object usu_id_modifica { get; set; }
        public DateTime doc_fecha_hora_creacion { get; set; }
        public DateTime doc_fecha_hora_modificacion { get; set; }
    }
}
