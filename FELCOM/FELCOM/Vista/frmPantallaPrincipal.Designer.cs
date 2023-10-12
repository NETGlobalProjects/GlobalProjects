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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.logsDgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XMLResponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxEx1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timerScanner = new System.Windows.Forms.Timer(this.components);
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleManagerAmbient1 = new DevComponents.DotNetBar.StyleManagerAmbient(this.components);
            this.ajustesbuttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pdfBtn = new DevComponents.DotNetBar.ButtonX();
            this.lblResultAsync = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaProcesosdataGridViewX1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1411, 24);
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
            this.listaProcesosdataGridViewX1.ColumnHeadersHeight = 25;
            this.listaProcesosdataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.listaProcesosdataGridViewX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaProcesosdataGridViewX1.Name = "listaProcesosdataGridViewX1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaProcesosdataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listaProcesosdataGridViewX1.RowHeadersWidth = 51;
            this.listaProcesosdataGridViewX1.Size = new System.Drawing.Size(1411, 650);
            this.listaProcesosdataGridViewX1.TabIndex = 0;
            // 
            // Archivo
            // 
            this.Archivo.DataPropertyName = "Archivo";
            this.Archivo.HeaderText = "Archivo";
            this.Archivo.MinimumWidth = 6;
            this.Archivo.Name = "Archivo";
            this.Archivo.Width = 300;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.DataPropertyName = "TipoDocumento";
            this.TipoDocumento.HeaderText = "Tipo Doc.";
            this.TipoDocumento.MinimumWidth = 6;
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.Width = 200;
            // 
            // Progreso
            // 
            this.Progreso.DataPropertyName = "Progreso";
            this.Progreso.HeaderText = "Progreso";
            this.Progreso.MinimumWidth = 6;
            this.Progreso.Name = "Progreso";
            this.Progreso.Text = null;
            this.Progreso.Width = 150;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 150;
            // 
            // vacio
            // 
            this.vacio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vacio.HeaderText = "";
            this.vacio.MinimumWidth = 6;
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
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1411, 684);
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
            this.superTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(1411, 684);
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabIndex = 1;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Document;
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.listaProcesosdataGridViewX1);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 34);
            this.superTabControlPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(1411, 650);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Symbol = "";
            this.superTabItem1.SymbolSize = 14F;
            this.superTabItem1.Text = "Procesos";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.panelEx2);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 37);
            this.superTabControlPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(1411, 641);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.splitContainer1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1411, 641);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.logsDgv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1411, 641);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // logsDgv
            // 
            this.logsDgv.AllowUserToAddRows = false;
            this.logsDgv.AllowUserToDeleteRows = false;
            this.logsDgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.logsDgv.ColumnHeadersHeight = 29;
            this.logsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.logsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fecha,
            this.Tipo,
            this.Mensaje,
            this.XMLResponse,
            this.vacio2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logsDgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.logsDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logsDgv.EnableHeadersVisualStyles = false;
            this.logsDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.logsDgv.Location = new System.Drawing.Point(0, 0);
            this.logsDgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logsDgv.Name = "logsDgv";
            this.logsDgv.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.logsDgv.RowHeadersWidth = 51;
            this.logsDgv.Size = new System.Drawing.Size(1411, 244);
            this.logsDgv.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 70;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 130;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 80;
            // 
            // Mensaje
            // 
            this.Mensaje.DataPropertyName = "Mensaje";
            this.Mensaje.HeaderText = "Mensaje";
            this.Mensaje.MinimumWidth = 6;
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.ReadOnly = true;
            this.Mensaje.Width = 350;
            // 
            // XMLResponse
            // 
            this.XMLResponse.DataPropertyName = "XMLResponse";
            this.XMLResponse.HeaderText = "Respuesta XML";
            this.XMLResponse.MinimumWidth = 6;
            this.XMLResponse.Name = "XMLResponse";
            this.XMLResponse.ReadOnly = true;
            this.XMLResponse.Width = 350;
            // 
            // vacio2
            // 
            this.vacio2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vacio2.HeaderText = "";
            this.vacio2.MinimumWidth = 6;
            this.vacio2.Name = "vacio2";
            this.vacio2.ReadOnly = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.richTextBoxEx1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer2.Size = new System.Drawing.Size(1411, 392);
            this.splitContainer2.SplitterDistance = 94;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 1;
            // 
            // richTextBoxEx1
            // 
            // 
            // 
            // 
            this.richTextBoxEx1.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEx1.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxEx1.Name = "richTextBoxEx1";
            this.richTextBoxEx1.Rtf = "{\\rtf1\\ansi\\deff0\\nouicompat{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft Sans Serif;}}\r" +
    "\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs19\\lang6154 richT" +
    "extBoxEx1\\par\r\n}\r\n";
            this.richTextBoxEx1.Size = new System.Drawing.Size(1411, 94);
            this.richTextBoxEx1.TabIndex = 0;
            this.richTextBoxEx1.Text = "richTextBoxEx1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1411, 293);
            this.webBrowser1.TabIndex = 0;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Symbol = "";
            this.superTabItem2.SymbolSize = 14F;
            this.superTabItem2.Text = "Logs";
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
            this.switchButton1.Location = new System.Drawing.Point(1255, 2);
            this.switchButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.OffText = "APAGADO";
            this.switchButton1.OnText = "ENCENDIDO";
            this.switchButton1.Size = new System.Drawing.Size(148, 27);
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
            this.ajustesbuttonX1.Location = new System.Drawing.Point(-4, 2);
            this.ajustesbuttonX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ajustesbuttonX1.Name = "ajustesbuttonX1";
            this.ajustesbuttonX1.Size = new System.Drawing.Size(131, 27);
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
            this.label1.Location = new System.Drawing.Point(343, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(1179, 4);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(68, 28);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Escaner:";
            // 
            // pdfBtn
            // 
            this.pdfBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.pdfBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.pdfBtn.Location = new System.Drawing.Point(785, 4);
            this.pdfBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pdfBtn.Name = "pdfBtn";
            this.pdfBtn.Size = new System.Drawing.Size(100, 28);
            this.pdfBtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pdfBtn.TabIndex = 6;
            this.pdfBtn.Text = "PDFF";
            // 
            // lblResultAsync
            // 
            this.lblResultAsync.AutoSize = true;
            this.lblResultAsync.Location = new System.Drawing.Point(893, 12);
            this.lblResultAsync.Name = "lblResultAsync";
            this.lblResultAsync.Size = new System.Drawing.Size(44, 16);
            this.lblResultAsync.TabIndex = 7;
            this.lblResultAsync.Text = "label2";
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 708);
            this.Controls.Add(this.lblResultAsync);
            this.Controls.Add(this.pdfBtn);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ajustesbuttonX1);
            this.Controls.Add(this.switchButton1);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPantallaPrincipal";
            this.Text = "FELCOM";
            ((System.ComponentModel.ISupportInitialize)(this.listaProcesosdataGridViewX1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logsDgv)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
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
        private DataGridViewX logsDgv;
        private LabelX labelX1;
        private ButtonX pdfBtn;
        private PanelEx panelEx2;
        private SplitContainer splitContainer1;
        private RichTextBoxEx richTextBoxEx1;
        private SplitContainer splitContainer2;
        private WebBrowser webBrowser1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Mensaje;
        private DataGridViewTextBoxColumn XMLResponse;
        private DataGridViewTextBoxColumn vacio2;
        private Label lblResultAsync;

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
        public DataGridViewX LogsDgv { get => logsDgv; set => logsDgv = value; }
        public ButtonX PdfBtn { get => pdfBtn; set => pdfBtn = value; }
        public RichTextBoxEx RichTextBoxEx1 { get => richTextBoxEx1; set => richTextBoxEx1 = value; }
        public WebBrowser WebBrowser1 { get => webBrowser1; set => webBrowser1 = value; }
        public Label LblResultAsync { get => lblResultAsync; set => lblResultAsync = value; }
    }
}