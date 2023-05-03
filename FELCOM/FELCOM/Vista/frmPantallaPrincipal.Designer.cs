using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;


namespace FELCOM.Vista
{
    partial class frmPantallaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listaProcesosdataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progreso = new DevComponents.DotNetBar.Controls.DataGridViewProgressBarXColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timerScanner = new System.Windows.Forms.Timer(this.components);
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleManagerAmbient1 = new DevComponents.DotNetBar.StyleManagerAmbient(this.components);
            this.ajustesbuttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaProcesosdataGridViewX1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listaProcesosdataGridViewX1
            // 
            this.listaProcesosdataGridViewX1.AllowUserToAddRows = false;
            this.listaProcesosdataGridViewX1.AllowUserToDeleteRows = false;
            this.listaProcesosdataGridViewX1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaProcesosdataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaProcesosdataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaProcesosdataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Archivo,
            this.TipoDocumento,
            this.Progreso,
            this.Estado,
            this.vacio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaProcesosdataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaProcesosdataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaProcesosdataGridViewX1.EnableHeadersVisualStyles = false;
            this.listaProcesosdataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.listaProcesosdataGridViewX1.Location = new System.Drawing.Point(0, 0);
            this.listaProcesosdataGridViewX1.Name = "listaProcesosdataGridViewX1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaProcesosdataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listaProcesosdataGridViewX1.Size = new System.Drawing.Size(935, 388);
            this.listaProcesosdataGridViewX1.TabIndex = 0;
            // 
            // Archivo
            // 
            this.Archivo.DataPropertyName = "Archivo";
            this.Archivo.HeaderText = "Archivo";
            this.Archivo.Name = "Archivo";
            this.Archivo.Width = 300;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "TipoDocumento";
            this.TipoDocumento.HeaderText = "Tipo Doc.";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.Width = 200;
            // 
            // Progreso
            // 
            this.Progreso.DataPropertyName = "Progreso";
            this.Progreso.HeaderText = "Progreso";
            this.Progreso.Name = "Progreso";
            this.Progreso.Text = null;
            this.Progreso.Width = 150;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 150;
            // 
            // vacio
            // 
            this.vacio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vacio.HeaderText = "";
            this.vacio.Name = "vacio";
            this.vacio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vacio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.superTabControl1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 24);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(935, 421);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // superTabControl1
            // 
            this.superTabControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.ForeColor = System.Drawing.Color.Black;
            this.superTabControl1.Location = new System.Drawing.Point(0, 0);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(935, 421);
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabIndex = 1;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.OfficeMobile2014;
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.listaProcesosdataGridViewX1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 33);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(935, 388);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "Procesos";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 33);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(1008, 525);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "Errores";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // timerScanner
            // 
            this.timerScanner.Enabled = true;
            this.timerScanner.Interval = 1000;
            // 
            // switchButton1
            // 
            this.switchButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton1.Location = new System.Drawing.Point(818, 2);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.OffText = "APAGADO";
            this.switchButton1.OnText = "ENCENDIDO";
            this.switchButton1.Size = new System.Drawing.Size(111, 22);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.TabIndex = 2;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.OfficeMobile2014;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // ajustesbuttonX1
            // 
            this.ajustesbuttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ajustesbuttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            this.ajustesbuttonX1.Location = new System.Drawing.Point(3, 2);
            this.ajustesbuttonX1.Name = "ajustesbuttonX1";
            this.ajustesbuttonX1.Size = new System.Drawing.Size(98, 23);
            this.ajustesbuttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ajustesbuttonX1.Symbol = "";
            this.ajustesbuttonX1.SymbolSize = 12F;
            this.ajustesbuttonX1.TabIndex = 3;
            this.ajustesbuttonX1.Text = "Ajustes";
            this.ajustesbuttonX1.Click += new System.EventHandler(this.ajustesbuttonX1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ajustesbuttonX1);
            this.Controls.Add(this.switchButton1);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPantallaPrincipal";
            this.Text = "FELCOM";
            ((System.ComponentModel.ISupportInitialize)(this.listaProcesosdataGridViewX1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private DevComponents.DotNetBar.Controls.DataGridViewX listaProcesosdataGridViewX1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Timer timerScanner;
        private DataGridViewTextBoxColumn Archivo;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewProgressBarXColumn Progreso;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn vacio;
        private SwitchButton switchButton1;
        private StyleManager styleManager1;
        private StyleManagerAmbient styleManagerAmbient1;
        private ButtonX ajustesbuttonX1;
        private Label label1;

        public DataGridViewX ListaProcesosdataGridViewX1 { get => listaProcesosdataGridViewX1; set => listaProcesosdataGridViewX1 = value; }
        public PanelEx PanelEx1 { get => panelEx1; set => panelEx1 = value; }
        public SuperTabControl SuperTabControl1 { get => superTabControl1; set => superTabControl1 = value; }
        public SuperTabControlPanel SuperTabControlPanel1 { get => superTabControlPanel1; set => superTabControlPanel1 = value; }
        public SuperTabItem SuperTabItem1 { get => superTabItem1; set => superTabItem1 = value; }
        public SuperTabControlPanel SuperTabControlPanel2 { get => superTabControlPanel2; set => superTabControlPanel2 = value; }
        public SuperTabItem SuperTabItem2 { get => superTabItem2; set => superTabItem2 = value; }
        public DataGridViewTextBoxColumn Archivo1 { get => Archivo; set => Archivo = value; }
        public DataGridViewTextBoxColumn TipoDocumento1 { get => TipoDocumento; set => TipoDocumento = value; }
        public DataGridViewProgressBarXColumn Progreso1 { get => Progreso; set => Progreso = value; }
        public DataGridViewTextBoxColumn Estado1 { get => Estado; set => Estado = value; }
        public DataGridViewTextBoxColumn Vacio { get => vacio; set => vacio = value; }
        public Timer Timer1 { get => timer1; set => timer1 = value; }
        public Timer TimerScanner { get => timerScanner; set => timerScanner = value; }
        public SwitchButton SwitchButton1 { get => switchButton1; set => switchButton1 = value; }
        public ButtonX AjustesbuttonX1 { get => ajustesbuttonX1; set => ajustesbuttonX1 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
    }
}