<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPropietarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPropietarios))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.id_propietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_baja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.duiMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.rutaTextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.codigoempleadoTextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.estatusSwitchButton1 = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.otrosdatosTextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.propietariolineaTextBoxX5 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.lineactualTextBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.modeloTextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.marcaTextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.imeiactualTextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.seleccionarButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.guardarButtonX7 = New DevComponents.DotNetBar.ButtonX()
        Me.eliminarButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.modificarButtonX5 = New DevComponents.DotNetBar.ButtonX()
        Me.nuevoButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.fechabajaTextBoxX5 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.fechaingresoTextBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.cargoComboBoxEx3 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.departamentoComboBoxEx2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.empresaComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.apellidosTextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.nombresTextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.idpropietarioTextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.localizarTextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupPanel2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(869, 607)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'GroupPanel2
        '
        Me.GroupPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.DataGridViewX1)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 366)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(743, 238)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 1
        Me.GroupPanel2.Text = "Listado de registros"
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_propietario, Me.nombres, Me.apellidos, Me.fecha_ingreso, Me.fecha_baja})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.RowHeadersWidth = 21
        Me.DataGridViewX1.Size = New System.Drawing.Size(737, 217)
        Me.DataGridViewX1.TabIndex = 0
        '
        'id_propietario
        '
        Me.id_propietario.DataPropertyName = "id_propietario"
        Me.id_propietario.HeaderText = "Id Propietario"
        Me.id_propietario.Name = "id_propietario"
        Me.id_propietario.ReadOnly = True
        Me.id_propietario.Width = 90
        '
        'nombres
        '
        Me.nombres.DataPropertyName = "nombres"
        Me.nombres.HeaderText = "Nombres"
        Me.nombres.Name = "nombres"
        Me.nombres.ReadOnly = True
        Me.nombres.Width = 200
        '
        'apellidos
        '
        Me.apellidos.DataPropertyName = "apellidos"
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.ReadOnly = True
        Me.apellidos.Width = 200
        '
        'fecha_ingreso
        '
        Me.fecha_ingreso.DataPropertyName = "fecha_ingreso"
        Me.fecha_ingreso.HeaderText = "Fecha de Ingreso"
        Me.fecha_ingreso.Name = "fecha_ingreso"
        Me.fecha_ingreso.ReadOnly = True
        '
        'fecha_baja
        '
        Me.fecha_baja.DataPropertyName = "fecha_egreso"
        Me.fecha_baja.HeaderText = "Fecha de Baja"
        Me.fecha_baja.Name = "fecha_baja"
        Me.fecha_baja.ReadOnly = True
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX19)
        Me.GroupPanel1.Controls.Add(Me.duiMaskedTextBox1)
        Me.GroupPanel1.Controls.Add(Me.rutaTextBoxX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX18)
        Me.GroupPanel1.Controls.Add(Me.codigoempleadoTextBoxX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX17)
        Me.GroupPanel1.Controls.Add(Me.estatusSwitchButton1)
        Me.GroupPanel1.Controls.Add(Me.LabelX16)
        Me.GroupPanel1.Controls.Add(Me.otrosdatosTextBoxX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX15)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel4)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel3)
        Me.GroupPanel1.Controls.Add(Me.seleccionarButtonX4)
        Me.GroupPanel1.Controls.Add(Me.guardarButtonX7)
        Me.GroupPanel1.Controls.Add(Me.eliminarButtonX6)
        Me.GroupPanel1.Controls.Add(Me.modificarButtonX5)
        Me.GroupPanel1.Controls.Add(Me.nuevoButtonX4)
        Me.GroupPanel1.Controls.Add(Me.fechabajaTextBoxX5)
        Me.GroupPanel1.Controls.Add(Me.LabelX9)
        Me.GroupPanel1.Controls.Add(Me.fechaingresoTextBoxX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX8)
        Me.GroupPanel1.Controls.Add(Me.ButtonX3)
        Me.GroupPanel1.Controls.Add(Me.ButtonX2)
        Me.GroupPanel1.Controls.Add(Me.ButtonX1)
        Me.GroupPanel1.Controls.Add(Me.cargoComboBoxEx3)
        Me.GroupPanel1.Controls.Add(Me.departamentoComboBoxEx2)
        Me.GroupPanel1.Controls.Add(Me.empresaComboBoxEx1)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.apellidosTextBoxX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.nombresTextBoxX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.idpropietarioTextBoxX1)
        Me.GroupPanel1.Controls.Add(Me.localizarTextBoxX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(743, 348)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Opciones propietarios"
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Location = New System.Drawing.Point(22, 268)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(83, 23)
        Me.LabelX19.TabIndex = 36
        Me.LabelX19.Text = "DUI:"
        Me.LabelX19.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'duiMaskedTextBox1
        '
        Me.duiMaskedTextBox1.Location = New System.Drawing.Point(120, 271)
        Me.duiMaskedTextBox1.Mask = "########-#"
        Me.duiMaskedTextBox1.Name = "duiMaskedTextBox1"
        Me.duiMaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.duiMaskedTextBox1.TabIndex = 15
        '
        'rutaTextBoxX2
        '
        Me.rutaTextBoxX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rutaTextBoxX2.Border.Class = "TextBoxBorder"
        Me.rutaTextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rutaTextBoxX2.DisabledBackColor = System.Drawing.Color.White
        Me.rutaTextBoxX2.ForeColor = System.Drawing.Color.Black
        Me.rutaTextBoxX2.Location = New System.Drawing.Point(476, 282)
        Me.rutaTextBoxX2.MaxLength = 40
        Me.rutaTextBoxX2.Name = "rutaTextBoxX2"
        Me.rutaTextBoxX2.ReadOnly = True
        Me.rutaTextBoxX2.Size = New System.Drawing.Size(86, 20)
        Me.rutaTextBoxX2.TabIndex = 34
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.Location = New System.Drawing.Point(357, 280)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(51, 23)
        Me.LabelX18.TabIndex = 33
        Me.LabelX18.Text = "Ruta:"
        '
        'codigoempleadoTextBoxX1
        '
        Me.codigoempleadoTextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.codigoempleadoTextBoxX1.Border.Class = "TextBoxBorder"
        Me.codigoempleadoTextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.codigoempleadoTextBoxX1.DisabledBackColor = System.Drawing.Color.White
        Me.codigoempleadoTextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.codigoempleadoTextBoxX1.Location = New System.Drawing.Point(476, 258)
        Me.codigoempleadoTextBoxX1.MaxLength = 40
        Me.codigoempleadoTextBoxX1.Name = "codigoempleadoTextBoxX1"
        Me.codigoempleadoTextBoxX1.ReadOnly = True
        Me.codigoempleadoTextBoxX1.Size = New System.Drawing.Size(86, 20)
        Me.codigoempleadoTextBoxX1.TabIndex = 32
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Location = New System.Drawing.Point(357, 254)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(116, 23)
        Me.LabelX17.TabIndex = 31
        Me.LabelX17.Text = "Código de Empleado:"
        '
        'estatusSwitchButton1
        '
        '
        '
        '
        Me.estatusSwitchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.estatusSwitchButton1.Enabled = False
        Me.estatusSwitchButton1.Location = New System.Drawing.Point(120, 298)
        Me.estatusSwitchButton1.Name = "estatusSwitchButton1"
        Me.estatusSwitchButton1.OffText = "Inactivo"
        Me.estatusSwitchButton1.OnText = "Activo"
        Me.estatusSwitchButton1.Size = New System.Drawing.Size(84, 25)
        Me.estatusSwitchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.estatusSwitchButton1.TabIndex = 16
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Location = New System.Drawing.Point(22, 298)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(83, 23)
        Me.LabelX16.TabIndex = 29
        Me.LabelX16.Text = "Estatus"
        Me.LabelX16.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'otrosdatosTextBoxX1
        '
        Me.otrosdatosTextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.otrosdatosTextBoxX1.Border.Class = "TextBoxBorder"
        Me.otrosdatosTextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.otrosdatosTextBoxX1.DisabledBackColor = System.Drawing.Color.White
        Me.otrosdatosTextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.otrosdatosTextBoxX1.Location = New System.Drawing.Point(120, 211)
        Me.otrosdatosTextBoxX1.Multiline = True
        Me.otrosdatosTextBoxX1.Name = "otrosdatosTextBoxX1"
        Me.otrosdatosTextBoxX1.ReadOnly = True
        Me.otrosdatosTextBoxX1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.otrosdatosTextBoxX1.Size = New System.Drawing.Size(225, 53)
        Me.otrosdatosTextBoxX1.TabIndex = 14
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Location = New System.Drawing.Point(22, 211)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(83, 23)
        Me.LabelX15.TabIndex = 28
        Me.LabelX15.Text = "Otros Datos:"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'GroupPanel4
        '
        Me.GroupPanel4.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.propietariolineaTextBoxX5)
        Me.GroupPanel4.Controls.Add(Me.LabelX14)
        Me.GroupPanel4.Controls.Add(Me.lineactualTextBoxX4)
        Me.GroupPanel4.Controls.Add(Me.LabelX13)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Location = New System.Drawing.Point(357, 182)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(284, 68)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 27
        Me.GroupPanel4.Text = "Datos Linea Actual"
        '
        'propietariolineaTextBoxX5
        '
        Me.propietariolineaTextBoxX5.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.propietariolineaTextBoxX5.Border.Class = "TextBoxBorder"
        Me.propietariolineaTextBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.propietariolineaTextBoxX5.DisabledBackColor = System.Drawing.Color.White
        Me.propietariolineaTextBoxX5.ForeColor = System.Drawing.Color.Black
        Me.propietariolineaTextBoxX5.Location = New System.Drawing.Point(104, 24)
        Me.propietariolineaTextBoxX5.Name = "propietariolineaTextBoxX5"
        Me.propietariolineaTextBoxX5.ReadOnly = True
        Me.propietariolineaTextBoxX5.Size = New System.Drawing.Size(166, 20)
        Me.propietariolineaTextBoxX5.TabIndex = 6
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Location = New System.Drawing.Point(106, 4)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(85, 23)
        Me.LabelX14.TabIndex = 5
        Me.LabelX14.Text = "Propietario"
        '
        'lineactualTextBoxX4
        '
        Me.lineactualTextBoxX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lineactualTextBoxX4.Border.Class = "TextBoxBorder"
        Me.lineactualTextBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lineactualTextBoxX4.DisabledBackColor = System.Drawing.Color.White
        Me.lineactualTextBoxX4.ForeColor = System.Drawing.Color.Black
        Me.lineactualTextBoxX4.Location = New System.Drawing.Point(4, 24)
        Me.lineactualTextBoxX4.Name = "lineactualTextBoxX4"
        Me.lineactualTextBoxX4.ReadOnly = True
        Me.lineactualTextBoxX4.Size = New System.Drawing.Size(99, 20)
        Me.lineactualTextBoxX4.TabIndex = 4
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Location = New System.Drawing.Point(4, 4)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(75, 23)
        Me.LabelX13.TabIndex = 0
        Me.LabelX13.Text = "Linea"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.modeloTextBoxX3)
        Me.GroupPanel3.Controls.Add(Me.marcaTextBoxX2)
        Me.GroupPanel3.Controls.Add(Me.imeiactualTextBoxX1)
        Me.GroupPanel3.Controls.Add(Me.LabelX12)
        Me.GroupPanel3.Controls.Add(Me.LabelX11)
        Me.GroupPanel3.Controls.Add(Me.LabelX10)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(357, 100)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(284, 75)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 26
        Me.GroupPanel3.Text = "Datos teléfono Actual"
        '
        'modeloTextBoxX3
        '
        Me.modeloTextBoxX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.modeloTextBoxX3.Border.Class = "TextBoxBorder"
        Me.modeloTextBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.modeloTextBoxX3.DisabledBackColor = System.Drawing.Color.White
        Me.modeloTextBoxX3.ForeColor = System.Drawing.Color.Black
        Me.modeloTextBoxX3.Location = New System.Drawing.Point(192, 31)
        Me.modeloTextBoxX3.Name = "modeloTextBoxX3"
        Me.modeloTextBoxX3.ReadOnly = True
        Me.modeloTextBoxX3.Size = New System.Drawing.Size(78, 20)
        Me.modeloTextBoxX3.TabIndex = 5
        '
        'marcaTextBoxX2
        '
        Me.marcaTextBoxX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.marcaTextBoxX2.Border.Class = "TextBoxBorder"
        Me.marcaTextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.marcaTextBoxX2.DisabledBackColor = System.Drawing.Color.White
        Me.marcaTextBoxX2.ForeColor = System.Drawing.Color.Black
        Me.marcaTextBoxX2.Location = New System.Drawing.Point(104, 31)
        Me.marcaTextBoxX2.Name = "marcaTextBoxX2"
        Me.marcaTextBoxX2.ReadOnly = True
        Me.marcaTextBoxX2.Size = New System.Drawing.Size(87, 20)
        Me.marcaTextBoxX2.TabIndex = 4
        '
        'imeiactualTextBoxX1
        '
        Me.imeiactualTextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.imeiactualTextBoxX1.Border.Class = "TextBoxBorder"
        Me.imeiactualTextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.imeiactualTextBoxX1.DisabledBackColor = System.Drawing.Color.White
        Me.imeiactualTextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.imeiactualTextBoxX1.Location = New System.Drawing.Point(3, 31)
        Me.imeiactualTextBoxX1.Name = "imeiactualTextBoxX1"
        Me.imeiactualTextBoxX1.ReadOnly = True
        Me.imeiactualTextBoxX1.Size = New System.Drawing.Size(100, 20)
        Me.imeiactualTextBoxX1.TabIndex = 3
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(202, 4)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(45, 23)
        Me.LabelX12.TabIndex = 2
        Me.LabelX12.Text = "Modelo"
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(104, 4)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(45, 23)
        Me.LabelX11.TabIndex = 1
        Me.LabelX11.Text = "Marca"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(4, 4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(45, 23)
        Me.LabelX10.TabIndex = 0
        Me.LabelX10.Text = "IMEI"
        '
        'seleccionarButtonX4
        '
        Me.seleccionarButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.seleccionarButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.seleccionarButtonX4.Image = Global.ModuloTelefonos.My.Resources.Resources.ok
        Me.seleccionarButtonX4.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.seleccionarButtonX4.Location = New System.Drawing.Point(647, 3)
        Me.seleccionarButtonX4.Name = "seleccionarButtonX4"
        Me.seleccionarButtonX4.Size = New System.Drawing.Size(87, 31)
        Me.seleccionarButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.seleccionarButtonX4.Symbol = ""
        Me.seleccionarButtonX4.SymbolSize = 12.0!
        Me.seleccionarButtonX4.TabIndex = 25
        Me.seleccionarButtonX4.Text = "Seleccionar"
        Me.seleccionarButtonX4.Visible = False
        '
        'guardarButtonX7
        '
        Me.guardarButtonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.guardarButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.guardarButtonX7.Enabled = False
        Me.guardarButtonX7.Image = Global.ModuloTelefonos.My.Resources.Resources.floppy_disk
        Me.guardarButtonX7.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.guardarButtonX7.Location = New System.Drawing.Point(647, 198)
        Me.guardarButtonX7.Name = "guardarButtonX7"
        Me.guardarButtonX7.Size = New System.Drawing.Size(87, 32)
        Me.guardarButtonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.guardarButtonX7.Symbol = ""
        Me.guardarButtonX7.SymbolSize = 12.0!
        Me.guardarButtonX7.TabIndex = 24
        Me.guardarButtonX7.Text = "&Guardar"
        '
        'eliminarButtonX6
        '
        Me.eliminarButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.eliminarButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.eliminarButtonX6.Image = Global.ModuloTelefonos.My.Resources.Resources.Eliminar2
        Me.eliminarButtonX6.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.eliminarButtonX6.Location = New System.Drawing.Point(647, 166)
        Me.eliminarButtonX6.Name = "eliminarButtonX6"
        Me.eliminarButtonX6.Size = New System.Drawing.Size(87, 32)
        Me.eliminarButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.eliminarButtonX6.Symbol = ""
        Me.eliminarButtonX6.SymbolSize = 12.0!
        Me.eliminarButtonX6.TabIndex = 23
        Me.eliminarButtonX6.Text = "&Eliminar"
        '
        'modificarButtonX5
        '
        Me.modificarButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.modificarButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.modificarButtonX5.Image = Global.ModuloTelefonos.My.Resources.Resources.atencion_revisar
        Me.modificarButtonX5.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.modificarButtonX5.Location = New System.Drawing.Point(647, 134)
        Me.modificarButtonX5.Name = "modificarButtonX5"
        Me.modificarButtonX5.Size = New System.Drawing.Size(87, 32)
        Me.modificarButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.modificarButtonX5.Symbol = ""
        Me.modificarButtonX5.SymbolSize = 12.0!
        Me.modificarButtonX5.TabIndex = 22
        Me.modificarButtonX5.Text = "&Modificar"
        '
        'nuevoButtonX4
        '
        Me.nuevoButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.nuevoButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.nuevoButtonX4.Image = Global.ModuloTelefonos.My.Resources.Resources.nuevo
        Me.nuevoButtonX4.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.nuevoButtonX4.Location = New System.Drawing.Point(647, 102)
        Me.nuevoButtonX4.Name = "nuevoButtonX4"
        Me.nuevoButtonX4.Size = New System.Drawing.Size(87, 32)
        Me.nuevoButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.nuevoButtonX4.Symbol = ""
        Me.nuevoButtonX4.SymbolSize = 12.0!
        Me.nuevoButtonX4.TabIndex = 21
        Me.nuevoButtonX4.Text = "&Nuevo"
        '
        'fechabajaTextBoxX5
        '
        Me.fechabajaTextBoxX5.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.fechabajaTextBoxX5.Border.Class = "TextBoxBorder"
        Me.fechabajaTextBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechabajaTextBoxX5.DisabledBackColor = System.Drawing.Color.White
        Me.fechabajaTextBoxX5.ForeColor = System.Drawing.Color.Black
        Me.fechabajaTextBoxX5.Location = New System.Drawing.Point(451, 74)
        Me.fechabajaTextBoxX5.Name = "fechabajaTextBoxX5"
        Me.fechabajaTextBoxX5.ReadOnly = True
        Me.fechabajaTextBoxX5.Size = New System.Drawing.Size(100, 20)
        Me.fechabajaTextBoxX5.TabIndex = 20
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(353, 72)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(92, 23)
        Me.LabelX9.TabIndex = 19
        Me.LabelX9.Text = "Fecha de Baja:"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'fechaingresoTextBoxX4
        '
        Me.fechaingresoTextBoxX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.fechaingresoTextBoxX4.Border.Class = "TextBoxBorder"
        Me.fechaingresoTextBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaingresoTextBoxX4.DisabledBackColor = System.Drawing.Color.White
        Me.fechaingresoTextBoxX4.ForeColor = System.Drawing.Color.Black
        Me.fechaingresoTextBoxX4.Location = New System.Drawing.Point(451, 48)
        Me.fechaingresoTextBoxX4.Name = "fechaingresoTextBoxX4"
        Me.fechaingresoTextBoxX4.ReadOnly = True
        Me.fechaingresoTextBoxX4.Size = New System.Drawing.Size(100, 20)
        Me.fechaingresoTextBoxX4.TabIndex = 18
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(353, 45)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(92, 23)
        Me.LabelX8.TabIndex = 17
        Me.LabelX8.Text = "Fecha de Ingreso:"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(322, 182)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(23, 20)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 16
        Me.ButtonX3.Text = "+"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(322, 156)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(23, 20)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 15
        Me.ButtonX2.Text = "+"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(322, 129)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(23, 20)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 14
        Me.ButtonX1.Text = "+"
        '
        'cargoComboBoxEx3
        '
        Me.cargoComboBoxEx3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cargoComboBoxEx3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cargoComboBoxEx3.DisplayMember = "Text"
        Me.cargoComboBoxEx3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cargoComboBoxEx3.Enabled = False
        Me.cargoComboBoxEx3.FormattingEnabled = True
        Me.cargoComboBoxEx3.ItemHeight = 14
        Me.cargoComboBoxEx3.Location = New System.Drawing.Point(120, 183)
        Me.cargoComboBoxEx3.Name = "cargoComboBoxEx3"
        Me.cargoComboBoxEx3.Size = New System.Drawing.Size(200, 20)
        Me.cargoComboBoxEx3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cargoComboBoxEx3.TabIndex = 13
        '
        'departamentoComboBoxEx2
        '
        Me.departamentoComboBoxEx2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.departamentoComboBoxEx2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.departamentoComboBoxEx2.DisplayMember = "Text"
        Me.departamentoComboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.departamentoComboBoxEx2.Enabled = False
        Me.departamentoComboBoxEx2.FormattingEnabled = True
        Me.departamentoComboBoxEx2.ItemHeight = 14
        Me.departamentoComboBoxEx2.Location = New System.Drawing.Point(120, 156)
        Me.departamentoComboBoxEx2.Name = "departamentoComboBoxEx2"
        Me.departamentoComboBoxEx2.Size = New System.Drawing.Size(200, 20)
        Me.departamentoComboBoxEx2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.departamentoComboBoxEx2.TabIndex = 12
        '
        'empresaComboBoxEx1
        '
        Me.empresaComboBoxEx1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.empresaComboBoxEx1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.empresaComboBoxEx1.DisplayMember = "Text"
        Me.empresaComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.empresaComboBoxEx1.Enabled = False
        Me.empresaComboBoxEx1.FormattingEnabled = True
        Me.empresaComboBoxEx1.ItemHeight = 14
        Me.empresaComboBoxEx1.Location = New System.Drawing.Point(120, 129)
        Me.empresaComboBoxEx1.Name = "empresaComboBoxEx1"
        Me.empresaComboBoxEx1.Size = New System.Drawing.Size(200, 20)
        Me.empresaComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.empresaComboBoxEx1.TabIndex = 11
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(22, 182)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(83, 23)
        Me.LabelX7.TabIndex = 10
        Me.LabelX7.Text = "Cargo:"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(22, 155)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(83, 23)
        Me.LabelX6.TabIndex = 9
        Me.LabelX6.Text = "Departamento:"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(22, 128)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(83, 23)
        Me.LabelX5.TabIndex = 8
        Me.LabelX5.Text = "Empresa:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'apellidosTextBoxX3
        '
        Me.apellidosTextBoxX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.apellidosTextBoxX3.Border.Class = "TextBoxBorder"
        Me.apellidosTextBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.apellidosTextBoxX3.DisabledBackColor = System.Drawing.Color.White
        Me.apellidosTextBoxX3.ForeColor = System.Drawing.Color.Black
        Me.apellidosTextBoxX3.Location = New System.Drawing.Point(120, 102)
        Me.apellidosTextBoxX3.MaxLength = 40
        Me.apellidosTextBoxX3.Name = "apellidosTextBoxX3"
        Me.apellidosTextBoxX3.ReadOnly = True
        Me.apellidosTextBoxX3.Size = New System.Drawing.Size(225, 20)
        Me.apellidosTextBoxX3.TabIndex = 7
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(22, 101)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(83, 23)
        Me.LabelX4.TabIndex = 6
        Me.LabelX4.Text = "Apellidos:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'nombresTextBoxX2
        '
        Me.nombresTextBoxX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.nombresTextBoxX2.Border.Class = "TextBoxBorder"
        Me.nombresTextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.nombresTextBoxX2.DisabledBackColor = System.Drawing.Color.White
        Me.nombresTextBoxX2.ForeColor = System.Drawing.Color.Black
        Me.nombresTextBoxX2.Location = New System.Drawing.Point(120, 75)
        Me.nombresTextBoxX2.MaxLength = 40
        Me.nombresTextBoxX2.Name = "nombresTextBoxX2"
        Me.nombresTextBoxX2.ReadOnly = True
        Me.nombresTextBoxX2.Size = New System.Drawing.Size(225, 20)
        Me.nombresTextBoxX2.TabIndex = 5
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(22, 74)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(83, 23)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Nombres:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(22, 47)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(83, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Id Propietario:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'idpropietarioTextBoxX1
        '
        Me.idpropietarioTextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.idpropietarioTextBoxX1.Border.Class = "TextBoxBorder"
        Me.idpropietarioTextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.idpropietarioTextBoxX1.DisabledBackColor = System.Drawing.Color.White
        Me.idpropietarioTextBoxX1.Enabled = False
        Me.idpropietarioTextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.idpropietarioTextBoxX1.Location = New System.Drawing.Point(120, 48)
        Me.idpropietarioTextBoxX1.Name = "idpropietarioTextBoxX1"
        Me.idpropietarioTextBoxX1.Size = New System.Drawing.Size(100, 20)
        Me.idpropietarioTextBoxX1.TabIndex = 2
        '
        'localizarTextBoxX1
        '
        Me.localizarTextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.localizarTextBoxX1.Border.Class = "TextBoxBorder"
        Me.localizarTextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.localizarTextBoxX1.DisabledBackColor = System.Drawing.Color.White
        Me.localizarTextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.localizarTextBoxX1.Location = New System.Drawing.Point(120, 11)
        Me.localizarTextBoxX1.Name = "localizarTextBoxX1"
        Me.localizarTextBoxX1.Size = New System.Drawing.Size(455, 20)
        Me.localizarTextBoxX1.TabIndex = 1
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(22, 11)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(83, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Localizar:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'frmPropietarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 607)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPropietarios"
        Me.Text = "frmPropietarios"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents id_propietario As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents fecha_ingreso As DataGridViewTextBoxColumn
    Friend WithEvents fecha_baja As DataGridViewTextBoxColumn
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rutaTextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents codigoempleadoTextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents estatusSwitchButton1 As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents otrosdatosTextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents propietariolineaTextBoxX5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lineactualTextBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents modeloTextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents marcaTextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents imeiactualTextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents seleccionarButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents guardarButtonX7 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents eliminarButtonX6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents modificarButtonX5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents nuevoButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents fechabajaTextBoxX5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents fechaingresoTextBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cargoComboBoxEx3 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents departamentoComboBoxEx2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents empresaComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents apellidosTextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents nombresTextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents idpropietarioTextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents localizarTextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents duiMaskedTextBox1 As MaskedTextBox
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
End Class
