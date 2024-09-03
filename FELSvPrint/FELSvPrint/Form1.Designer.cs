using DevComponents.DotNetBar.Controls;

namespace FELSvPrint
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.switchButtonItem2 = new DevComponents.DotNetBar.SwitchButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelH5 = new System.Windows.Forms.Panel();
            this.progressBarH5 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.panelH4 = new System.Windows.Forms.Panel();
            this.progressBarH4 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.panelH3 = new System.Windows.Forms.Panel();
            this.progressBarH3 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.panelH2 = new System.Windows.Forms.Panel();
            this.progressBarH2 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.panelH1 = new System.Windows.Forms.Panel();
            this.progressBarH1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.dockSite7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.bar1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelH5.SuspendLayout();
            this.panelH4.SuspendLayout();
            this.panelH3.SuspendLayout();
            this.panelH2.SuspendLayout();
            this.panelH1.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // dotNetBarManager1
            // 
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.dotNetBarManager1.BottomDockSite = this.dockSite4;
            this.dotNetBarManager1.EnableFullSizeDock = false;
            this.dotNetBarManager1.LeftDockSite = this.dockSite1;
            this.dotNetBarManager1.ParentForm = this;
            this.dotNetBarManager1.RightDockSite = this.dockSite2;
            this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.dotNetBarManager1.ToolbarBottomDockSite = this.dockSite8;
            this.dotNetBarManager1.ToolbarLeftDockSite = this.dockSite5;
            this.dotNetBarManager1.ToolbarRightDockSite = this.dockSite6;
            this.dotNetBarManager1.ToolbarTopDockSite = this.dockSite7;
            this.dotNetBarManager1.TopDockSite = this.dockSite3;
            // 
            // dockSite4
            // 
            this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite4.Location = new System.Drawing.Point(0, 413);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(1094, 0);
            this.dockSite4.TabIndex = 3;
            this.dockSite4.TabStop = false;
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite1.Location = new System.Drawing.Point(0, 28);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(0, 385);
            this.dockSite1.TabIndex = 0;
            this.dockSite1.TabStop = false;
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite2.Location = new System.Drawing.Point(1094, 28);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(0, 385);
            this.dockSite2.TabIndex = 1;
            this.dockSite2.TabStop = false;
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(0, 413);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(1094, 0);
            this.dockSite8.TabIndex = 7;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(0, 28);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 385);
            this.dockSite5.TabIndex = 4;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(1094, 28);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 385);
            this.dockSite6.TabIndex = 5;
            this.dockSite6.TabStop = false;
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.Controls.Add(this.bar1);
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.Location = new System.Drawing.Point(0, 0);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(1094, 28);
            this.dockSite7.TabIndex = 6;
            this.dockSite7.TabStop = false;
            // 
            // bar1
            // 
            this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
            this.bar1.AccessibleName = "DotNetBar Bar";
            this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bar1.ColorScheme.PredefinedColorScheme = DevComponents.DotNetBar.ePredefinedColorScheme.Blue2003;
            this.bar1.Controls.Add(this.switchButton1);
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem3,
            this.buttonItem4});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.MenuBar = true;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1094, 27);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // switchButton1
            // 
            this.switchButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton1.Location = new System.Drawing.Point(12998, 4);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.OffText = "APAGADO";
            this.switchButton1.OnText = "ENCENDIDO";
            this.switchButton1.Size = new System.Drawing.Size(116, 22);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.TabIndex = 0;
            this.switchButton1.Value = true;
            this.switchButton1.ValueObject = "Y";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.switchButtonItem2});
            this.buttonItem1.Symbol = "";
            this.buttonItem1.SymbolSize = 14F;
            this.buttonItem1.Text = "Opciones";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Symbol = "";
            this.buttonItem2.Text = "Ajustes";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // switchButtonItem2
            // 
            this.switchButtonItem2.Name = "switchButtonItem2";
            this.switchButtonItem2.OffText = "NO";
            this.switchButtonItem2.OnText = "SI";
            this.switchButtonItem2.Text = "Lector encendido";
            this.switchButtonItem2.Value = true;
            // 
            // buttonItem3
            // 
            this.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Symbol = "";
            this.buttonItem3.SymbolSize = 14F;
            this.buttonItem3.Text = "Actualizar listado";
            this.buttonItem3.Click += new System.EventHandler(this.buttonItem3_Click);
            // 
            // buttonItem4
            // 
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.Text = "Imprimir Tickets";
            this.buttonItem4.Click += new System.EventHandler(this.buttonItem4_Click);
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.dockSite3.Location = new System.Drawing.Point(0, 28);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(1094, 0);
            this.dockSite3.TabIndex = 2;
            this.dockSite3.TabStop = false;
            // 
            // superGridControl1
            // 
            this.superGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.superGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.Location = new System.Drawing.Point(0, 28);
            this.superGridControl1.Name = "superGridControl1";
            // 
            // 
            // 
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn1);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn2);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn3);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn4);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn5);
            this.superGridControl1.PrimaryGrid.Columns.Add(this.gridColumn6);
            this.superGridControl1.PrimaryGrid.MultiSelect = false;
            this.superGridControl1.Size = new System.Drawing.Size(1094, 385);
            this.superGridControl1.TabIndex = 8;
            this.superGridControl1.Text = "superGridControl1";
            this.superGridControl1.GetRowCellStyle += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridGetRowCellStyleEventArgs>(this.superGridControl1_GetRowCellStyle);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            this.gridColumn1.DataPropertyName = "Archivo";
            this.gridColumn1.Name = "Archivo";
            this.gridColumn1.Width = 300;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            this.gridColumn2.DataPropertyName = "Ubicacion";
            this.gridColumn2.Name = "Ubicación";
            this.gridColumn2.Width = 400;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            this.gridColumn3.DataPropertyName = "Impresora";
            this.gridColumn3.Name = "Impresora";
            // 
            // gridColumn4
            // 
            this.gridColumn4.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            this.gridColumn4.DataPropertyName = "Usuario";
            this.gridColumn4.Name = "Usuario";
            // 
            // gridColumn5
            // 
            this.gridColumn5.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            this.gridColumn5.DataPropertyName = "FechaImpresion";
            this.gridColumn5.Name = "Fecha Impresión";
            this.gridColumn5.Width = 120;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.gridColumn6.DataPropertyName = "Resultado";
            this.gridColumn6.HeaderText = "Resultado";
            this.gridColumn6.Name = "Resultado";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelH5);
            this.panel1.Controls.Add(this.panelH4);
            this.panel1.Controls.Add(this.panelH3);
            this.panel1.Controls.Add(this.panelH2);
            this.panel1.Controls.Add(this.panelH1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 184);
            this.panel1.TabIndex = 9;
            // 
            // panelH5
            // 
            this.panelH5.Controls.Add(this.progressBarH5);
            this.panelH5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelH5.Location = new System.Drawing.Point(0, 140);
            this.panelH5.Name = "panelH5";
            this.panelH5.Size = new System.Drawing.Size(1094, 35);
            this.panelH5.TabIndex = 4;
            // 
            // progressBarH5
            // 
            this.progressBarH5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.progressBarH5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarH5.Location = new System.Drawing.Point(12, 6);
            this.progressBarH5.Name = "progressBarH5";
            this.progressBarH5.Size = new System.Drawing.Size(1070, 23);
            this.progressBarH5.TabIndex = 2;
            this.progressBarH5.Text = "H5";
            this.progressBarH5.TextVisible = true;
            // 
            // panelH4
            // 
            this.panelH4.Controls.Add(this.progressBarH4);
            this.panelH4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelH4.Location = new System.Drawing.Point(0, 105);
            this.panelH4.Name = "panelH4";
            this.panelH4.Size = new System.Drawing.Size(1094, 35);
            this.panelH4.TabIndex = 3;
            // 
            // progressBarH4
            // 
            this.progressBarH4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.progressBarH4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarH4.Location = new System.Drawing.Point(12, 6);
            this.progressBarH4.Name = "progressBarH4";
            this.progressBarH4.Size = new System.Drawing.Size(1070, 23);
            this.progressBarH4.TabIndex = 2;
            this.progressBarH4.Text = "H4";
            this.progressBarH4.TextVisible = true;
            // 
            // panelH3
            // 
            this.panelH3.Controls.Add(this.progressBarH3);
            this.panelH3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelH3.Location = new System.Drawing.Point(0, 70);
            this.panelH3.Name = "panelH3";
            this.panelH3.Size = new System.Drawing.Size(1094, 35);
            this.panelH3.TabIndex = 2;
            // 
            // progressBarH3
            // 
            this.progressBarH3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.progressBarH3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarH3.Location = new System.Drawing.Point(12, 6);
            this.progressBarH3.Name = "progressBarH3";
            this.progressBarH3.Size = new System.Drawing.Size(1070, 23);
            this.progressBarH3.TabIndex = 2;
            this.progressBarH3.Text = "H3";
            this.progressBarH3.TextVisible = true;
            // 
            // panelH2
            // 
            this.panelH2.Controls.Add(this.progressBarH2);
            this.panelH2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelH2.Location = new System.Drawing.Point(0, 35);
            this.panelH2.Name = "panelH2";
            this.panelH2.Size = new System.Drawing.Size(1094, 35);
            this.panelH2.TabIndex = 1;
            // 
            // progressBarH2
            // 
            this.progressBarH2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.progressBarH2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarH2.Location = new System.Drawing.Point(12, 6);
            this.progressBarH2.Name = "progressBarH2";
            this.progressBarH2.Size = new System.Drawing.Size(1070, 23);
            this.progressBarH2.TabIndex = 2;
            this.progressBarH2.Text = "H2";
            this.progressBarH2.TextVisible = true;
            // 
            // panelH1
            // 
            this.panelH1.Controls.Add(this.progressBarH1);
            this.panelH1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelH1.Location = new System.Drawing.Point(0, 0);
            this.panelH1.Name = "panelH1";
            this.panelH1.Size = new System.Drawing.Size(1094, 35);
            this.panelH1.TabIndex = 0;
            // 
            // progressBarH1
            // 
            this.progressBarH1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.progressBarH1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarH1.Location = new System.Drawing.Point(12, 6);
            this.progressBarH1.Name = "progressBarH1";
            this.progressBarH1.Size = new System.Drawing.Size(1070, 23);
            this.progressBarH1.TabIndex = 1;
            this.progressBarH1.Text = "H1";
            this.progressBarH1.TextVisible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 597);
            this.Controls.Add(this.superGridControl1);
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite8);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FELSv Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dockSite7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.bar1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelH5.ResumeLayout(false);
            this.panelH4.ResumeLayout(false);
            this.panelH3.ResumeLayout(false);
            this.panelH2.ResumeLayout(false);
            this.panelH1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
        private DevComponents.DotNetBar.DockSite dockSite4;
        private DevComponents.DotNetBar.DockSite dockSite1;
        private DevComponents.DotNetBar.DockSite dockSite2;
        private DevComponents.DotNetBar.DockSite dockSite3;
        private DevComponents.DotNetBar.DockSite dockSite5;
        private DevComponents.DotNetBar.DockSite dockSite6;
        private DevComponents.DotNetBar.DockSite dockSite7;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.DockSite dockSite8;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.SwitchButtonItem switchButtonItem2;
        private System.Windows.Forms.Timer timer2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelH5;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarH5;
        private System.Windows.Forms.Panel panelH4;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarH4;
        private System.Windows.Forms.Panel panelH3;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarH3;
        private System.Windows.Forms.Panel panelH2;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarH2;
        private System.Windows.Forms.Panel panelH1;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarH1;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;

        public ProgressBarX ProgressBarH1 { get => progressBarH1; set => progressBarH1 = value; }
    }
}

