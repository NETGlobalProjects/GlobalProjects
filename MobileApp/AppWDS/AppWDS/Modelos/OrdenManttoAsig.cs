using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Modelos
{
    public class OrdenManttoAsig
    {
        public int pai_id { get; set; }
        public int emp_id { get; set; }
        public int ord_id { get; set; }
        public DateTime? ord_fecha_hora_creacion { get; set; }
        public string oes_descripcion { get; set; }
        public int mec_id { get; set; }
        public string mec_nombres { get; set; }
        public int? usu_id_crea { get; set; }
        public string usu_nombres { get; set; }
        public string usu_nomina_fotografia { get; set; }
        public int? usu_id_mec { get; set; }
        public string ord_descripcion { get; set; }
        public string estado_color { get; set; }
        public string detalle { get; set; }
        public string are_descripcion { get; set; }
        public string sba_descripcion { get; set; }
        public string maq_descripcion { get; set; }
        public string maq_nombre { get; set; }
        public string maq_id { get; set; }
        public int no_materiales { get; set; }
        public int no_mecanicos { get; set; }
        public string tio_descripcion { get; set; }
        public string pri_descripcion { get; set; }
        public string color_prioridad { get; set; }
        public double? avance { get; set; }
        public string ord_comentarios_mecanico { get; set; }
        

    }
}
