using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Modelos
{
    public class OrdenManttoMecanicos
    {
        public int pai_id { get; set; }
        public int emp_id { get; set; }
        public int ord_id { get; set; }
        public int mod_id { get; set; }
        public int mec_id { get; set; }
        public string mec_nombre { get; set; }
        public string mec_telefono { get; set; }
        public string usu_nomina_fotografia { get; set; }
    }
}
