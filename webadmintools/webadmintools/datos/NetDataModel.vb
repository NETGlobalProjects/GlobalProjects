Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class NetDataModel
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=NetDataEntities")
    End Sub
    Public Overridable Property Dealer As DbSet(Of Dealer)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.CodPais) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.Nombre) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.DirectorioDato) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.Representante) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.Contador) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.Auditor) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.GerenteGeneral) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.SubGerente) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.JefeOperacion) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.Pagador) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.Ciudad) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.Direccion) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.Lema) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.Moneda) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.NRC) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.Prefijo) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.Logo) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.TipoContribuyente) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.NombreCorto) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.NIT) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.Giro) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.NombreSociedad) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.CortoSociedad) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.TipoDoc) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.AfiliacionIVA) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.CodActEcon) _
            .IsFixedLength() _
            .IsUnicode(False)

        modelBuilder.Entity(Of Dealer)() _
            .Property(Function(e) e.ambiente) _
            .IsFixedLength() _
            .IsUnicode(False)
    End Sub
End Class
