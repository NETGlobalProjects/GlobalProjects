Imports DevComponents.DotNetBar
Public Class Login
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim Correcto As Boolean = False
    Public con As New SqlClient.SqlConnection(My.MySettings.Default.oConSQL.ToString)
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        End
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Try
            Correcto = False
            Dim user As String = ""
            Dim cmd2 As SqlClient.SqlCommand
            Dim leer2 As SqlClient.SqlDataReader
            cmd2 = New SqlClient.SqlCommand("select tb.Usuario,contraseña , Nombre from tbSeguridad tb", con)
            con.Open()
            leer2 = cmd2.ExecuteReader
            While leer2.Read
                If Me.txtUsuario.Text = RTrim(leer2(0).ToString) And Me.txtContraseña.Text = RTrim(leer2(1).ToString) Then
                    Correcto = True
                    UsuarioActual = leer2(2).ToString
                    user = RTrim(leer2(0))
                End If
            End While
            con.Close()
            If Correcto = True Then

                Try
                    oUser = user

                    TecnicoLogueado = "Administrador"

                Catch ex As Exception
                End Try

                With frmMenuModuloInventarioTelefonos
                    .WindowState = FormWindowState.Normal
                    .StartPosition = FormStartPosition.CenterScreen

                    .Show()
                    Me.Hide()
                End With
            Else
                MessageBoxEx.Show("Usuario ó Contraseña incorrecta", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Me.txtContraseña.Focus()
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Version2.Text = "Versión: " & My.Application.Info.Version.ToString
    End Sub

    Private Sub txtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonX2_Click(sender, e)
        End If
    End Sub
End Class
