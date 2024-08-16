<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddModEquipo
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddModEquipo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.disponibleCheckBoxX1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.estadoComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.descripcionTextBox5 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.garantiaIntegerInput1 = New DevComponents.Editors.IntegerInput()
        Me.proveedorTextBox4 = New System.Windows.Forms.TextBox()
        Me.fechaDateTimeInput1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.serieTextBox3 = New System.Windows.Forms.TextBox()
        Me.modeloTextBox2 = New System.Windows.Forms.TextBox()
        Me.marcaComboBox2 = New System.Windows.Forms.ComboBox()
        Me.tipoComboBox1 = New System.Windows.Forms.ComboBox()
        Me.idTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New DevComponents.DotNetBar.ButtonX()
        Me.Button2 = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1.SuspendLayout()
        CType(Me.garantiaIntegerInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fechaDateTimeInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.disponibleCheckBoxX1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.estadoComboBox1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.descripcionTextBox5)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.garantiaIntegerInput1)
        Me.Panel1.Controls.Add(Me.proveedorTextBox4)
        Me.Panel1.Controls.Add(Me.fechaDateTimeInput1)
        Me.Panel1.Controls.Add(Me.serieTextBox3)
        Me.Panel1.Controls.Add(Me.modeloTextBox2)
        Me.Panel1.Controls.Add(Me.marcaComboBox2)
        Me.Panel1.Controls.Add(Me.tipoComboBox1)
        Me.Panel1.Controls.Add(Me.idTextBox1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 486)
        Me.Panel1.TabIndex = 0
        '
        'disponibleCheckBoxX1
        '
        '
        '
        '
        Me.disponibleCheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.disponibleCheckBoxX1.Location = New System.Drawing.Point(141, 264)
        Me.disponibleCheckBoxX1.Name = "disponibleCheckBoxX1"
        Me.disponibleCheckBoxX1.Size = New System.Drawing.Size(330, 23)
        Me.disponibleCheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.disponibleCheckBoxX1.TabIndex = 22
        Me.disponibleCheckBoxX1.Text = "Marcar si el equipo está disponble"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(12, 267)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Disponible"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'estadoComboBox1
        '
        Me.estadoComboBox1.FormattingEnabled = True
        Me.estadoComboBox1.Location = New System.Drawing.Point(141, 80)
        Me.estadoComboBox1.Name = "estadoComboBox1"
        Me.estadoComboBox1.Size = New System.Drawing.Size(169, 21)
        Me.estadoComboBox1.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(12, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Estado"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'descripcionTextBox5
        '
        Me.descripcionTextBox5.Location = New System.Drawing.Point(141, 293)
        Me.descripcionTextBox5.MaxLength = 250
        Me.descripcionTextBox5.Multiline = True
        Me.descripcionTextBox5.Name = "descripcionTextBox5"
        Me.descripcionTextBox5.Size = New System.Drawing.Size(330, 108)
        Me.descripcionTextBox5.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(12, 296)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Descripción"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(225, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "meses"
        '
        'garantiaIntegerInput1
        '
        '
        '
        '
        Me.garantiaIntegerInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.garantiaIntegerInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.garantiaIntegerInput1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.garantiaIntegerInput1.Location = New System.Drawing.Point(141, 240)
        Me.garantiaIntegerInput1.Name = "garantiaIntegerInput1"
        Me.garantiaIntegerInput1.ShowUpDown = True
        Me.garantiaIntegerInput1.Size = New System.Drawing.Size(80, 20)
        Me.garantiaIntegerInput1.TabIndex = 7
        '
        'proveedorTextBox4
        '
        Me.proveedorTextBox4.Location = New System.Drawing.Point(141, 213)
        Me.proveedorTextBox4.MaxLength = 100
        Me.proveedorTextBox4.Name = "proveedorTextBox4"
        Me.proveedorTextBox4.Size = New System.Drawing.Size(330, 20)
        Me.proveedorTextBox4.TabIndex = 6
        '
        'fechaDateTimeInput1
        '
        Me.fechaDateTimeInput1.AutoAdvance = True
        '
        '
        '
        Me.fechaDateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.fechaDateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaDateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.fechaDateTimeInput1.ButtonDropDown.Visible = True
        Me.fechaDateTimeInput1.IsPopupCalendarOpen = False
        Me.fechaDateTimeInput1.Location = New System.Drawing.Point(141, 187)
        '
        '
        '
        Me.fechaDateTimeInput1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fechaDateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaDateTimeInput1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.fechaDateTimeInput1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.fechaDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.fechaDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.fechaDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.fechaDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.fechaDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.fechaDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaDateTimeInput1.MonthCalendar.DisplayMonth = New Date(2022, 5, 1, 0, 0, 0, 0)
        Me.fechaDateTimeInput1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.fechaDateTimeInput1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fechaDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.fechaDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.fechaDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.fechaDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaDateTimeInput1.MonthCalendar.TodayButtonVisible = True
        Me.fechaDateTimeInput1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.fechaDateTimeInput1.Name = "fechaDateTimeInput1"
        Me.fechaDateTimeInput1.Size = New System.Drawing.Size(169, 20)
        Me.fechaDateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.fechaDateTimeInput1.TabIndex = 5
        '
        'serieTextBox3
        '
        Me.serieTextBox3.Location = New System.Drawing.Point(141, 160)
        Me.serieTextBox3.MaxLength = 50
        Me.serieTextBox3.Name = "serieTextBox3"
        Me.serieTextBox3.Size = New System.Drawing.Size(169, 20)
        Me.serieTextBox3.TabIndex = 4
        '
        'modeloTextBox2
        '
        Me.modeloTextBox2.Location = New System.Drawing.Point(141, 134)
        Me.modeloTextBox2.MaxLength = 50
        Me.modeloTextBox2.Name = "modeloTextBox2"
        Me.modeloTextBox2.Size = New System.Drawing.Size(169, 20)
        Me.modeloTextBox2.TabIndex = 3
        '
        'marcaComboBox2
        '
        Me.marcaComboBox2.FormattingEnabled = True
        Me.marcaComboBox2.Location = New System.Drawing.Point(141, 107)
        Me.marcaComboBox2.Name = "marcaComboBox2"
        Me.marcaComboBox2.Size = New System.Drawing.Size(169, 21)
        Me.marcaComboBox2.TabIndex = 2
        '
        'tipoComboBox1
        '
        Me.tipoComboBox1.FormattingEnabled = True
        Me.tipoComboBox1.Location = New System.Drawing.Point(141, 53)
        Me.tipoComboBox1.Name = "tipoComboBox1"
        Me.tipoComboBox1.Size = New System.Drawing.Size(169, 21)
        Me.tipoComboBox1.TabIndex = 0
        '
        'idTextBox1
        '
        Me.idTextBox1.Enabled = False
        Me.idTextBox1.Location = New System.Drawing.Point(141, 27)
        Me.idTextBox1.Name = "idTextBox1"
        Me.idTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.idTextBox1.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(15, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Tiempo garantia"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Proveedor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(15, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fecha de compra"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Serie"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Modelo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Marca"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Equipo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 440)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(534, 46)
        Me.Panel2.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Button1.Location = New System.Drawing.Point(447, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Button1.Symbol = ""
        Me.Button1.SymbolSize = 12.0!
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Cancelar"
        '
        'Button2
        '
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Button2.Location = New System.Drawing.Point(324, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 23)
        Me.Button2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Button2.Symbol = ""
        Me.Button2.SymbolSize = 12.0!
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Aceptar"
        '
        'frmAddModEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddModEquipo"
        Me.Text = "Agregar o modificar equipos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.garantiaIntegerInput1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fechaDateTimeInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents descripcionTextBox5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents garantiaIntegerInput1 As DevComponents.Editors.IntegerInput
    Friend WithEvents proveedorTextBox4 As TextBox
    Friend WithEvents fechaDateTimeInput1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents serieTextBox3 As TextBox
    Friend WithEvents modeloTextBox2 As TextBox
    Friend WithEvents marcaComboBox2 As ComboBox
    Friend WithEvents tipoComboBox1 As ComboBox
    Friend WithEvents idTextBox1 As TextBox
    Friend WithEvents estadoComboBox1 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Button2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents disponibleCheckBoxX1 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Label12 As Label
End Class
