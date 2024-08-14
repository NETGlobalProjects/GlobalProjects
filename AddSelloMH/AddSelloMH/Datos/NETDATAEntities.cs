using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AddSelloMH.Datos
{
    public partial class NETDATAEntities : DbContext
    {
        public NETDATAEntities()
            : base( Conexion.instancia.getCnString() + ";MultipleActiveResultSets=True; App=EntityFramework;")
        {
        }

        public virtual DbSet<FELSV> FELSV { get; set; }
        public virtual DbSet<vFELSV> vFELSV { get; set; }
        public virtual DbSet<WSRequest> WSRequest { get; set; }
        public virtual DbSet<WebService> WebService { get; set; }
        public virtual DbSet<FELSVResponse> FELSVResponse { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FELSV>()
                .Property(e => e.CodPais)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FELSV>()
                .Property(e => e.Tda)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FELSV>()
                .Property(e => e.TipoDoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FELSV>()
                .Property(e => e.Serie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FELSV>()
                .Property(e => e.NumeroControl)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FELSV>()
                .Property(e => e.CodigoGeneracion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FELSV>()
                .Property(e => e.SelloRecibido)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FELSV>()
                .Property(e => e.CodigoGeneracionA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FELSV>()
                .Property(e => e.SelloRecibidoA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FELSV>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<FELSV>()
                .Property(e => e.Consolidado)
                .IsUnicode(false);

            modelBuilder.Entity<FELSV>()
                .Property(e => e.Vendedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FELSV>()
                .Property(e => e.Placa)
                .IsUnicode(false);

            modelBuilder.Entity<FELSV>()
                .Property(e => e.ObservacionesA)
                .IsUnicode(false);
        }
    }
}
