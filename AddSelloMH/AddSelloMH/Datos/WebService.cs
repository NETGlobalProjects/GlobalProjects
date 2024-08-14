using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSelloMH.Datos
{
    [Table("WebService")]
    public class WebService
    {
        [Key]
        [Column(Order =0)]
        public string CodPais { get; set; }
        [Key]
        [Column(Order = 1)]
        public int Dealer { get; set; }
        [Key]
        [Column(Order = 2)]
        public int No { get; set; }
        public string Nombre { get; set; }
        public string URL { get; set; }
        public string Metodo { get; set; }
        public string ContentType { get; set; }
        public int Timeout { get; set; }
        public bool Activo { get; set; }
    }
}
