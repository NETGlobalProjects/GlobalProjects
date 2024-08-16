<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotesTelefonos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.escrituraButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.lecturaButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.notasTextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.totalLabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.seleccionarButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.DataGridViewX2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.imei = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_marca = New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_so = New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn()
        Me.version_so = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_ingreso = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.fecha_asignacion = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.id_usuario_actual = New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn()
        Me.numero_linea_propietario = New DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn()
        Me.nombre_propietario = New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn()
        Me.numero_linea_actual = New DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn()
        Me.fecha_baja = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.id_estado = New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn()
        Me.notas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vacio_01 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn()
        Me.documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detalles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.ButtonX2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel3)
        Me.PanelEx1.Controls.Add(Me.GroupPanel2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1235, 700)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.ButtonX2.Location = New System.Drawing.Point(940, 16)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(173, 34)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 3
        Me.ButtonX2.Text = "&Actualizar Listas"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.escrituraButtonX4)
        Me.GroupPanel3.Controls.Add(Me.lecturaButtonX3)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(12, 4)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(194, 63)
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
        Me.GroupPanel3.TabIndex = 2
        Me.GroupPanel3.Text = "Modo"
        '
        'escrituraButtonX4
        '
        Me.escrituraButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.escrituraButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.escrituraButtonX4.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.escrituraButtonX4.Location = New System.Drawing.Point(88, 7)
        Me.escrituraButtonX4.Name = "escrituraButtonX4"
        Me.escrituraButtonX4.Size = New System.Drawing.Size(97, 32)
        Me.escrituraButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.escrituraButtonX4.TabIndex = 1
        Me.escrituraButtonX4.Text = "Escritura"
        '
        'lecturaButtonX3
        '
        Me.lecturaButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.lecturaButtonX3.Checked = True
        Me.lecturaButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.lecturaButtonX3.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.lecturaButtonX3.Location = New System.Drawing.Point(7, 7)
        Me.lecturaButtonX3.Name = "lecturaButtonX3"
        Me.lecturaButtonX3.Size = New System.Drawing.Size(75, 32)
        Me.lecturaButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.lecturaButtonX3.TabIndex = 0
        Me.lecturaButtonX3.Text = "Lectura"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.notasTextBoxX2)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.totalLabelX3)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        Me.GroupPanel2.Controls.Add(Me.seleccionarButtonX2)
        Me.GroupPanel2.Controls.Add(Me.ButtonX1)
        Me.GroupPanel2.Controls.Add(Me.TextBoxX1)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.Controls.Add(Me.LinkLabel3)
        Me.GroupPanel2.Controls.Add(Me.LinkLabel4)
        Me.GroupPanel2.Controls.Add(Me.DataGridViewX2)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(7, 278)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1225, 419)
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
        Me.GroupPanel2.Text = "Telefonos"
        '
        'notasTextBoxX2
        '
        Me.notasTextBoxX2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.notasTextBoxX2.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.notasTextBoxX2.Border.Class = "TextBoxBorder"
        Me.notasTextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.notasTextBoxX2.Location = New System.Drawing.Point(798, 3)
        Me.notasTextBoxX2.Multiline = True
        Me.notasTextBoxX2.Name = "notasTextBoxX2"
        Me.notasTextBoxX2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.notasTextBoxX2.Size = New System.Drawing.Size(103, 30)
        Me.notasTextBoxX2.TabIndex = 12
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(747, 10)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 11
        Me.LabelX3.Text = "Notas:"
        '
        'totalLabelX3
        '
        '
        '
        '
        Me.totalLabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.totalLabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabelX3.Location = New System.Drawing.Point(683, 9)
        Me.totalLabelX3.Name = "totalLabelX3"
        Me.totalLabelX3.Size = New System.Drawing.Size(42, 23)
        Me.totalLabelX3.TabIndex = 10
        Me.totalLabelX3.Text = "0"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(646, 9)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(50, 23)
        Me.LabelX2.TabIndex = 9
        Me.LabelX2.Text = "Total:"
        '
        'seleccionarButtonX2
        '
        Me.seleccionarButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.seleccionarButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.seleccionarButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.seleccionarButtonX2.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.seleccionarButtonX2.Location = New System.Drawing.Point(924, 3)
        Me.seleccionarButtonX2.Name = "seleccionarButtonX2"
        Me.seleccionarButtonX2.Size = New System.Drawing.Size(173, 29)
        Me.seleccionarButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.seleccionarButtonX2.TabIndex = 8
        Me.seleccionarButtonX2.Text = "Seleccionar"
        Me.seleccionarButtonX2.Visible = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.Location = New System.Drawing.Point(457, 10)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(122, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 7
        Me.ButtonX1.Text = "Búsqueda Avanzada"
        Me.ButtonX1.Visible = False
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX1.Location = New System.Drawing.Point(53, 6)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(398, 26)
        Me.TextBoxX1.TabIndex = 6
        Me.TextBoxX1.WatermarkText = "Realice una búsqueda x IMEI o nombre de usuario actual"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(8, 10)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(55, 23)
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "Buscar:"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(1172, 19)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(35, 13)
        Me.LinkLabel3.TabIndex = 4
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Quitar"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(1129, 19)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(37, 13)
        Me.LinkLabel4.TabIndex = 3
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Añadir"
        '
        'DataGridViewX2
        '
        Me.DataGridViewX2.AllowUserToAddRows = False
        Me.DataGridViewX2.AllowUserToDeleteRows = False
        Me.DataGridViewX2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewX2.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.imei, Me.serie, Me.id_marca, Me.modelo, Me.id_so, Me.version_so, Me.t_lote, Me.fecha_ingreso, Me.fecha_asignacion, Me.id_usuario_actual, Me.numero_linea_propietario, Me.nombre_propietario, Me.numero_linea_actual, Me.fecha_baja, Me.id_estado, Me.notas, Me.vacio_01})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX2.EnableHeadersVisualStyles = False
        Me.DataGridViewX2.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX2.Location = New System.Drawing.Point(6, 39)
        Me.DataGridViewX2.Name = "DataGridViewX2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX2.Size = New System.Drawing.Size(1204, 335)
        Me.DataGridViewX2.TabIndex = 1
        '
        'imei
        '
        Me.imei.DataPropertyName = "imei"
        Me.imei.HeaderText = "IMEI"
        Me.imei.MaxInputLength = 20
        Me.imei.Name = "imei"
        Me.imei.Width = 113
        '
        'serie
        '
        Me.serie.DataPropertyName = "serie"
        Me.serie.HeaderText = "Serie"
        Me.serie.MaxInputLength = 20
        Me.serie.Name = "serie"
        Me.serie.Width = 110
        '
        'id_marca
        '
        Me.id_marca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.id_marca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.id_marca.DataPropertyName = "id_marca"
        Me.id_marca.DropDownHeight = 106
        Me.id_marca.DropDownWidth = 121
        Me.id_marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.id_marca.HeaderText = "Marca"
        Me.id_marca.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.id_marca.IntegralHeight = False
        Me.id_marca.ItemHeight = 15
        Me.id_marca.Name = "id_marca"
        Me.id_marca.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id_marca.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'modelo
        '
        Me.modelo.DataPropertyName = "modelo"
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.MaxInputLength = 20
        Me.modelo.Name = "modelo"
        '
        'id_so
        '
        Me.id_so.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.id_so.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.id_so.DataPropertyName = "id_so"
        Me.id_so.DropDownHeight = 106
        Me.id_so.DropDownWidth = 121
        Me.id_so.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.id_so.HeaderText = "Sistema Operativo"
        Me.id_so.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.id_so.IntegralHeight = False
        Me.id_so.ItemHeight = 15
        Me.id_so.Name = "id_so"
        Me.id_so.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'version_so
        '
        Me.version_so.DataPropertyName = "version_so"
        Me.version_so.HeaderText = "Version SO"
        Me.version_so.MaxInputLength = 10
        Me.version_so.Name = "version_so"
        Me.version_so.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.version_so.Width = 60
        '
        't_lote
        '
        Me.t_lote.DataPropertyName = "lote"
        Me.t_lote.HeaderText = "Lote"
        Me.t_lote.MaxInputLength = 8
        Me.t_lote.Name = "t_lote"
        Me.t_lote.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.t_lote.Width = 80
        '
        'fecha_ingreso
        '
        Me.fecha_ingreso.AutoAdvance = True
        '
        '
        '
        Me.fecha_ingreso.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.fecha_ingreso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha_ingreso.DataPropertyName = "fecha_ingreso"
        Me.fecha_ingreso.HeaderText = "Fecha de Ingreso"
        Me.fecha_ingreso.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.fecha_ingreso.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fecha_ingreso.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha_ingreso.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.fecha_ingreso.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha_ingreso.MonthCalendar.DisplayMonth = New Date(2018, 12, 1, 0, 0, 0, 0)
        Me.fecha_ingreso.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.fecha_ingreso.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fecha_ingreso.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha_ingreso.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.fecha_ingreso.Name = "fecha_ingreso"
        Me.fecha_ingreso.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fecha_ingreso.Width = 80
        '
        'fecha_asignacion
        '
        Me.fecha_asignacion.AutoAdvance = True
        '
        '
        '
        Me.fecha_asignacion.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.fecha_asignacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha_asignacion.DataPropertyName = "fecha_asignacion"
        Me.fecha_asignacion.HeaderText = "Fecha de Asignacion"
        Me.fecha_asignacion.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.fecha_asignacion.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fecha_asignacion.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha_asignacion.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.fecha_asignacion.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha_asignacion.MonthCalendar.DisplayMonth = New Date(2018, 12, 1, 0, 0, 0, 0)
        Me.fecha_asignacion.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.fecha_asignacion.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fecha_asignacion.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha_asignacion.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.fecha_asignacion.Name = "fecha_asignacion"
        Me.fecha_asignacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fecha_asignacion.Width = 80
        '
        'id_usuario_actual
        '
        Me.id_usuario_actual.DataPropertyName = "id_usuario_actual"
        Me.id_usuario_actual.DropDownHeight = 106
        Me.id_usuario_actual.DropDownWidth = 121
        Me.id_usuario_actual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.id_usuario_actual.HeaderText = "Usuario Actual"
        Me.id_usuario_actual.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.id_usuario_actual.IntegralHeight = False
        Me.id_usuario_actual.ItemHeight = 15
        Me.id_usuario_actual.MaxInputLength = 10
        Me.id_usuario_actual.Name = "id_usuario_actual"
        Me.id_usuario_actual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.id_usuario_actual.Width = 150
        '
        'numero_linea_propietario
        '
        Me.numero_linea_propietario.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.numero_linea_propietario.BackgroundStyle.Class = "DataGridViewBorder"
        Me.numero_linea_propietario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.numero_linea_propietario.Culture = New System.Globalization.CultureInfo("es-PA")
        Me.numero_linea_propietario.DataPropertyName = "numero_linea_propietario"
        Me.numero_linea_propietario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.numero_linea_propietario.HeaderText = "Numero Propietario"
        Me.numero_linea_propietario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.numero_linea_propietario.Mask = "####-####"
        Me.numero_linea_propietario.Name = "numero_linea_propietario"
        Me.numero_linea_propietario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.numero_linea_propietario.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.numero_linea_propietario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numero_linea_propietario.Text = "    -"
        Me.numero_linea_propietario.Width = 80
        '
        'nombre_propietario
        '
        Me.nombre_propietario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.nombre_propietario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.nombre_propietario.DataPropertyName = "nombre_propietario"
        Me.nombre_propietario.DropDownHeight = 106
        Me.nombre_propietario.DropDownWidth = 121
        Me.nombre_propietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nombre_propietario.HeaderText = "Nombre del Propietario"
        Me.nombre_propietario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nombre_propietario.IntegralHeight = False
        Me.nombre_propietario.ItemHeight = 15
        Me.nombre_propietario.Name = "nombre_propietario"
        Me.nombre_propietario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nombre_propietario.Width = 175
        '
        'numero_linea_actual
        '
        Me.numero_linea_actual.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.numero_linea_actual.BackgroundStyle.Class = "DataGridViewBorder"
        Me.numero_linea_actual.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.numero_linea_actual.Culture = New System.Globalization.CultureInfo("es-PA")
        Me.numero_linea_actual.DataPropertyName = "numero_linea_actual"
        Me.numero_linea_actual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.numero_linea_actual.HeaderText = "Numero Actual"
        Me.numero_linea_actual.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.numero_linea_actual.Mask = "####-####"
        Me.numero_linea_actual.Name = "numero_linea_actual"
        Me.numero_linea_actual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.numero_linea_actual.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.numero_linea_actual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numero_linea_actual.Text = "    -"
        Me.numero_linea_actual.Width = 80
        '
        'fecha_baja
        '
        Me.fecha_baja.AutoAdvance = True
        '
        '
        '
        Me.fecha_baja.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.fecha_baja.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha_baja.DataPropertyName = "fecha_baja"
        Me.fecha_baja.HeaderText = "Fecha de Baja"
        Me.fecha_baja.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.fecha_baja.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fecha_baja.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha_baja.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.fecha_baja.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha_baja.MonthCalendar.DisplayMonth = New Date(2018, 12, 1, 0, 0, 0, 0)
        Me.fecha_baja.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.fecha_baja.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fecha_baja.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha_baja.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.fecha_baja.Name = "fecha_baja"
        Me.fecha_baja.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fecha_baja.Width = 80
        '
        'id_estado
        '
        Me.id_estado.DataPropertyName = "id_estado_telefono"
        Me.id_estado.DropDownHeight = 106
        Me.id_estado.DropDownWidth = 121
        Me.id_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.id_estado.HeaderText = "Estado"
        Me.id_estado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.id_estado.IntegralHeight = False
        Me.id_estado.ItemHeight = 15
        Me.id_estado.Name = "id_estado"
        Me.id_estado.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'notas
        '
        Me.notas.DataPropertyName = "notas"
        Me.notas.HeaderText = "notas"
        Me.notas.MaxInputLength = 500
        Me.notas.Name = "notas"
        Me.notas.Width = 300
        '
        'vacio_01
        '
        Me.vacio_01.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vacio_01.HeaderText = " "
        Me.vacio_01.Name = "vacio_01"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LinkLabel2)
        Me.GroupPanel1.Controls.Add(Me.LinkLabel1)
        Me.GroupPanel1.Controls.Add(Me.DataGridViewX1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 56)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1220, 214)
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
        Me.GroupPanel1.Text = "Lotes"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(1167, -2)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(35, 13)
        Me.LinkLabel2.TabIndex = 2
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Quitar"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1124, -2)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(37, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Añadir"
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewX1.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lote, Me.fecha, Me.mes, Me.tipo, Me.documento, Me.cantidad, Me.costo, Me.detalles})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewX1.EnableHeadersVisualStyles = False
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(3, 10)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewX1.Size = New System.Drawing.Size(1199, 159)
        Me.DataGridViewX1.TabIndex = 0
        '
        'lote
        '
        Me.lote.DataPropertyName = "lote"
        Me.lote.HeaderText = "Lote"
        Me.lote.MaxInputLength = 8
        Me.lote.Name = "lote"
        Me.lote.Width = 80
        '
        'fecha
        '
        Me.fecha.AutoAdvance = True
        '
        '
        '
        Me.fecha.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.fecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.fecha.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.fecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha.MonthCalendar.DisplayMonth = New Date(2018, 12, 1, 0, 0, 0, 0)
        Me.fecha.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.fecha.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.fecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.fecha.Name = "fecha"
        Me.fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fecha.Width = 80
        '
        'mes
        '
        Me.mes.DataPropertyName = "mes"
        Me.mes.HeaderText = "Mes"
        Me.mes.MaxInputLength = 5
        Me.mes.Name = "mes"
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "tipo"
        Me.tipo.DisplayMember = "Text"
        Me.tipo.DropDownHeight = 106
        Me.tipo.DropDownWidth = 121
        Me.tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tipo.IntegralHeight = False
        Me.tipo.ItemHeight = 15
        Me.tipo.MaxInputLength = 20
        Me.tipo.Name = "tipo"
        Me.tipo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'documento
        '
        Me.documento.DataPropertyName = "documento"
        Me.documento.HeaderText = "Documento"
        Me.documento.MaxInputLength = 20
        Me.documento.Name = "documento"
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'costo
        '
        Me.costo.DataPropertyName = "costo"
        Me.costo.HeaderText = "Costo"
        Me.costo.Name = "costo"
        '
        'detalles
        '
        Me.detalles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.detalles.DataPropertyName = "detalles_adicionales"
        Me.detalles.HeaderText = "Detalles adicionales"
        Me.detalles.MaxInputLength = 1000
        Me.detalles.Name = "detalles"
        '
        'frmLotesTelefonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 700)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Name = "frmLotesTelefonos"
        Me.Text = "frmLotesTelefonos"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents escrituraButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lecturaButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents notasTextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents totalLabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents seleccionarButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents DataGridViewX2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents imei As DataGridViewTextBoxColumn
    Friend WithEvents serie As DataGridViewTextBoxColumn
    Friend WithEvents id_marca As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Friend WithEvents modelo As DataGridViewTextBoxColumn
    Friend WithEvents id_so As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Friend WithEvents version_so As DataGridViewTextBoxColumn
    Friend WithEvents t_lote As DataGridViewTextBoxColumn
    Friend WithEvents fecha_ingreso As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents fecha_asignacion As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents id_usuario_actual As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Friend WithEvents numero_linea_propietario As DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn
    Friend WithEvents nombre_propietario As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Friend WithEvents numero_linea_actual As DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn
    Friend WithEvents fecha_baja As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents id_estado As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Friend WithEvents notas As DataGridViewTextBoxColumn
    Friend WithEvents vacio_01 As DataGridViewTextBoxColumn
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents lote As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents mes As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Friend WithEvents documento As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents costo As DataGridViewTextBoxColumn
    Friend WithEvents detalles As DataGridViewTextBoxColumn
End Class
