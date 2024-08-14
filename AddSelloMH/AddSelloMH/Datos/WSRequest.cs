using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSelloMH.Datos
{
    [Table("WSRequest")]
    public  class WSRequest
    {
        [Key]
        [Column(Order=0)]
        public string CodPais { get; set; }
        [Key]
        [Column(Order = 1)]
        public int Dealer { get; set; }
        [Key]
        [Column(Order = 2)]
        public int No { get; set; }
        [Key]
        [Column(Order = 3)]
        public string Propiedad { get; set; }
        public string Valor { get; set; }
        public bool Modificable { get; set; }
        public int Orden {get; set; }
    }
}
