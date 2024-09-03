namespace FELSvPrint.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FELPDFs
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Archivo { get; set; }

        [Required]
        [StringLength(500)]
        public string Ubicacion { get; set; }

        
        [StringLength(10)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Impresora { get; set; }

        public DateTime FechaImpresion { get; set; }

        [Required]
        [StringLength(250)]
        public string Resultado { get; set; }
    }
}
