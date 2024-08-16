<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManttoEquipos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManttoEquipos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id_equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tiempo_garantia_meses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vacio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.editarLinkLabel3 = New DevComponents.DotNetBar.ButtonX()
        Me.LinkLabel1 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.eliminarLinkLabel2 = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1094, 503)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1094, 451)
        Me.Panel3.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_equipo, Me.id_tipo, Me.marca, Me.modelo, Me.serie, Me.descripcion, Me.fecha_compra, Me.proveedor, Me.tiempo_garantia_meses, Me.estado, Me.vacio})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1094, 451)
        Me.DataGridView1.TabIndex = 0
        '
        'id_equipo
        '
        Me.id_equipo.DataPropertyName = "id_equipo"
        Me.id_equipo.HeaderText = "ID Equipo"
        Me.id_equipo.Name = "id_equipo"
        Me.id_equipo.Width = 70
        '
        'id_tipo
        '
        Me.id_tipo.DataPropertyName = "tipo"
        Me.id_tipo.HeaderText = "Tipo"
        Me.id_tipo.Name = "id_tipo"
        '
        'marca
        '
        Me.marca.DataPropertyName = "marca"
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        '
        'modelo
        '
        Me.modelo.DataPropertyName = "marca"
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        '
        'serie
        '
        Me.serie.DataPropertyName = "serie"
        Me.serie.HeaderText = "Serie"
        Me.serie.Name = "serie"
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 250
        '
        'fecha_compra
        '
        Me.fecha_compra.DataPropertyName = "fecha_compra"
        Me.fecha_compra.HeaderText = "Fecha Compra"
        Me.fecha_compra.Name = "fecha_compra"
        Me.fecha_compra.Width = 80
        '
        'proveedor
        '
        Me.proveedor.DataPropertyName = "proveedor"
        Me.proveedor.HeaderText = "Proveedor"
        Me.proveedor.Name = "proveedor"
        Me.proveedor.Width = 150
        '
        'tiempo_garantia_meses
        '
        Me.tiempo_garantia_meses.DataPropertyName = "tiempo_garantia_meses"
        Me.tiempo_garantia_meses.HeaderText = "Garantia /Meses"
        Me.tiempo_garantia_meses.Name = "tiempo_garantia_meses"
        Me.tiempo_garantia_meses.Width = 80
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        '
        'vacio
        '
        Me.vacio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.vacio.HeaderText = ""
        Me.vacio.Name = "vacio"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1094, 52)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.eliminarLinkLabel2)
        Me.GroupBox2.Controls.Add(Me.editarLinkLabel3)
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Location = New System.Drawing.Point(830, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 45)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acciones"
        '
        'editarLinkLabel3
        '
        Me.editarLinkLabel3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.editarLinkLabel3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.editarLinkLabel3.Enabled = False
        Me.editarLinkLabel3.Location = New System.Drawing.Point(95, 16)
        Me.editarLinkLabel3.Name = "editarLinkLabel3"
        Me.editarLinkLabel3.Size = New System.Drawing.Size(75, 23)
        Me.editarLinkLabel3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.editarLinkLabel3.Symbol = ""
        Me.editarLinkLabel3.SymbolSize = 12.0!
        Me.editarLinkLabel3.TabIndex = 4
        Me.editarLinkLabel3.Text = "&Editar"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.LinkLabel1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.LinkLabel1.Location = New System.Drawing.Point(14, 16)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(75, 23)
        Me.LinkLabel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LinkLabel1.Symbol = ""
        Me.LinkLabel1.SymbolSize = 12.0!
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.Text = "&Añadir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(820, 45)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(84, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(718, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Búscar"
        '
        'eliminarLinkLabel2
        '
        Me.eliminarLinkLabel2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.eliminarLinkLabel2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.eliminarLinkLabel2.Enabled = False
        Me.eliminarLinkLabel2.Location = New System.Drawing.Point(176, 16)
        Me.eliminarLinkLabel2.Name = "eliminarLinkLabel2"
        Me.eliminarLinkLabel2.Size = New System.Drawing.Size(75, 23)
        Me.eliminarLinkLabel2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.eliminarLinkLabel2.Symbol = ""
        Me.eliminarLinkLabel2.SymbolSize = 12.0!
        Me.eliminarLinkLabel2.TabIndex = 5
        Me.eliminarLinkLabel2.Text = "&Eliminar"
        '
        'frmManttoEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 503)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmManttoEquipos"
        Me.Text = "Mantenimiento de equipos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id_equipo As DataGridViewTextBoxColumn
    Friend WithEvents id_tipo As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents modelo As DataGridViewTextBoxColumn
    Friend WithEvents serie As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents fecha_compra As DataGridViewTextBoxColumn
    Friend WithEvents proveedor As DataGridViewTextBoxColumn
    Friend WithEvents tiempo_garantia_meses As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents vacio As DataGridViewTextBoxColumn
    Friend WithEvents editarLinkLabel3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LinkLabel1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents eliminarLinkLabel2 As DevComponents.DotNetBar.ButtonX
End Class
