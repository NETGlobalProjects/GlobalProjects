<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgEmergentePropietarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewX2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.b_id_propietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_completo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewX2
        '
        Me.DataGridViewX2.AllowUserToAddRows = False
        Me.DataGridViewX2.AllowUserToDeleteRows = False
        Me.DataGridViewX2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.b_id_propietario, Me.nombre_completo, Me.b_empresa, Me.b_departamento, Me.b_cargo})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX2.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX2.Name = "DataGridViewX2"
        Me.DataGridViewX2.ReadOnly = True
        Me.DataGridViewX2.RowHeadersWidth = 21
        Me.DataGridViewX2.Size = New System.Drawing.Size(634, 263)
        Me.DataGridViewX2.TabIndex = 35
        Me.DataGridViewX2.Visible = False
        '
        'b_id_propietario
        '
        Me.b_id_propietario.DataPropertyName = "id_propietario"
        Me.b_id_propietario.HeaderText = "ID Propietario"
        Me.b_id_propietario.Name = "b_id_propietario"
        Me.b_id_propietario.ReadOnly = True
        Me.b_id_propietario.Width = 60
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
        'dlgEmergentePropietarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 263)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridViewX2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dlgEmergentePropietarios"
        Me.Text = "dlgEmergentePropietarios"
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewX2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents b_id_propietario As DataGridViewTextBoxColumn
    Friend WithEvents nombre_completo As DataGridViewTextBoxColumn
    Friend WithEvents b_empresa As DataGridViewTextBoxColumn
    Friend WithEvents b_departamento As DataGridViewTextBoxColumn
    Friend WithEvents b_cargo As DataGridViewTextBoxColumn
End Class
