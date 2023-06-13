using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Modelos
{
   public class PushNotificaciones
    {
        public int pus_id { get; set; }
        public int pai_id { get; set; }
        public int emp_id { get; set; }
        public int ord_id { get; set; }
        public int usu_id { get; set; }
        public bool pus_read { get; set; }
        public DateTime? pus_fecha { get; set; }
        public string pus_title { get; set; }
        public string pus_descripcion { get; set; }
    }
}
