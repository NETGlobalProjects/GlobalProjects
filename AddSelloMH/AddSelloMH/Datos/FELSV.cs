namespace AddSelloMH.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FELSV")]
    public partial class FELSV
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

        [Required]
        [StringLength(50)]
        public string SelloRecibido { get; set; }

        [Required]
        [StringLength(36)]
        public string CodigoGeneracionA { get; set; }

        [Required]
        [StringLength(50)]
        public string SelloRecibidoA { get; set; }

        public bool Anulado { get; set; }

        public bool Enviado { get; set; }

        public bool Seleccionar { get; set; }

        [Required]
        [StringLength(500)]
        public string Observaciones { get; set; }

        [Required]
        [StringLength(10)]
        public string Consolidado { get; set; }

        [Required]
        [StringLength(7)]
        public string Vendedor { get; set; }

        [Required]
        [StringLength(10)]
        public string Placa { get; set; }

        public bool Cola { get; set; }

        public bool Impreso { get; set; }

        [Required]
        [StringLength(500)]
        public string ObservacionesA { get; set; }

        public short EmailError { get; set; }

        public DateTime FechaNatural { get; set; }
       
    }
}
