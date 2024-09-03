using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELSvPrint.Datos
{
    [Table("ConfigPBS")]
    public class ConfigPBS
    {
        [Key]
        public string Impresora { get; set; }
    }
}
