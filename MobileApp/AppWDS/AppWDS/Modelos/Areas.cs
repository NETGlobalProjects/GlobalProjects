using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Modelos
{
    public class Areas
    {
        public int pai_id { get; set; }
        public int emp_id { get; set; }
        public int are_id { get; set; }
        public int cco_id { get; set; }
        public string are_descripcion { get; set; }
        public string ctc_id { get; set; }
        public bool are_activo { get; set; }
        public DateTime are_fecha_hora_creacion { get; set; }
        public int usu_id_crea { get; set; }
        public DateTime? are_fecha_hora_modificacion { get; set; }
        public int? usu_id_modifica { get; set; }
    }
}
