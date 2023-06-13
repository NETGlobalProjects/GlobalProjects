using System;
using System.Collections.Generic;
using System.Text;

namespace AppWDS.Modelos
{
   public  class Maquinas
    {
        public string maq_codigo_nombre { get; set; }
        public int pai_id { get; set; }
        public int emp_id { get; set; }
        public string maq_id { get; set; }
        public string maq_nombre { get; set; }
        public string maq_descripcion { get; set; }
        public string maq_no_serie { get; set; }
        public string maq_capacidad { get; set; }
        public object maq_fecha_ingreso { get; set; }
        public object maq_potencia { get; set; }
        public object mar_id { get; set; }
        public string maq_modelo { get; set; }
        public object cco_id { get; set; }
        public object maq_fecha_fabricacion { get; set; }
        public string maq_dimensiones { get; set; }
        public string maq_cap_diseno { get; set; }
        public string ctc_id { get; set; }
        public string maq_activo_fijo { get; set; }
        public object maq_peso_neto { get; set; }
        public object maq_fecha_instalacion { get; set; }
        public int are_id { get; set; }
        public int sba_id { get; set; }
        public object prv_id { get; set; }
        public object uni_id { get; set; }
        public string maq_estado { get; set; }
    }
}
