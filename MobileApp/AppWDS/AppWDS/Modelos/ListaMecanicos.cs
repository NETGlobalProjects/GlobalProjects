using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Modelos
{
    public class ListaMecanicos
    {
        public int mec_id { get; set; }
        public string mec_nombre { get; set; }
        public string usu_nomina_fotografia { get; set; }
        public string mec_estado { get; set; }
        public string mec_estado_color { get; set; }
        public string ordenes_asignadas { get; set; }
    }
}
