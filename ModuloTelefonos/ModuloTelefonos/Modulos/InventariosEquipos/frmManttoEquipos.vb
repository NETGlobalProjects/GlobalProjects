Public Class frmManttoEquipos
    Private Sub frmManttoEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListado()
    End Sub
    Public Sub cargarListado()
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.DataSource = EquiposClase.getListado(Me.TextBox1.Text)
        If Me.DataGridView1.Rows.Count > 0 Then
            eliminarLinkLabel2.Enabled = True
            editarLinkLabel3.Enabled = True
        Else
            eliminarLinkLabel2.Enabled = False
            editarLinkLabel3.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarListado()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        With frmAddModEquipo
            .accion = "añadir"
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As EventArgs) Handles editarLinkLabel3.Click
        With frmAddModEquipo
            .accion = "editar"
            .id_equipo = Convert.ToInt32(Me.DataGridView1.CurrentRow.Cells("id_equipo").Value)
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As EventArgs) Handles eliminarLinkLabel2.Click
        Dim id_equipo As Integer = CInt(Me.DataGridView1.CurrentRow.Cells("id_equipo").Value)
        Dim resp As DialogResult = MessageBox.Show("¿Confirma que desea eliminar el registro de equipo " & id_equipo.ToString() & "?", "Confirme operación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = DialogResult.Yes Then
            EquiposClase.elimininarEquipo(id_equipo)
            cargarListado()
        End If
    End Sub
End Class