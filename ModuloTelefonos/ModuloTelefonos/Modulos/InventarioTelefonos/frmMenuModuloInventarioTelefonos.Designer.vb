<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuModuloInventarioTelefonos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuModuloInventarioTelefonos))
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Version2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadosTeléfonosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MotivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonX5 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Panel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.AutoExpandOnClick = True
        Me.ButtonX3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX3.Image = Global.ModuloTelefonos.My.Resources.Resources.user
        Me.ButtonX3.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.ButtonX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX3.Location = New System.Drawing.Point(12, 202)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(151, 129)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.Symbol = ""
        Me.ButtonX3.SymbolSize = 30.0!
        Me.ButtonX3.TabIndex = 2
        Me.ButtonX3.Text = "Propietarios"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.AutoExpandOnClick = True
        Me.ButtonX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.ModuloTelefonos.My.Resources.Resources.linea
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.ButtonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX1.Location = New System.Drawing.Point(12, 67)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(151, 129)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 30.0!
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = "Lineas"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.AutoExpandOnClick = True
        Me.ButtonX4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonX4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX4.Image = Global.ModuloTelefonos.My.Resources.Resources.movimiento
        Me.ButtonX4.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.ButtonX4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX4.Location = New System.Drawing.Point(169, 202)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(151, 130)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.Symbol = ""
        Me.ButtonX4.SymbolSize = 30.0!
        Me.ButtonX4.TabIndex = 3
        Me.ButtonX4.Text = "Movimientos"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.AutoExpandOnClick = True
        Me.ButtonX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Image = Global.ModuloTelefonos.My.Resources.Resources.mobile_phone
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.ButtonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX2.Location = New System.Drawing.Point(169, 67)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(151, 130)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.SymbolSize = 30.0!
        Me.ButtonX2.TabIndex = 1
        Me.ButtonX2.Text = "Teléfonos"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Version2)
        Me.Panel3.Controls.Add(Me.MenuStrip1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(496, 52)
        Me.Panel3.TabIndex = 6
        '
        'Version2
        '
        Me.Version2.BackColor = System.Drawing.Color.Transparent
        Me.Version2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Version2.Location = New System.Drawing.Point(344, 27)
        Me.Version2.Name = "Version2"
        Me.Version2.Size = New System.Drawing.Size(149, 21)
        Me.Version2.TabIndex = 63
        Me.Version2.Text = "Versión {0}.{1:00}"
        Me.Version2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(496, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientosToolStripMenuItem
        '
        Me.MantenimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadosTeléfonosToolStripMenuItem, Me.MotivosToolStripMenuItem, Me.MarcasToolStripMenuItem})
        Me.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        Me.MantenimientosToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.MantenimientosToolStripMenuItem.Text = "Mantenimientos"
        '
        'EstadosTeléfonosToolStripMenuItem
        '
        Me.EstadosTeléfonosToolStripMenuItem.Name = "EstadosTeléfonosToolStripMenuItem"
        Me.EstadosTeléfonosToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EstadosTeléfonosToolStripMenuItem.Text = "Estados Teléfonos"
        '
        'MotivosToolStripMenuItem
        '
        Me.MotivosToolStripMenuItem.Name = "MotivosToolStripMenuItem"
        Me.MotivosToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.MotivosToolStripMenuItem.Text = "Motivos"
        '
        'MarcasToolStripMenuItem
        '
        Me.MarcasToolStripMenuItem.Name = "MarcasToolStripMenuItem"
        Me.MarcasToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.MarcasToolStripMenuItem.Text = "Marcas"
        '
        'ButtonX5
        '
        Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX5.AutoExpandOnClick = True
        Me.ButtonX5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX5.Image = Global.ModuloTelefonos.My.Resources.Resources.mobile_phone
        Me.ButtonX5.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.ButtonX5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX5.Location = New System.Drawing.Point(326, 67)
        Me.ButtonX5.Name = "ButtonX5"
        Me.ButtonX5.Size = New System.Drawing.Size(151, 130)
        Me.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX5.Symbol = ""
        Me.ButtonX5.SymbolSize = 30.0!
        Me.ButtonX5.TabIndex = 7
        Me.ButtonX5.Text = "Equipos"
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.AutoExpandOnClick = True
        Me.ButtonX6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonX6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX6.Image = Global.ModuloTelefonos.My.Resources.Resources.movimiento
        Me.ButtonX6.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.ButtonX6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX6.Location = New System.Drawing.Point(326, 201)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Size = New System.Drawing.Size(151, 130)
        Me.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX6.Symbol = ""
        Me.ButtonX6.SymbolSize = 30.0!
        Me.ButtonX6.TabIndex = 8
        Me.ButtonX6.Text = "Salir"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.OfficeMobile2014
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'frmMenuModuloInventarioTelefonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 353)
        Me.Controls.Add(Me.ButtonX6)
        Me.Controls.Add(Me.ButtonX5)
        Me.Controls.Add(Me.ButtonX4)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ButtonX1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenuModuloInventarioTelefonos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Version2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadosTeléfonosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MotivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarcasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonX5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
End Class
