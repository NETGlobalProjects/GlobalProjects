<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmLeerBascula
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmLeerBascula))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoDelPuertoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cancelarButton1 = New System.Windows.Forms.Button()
        Me.leerpesoButton2 = New System.Windows.Forms.Button()
        Me.fijarpesoButton3 = New System.Windows.Forms.Button()
        Me.enviarpesoButton4 = New System.Windows.Forms.Button()
        Me.leerPesoTimer = New System.Windows.Forms.Timer(Me.components)
        Me.escanearCarpetaTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tokeninfoLabel2 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.menuNotificacion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OcultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ultimoprocesadoLabel2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.unidadmedidaComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.estadopuertoLabel = New System.Windows.Forms.Label()
        Me.unidadMedidaTextBox2 = New System.Windows.Forms.TextBox()
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.menuNotificacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.EstadoDelPuertoToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(457, 28)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(587, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Image = Global.LeeBasculaND.My.Resources.Resources.settings
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'EstadoDelPuertoToolStripMenuItem
        '
        Me.EstadoDelPuertoToolStripMenuItem.Name = "EstadoDelPuertoToolStripMenuItem"
        Me.EstadoDelPuertoToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.EstadoDelPuertoToolStripMenuItem.Text = "Estado del Puerto"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-1, 31)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(399, 67)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TabStop = False
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cancelarButton1
        '
        Me.cancelarButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelarButton1.BackColor = System.Drawing.Color.Green
        Me.cancelarButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelarButton1.ForeColor = System.Drawing.Color.White
        Me.cancelarButton1.Location = New System.Drawing.Point(462, 212)
        Me.cancelarButton1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cancelarButton1.Name = "cancelarButton1"
        Me.cancelarButton1.Size = New System.Drawing.Size(118, 42)
        Me.cancelarButton1.TabIndex = 2
        Me.cancelarButton1.Text = "&Cancelar"
        Me.cancelarButton1.UseVisualStyleBackColor = False
        '
        'leerpesoButton2
        '
        Me.leerpesoButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.leerpesoButton2.BackColor = System.Drawing.Color.Green
        Me.leerpesoButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leerpesoButton2.ForeColor = System.Drawing.Color.White
        Me.leerpesoButton2.Location = New System.Drawing.Point(11, 212)
        Me.leerpesoButton2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.leerpesoButton2.Name = "leerpesoButton2"
        Me.leerpesoButton2.Size = New System.Drawing.Size(103, 42)
        Me.leerpesoButton2.TabIndex = 3
        Me.leerpesoButton2.Text = "&Leer"
        Me.leerpesoButton2.UseVisualStyleBackColor = False
        '
        'fijarpesoButton3
        '
        Me.fijarpesoButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fijarpesoButton3.BackColor = System.Drawing.Color.Green
        Me.fijarpesoButton3.Enabled = False
        Me.fijarpesoButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fijarpesoButton3.ForeColor = System.Drawing.Color.White
        Me.fijarpesoButton3.Location = New System.Drawing.Point(118, 212)
        Me.fijarpesoButton3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.fijarpesoButton3.Name = "fijarpesoButton3"
        Me.fijarpesoButton3.Size = New System.Drawing.Size(93, 42)
        Me.fijarpesoButton3.TabIndex = 4
        Me.fijarpesoButton3.Text = "&Fijar"
        Me.fijarpesoButton3.UseVisualStyleBackColor = False
        '
        'enviarpesoButton4
        '
        Me.enviarpesoButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.enviarpesoButton4.BackColor = System.Drawing.Color.Green
        Me.enviarpesoButton4.Enabled = False
        Me.enviarpesoButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enviarpesoButton4.ForeColor = System.Drawing.Color.White
        Me.enviarpesoButton4.Location = New System.Drawing.Point(215, 212)
        Me.enviarpesoButton4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.enviarpesoButton4.Name = "enviarpesoButton4"
        Me.enviarpesoButton4.Size = New System.Drawing.Size(93, 42)
        Me.enviarpesoButton4.TabIndex = 5
        Me.enviarpesoButton4.Text = "&Enviar"
        Me.enviarpesoButton4.UseVisualStyleBackColor = False
        '
        'leerPesoTimer
        '
        Me.leerPesoTimer.Interval = 1000
        '
        'escanearCarpetaTimer
        '
        Me.escanearCarpetaTimer.Enabled = True
        Me.escanearCarpetaTimer.Interval = 1000
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Token Actual:"
        '
        'tokeninfoLabel2
        '
        Me.tokeninfoLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tokeninfoLabel2.AutoSize = True
        Me.tokeninfoLabel2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tokeninfoLabel2.Location = New System.Drawing.Point(129, 167)
        Me.tokeninfoLabel2.Name = "tokeninfoLabel2"
        Me.tokeninfoLabel2.Size = New System.Drawing.Size(11, 16)
        Me.tokeninfoLabel2.TabIndex = 7
        Me.tokeninfoLabel2.Text = "-"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.menuNotificacion
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Leer Báscula VB.NET"
        Me.NotifyIcon1.Visible = True
        '
        'menuNotificacion
        '
        Me.menuNotificacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarToolStripMenuItem, Me.OcultarToolStripMenuItem})
        Me.menuNotificacion.Name = "menuNotificacion"
        Me.menuNotificacion.Size = New System.Drawing.Size(116, 48)
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'OcultarToolStripMenuItem
        '
        Me.OcultarToolStripMenuItem.Name = "OcultarToolStripMenuItem"
        Me.OcultarToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.OcultarToolStripMenuItem.Text = "Ocultar"
        '
        'ultimoprocesadoLabel2
        '
        Me.ultimoprocesadoLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ultimoprocesadoLabel2.AutoSize = True
        Me.ultimoprocesadoLabel2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ultimoprocesadoLabel2.Location = New System.Drawing.Point(129, 192)
        Me.ultimoprocesadoLabel2.Name = "ultimoprocesadoLabel2"
        Me.ultimoprocesadoLabel2.Size = New System.Drawing.Size(11, 16)
        Me.ultimoprocesadoLabel2.TabIndex = 9
        Me.ultimoprocesadoLabel2.Text = "-"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Ultimo Procesado:"
        '
        'unidadmedidaComboBox1
        '
        Me.unidadmedidaComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.unidadmedidaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.unidadmedidaComboBox1.FormattingEnabled = True
        Me.unidadmedidaComboBox1.Items.AddRange(New Object() {"Kgs.", "Lbs."})
        Me.unidadmedidaComboBox1.Location = New System.Drawing.Point(491, 3)
        Me.unidadmedidaComboBox1.Name = "unidadmedidaComboBox1"
        Me.unidadmedidaComboBox1.Size = New System.Drawing.Size(91, 24)
        Me.unidadmedidaComboBox1.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(397, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Unidad de Medida:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Estado del Puerto:"
        '
        'estadopuertoLabel
        '
        Me.estadopuertoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.estadopuertoLabel.AutoSize = True
        Me.estadopuertoLabel.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estadopuertoLabel.Location = New System.Drawing.Point(129, 141)
        Me.estadopuertoLabel.Name = "estadopuertoLabel"
        Me.estadopuertoLabel.Size = New System.Drawing.Size(11, 16)
        Me.estadopuertoLabel.TabIndex = 18
        Me.estadopuertoLabel.Text = "-"
        '
        'unidadMedidaTextBox2
        '
        Me.unidadMedidaTextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.unidadMedidaTextBox2.BackColor = System.Drawing.Color.White
        Me.unidadMedidaTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unidadMedidaTextBox2.ForeColor = System.Drawing.Color.Black
        Me.unidadMedidaTextBox2.Location = New System.Drawing.Point(397, 31)
        Me.unidadMedidaTextBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.unidadMedidaTextBox2.Name = "unidadMedidaTextBox2"
        Me.unidadMedidaTextBox2.ReadOnly = True
        Me.unidadMedidaTextBox2.Size = New System.Drawing.Size(185, 67)
        Me.unidadMedidaTextBox2.TabIndex = 19
        Me.unidadMedidaTextBox2.TabStop = False
        Me.unidadMedidaTextBox2.Text = "Kgs."
        Me.unidadMedidaTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SerialPort2
        '
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'fmLeerBascula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(587, 273)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.unidadMedidaTextBox2)
        Me.Controls.Add(Me.estadopuertoLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.unidadmedidaComboBox1)
        Me.Controls.Add(Me.ultimoprocesadoLabel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tokeninfoLabel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.enviarpesoButton4)
        Me.Controls.Add(Me.fijarpesoButton3)
        Me.Controls.Add(Me.leerpesoButton2)
        Me.Controls.Add(Me.cancelarButton1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(608, 318)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(603, 312)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(603, 312)
        Me.Name = "fmLeerBascula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Leer Báscula VB.NET"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.menuNotificacion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cancelarButton1 As System.Windows.Forms.Button
    Friend WithEvents leerpesoButton2 As System.Windows.Forms.Button
    Friend WithEvents fijarpesoButton3 As System.Windows.Forms.Button
    Friend WithEvents enviarpesoButton4 As System.Windows.Forms.Button
    Friend WithEvents leerPesoTimer As System.Windows.Forms.Timer
    Friend WithEvents escanearCarpetaTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tokeninfoLabel2 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents menuNotificacion As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MostrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OcultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ultimoprocesadoLabel2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents unidadmedidaComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents estadopuertoLabel As System.Windows.Forms.Label
    Friend WithEvents EstadoDelPuertoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents unidadMedidaTextBox2 As TextBox
    Friend WithEvents SerialPort2 As IO.Ports.SerialPort
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
End Class
