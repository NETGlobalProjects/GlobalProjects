<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.estacionesComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tiempoleetablaNumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.minutosLabel3 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.puertoComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bitsdatosNumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.velocidadbaudiosNumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.directorioescanearTextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.unidadmedidaComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bitsParadaComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.tiempoleetablaNumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bitsdatosNumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.velocidadbaudiosNumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(335, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(416, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "&Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Estación Báscula"
        '
        'estacionesComboBox1
        '
        Me.estacionesComboBox1.FormattingEnabled = True
        Me.estacionesComboBox1.Location = New System.Drawing.Point(213, 28)
        Me.estacionesComboBox1.Name = "estacionesComboBox1"
        Me.estacionesComboBox1.Size = New System.Drawing.Size(158, 21)
        Me.estacionesComboBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tiempo en segundos escanear directorio"
        '
        'tiempoleetablaNumericUpDown1
        '
        Me.tiempoleetablaNumericUpDown1.Location = New System.Drawing.Point(213, 65)
        Me.tiempoleetablaNumericUpDown1.Name = "tiempoleetablaNumericUpDown1"
        Me.tiempoleetablaNumericUpDown1.Size = New System.Drawing.Size(54, 20)
        Me.tiempoleetablaNumericUpDown1.TabIndex = 5
        '
        'minutosLabel3
        '
        Me.minutosLabel3.AutoSize = True
        Me.minutosLabel3.Location = New System.Drawing.Point(273, 69)
        Me.minutosLabel3.Name = "minutosLabel3"
        Me.minutosLabel3.Size = New System.Drawing.Size(52, 13)
        Me.minutosLabel3.TabIndex = 6
        Me.minutosLabel3.Text = "0 minutos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre"
        '
        'puertoComboBox1
        '
        Me.puertoComboBox1.FormattingEnabled = True
        Me.puertoComboBox1.Location = New System.Drawing.Point(200, 19)
        Me.puertoComboBox1.Name = "puertoComboBox1"
        Me.puertoComboBox1.Size = New System.Drawing.Size(82, 21)
        Me.puertoComboBox1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bitsParadaComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.bitsdatosNumericUpDown2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.velocidadbaudiosNumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.puertoComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 118)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Puerto"
        '
        'bitsdatosNumericUpDown2
        '
        Me.bitsdatosNumericUpDown2.Location = New System.Drawing.Point(200, 72)
        Me.bitsdatosNumericUpDown2.Name = "bitsdatosNumericUpDown2"
        Me.bitsdatosNumericUpDown2.Size = New System.Drawing.Size(82, 20)
        Me.bitsdatosNumericUpDown2.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Bits de datos"
        '
        'velocidadbaudiosNumericUpDown1
        '
        Me.velocidadbaudiosNumericUpDown1.Location = New System.Drawing.Point(200, 46)
        Me.velocidadbaudiosNumericUpDown1.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.velocidadbaudiosNumericUpDown1.Name = "velocidadbaudiosNumericUpDown1"
        Me.velocidadbaudiosNumericUpDown1.Size = New System.Drawing.Size(82, 20)
        Me.velocidadbaudiosNumericUpDown1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Velocidad en baudios"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Directorio a escanear"
        '
        'directorioescanearTextBox1
        '
        Me.directorioescanearTextBox1.Location = New System.Drawing.Point(213, 97)
        Me.directorioescanearTextBox1.Name = "directorioescanearTextBox1"
        Me.directorioescanearTextBox1.Size = New System.Drawing.Size(248, 20)
        Me.directorioescanearTextBox1.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(463, 95)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = False
        '
        'unidadmedidaComboBox1
        '
        Me.unidadmedidaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.unidadmedidaComboBox1.Enabled = False
        Me.unidadmedidaComboBox1.FormattingEnabled = True
        Me.unidadmedidaComboBox1.Items.AddRange(New Object() {"Kgs.", "Lbs."})
        Me.unidadmedidaComboBox1.Location = New System.Drawing.Point(213, 130)
        Me.unidadmedidaComboBox1.Name = "unidadmedidaComboBox1"
        Me.unidadmedidaComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.unidadmedidaComboBox1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Unidad de Medida"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(65, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Bits de parada"
        '
        'bitsParadaComboBox1
        '
        Me.bitsParadaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bitsParadaComboBox1.FormattingEnabled = True
        Me.bitsParadaComboBox1.Items.AddRange(New Object() {"1", "2"})
        Me.bitsParadaComboBox1.Location = New System.Drawing.Point(200, 99)
        Me.bitsParadaComboBox1.Name = "bitsParadaComboBox1"
        Me.bitsParadaComboBox1.Size = New System.Drawing.Size(82, 21)
        Me.bitsParadaComboBox1.TabIndex = 16
        '
        'frmOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(501, 329)
        Me.ControlBox = False
        Me.Controls.Add(Me.unidadmedidaComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.directorioescanearTextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.minutosLabel3)
        Me.Controls.Add(Me.tiempoleetablaNumericUpDown1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.estacionesComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmOpciones"
        Me.Text = "Opciones"
        Me.TopMost = True
        CType(Me.tiempoleetablaNumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bitsdatosNumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.velocidadbaudiosNumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents estacionesComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tiempoleetablaNumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents minutosLabel3 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents puertoComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents velocidadbaudiosNumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents bitsdatosNumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents directorioescanearTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents unidadmedidaComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As Label
    Friend WithEvents bitsParadaComboBox1 As ComboBox
End Class
