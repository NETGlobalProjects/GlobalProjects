using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Modelos
{
    public class OrdenManttoItems
    {
        public int pai_id { get; set; }
        public int emp_id { get; set; }
        public int ord_id { get; set; }
        public int dor_id { get; set; }
        public string inv_id { get; set; }
        public string dor_descripcion { get; set; }
        public double? dor_cantidad { get; set; }
        public double? dor_unitario { get; set; }
        public double? dor_costo { get; set; }
        public double? dor_importe { get; set; }
        public int? usu_id_crea { get; set; }
        public int? usu_id_modifica { get; set; }
        public DateTime? dor_fecha_hora_creacion { get; set; }
        public DateTime? dor_fecha_hora_modificacion { get; set; }
        public string dor_tipo { get; set; }
        public int? reg_id { get; set; }
        public int? dor_estado { get; set; }
        public string dor_descripcion_larga { get; set; }
    }
}
