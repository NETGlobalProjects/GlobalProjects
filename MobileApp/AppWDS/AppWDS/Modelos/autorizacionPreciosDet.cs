using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AppWDS.Modelos
{
   public class autorizacionPreciosDet
    {
        [JsonProperty("$id")]
        public string Id { get; set; }
        public double Cot_precio_sugerido { get; set; }
        public int Cot_id { get; set; }
        public string Cliente { get; set; }
        public int Cot_correlativo { get; set; }
        public string Inv_id { get; set; }
        public string Cot_descripcion { get; set; }
        public double Cot_cantidad { get; set; }
        public double Cot_peso { get; set; }
        public double Cot_margen { get; set; }
        public double Cot_preciociva { get; set; }
        public double Cot_preciosiva { get; set; }
    }
}
