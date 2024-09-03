Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class fmLeerBascula
    Dim InString As String
    Dim InStringPuro As String
    Dim Token As String
    Dim odtsDatos As New dtsDatos
    Dim archivoleido As String
    Dim pesofijado As Double
    Dim BasculaTokenslecturasAdapter As New dtsDatosTableAdapters.BasculaTokensLecturasTableAdapter
    Private objMutex As System.Threading.Mutex
    Private Sub OpcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpcionesToolStripMenuItem.Click
        With frmOpciones
            .StartPosition = FormStartPosition.CenterScreen
            .WindowState = FormWindowState.Normal
            .ShowDialog()
        End With
    End Sub

    Public Function GetEstadoPuerto() As String
        Dim estado As String
        If SerialPort2.IsOpen Then
            estado = "ABIERTO"

        Else
            estado = "CERRADO"
        End If
        Me.estadopuertoLabel.Text = estado

        Return estado
    End Function
    Public Sub CerrarPuerto()
        If Me.SerialPort2.IsOpen Then
            Me.SerialPort2.Close()

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cancelarButton1.Click
        If RTrim(Token) <> "" Then
            Dim respuesta As MsgBoxResult
            respuesta = MessageBox.Show("Se cancelará la llamada actual, deberá invocar nuevamente la llamada desde NetData" & vbCrLf & vbCrLf & "¿Desea continuar de todas formas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If respuesta = MsgBoxResult.Yes Then
                cancelarlecturaEnTabla()
                File.Delete(archivoleido)
                If SerialPort2.IsOpen Then
                    Me.SerialPort2.Close()
                End If
                Me.leerPesoTimer.Enabled = False
                Me.menuNotificacion.Enabled = True
                Me.escanearCarpetaTimer.Enabled = True
                Me.Hide()
            End If
        Else
            If SerialPort2.IsOpen Then
                Me.SerialPort2.Close()
            End If
            Me.leerPesoTimer.Enabled = False
            Me.menuNotificacion.Enabled = True
            Me.escanearCarpetaTimer.Enabled = True
            Me.Hide()
        End If

    End Sub
    Sub leerpeso()


        Try
            If Me.leerpesoButton2.Text = "&Leer" Then

                Me.leerpesoButton2.Text = "&Detener"
                Me.enviarpesoButton4.Enabled = False
                'Me.fijarpesoButton3.Enabled = True
                Me.cancelarButton1.Enabled = False
                Me.SerialPort2.PortName = My.MySettings.Default.puerto
                If My.MySettings.Default.bitsParada = 1 Then
                    Me.SerialPort2.StopBits = StopBits.One
                ElseIf My.MySettings.Default.bitsParada = 2 Then
                    Me.SerialPort2.StopBits = StopBits.Two
                End If

                Me.SerialPort2.ReceivedBytesThreshold = 9
                Me.SerialPort2.BaudRate = My.MySettings.Default.velocidad_baudios
                Me.SerialPort2.DataBits = My.MySettings.Default.bits_de_datos
                Me.SerialPort2.Handshake = Handshake.None
                validarPesoNovacio()

                If Not SerialPort2.IsOpen Then
                    Me.SerialPort2.Open()
                End If

                Me.leerPesoTimer.Enabled = True
                Me.leerPesoTimer.Start()

                If SerialPort2.IsOpen Then
                    Me.estadopuertoLabel.Text = "ABIERTO (Obteniendo Datos...)"
                    'Me.SerialPort1.Close()
                Else
                    Me.estadopuertoLabel.Text = "CERRADO"
                End If
                Me.unidadmedidaComboBox1.Enabled = False





            ElseIf Me.leerpesoButton2.Text = "&Detener" Then

                Me.leerpesoButton2.Text = "&Leer"
                Me.enviarpesoButton4.Enabled = True
                Me.fijarpesoButton3.Enabled = False
                Me.cancelarButton1.Enabled = True
                Me.TextBox1.Text = ""
                Me.unidadMedidaTextBox2.Text = Trim(My.MySettings.Default.unidadmedida)
                Me.leerPesoTimer.Enabled = False
                If SerialPort2.IsOpen Then
                    Me.SerialPort2.Close()
                End If
                GetEstadoPuerto()
                Me.unidadmedidaComboBox1.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Finally
            '    'If Me.SerialPort2.IsOpen Then
            '    '    Me.SerialPort2.Close()
            '    'End If
        End Try
    End Sub
    Private Sub leerpesoButton2_Click(sender As Object, e As EventArgs) Handles leerpesoButton2.Click
        InString = "0"
        InStringPuro = "0"
        leerpeso()

    End Sub
    Private Sub leerPesoTimer_Tick(sender As Object, e As EventArgs) Handles leerPesoTimer.Tick
        Static segs As Integer
        segs += 1
        If segs = 1 Then
            If IsNumeric(InString) Then
                Me.TextBox1.Text = CInt(InString)

            End If
            Me.Label5.Text = InStringPuro
            If Label5.Text = "" Then
                Me.Label5.Text = "Sin datos"
            End If
            segs = 0
        End If
    End Sub
    Private Sub fijarpesoButton3_Click(sender As Object, e As EventArgs) Handles fijarpesoButton3.Click
        Try
            If Me.leerpesoButton2.Text = "&Detener" Then
                Me.leerPesoTimer.Enabled = False
                leerPesoTimer.Stop()
                If SerialPort2.IsOpen Then
                    Me.SerialPort2.Close()
                End If
                GetEstadoPuerto()
                Me.unidadmedidaComboBox1.Enabled = True
                'pesofijado = dejarNumerosPuntos(Replace(Me.TextBox1.Text, RTrim(My.MySettings.Default.unidadmedida), ""))
                Me.leerpesoButton2.Text = "&Leer"
                Me.fijarpesoButton3.Enabled = False
                If Me.TextBox1.Text <> 0 Then
                    Me.enviarpesoButton4.Enabled = True
                Else
                    Me.enviarpesoButton4.Enabled = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al fijar peso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function dejarNumerosPuntos(cadenaTexto As String) As String
        Const listaNumeros = "0123456789."
        Dim cadenaTemporal As String
        Dim i As Integer

        cadenaTexto = Trim$(cadenaTexto)
        If Len(cadenaTexto) = 0 Then
            Exit Function
        End If

        cadenaTemporal = ""

        For i = 1 To Len(cadenaTexto)
            If InStr(listaNumeros, Mid$(cadenaTexto, i, 1)) Then
                cadenaTemporal = cadenaTemporal + Mid$(cadenaTexto, i, 1)
            End If
        Next
        dejarNumerosPuntos = cadenaTemporal
    End Function
    Sub cancelarlecturaEnTabla()
        BasculaTokenslecturasAdapter.CancelaLectura(Token)
    End Sub
    Private Sub fmLeerBascula_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        If Me.leerpesoButton2.Text = "&Detener" Then
            MessageBox.Show("Debe detener la lectura de la báscula antes de cancelar el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If RTrim(Token) <> "" Then
                Dim respuesta As MsgBoxResult
                respuesta = MessageBox.Show("Informarle que el aplicativo no se cerrará, sino que se minimizará y cancelará la llamada actual" & vbCrLf & vbCrLf & "¿Desea continuar de todas formas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If respuesta = MsgBoxResult.Yes Then
                    cancelarlecturaEnTabla()
                    File.Delete(archivoleido)
                    If SerialPort2.IsOpen Then
                        Me.SerialPort2.Close()
                    End If
                    Me.leerPesoTimer.Enabled = False
                    Me.menuNotificacion.Enabled = True
                    Me.escanearCarpetaTimer.Enabled = True
                    Me.escanearCarpetaTimer.Start()
                    Me.Hide()
                End If
            Else
                If SerialPort2.IsOpen Then
                    Me.SerialPort2.Close()
                End If
                Me.leerPesoTimer.Enabled = False
                Me.menuNotificacion.Enabled = True
                Me.escanearCarpetaTimer.Enabled = True
                Me.escanearCarpetaTimer.Start()
                Me.Hide()
            End If

        End If
    End Sub
    Sub escanerCarpeta()
        Token = ""
        Me.TextBox1.Text = ""
        Me.unidadMedidaTextBox2.Text = RTrim(My.MySettings.Default.unidadmedida)
        Me.tokeninfoLabel2.Text = "Sin petición"
        Me.ultimoprocesadoLabel2.Text = "Sin Dato"
        Me.enviarpesoButton4.Enabled = False
        Me.fijarpesoButton3.Enabled = False

        Dim aFileInfo As System.IO.FileInfo
        Dim fileInfos() As System.IO.FileInfo
        Dim aDirectoryInfo As System.IO.DirectoryInfo
        aDirectoryInfo = New System.IO.DirectoryInfo(My.MySettings.Default.directorio_escanear)
        fileInfos = aDirectoryInfo.GetFiles("*.txt")

        Dim EarlyDate As New DateTime(1000)
        Dim strLatestFile As String = String.Empty

        For Each aFileInfo In fileInfos
            If aFileInfo.FullName.Contains(My.MySettings.Default.estacionbascula) Then
                If aFileInfo.LastWriteTime > EarlyDate Then
                    strLatestFile = aFileInfo.FullName
                    EarlyDate = aFileInfo.LastWriteTime
                End If
            End If

        Next
        If strLatestFile <> "" Then
            For Each Archivos As String In System.IO.Directory.GetFiles(My.MySettings.Default.directorio_escanear)
                If Archivos <> strLatestFile And Archivos.Contains(My.MySettings.Default.estacionbascula) Then
                    File.Delete(Archivos)
                Else
                    If Archivos.Contains(My.MySettings.Default.estacionbascula) Then
                        Me.escanearCarpetaTimer.Enabled = False
                        Token = Path.GetFileName(Archivos).Replace(".txt", "")
                        ultimoprocesadoLabel2.Text = BasculaTokenslecturasAdapter.GetUltimoTokenProcesado(My.MySettings.Default.estacionbascula)
                        archivoleido = Archivos
                        Me.menuNotificacion.Enabled = False
                        Me.TextBox1.Text = ""
                        Me.unidadMedidaTextBox2.Text = Me.unidadmedidaComboBox1.Text
                        Me.tokeninfoLabel2.Text = Token
                        leerpeso()
                        Me.Show()
                        Exit For
                    End If

                End If

            Next
        End If
    End Sub
    Private Sub escanearCarpetaTimer_Tick(sender As Object, e As EventArgs) Handles escanearCarpetaTimer.Tick
        Static segs As Integer
        segs += 1
        If segs = My.MySettings.Default.tiempo_segs_lee_tb Then
            escanerCarpeta()
            segs = 0
        End If
    End Sub
    Private Sub enviarpesoButton4_Click(sender As Object, e As EventArgs) Handles enviarpesoButton4.Click
        Try

            'Dim mbox As New mb.ShowMessagebox
            'mbox.ButtonText("Confimar", "Regresar")
            'mbox.Fonts(New Font("Arial Narrow", 20, FontStyle.Bold))
            'Dim respuesta As MsgBoxResult = mbox.ShowBox(String.Format("El valor que se enviará es de {0} " & Trim(Me.unidadMedidaTextBox2.Text) & vbCrLf & vbCrLf & "¿Confirma que el valor es correcto?", dejarNumerosPuntos(Me.TextBox1.Text)), mb.MStyle.YesNo, mb.FStyle.Question, "Confirme el valor")
            'If respuesta = MsgBoxResult.Yes Then
            BasculaTokenslecturasAdapter.EnviarDatos(dejarNumerosPuntos(Me.TextBox1.Text), My.MySettings.Default.unidadmedida, Token)
            File.Delete(archivoleido)
            Me.escanearCarpetaTimer.Enabled = True
            Me.menuNotificacion.Enabled = True
            Me.escanearCarpetaTimer.Start()
            Me.enviarpesoButton4.Enabled = False
            If Me.SerialPort2.IsOpen Then
                Me.SerialPort2.Close()
            End If
            Me.Hide()
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al enviar peso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            escanearCarpetaTimer.Enabled = True
            escanearCarpetaTimer.Start()
        End Try

    End Sub
    Private Sub fmLeerBascula_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Control + Keys.Alt + Keys.C Then
            If SerialPort2.IsOpen Then
                Me.SerialPort2.Close()
            End If
            End
        End If
        If e.KeyCode = Keys.Escape Then
            If Me.leerpesoButton2.Text = "&Detener" Then
                MessageBox.Show("Debe detener la lectura de la báscula antes de cancelar el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If RTrim(Token) <> "" Then
                    Dim respuesta As MsgBoxResult
                    respuesta = MessageBox.Show("Informarle que el aplicativo no se cerrará, sino que se minimizará y cancelará la llamada actual" & vbCrLf & vbCrLf & "¿Desea continuar de todas formas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If respuesta = MsgBoxResult.Yes Then
                        cancelarlecturaEnTabla()
                        File.Delete(archivoleido)
                        If SerialPort2.IsOpen Then
                            Me.SerialPort2.Close()
                        End If
                        Me.leerPesoTimer.Enabled = False
                        Me.menuNotificacion.Enabled = True
                        Me.escanearCarpetaTimer.Enabled = True
                        Me.Hide()
                    End If
                Else
                    If SerialPort2.IsOpen Then
                        Me.SerialPort2.Close()
                    End If
                    Me.leerPesoTimer.Enabled = False
                    Me.menuNotificacion.Enabled = True
                    Me.escanearCarpetaTimer.Enabled = True
                    Me.Hide()
                End If
            End If
        End If
    End Sub
    Private Sub fmLeerBascula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objMutex = New System.Threading.Mutex(False, "LeeBasculaND")
        If objMutex.WaitOne(0, False) = False Then
            objMutex.Close()
            objMutex = Nothing
            MessageBox.Show("La aplicación ya esta ejecutándose!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        Else
            Dim privateFonts As New System.Drawing.Text.PrivateFontCollection()
            Dim ruta As String = IO.Path.GetFullPath(My.Application.Info.DirectoryPath)
            Try
                privateFonts.AddFontFile(ruta & "\digital_7_italic.ttf")
                Dim font As New System.Drawing.Font(privateFonts.Families(0), 70)
                Me.TextBox1.Font = font
                Me.unidadMedidaTextBox2.Font = font
            Catch ex As Exception
            End Try



            If SerialPort2.IsOpen Then
                Me.estadopuertoLabel.Text = "ABIERTO (Obteniendo Datos...)"
            Else
                Me.estadopuertoLabel.Text = "CERRADO"
            End If
            Me.unidadmedidaComboBox1.Text = My.MySettings.Default.unidadmedida
            Me.TextBox1.Text = ""
            Me.unidadMedidaTextBox2.Text = RTrim(My.MySettings.Default.unidadmedida)
            Me.tokeninfoLabel2.Text = "Sin petición"
            Me.Hide()

        End If
    End Sub
    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Me.escanearCarpetaTimer.Enabled = False
        Me.Show()
    End Sub
    Private Sub OcultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OcultarToolStripMenuItem.Click
        Me.escanearCarpetaTimer.Enabled = True
        Me.Hide()
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.Token = "" Then
            Me.escanearCarpetaTimer.Enabled = False
            Me.Show()
        End If
    End Sub
    Private Sub unidadmedidaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles unidadmedidaComboBox1.SelectedIndexChanged
        My.MySettings.Default.unidadmedida = Me.unidadmedidaComboBox1.Text
        My.MySettings.Default.Save()
        'Me.TextBox1.Text = 0
        Me.unidadMedidaTextBox2.Text = Me.unidadmedidaComboBox1.Text
    End Sub
    Private Sub unidadmedidaComboBox1_TextChanged(sender As Object, e As EventArgs) Handles unidadmedidaComboBox1.TextChanged
        My.MySettings.Default.unidadmedida = Me.unidadmedidaComboBox1.Text
        My.MySettings.Default.Save()
        'Me.TextBox1.Text = 0
        Me.unidadMedidaTextBox2.Text = RTrim(My.MySettings.Default.unidadmedida)
    End Sub

    Private Sub EstadoDelPuertoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDelPuertoToolStripMenuItem.Click
        With frmVerEstadoPuerto
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub SerialPort2_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort2.DataReceived
        ' InString = dejarNumerosPuntos(Me.SerialPort2.ReadExisting)
        InString = Me.SerialPort2.ReadExisting.Substring(2, 6)
    End Sub
    Sub validarPesoNovacio()
        If Trim(Me.TextBox1.Text) <> "" Then
            Me.fijarpesoButton3.Enabled = True
        Else
            Me.fijarpesoButton3.Enabled = False
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        validarPesoNovacio()
    End Sub
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        With frmAcercaDe
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
End Class
