Public Class frmOpciones

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.estacionesComboBox1.Text = My.MySettings.Default.estacionbascula
        Me.tiempoleetablaNumericUpDown1.Value = My.MySettings.Default.tiempo_segs_lee_tb
        Me.minutosLabel3.Text = Math.Round(Me.tiempoleetablaNumericUpDown1.Value / 60, 2) & " minuto(s)"
        Me.velocidadbaudiosNumericUpDown1.Value = My.MySettings.Default.velocidad_baudios
        Me.bitsdatosNumericUpDown2.Value = My.MySettings.Default.bits_de_datos
        Me.directorioescanearTextBox1.Text = My.MySettings.Default.directorio_escanear
        Me.unidadmedidaComboBox1.Text = My.MySettings.Default.unidadmedida
        Me.bitsParadaComboBox1.Text = My.MySettings.Default.bitsParada

        puertoComboBox1.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            puertoComboBox1.Items.Add(sp)
        Next
        Me.puertoComboBox1.Text = My.MySettings.Default.puerto
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.MySettings.Default.estacionbascula = Me.estacionesComboBox1.Text
        My.MySettings.Default.tiempo_segs_lee_tb = Me.tiempoleetablaNumericUpDown1.Value
        My.MySettings.Default.puerto = Me.puertoComboBox1.Text
        My.MySettings.Default.velocidad_baudios = Me.velocidadbaudiosNumericUpDown1.Value
        My.MySettings.Default.bits_de_datos = Me.bitsdatosNumericUpDown2.Value
        My.MySettings.Default.directorio_escanear = Me.directorioescanearTextBox1.Text
        My.MySettings.Default.unidadmedida = Me.unidadmedidaComboBox1.Text
        My.MySettings.Default.bitsParada = Me.bitsParadaComboBox1.Text
        My.MySettings.Default.Save()
        Me.Close()
    End Sub

    Private Sub tiempoleetablaNumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles tiempoleetablaNumericUpDown1.ValueChanged
        Me.minutosLabel3.Text = Math.Round(Me.tiempoleetablaNumericUpDown1.Value / 60, 2) & " minuto(s)"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Me.directorioescanearTextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
End Class