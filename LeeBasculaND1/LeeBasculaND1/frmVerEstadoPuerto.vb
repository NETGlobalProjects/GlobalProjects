Public Class frmVerEstadoPuerto

    Private Sub frmVerEstadoPuerto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        validarestado()
    End Sub
    Sub validarestado()
        Me.estadoPuertoLabel2.Text = fmLeerBascula.GetEstadoPuerto
        If estadoPuertoLabel2.Text = "ABIERTO" Then
            Me.Button1.Enabled = True
        Else
            Me.Button1.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        fmLeerBascula.CerrarPuerto()
        validarestado()
    End Sub
End Class