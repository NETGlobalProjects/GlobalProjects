using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Views
{
   public class OrdenManttoAll
    {
        public int pai_id { get; set; }
        public int emp_id { get; set; }
        public int ord_id { get; set; }
        public string tio_descripcion { get; set; }
        public int pla_id { get; set; }
        public string pla_descripcion { get; set; }
        public int usu_id_crea { get; set; }
        public DateTime? ord_fecha_hora_creacion { get; set; }
        public int are_id { get; set; }
        public string are_descripcion { get; set; }
        public int sba_id { get; set; }
        public string sba_descripcion { get; set; }
        public string maq_id { get; set; }
        public string maq_nombre { get; set; }
        public int pri_id { get; set; }
        public string pri_descripcion { get; set; }
        public string color_prioridad { get; set; }
        public double avance { get; set; }
        public string estado_color { get; set; }
        public int oes_id { get; set; }
        public string oes_descripcion { get; set; }
        public string ord_descripcion { get; set; }
        public int mecanicos_asignados { get; set; }
        public string usu_nomina_fotografia { get; set; }
        public string ord_descripcion_2 { get; set; }
        public string detalle { get; set; }
    }
}
