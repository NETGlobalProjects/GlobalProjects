<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscarNomina
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.nominasDgv = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.buscarBtn = New DevComponents.DotNetBar.ButtonX()
        Me.filtroCbx = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.busquedaTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.direccionTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.centroCostosTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.fechaIngTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.idCargoTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.idDepartamentoTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.departamentoTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.cargoTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.telefonoTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.duiTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dealerTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.idDealerTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.nombreTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.codigoEmpleadoTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cancelarBtn = New DevComponents.DotNetBar.ButtonX()
        Me.seleccionarBtn = New DevComponents.DotNetBar.ButtonX()
        Me.codEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dui = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vacio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.nominasDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupPanel2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.GroupPanel3)
        Me.PanelEx1.Controls.Add(Me.GroupPanel4)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(714, 607)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 5
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.nominasDgv)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 50)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(714, 360)
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
        '
        'nominasDgv
        '
        Me.nominasDgv.AllowUserToAddRows = False
        Me.nominasDgv.AllowUserToDeleteRows = False
        Me.nominasDgv.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nominasDgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.nominasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.nominasDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codEmpleado, Me.nombres, Me.apellidos, Me.dui, Me.fechaIngreso, Me.vacio})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nominasDgv.DefaultCellStyle = DataGridViewCellStyle11
        Me.nominasDgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nominasDgv.EnableHeadersVisualStyles = False
        Me.nominasDgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.nominasDgv.Location = New System.Drawing.Point(0, 0)
        Me.nominasDgv.Name = "nominasDgv"
        Me.nominasDgv.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nominasDgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.nominasDgv.RowHeadersWidth = 21
        Me.nominasDgv.Size = New System.Drawing.Size(708, 354)
        Me.nominasDgv.TabIndex = 0
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Panel2)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(714, 50)
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
        Me.GroupPanel1.TabIndex = 2
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(398, 12)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(52, 20)
        Me.LabelX2.SymbolColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelX2.SymbolSize = 15.0!
        Me.LabelX2.TabIndex = 28
        Me.LabelX2.Text = "Filtrar por:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'buscarBtn
        '
        Me.buscarBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buscarBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.buscarBtn.Image = Global.ModuloTelefonos.My.Resources.Resources.atencion_revisar
        Me.buscarBtn.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.buscarBtn.Location = New System.Drawing.Point(592, 12)
        Me.buscarBtn.Name = "buscarBtn"
        Me.buscarBtn.Size = New System.Drawing.Size(96, 20)
        Me.buscarBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.buscarBtn.Symbol = "59574"
        Me.buscarBtn.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.buscarBtn.SymbolSize = 12.0!
        Me.buscarBtn.TabIndex = 27
        Me.buscarBtn.Text = "&Buscar"
        '
        'filtroCbx
        '
        Me.filtroCbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.filtroCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.filtroCbx.DisplayMember = "Text"
        Me.filtroCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.filtroCbx.ForeColor = System.Drawing.Color.Black
        Me.filtroCbx.FormattingEnabled = True
        Me.filtroCbx.ItemHeight = 14
        Me.filtroCbx.Location = New System.Drawing.Point(453, 12)
        Me.filtroCbx.Name = "filtroCbx"
        Me.filtroCbx.Size = New System.Drawing.Size(133, 20)
        Me.filtroCbx.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.filtroCbx.TabIndex = 12
        Me.filtroCbx.WatermarkText = "-- Seleccionar --"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(3, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(100, 20)
        Me.LabelX1.SymbolColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelX1.SymbolSize = 15.0!
        Me.LabelX1.TabIndex = 3
        Me.LabelX1.Text = "Buscar como:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'busquedaTxt
        '
        Me.busquedaTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.busquedaTxt.Border.Class = "TextBoxBorder"
        Me.busquedaTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.busquedaTxt.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.busquedaTxt.ForeColor = System.Drawing.Color.Black
        Me.busquedaTxt.Location = New System.Drawing.Point(106, 12)
        Me.busquedaTxt.Name = "busquedaTxt"
        Me.busquedaTxt.Size = New System.Drawing.Size(276, 20)
        Me.busquedaTxt.TabIndex = 2
        Me.busquedaTxt.WatermarkText = "Escriba aquí..."
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.Panel1)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel3.Location = New System.Drawing.Point(0, 410)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(714, 153)
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
        Me.GroupPanel3.TabIndex = 3
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LabelX14.Location = New System.Drawing.Point(617, 116)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(70, 20)
        Me.LabelX14.SymbolColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelX14.SymbolSize = 15.0!
        Me.LabelX14.TabIndex = 26
        Me.LabelX14.Text = "estatus activo"
        Me.LabelX14.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.ForeColor = System.Drawing.Color.DimGray
        Me.LabelX13.Location = New System.Drawing.Point(455, 116)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(161, 20)
        Me.LabelX13.Symbol = ""
        Me.LabelX13.SymbolColor = System.Drawing.Color.DimGray
        Me.LabelX13.SymbolSize = 12.0!
        Me.LabelX13.TabIndex = 25
        Me.LabelX13.Text = "Muestra solo empleados con"
        Me.LabelX13.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(21, 38)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(96, 20)
        Me.LabelX12.SymbolColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelX12.SymbolSize = 15.0!
        Me.LabelX12.TabIndex = 24
        Me.LabelX12.Text = "Dirección:"
        Me.LabelX12.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'direccionTxt
        '
        Me.direccionTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.direccionTxt.Border.Class = "TextBoxBorder"
        Me.direccionTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.direccionTxt.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.direccionTxt.ForeColor = System.Drawing.Color.Black
        Me.direccionTxt.Location = New System.Drawing.Point(120, 38)
        Me.direccionTxt.Name = "direccionTxt"
        Me.direccionTxt.ReadOnly = True
        Me.direccionTxt.Size = New System.Drawing.Size(568, 20)
        Me.direccionTxt.TabIndex = 23
        Me.direccionTxt.WatermarkText = "..."
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(459, 64)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(92, 20)
        Me.LabelX11.SymbolColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelX11.SymbolSize = 15.0!
        Me.LabelX11.TabIndex = 22
        Me.LabelX11.Text = "Centro de Costos:"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'centroCostosTxt
        '
        Me.centroCostosTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.centroCostosTxt.Border.Class = "TextBoxBorder"
        Me.centroCostosTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.centroCostosTxt.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.centroCostosTxt.ForeColor = System.Drawing.Color.Black
        Me.centroCostosTxt.Location = New System.Drawing.Point(557, 64)
        Me.centroCostosTxt.Name = "centroCostosTxt"
        Me.centroCostosTxt.ReadOnly = True
        Me.centroCostosTxt.Size = New System.Drawing.Size(131, 20)
        Me.centroCostosTxt.TabIndex = 21
        Me.centroCostosTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.centroCostosTxt.WatermarkText = "..."
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(459, 90)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(92, 20)
        Me.LabelX10.SymbolColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelX10.SymbolSize = 15.0!
        Me.LabelX10.TabIndex = 20
        Me.LabelX10.Text = "Fecha Ingreso:"
        Me.LabelX10.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'fechaIngTxt
        '
        Me.fechaIngTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.fechaIngTxt.Border.Class = "TextBoxBorder"
        Me.fechaIngTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fechaIngTxt.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.fechaIngTxt.ForeColor = System.Drawing.Color.Black
        Me.fechaIngTxt.Location = New System.Drawing.Point(557, 90)
        Me.fechaIngTxt.Name = "fechaIngTxt"
        Me.fechaIngTxt.ReadOnly = True
        Me.fechaIngTxt.Size = New System.Drawing.Size(131, 20)
        Me.fechaIngTxt.TabIndex = 19
        Me.fechaIngTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.fechaIngTxt.WatermarkText = "..."
        '
        'idCargoTxt
        '
        Me.idCargoTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.idCargoTxt.Border.Class = "TextBoxBorder"
        Me.idCargoTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.idCargoTxt.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.idCargoTxt.ForeColor = System.Drawing.Color.Black
        Me.idCargoTxt.Location = New System.Drawing.Point(120, 64)
        Me.idCargoTxt.Name = "idCargoTxt"
        Me.idCargoTxt.ReadOnly = True
        Me.idCargoTxt.Size = New System.Drawing.Size(51, 20)
        Me.idCargoTxt.TabIndex = 18
        Me.idCargoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.idCargoTxt.WatermarkText = "#"
        '
        'idDepartamentoTxt
        '
        Me.idDepartamentoTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.idDepartamentoTxt.Border.Class = "TextBoxBorder"
        Me.idDepartamentoTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.idDepartamentoTxt.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.idDepartamentoTxt.ForeColor = System.Drawing.Color.Black
        Me.idDepartamentoTxt.Location = New System.Drawing.Point(120, 90)
        Me.idDepartamentoTxt.Name = "idDepartamentoTxt"
        Me.idDepartamentoTxt.ReadOnly = True
        Me.idDepartamentoTxt.Size = New System.Drawing.Size(51, 20)
        Me.idDepartamentoTxt.TabIndex = 17
        Me.idDepartamentoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.idDepartamentoTxt.WatermarkText = "#"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(37, 90)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(80, 20)
        Me.LabelX9.SymbolColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelX9.SymbolSize = 15.0!
        Me.LabelX9.TabIndex = 16
        Me.LabelX9.Text = "Departamento:"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'departamentoTxt
        '
        Me.departamentoTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.departamentoTxt.Border.Class = "TextBoxBorder"
        Me.departamentoTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.departamentoTxt.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.departamentoTxt.ForeColor = System.Drawing.Color.Black
        Me.departamentoTxt.Location = New System.Drawing.Point(174, 90)
        Me.departamentoTxt.Name = "departamentoTxt"
        Me.departamentoTxt.ReadOnly = True
        Me.departamentoTxt.Size = New System.Drawing.Size(262, 20)
        Me.departamentoTxt.TabIndex = 15
        Me.departamentoTxt.WatermarkText = "..."
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(21, 64)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(96, 20)
        Me.LabelX8.SymbolColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelX8.SymbolSize = 15.0!
        Me.LabelX8.TabIndex = 14
        Me.LabelX8.Text = "Cargo:"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cargoTxt
        '
        Me.cargoTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.cargoTxt.Border.Class = "TextBoxBorder"
        Me.cargoTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cargoTxt.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cargoTxt.ForeColor = System.Drawing.Color.Black
        Me.cargoTxt.Location = New System.Drawing.Point(174, 64)
        Me.cargoTxt.Name = "cargoTxt"
        Me.cargoTxt.ReadOnly = True
        Me.cargoTxt.Size = New System.Drawing.Size(262, 20)
        Me.cargoTxt.TabIndex = 13
        Me.cargoTxt.WatermarkText = "..."
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(275, 116)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(48, 20)
        Me.LabelX7.SymbolColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelX7.SymbolSize = 15.0!
        Me.LabelX7.TabIndex = 12
        Me.LabelX7.Text = "Teléfono:"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'telefonoTxt
        '
        Me.telefonoTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.telefonoTxt.Border.Class = "TextBoxBorder"
        Me.telefonoTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.telefonoTxt.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.telefonoTxt.ForeColor = System.Drawing.Color.Black
        Me.telefonoTxt.Location = New System.Drawing.Point(326, 116)
        Me.telefonoTxt.Name = "telefonoTxt"
        Me.telefonoTxt.ReadOnly = True
        Me.telefonoTxt.Size = New System.Drawing.Size(110, 20)
        Me.telefonoTxt.TabIndex = 11
        Me.telefonoTxt.WatermarkText = "..."
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(78, 116)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(39, 20)
        Me.LabelX6.SymbolColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelX6.SymbolSize = 15.0!
        Me.LabelX6.TabIndex = 10
        Me.LabelX6.Text = "DUI:"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'duiTxt
        '
        Me.duiTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.duiTxt.Border.Class = "TextBoxBorder"
        Me.duiTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.duiTxt.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.duiTxt.ForeColor = System.Drawing.Color.Black
        Me.duiTxt.Location = New System.Drawing.Point(120, 116)
        Me.duiTxt.Name = "duiTxt"
        Me.duiTxt.ReadOnly = True
        Me.duiTxt.Size = New System.Drawing.Size(146, 20)
        Me.duiTxt.TabIndex = 9
        Me.duiTxt.WatermarkText = "..."
        '
        'dealerTxt
        '
        Me.dealerTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.dealerTxt.Border.Class = "TextBoxBorder"
        Me.dealerTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dealerTxt.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.dealerTxt.ForeColor = System.Drawing.Color.Black
        Me.dealerTxt.Location = New System.Drawing.Point(489, 12)
        Me.dealerTxt.Name = "dealerTxt"
        Me.dealerTxt.ReadOnly = True
        Me.dealerTxt.Size = New System.Drawing.Size(199, 20)
        Me.dealerTxt.TabIndex = 8
        Me.dealerTxt.Text = "..."
        Me.dealerTxt.WatermarkText = "..."
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(417, 12)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(41, 20)
        Me.LabelX5.SymbolColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelX5.SymbolSize = 15.0!
        Me.LabelX5.TabIndex = 7
        Me.LabelX5.Text = "Dealer:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'idDealerTxt
        '
        Me.idDealerTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.idDealerTxt.Border.Class = "TextBoxBorder"
        Me.idDealerTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.idDealerTxt.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.idDealerTxt.ForeColor = System.Drawing.Color.Black
        Me.idDealerTxt.Location = New System.Drawing.Point(461, 12)
        Me.idDealerTxt.Name = "idDealerTxt"
        Me.idDealerTxt.ReadOnly = True
        Me.idDealerTxt.Size = New System.Drawing.Size(25, 20)
        Me.idDealerTxt.TabIndex = 6
        Me.idDealerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.idDealerTxt.WatermarkText = "#"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(21, 12)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(96, 20)
        Me.LabelX3.SymbolColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelX3.SymbolSize = 15.0!
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Nombre completo:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'nombreTxt
        '
        Me.nombreTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.nombreTxt.Border.Class = "TextBoxBorder"
        Me.nombreTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.nombreTxt.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.nombreTxt.ForeColor = System.Drawing.Color.Black
        Me.nombreTxt.Location = New System.Drawing.Point(120, 12)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.ReadOnly = True
        Me.nombreTxt.Size = New System.Drawing.Size(293, 20)
        Me.nombreTxt.TabIndex = 4
        Me.nombreTxt.WatermarkText = "..."
        '
        'GroupPanel4
        '
        Me.GroupPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.LabelX4)
        Me.GroupPanel4.Controls.Add(Me.codigoEmpleadoTxt)
        Me.GroupPanel4.Controls.Add(Me.cancelarBtn)
        Me.GroupPanel4.Controls.Add(Me.seleccionarBtn)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 563)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(714, 44)
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
        Me.GroupPanel4.TabIndex = 4
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(6, 10)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(111, 20)
        Me.LabelX4.SymbolColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabelX4.SymbolSize = 15.0!
        Me.LabelX4.TabIndex = 28
        Me.LabelX4.Text = "# Cód. Empleado:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'codigoEmpleadoTxt
        '
        Me.codigoEmpleadoTxt.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.codigoEmpleadoTxt.Border.Class = "TextBoxBorder"
        Me.codigoEmpleadoTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.codigoEmpleadoTxt.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.codigoEmpleadoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigoEmpleadoTxt.ForeColor = System.Drawing.Color.Black
        Me.codigoEmpleadoTxt.Location = New System.Drawing.Point(120, 10)
        Me.codigoEmpleadoTxt.Name = "codigoEmpleadoTxt"
        Me.codigoEmpleadoTxt.ReadOnly = True
        Me.codigoEmpleadoTxt.Size = New System.Drawing.Size(132, 20)
        Me.codigoEmpleadoTxt.TabIndex = 27
        Me.codigoEmpleadoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.codigoEmpleadoTxt.WatermarkText = "#"
        '
        'cancelarBtn
        '
        Me.cancelarBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cancelarBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.cancelarBtn.Image = Global.ModuloTelefonos.My.Resources.Resources.atencion_revisar
        Me.cancelarBtn.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.cancelarBtn.Location = New System.Drawing.Point(556, 3)
        Me.cancelarBtn.Name = "cancelarBtn"
        Me.cancelarBtn.Size = New System.Drawing.Size(132, 32)
        Me.cancelarBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cancelarBtn.Symbol = "58825"
        Me.cancelarBtn.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.cancelarBtn.SymbolSize = 12.0!
        Me.cancelarBtn.TabIndex = 26
        Me.cancelarBtn.Text = "& Cancelar"
        '
        'seleccionarBtn
        '
        Me.seleccionarBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.seleccionarBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.seleccionarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seleccionarBtn.Image = Global.ModuloTelefonos.My.Resources.Resources.atencion_revisar
        Me.seleccionarBtn.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.seleccionarBtn.Location = New System.Drawing.Point(278, 3)
        Me.seleccionarBtn.Name = "seleccionarBtn"
        Me.seleccionarBtn.Size = New System.Drawing.Size(272, 32)
        Me.seleccionarBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.seleccionarBtn.Symbol = "59500"
        Me.seleccionarBtn.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.seleccionarBtn.SymbolSize = 12.0!
        Me.seleccionarBtn.TabIndex = 25
        Me.seleccionarBtn.Text = "& Seleccionar"
        '
        'codEmpleado
        '
        Me.codEmpleado.DataPropertyName = "Numero"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codEmpleado.DefaultCellStyle = DataGridViewCellStyle8
        Me.codEmpleado.HeaderText = "#Empleado"
        Me.codEmpleado.Name = "codEmpleado"
        Me.codEmpleado.ReadOnly = True
        Me.codEmpleado.ToolTipText = "Codigo del empleado en nomina"
        Me.codEmpleado.Width = 80
        '
        'nombres
        '
        Me.nombres.DataPropertyName = "Nombre"
        Me.nombres.HeaderText = "Nombres"
        Me.nombres.Name = "nombres"
        Me.nombres.ReadOnly = True
        Me.nombres.ToolTipText = "Nombres del empleado en nomina"
        Me.nombres.Width = 170
        '
        'apellidos
        '
        Me.apellidos.DataPropertyName = "Apellidos"
        Me.apellidos.HeaderText = "Apellidos"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.ReadOnly = True
        Me.apellidos.ToolTipText = "Apellidos del empleado  en nomina"
        Me.apellidos.Width = 170
        '
        'dui
        '
        Me.dui.DataPropertyName = "DUI"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dui.DefaultCellStyle = DataGridViewCellStyle9
        Me.dui.HeaderText = "DUI"
        Me.dui.Name = "dui"
        Me.dui.ReadOnly = True
        Me.dui.ToolTipText = "Numero de DUI del empleado en nomina"
        Me.dui.Width = 130
        '
        'fechaIngreso
        '
        Me.fechaIngreso.DataPropertyName = "FechaIngreso"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.fechaIngreso.DefaultCellStyle = DataGridViewCellStyle10
        Me.fechaIngreso.HeaderText = "Fecha Ingreso"
        Me.fechaIngreso.Name = "fechaIngreso"
        Me.fechaIngreso.ReadOnly = True
        Me.fechaIngreso.ToolTipText = "Fecha de ingreso registrada en nomina"
        '
        'vacio
        '
        Me.vacio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vacio.HeaderText = ""
        Me.vacio.Name = "vacio"
        Me.vacio.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LabelX3)
        Me.Panel1.Controls.Add(Me.LabelX14)
        Me.Panel1.Controls.Add(Me.nombreTxt)
        Me.Panel1.Controls.Add(Me.LabelX13)
        Me.Panel1.Controls.Add(Me.idDealerTxt)
        Me.Panel1.Controls.Add(Me.LabelX12)
        Me.Panel1.Controls.Add(Me.LabelX5)
        Me.Panel1.Controls.Add(Me.direccionTxt)
        Me.Panel1.Controls.Add(Me.dealerTxt)
        Me.Panel1.Controls.Add(Me.LabelX11)
        Me.Panel1.Controls.Add(Me.duiTxt)
        Me.Panel1.Controls.Add(Me.centroCostosTxt)
        Me.Panel1.Controls.Add(Me.LabelX6)
        Me.Panel1.Controls.Add(Me.LabelX10)
        Me.Panel1.Controls.Add(Me.telefonoTxt)
        Me.Panel1.Controls.Add(Me.fechaIngTxt)
        Me.Panel1.Controls.Add(Me.LabelX7)
        Me.Panel1.Controls.Add(Me.idCargoTxt)
        Me.Panel1.Controls.Add(Me.cargoTxt)
        Me.Panel1.Controls.Add(Me.idDepartamentoTxt)
        Me.Panel1.Controls.Add(Me.LabelX8)
        Me.Panel1.Controls.Add(Me.LabelX9)
        Me.Panel1.Controls.Add(Me.departamentoTxt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(708, 147)
        Me.Panel1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LabelX1)
        Me.Panel2.Controls.Add(Me.LabelX2)
        Me.Panel2.Controls.Add(Me.busquedaTxt)
        Me.Panel2.Controls.Add(Me.buscarBtn)
        Me.Panel2.Controls.Add(Me.filtroCbx)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(708, 44)
        Me.Panel2.TabIndex = 29
        '
        'frmBuscarNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 607)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Name = "frmBuscarNomina"
        Me.Text = "Datos por nomina"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.nominasDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents nominasDgv As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cancelarBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents seleccionarBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents busquedaTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents buscarBtn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents filtroCbx As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents nombreTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents codigoEmpleadoTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents idDealerTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents duiTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dealerTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents telefonoTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cargoTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents idCargoTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents idDepartamentoTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents departamentoTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents fechaIngTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents centroCostosTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents direccionTxt As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents codEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents nombres As DataGridViewTextBoxColumn
    Friend WithEvents apellidos As DataGridViewTextBoxColumn
    Friend WithEvents dui As DataGridViewTextBoxColumn
    Friend WithEvents fechaIngreso As DataGridViewTextBoxColumn
    Friend WithEvents vacio As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
