using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FELSvPrint.Datos
{
    public partial class NetDataEntitie : DbContext
    {
        public NetDataEntitie()
            : base("name=NetDataEntity")
        {
        }

        public virtual DbSet<FELPDFs> FELPDFs { get; set; }
        public virtual DbSet<ConfigPBS> ConfigPBS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FELPDFs>()
                .Property(e => e.Usuario)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
