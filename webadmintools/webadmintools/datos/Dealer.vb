Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Dealer")>
Partial Public Class Dealer
    <Key>
    <Column(Order:=0)>
    <StringLength(3)>
    Public Property CodPais As String

    <Key>
    <Column(Order:=1)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Codigo As Integer

    <Required>
    <StringLength(60)>
    Public Property Nombre As String

    <Required>
    <StringLength(75)>
    Public Property DirectorioDato As String

    <Required>
    <StringLength(50)>
    Public Property Representante As String

    <Required>
    <StringLength(50)>
    Public Property Contador As String

    <Required>
    <StringLength(50)>
    Public Property Auditor As String

    <Required>
    <StringLength(50)>
    Public Property GerenteGeneral As String

    <Required>
    <StringLength(50)>
    Public Property SubGerente As String

    <Required>
    <StringLength(50)>
    Public Property JefeOperacion As String

    <Required>
    <StringLength(50)>
    Public Property Pagador As String

    <Required>
    <StringLength(50)>
    Public Property Ciudad As String

    <Required>
    <StringLength(125)>
    Public Property Direccion As String

    <Required>
    <StringLength(200)>
    Public Property Lema As String

    <Required>
    <StringLength(25)>
    Public Property Moneda As String

    <Required>
    <StringLength(8)>
    Public Property NRC As String

    <Required>
    <StringLength(2)>
    Public Property Prefijo As String

    <StringLength(250)>
    Public Property Logo As String

    <Required>
    <StringLength(15)>
    Public Property TipoContribuyente As String

    <StringLength(20)>
    Public Property NombreCorto As String

    <StringLength(20)>
    Public Property NIT As String

    <StringLength(50)>
    Public Property Giro As String

    Public Property ManejaLote As Boolean?

    <StringLength(150)>
    Public Property NombreSociedad As String

    <StringLength(50)>
    Public Property CortoSociedad As String

    Public Property GenerarPartida As Boolean?

    Public Property GenerarPosteo As Boolean?

    Public Property GrupoCliente As Integer

    <Required>
    <StringLength(2)>
    Public Property TipoDoc As String

    <Required>
    <StringLength(10)>
    Public Property AfiliacionIVA As String

    Public Property Certificador As Short

    Public Property Departamento As Short

    Public Property Municipio As Short

    <Required>
    <StringLength(8)>
    Public Property Telefono As String

    <Required>
    <StringLength(100)>
    Public Property Email As String

    <Required>
    <StringLength(5)>
    Public Property CodActEcon As String

    <Required>
    <StringLength(10)>
    Public Property TipoDocAut As String

    <Required>
    <StringLength(30)>
    Public Property NoDocAut As String

    <Required>
    <StringLength(100)>
    Public Property NombreAut As String

    <Required>
    <StringLength(2)>
    Public Property ambiente As String

    Public Property FEL As Boolean

    <Required>
    <StringLength(10)>
    Public Property TipoDocSol As String

    <Required>
    <StringLength(30)>
    Public Property NoDocSol As String

    <Required>
    <StringLength(100)>
    Public Property NombreSol As String
End Class
