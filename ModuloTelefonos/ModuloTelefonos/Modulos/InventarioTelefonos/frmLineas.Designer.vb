<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineas
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLineas))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.numero = New DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn()
        Me.compañia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.con_datos = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.detalle_plan_datos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_contratacion = New DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn()
        Me.duraccion_contrato_meses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ultima_renovacion = New DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn()
        Me.proxima_renovacion = New DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn()
        Me.id_propietario = New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn()
        Me.id_propietario_actual = New DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn()
        Me.identificador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imei_actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_cancelacion = New DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn()
        Me.cuota = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.pornumeroCheckBoxX1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.porpropietarioCheckBoxX2 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.seleccionarButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.escrituraButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.lecturaButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.DataGridViewX2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.b_id_propietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_completo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1216, 675)
        Me.Panel2.TabIndex = 39
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridViewX1)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 102)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1216, 573)
        Me.Panel4.TabIndex = 1
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.compañia, Me.con_datos, Me.detalle_plan_datos, Me.fecha_contratacion, Me.duraccion_contrato_meses, Me.ultima_renovacion, Me.proxima_renovacion, Me.id_propietario, Me.id_propietario_actual, Me.identificador, Me.imei_actual, Me.fecha_cancelacion, Me.cuota})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 20)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(1216, 553)
        Me.DataGridViewX1.TabIndex = 2
        '
        'numero
        '
        Me.numero.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.numero.BackgroundStyle.Class = "DataGridViewBorder"
        Me.numero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.numero.Culture = New System.Globalization.CultureInfo("es-PA")
        Me.numero.DataPropertyName = "numero"
        Me.numero.ForeColor = System.Drawing.SystemColors.ControlText
        Me.numero.HeaderText = "Número"
        Me.numero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.numero.Mask = "####-####"
        Me.numero.MaxInputLength = 10
        Me.numero.Name = "numero"
        Me.numero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.numero.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.numero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.numero.Text = "    -"
        Me.numero.Width = 80
        '
        'compañia
        '
        Me.compañia.DataPropertyName = "compañia"
        Me.compañia.HeaderText = "Compañia"
        Me.compañia.MaxInputLength = 10
        Me.compañia.Name = "compañia"
        Me.compañia.Width = 70
        '
        'con_datos
        '
        Me.con_datos.Checked = True
        Me.con_datos.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.con_datos.CheckValue = "N"
        Me.con_datos.DataPropertyName = "con_datos"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.con_datos.DefaultCellStyle = DataGridViewCellStyle7
        Me.con_datos.HeaderText = "Posee plan de Datos"
        Me.con_datos.Name = "con_datos"
        Me.con_datos.Width = 70
        '
        'detalle_plan_datos
        '
        Me.detalle_plan_datos.DataPropertyName = "detalle_plan_datos"
        Me.detalle_plan_datos.HeaderText = "Detalle del Plan Datos"
        Me.detalle_plan_datos.MaxInputLength = 200
        Me.detalle_plan_datos.Name = "detalle_plan_datos"
        Me.detalle_plan_datos.Width = 225
        '
        'fecha_contratacion
        '
        Me.fecha_contratacion.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.fecha_contratacion.BackgroundStyle.Class = "DataGridViewBorder"
        Me.fecha_contratacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha_contratacion.Culture = New System.Globalization.CultureInfo("es-PA")
        Me.fecha_contratacion.DataPropertyName = "fecha_contratacion"
        Me.fecha_contratacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fecha_contratacion.HeaderText = "Fecha de Contrato"
        Me.fecha_contratacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.fecha_contratacion.Mask = "##/##/####"
        Me.fecha_contratacion.Name = "fecha_contratacion"
        Me.fecha_contratacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fecha_contratacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fecha_contratacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fecha_contratacion.Text = "  /  /"
        Me.fecha_contratacion.Width = 80
        '
        'duraccion_contrato_meses
        '
        Me.duraccion_contrato_meses.DataPropertyName = "duraccion_contrato_meses"
        Me.duraccion_contrato_meses.HeaderText = "Duracion contrato en meses"
        Me.duraccion_contrato_meses.Name = "duraccion_contrato_meses"
        Me.duraccion_contrato_meses.Width = 80
        '
        'ultima_renovacion
        '
        Me.ultima_renovacion.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.ultima_renovacion.BackgroundStyle.Class = "DataGridViewBorder"
        Me.ultima_renovacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ultima_renovacion.Culture = New System.Globalization.CultureInfo("es-PA")
        Me.ultima_renovacion.DataPropertyName = "ultima_renovacion"
        Me.ultima_renovacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ultima_renovacion.HeaderText = "Ultima Renovación"
        Me.ultima_renovacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ultima_renovacion.Mask = "##/##/####"
        Me.ultima_renovacion.Name = "ultima_renovacion"
        Me.ultima_renovacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ultima_renovacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ultima_renovacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ultima_renovacion.Text = "  /  /"
        Me.ultima_renovacion.Width = 80
        '
        'proxima_renovacion
        '
        Me.proxima_renovacion.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.proxima_renovacion.BackgroundStyle.Class = "DataGridViewBorder"
        Me.proxima_renovacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.proxima_renovacion.Culture = New System.Globalization.CultureInfo("es-SV")
        Me.proxima_renovacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.proxima_renovacion.HeaderText = "Próxima Renovación"
        Me.proxima_renovacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.proxima_renovacion.Mask = "##/##/####"
        Me.proxima_renovacion.Name = "proxima_renovacion"
        Me.proxima_renovacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.proxima_renovacion.ReadOnly = True
        Me.proxima_renovacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.proxima_renovacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.proxima_renovacion.Text = "  /  /"
        Me.proxima_renovacion.Width = 80
        '
        'id_propietario
        '
        Me.id_propietario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.id_propietario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.id_propietario.DataPropertyName = "id_propietario"
        Me.id_propietario.DropDownHeight = 106
        Me.id_propietario.DropDownWidth = 121
        Me.id_propietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.id_propietario.HeaderText = "Propietario Linea"
        Me.id_propietario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.id_propietario.IntegralHeight = False
        Me.id_propietario.ItemHeight = 15
        Me.id_propietario.Name = "id_propietario"
        Me.id_propietario.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id_propietario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.id_propietario.Width = 200
        '
        'id_propietario_actual
        '
        Me.id_propietario_actual.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.id_propietario_actual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.id_propietario_actual.DataPropertyName = "id_propietario_actual"
        Me.id_propietario_actual.DropDownHeight = 106
        Me.id_propietario_actual.DropDownWidth = 121
        Me.id_propietario_actual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.id_propietario_actual.HeaderText = "Propietario Actual"
        Me.id_propietario_actual.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.id_propietario_actual.IntegralHeight = False
        Me.id_propietario_actual.ItemHeight = 15
        Me.id_propietario_actual.Name = "id_propietario_actual"
        Me.id_propietario_actual.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id_propietario_actual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.id_propietario_actual.Width = 200
        '
        'identificador
        '
        Me.identificador.DataPropertyName = "identificador"
        Me.identificador.HeaderText = "Identificador"
        Me.identificador.MaxInputLength = 200
        Me.identificador.Name = "identificador"
        Me.identificador.Width = 250
        '
        'imei_actual
        '
        Me.imei_actual.DataPropertyName = "imei_actual"
        Me.imei_actual.HeaderText = "IMEI Actual"
        Me.imei_actual.MaxInputLength = 20
        Me.imei_actual.Name = "imei_actual"
        Me.imei_actual.Width = 150
        '
        'fecha_cancelacion
        '
        Me.fecha_cancelacion.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.fecha_cancelacion.BackgroundStyle.Class = "DataGridViewBorder"
        Me.fecha_cancelacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.fecha_cancelacion.Culture = New System.Globalization.CultureInfo("es-PA")
        Me.fecha_cancelacion.DataPropertyName = "fecha_cancelacion"
        Me.fecha_cancelacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fecha_cancelacion.HeaderText = "Fecha de Cancelación"
        Me.fecha_cancelacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.fecha_cancelacion.Mask = "##/##/####"
        Me.fecha_cancelacion.Name = "fecha_cancelacion"
        Me.fecha_cancelacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fecha_cancelacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.fecha_cancelacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fecha_cancelacion.Text = "  /  /"
        Me.fecha_cancelacion.Width = 80
        '
        'cuota
        '
        '
        '
        '
        Me.cuota.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.cuota.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cuota.DataPropertyName = "cuota"
        Me.cuota.HeaderText = "Cuota"
        Me.cuota.Increment = 1.0R
        Me.cuota.Name = "cuota"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LinkLabel2)
        Me.Panel5.Controls.Add(Me.LinkLabel1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1216, 20)
        Me.Panel5.TabIndex = 3
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(1167, 3)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(43, 16)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Quitar"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(1124, 3)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(47, 16)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Añadir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(155, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Repositorio de Lineas"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1216, 102)
        Me.Panel3.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel8)
        Me.Panel9.Controls.Add(Me.Panel11)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(130, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1086, 102)
        Me.Panel9.TabIndex = 39
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.TextBoxX1)
        Me.Panel8.Controls.Add(Me.Panel10)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(638, 102)
        Me.Panel8.TabIndex = 38
        '
        'TextBoxX1
        '
        Me.TextBoxX1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX1.Location = New System.Drawing.Point(6, 38)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(626, 26)
        Me.TextBoxX1.TabIndex = 1
        Me.TextBoxX1.WatermarkText = "Realizar búsqueda "
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.LabelX3)
        Me.Panel10.Controls.Add(Me.pornumeroCheckBoxX1)
        Me.Panel10.Controls.Add(Me.porpropietarioCheckBoxX2)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(638, 32)
        Me.Panel10.TabIndex = 9
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(6, 6)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Búscar"
        '
        'pornumeroCheckBoxX1
        '
        '
        '
        '
        Me.pornumeroCheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pornumeroCheckBoxX1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.pornumeroCheckBoxX1.Checked = True
        Me.pornumeroCheckBoxX1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.pornumeroCheckBoxX1.CheckValue = "Y"
        Me.pornumeroCheckBoxX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pornumeroCheckBoxX1.Location = New System.Drawing.Point(152, 6)
        Me.pornumeroCheckBoxX1.Name = "pornumeroCheckBoxX1"
        Me.pornumeroCheckBoxX1.Size = New System.Drawing.Size(100, 23)
        Me.pornumeroCheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pornumeroCheckBoxX1.TabIndex = 7
        Me.pornumeroCheckBoxX1.Text = "Por número"
        '
        'porpropietarioCheckBoxX2
        '
        '
        '
        '
        Me.porpropietarioCheckBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.porpropietarioCheckBoxX2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.porpropietarioCheckBoxX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.porpropietarioCheckBoxX2.Location = New System.Drawing.Point(258, 6)
        Me.porpropietarioCheckBoxX2.Name = "porpropietarioCheckBoxX2"
        Me.porpropietarioCheckBoxX2.Size = New System.Drawing.Size(149, 23)
        Me.porpropietarioCheckBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.porpropietarioCheckBoxX2.TabIndex = 8
        Me.porpropietarioCheckBoxX2.Text = "Por propietario"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(638, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(448, 102)
        Me.Panel11.TabIndex = 41
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.10559!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.89441!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.seleccionarButtonX1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonX1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonX2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 32)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(448, 70)
        Me.TableLayoutPanel2.TabIndex = 40
        '
        'seleccionarButtonX1
        '
        Me.seleccionarButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.seleccionarButtonX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.seleccionarButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.seleccionarButtonX1.Dock = System.Windows.Forms.DockStyle.Top
        Me.seleccionarButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seleccionarButtonX1.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.seleccionarButtonX1.Location = New System.Drawing.Point(321, 3)
        Me.seleccionarButtonX1.Name = "seleccionarButtonX1"
        Me.seleccionarButtonX1.Size = New System.Drawing.Size(124, 43)
        Me.seleccionarButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.seleccionarButtonX1.Symbol = ""
        Me.seleccionarButtonX1.TabIndex = 5
        Me.seleccionarButtonX1.Text = "Seleccionar"
        Me.seleccionarButtonX1.Visible = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.ButtonX1.Location = New System.Drawing.Point(172, 3)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(143, 43)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 6
        Me.ButtonX1.Text = "Actualizar"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX2.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(45, 40)
        Me.ButtonX2.Location = New System.Drawing.Point(3, 3)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(163, 43)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 35
        Me.ButtonX2.Text = "Rep.de SIM (0)"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.LabelX1)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(448, 32)
        Me.Panel12.TabIndex = 10
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(6, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Opciones"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(130, 102)
        Me.Panel6.TabIndex = 37
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.escrituraButtonX4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lecturaButtonX3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 32)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(130, 70)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'escrituraButtonX4
        '
        Me.escrituraButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.escrituraButtonX4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.escrituraButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.escrituraButtonX4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.escrituraButtonX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.escrituraButtonX4.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.escrituraButtonX4.Location = New System.Drawing.Point(3, 38)
        Me.escrituraButtonX4.Name = "escrituraButtonX4"
        Me.escrituraButtonX4.Size = New System.Drawing.Size(124, 29)
        Me.escrituraButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.escrituraButtonX4.TabIndex = 1
        Me.escrituraButtonX4.Text = "Escritura"
        '
        'lecturaButtonX3
        '
        Me.lecturaButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.lecturaButtonX3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lecturaButtonX3.Checked = True
        Me.lecturaButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.lecturaButtonX3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lecturaButtonX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lecturaButtonX3.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.lecturaButtonX3.Location = New System.Drawing.Point(3, 3)
        Me.lecturaButtonX3.Name = "lecturaButtonX3"
        Me.lecturaButtonX3.Size = New System.Drawing.Size(124, 29)
        Me.lecturaButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.lecturaButtonX3.TabIndex = 0
        Me.lecturaButtonX3.Text = "Lectura"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.LabelX2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(130, 32)
        Me.Panel7.TabIndex = 0
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(5, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Modo"
        '
        'DataGridViewX2
        '
        Me.DataGridViewX2.AllowUserToAddRows = False
        Me.DataGridViewX2.AllowUserToDeleteRows = False
        Me.DataGridViewX2.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewX2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.b_id_propietario, Me.nombre_completo, Me.b_empresa, Me.b_departamento, Me.b_cargo})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX2.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewX2.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.DataGridViewX2.Location = New System.Drawing.Point(293, 271)
        Me.DataGridViewX2.Name = "DataGridViewX2"
        Me.DataGridViewX2.ReadOnly = True
        Me.DataGridViewX2.RowHeadersWidth = 21
        Me.DataGridViewX2.Size = New System.Drawing.Size(631, 134)
        Me.DataGridViewX2.TabIndex = 40
        Me.DataGridViewX2.Visible = False
        '
        'b_id_propietario
        '
        Me.b_id_propietario.DataPropertyName = "id_propietario"
        Me.b_id_propietario.HeaderText = "ID"
        Me.b_id_propietario.Name = "b_id_propietario"
        Me.b_id_propietario.ReadOnly = True
        Me.b_id_propietario.Width = 50
        '
        'nombre_completo
        '
        Me.nombre_completo.DataPropertyName = "nombre_completo"
        Me.nombre_completo.HeaderText = "Nombre Completo"
        Me.nombre_completo.Name = "nombre_completo"
        Me.nombre_completo.ReadOnly = True
        Me.nombre_completo.Width = 200
        '
        'b_empresa
        '
        Me.b_empresa.DataPropertyName = "empresa"
        Me.b_empresa.HeaderText = "Empresa"
        Me.b_empresa.Name = "b_empresa"
        Me.b_empresa.ReadOnly = True
        Me.b_empresa.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'b_departamento
        '
        Me.b_departamento.DataPropertyName = "departamento"
        Me.b_departamento.HeaderText = "Departamento"
        Me.b_departamento.Name = "b_departamento"
        Me.b_departamento.ReadOnly = True
        Me.b_departamento.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'b_cargo
        '
        Me.b_cargo.DataPropertyName = "cargo"
        Me.b_cargo.HeaderText = "Cargo"
        Me.b_cargo.Name = "b_cargo"
        Me.b_cargo.ReadOnly = True
        Me.b_cargo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'frmLineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 675)
        Me.Controls.Add(Me.DataGridViewX2)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLineas"
        Me.Text = "Líneas"
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents numero As DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn
    Friend WithEvents compañia As DataGridViewTextBoxColumn
    Friend WithEvents con_datos As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents detalle_plan_datos As DataGridViewTextBoxColumn
    Friend WithEvents fecha_contratacion As DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn
    Friend WithEvents duraccion_contrato_meses As DataGridViewTextBoxColumn
    Friend WithEvents ultima_renovacion As DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn
    Friend WithEvents proxima_renovacion As DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn
    Friend WithEvents id_propietario As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Friend WithEvents id_propietario_actual As DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn
    Friend WithEvents identificador As DataGridViewTextBoxColumn
    Friend WithEvents imei_actual As DataGridViewTextBoxColumn
    Friend WithEvents fecha_cancelacion As DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn
    Friend WithEvents cuota As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel10 As Panel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents pornumeroCheckBoxX1 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents porpropietarioCheckBoxX2 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents seleccionarButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel12 As Panel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents escrituraButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lecturaButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DataGridViewX2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents b_id_propietario As DataGridViewTextBoxColumn
    Friend WithEvents nombre_completo As DataGridViewTextBoxColumn
    Friend WithEvents b_empresa As DataGridViewTextBoxColumn
    Friend WithEvents b_departamento As DataGridViewTextBoxColumn
    Friend WithEvents b_cargo As DataGridViewTextBoxColumn
End Class
