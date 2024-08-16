Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class xRptFicha
    Private Function CreateReport() As XtraReport
        Dim report1 As New xRptFicha()
        AddHandler report1.AfterPrint, AddressOf Report1_AfterPrint
        Return report1
    End Function

    Private Sub Report1_AfterPrint(ByVal sender As Object, ByVal e As EventArgs)
        Dim report2 As New xRptFichaPolitica()
        report2.CreateDocument()

        Dim report1 As XtraReport = DirectCast(sender, XtraReport)
        report1.ModifyDocument(Sub(x)
                                   x.AddPages(report2.Pages)
                               End Sub)
    End Sub
    Private Sub lineaXrTable1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles lineaXrTable1.BeforePrint
        Dim tabla As XRTable = CType(sender, XRTable)
        Dim tipo_mov As String = Trim(Convert.ToString(GetCurrentColumnValue("tipo_movimiento")))
        If tipo_mov = "Linea" Then
            tabla.Visible = True
        Else
            tabla.Visible = False
        End If

    End Sub

    Private Sub telefonoXrTable2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles telefonoXrTable2.BeforePrint
        Dim tabla As XRTable = CType(sender, XRTable)
        Dim tipo_mov As String = Trim(Convert.ToString(GetCurrentColumnValue("tipo_movimiento")))
        If tipo_mov = "Teléfono" Then
            tabla.Visible = True
        Else
            tabla.Visible = False
        End If
    End Sub
    Private Sub equiposXrTable2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles equipoXrTable2.BeforePrint
        Dim tabla As XRTable = CType(sender, XRTable)
        Dim tipo_mov As String = Trim(Convert.ToString(GetCurrentColumnValue("tipo_movimiento")))
        If tipo_mov = "Equipos varios" Then
            tabla.Visible = True
        Else
            tabla.Visible = False
        End If
    End Sub

    Private Sub acuerdoXrTable2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles acuerdoXrTable2.BeforePrint
        Dim tabla As XRTable = CType(sender, XRTable)
        Dim tipo_mov As String = Trim(Convert.ToString(GetCurrentColumnValue("mostrar_enunciado")))
        If tipo_mov = "S" Then
            tabla.Visible = True
        Else
            tabla.Visible = False
        End If
    End Sub
End Class