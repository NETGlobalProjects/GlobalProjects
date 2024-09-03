Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmMenuModuloInventarioTelefonos
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub frmMenuModuloInventarioTelefonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Version2.Text = "Versión: " & My.Application.Info.Version.ToString
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        With frmLineas
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .actualizar()
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        With frmLotesTelefonos
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .actualizar()
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        With frmPropietarios
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        With frmMovimientos
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .Actualizar()
            .ShowDialog()
        End With
    End Sub






    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonX5_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub EstadosTeléfonosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadosTeléfonosToolStripMenuItem.Click
        With frmEstadosTelefonos
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub MotivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MotivosToolStripMenuItem.Click
        With frmMotivosTelefonos
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub frmMenuModuloInventarioTelefonos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub ButtonX5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonX5_Click_2(sender As Object, e As EventArgs) Handles ButtonX5.Click
        With frmManttoEquipos
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonX6_Click(sender As Object, e As EventArgs) Handles ButtonX6.Click
        End
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasToolStripMenuItem.Click
        With frmMarcasTelefonos
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
End Class