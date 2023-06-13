using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AppWDS.Modelos
{
    public class autorizacionPrecios
    {
        [JsonProperty("$id")]
        public string Id { get; set; }
        public int Cot_id { get; set; }
        public string Usu_nomina_fotografia { get; set; }
        public string Cliente { get; set; }
        public int No_productos { get; set; }
        public DateTime Fecha_cotizacion { get; set; }
        public string Usu_id_crea { get; set; }
        public string Cot_tipo_doc { get; set; }
        public int Doc_decimales { get; set; }
    }

}
