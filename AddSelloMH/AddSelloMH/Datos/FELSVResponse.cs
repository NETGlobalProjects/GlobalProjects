using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSelloMH.Datos
{
    [Table("FELSVResponse")]
    public class FELSVResponse
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string CodPais { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dealer { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(7)]
        public string Tda { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string TipoDoc { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string Serie { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DocNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroControl { get; set; }

        [Required]
        [StringLength(36)]
        public string CodigoGeneracion { get; set; }

      
        [StringLength(50)]
        public string SelloRecibido { get; set; }

      
        [StringLength(36)]
        public string CodigoGeneracionA { get; set; }

       
        [StringLength(50)]
        public string SelloRecibidoA { get; set; }

        public bool? conRespuesta { get; set; }
        public string JsonRespuesta { get; set; }
        public DateTime? FechaCreacion { get; set; }


    }
}
