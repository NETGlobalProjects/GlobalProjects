namespace ArchivadorFEL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            porEmpresacheckBox1 = new CheckBox();
            empresasComboBox1 = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            hastaDateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            desdeDateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            destinobutton1 = new Button();
            groupBox2 = new GroupBox();
            progressBar1 = new ProgressBar();
            indicadorProgresolabel4 = new Label();
            FD = new FolderBrowserDialog();
            button2 = new Button();
            informacionLabel = new Label();
            comenzarbutton3 = new Button();
            BW = new System.ComponentModel.BackgroundWorker();
            menuStrip1 = new MenuStrip();
            cambiarOrigenToolStripMenuItem = new ToolStripMenuItem();
            logslinkLabel1 = new LinkLabel();
            Loginpanel1 = new Panel();
            label6 = new Label();
            button3 = new Button();
            contraseñatextBox2 = new TextBox();
            usuariotextBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            controlpanel1 = new Panel();
            groupBox3 = new GroupBox();
            porSucursalcheckBox2 = new CheckBox();
            sucursalescomboBox1 = new ComboBox();
            label8 = new Label();
            cerrarSesionbutton1 = new Button();
            infoUsuariolabel7 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            Loginpanel1.SuspendLayout();
            controlpanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // porEmpresacheckBox1
            // 
            porEmpresacheckBox1.AutoSize = true;
            porEmpresacheckBox1.Location = new Point(11, 22);
            porEmpresacheckBox1.Name = "porEmpresacheckBox1";
            porEmpresacheckBox1.Size = new Size(92, 19);
            porEmpresacheckBox1.TabIndex = 0;
            porEmpresacheckBox1.Text = "Por Empresa";
            porEmpresacheckBox1.UseVisualStyleBackColor = true;
            porEmpresacheckBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // empresasComboBox1
            // 
            empresasComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            empresasComboBox1.Enabled = false;
            empresasComboBox1.FormattingEnabled = true;
            empresasComboBox1.Location = new Point(238, 19);
            empresasComboBox1.Name = "empresasComboBox1";
            empresasComboBox1.Size = new Size(287, 23);
            empresasComboBox1.TabIndex = 1;
            empresasComboBox1.SelectionChangeCommitted += empresasComboBox1_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 22);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione la Empresa";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(hastaDateTimePicker2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(desdeDateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(23, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 70);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estableza el rango de fecha";
            // 
            // hastaDateTimePicker2
            // 
            hastaDateTimePicker2.Format = DateTimePickerFormat.Short;
            hastaDateTimePicker2.Location = new Point(302, 28);
            hastaDateTimePicker2.Name = "hastaDateTimePicker2";
            hastaDateTimePicker2.Size = new Size(102, 23);
            hastaDateTimePicker2.TabIndex = 3;
            hastaDateTimePicker2.ValueChanged += hastaDateTimePicker2_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 34);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 2;
            label3.Text = "Al";
            // 
            // desdeDateTimePicker1
            // 
            desdeDateTimePicker1.Format = DateTimePickerFormat.Short;
            desdeDateTimePicker1.Location = new Point(141, 28);
            desdeDateTimePicker1.Name = "desdeDateTimePicker1";
            desdeDateTimePicker1.Size = new Size(102, 23);
            desdeDateTimePicker1.TabIndex = 1;
            desdeDateTimePicker1.ValueChanged += desdeDateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 34);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 0;
            label2.Text = "Del";
            // 
            // destinobutton1
            // 
            destinobutton1.Location = new Point(25, 177);
            destinobutton1.Name = "destinobutton1";
            destinobutton1.Size = new Size(249, 31);
            destinobutton1.TabIndex = 4;
            destinobutton1.Text = "Seleccionar Destino";
            destinobutton1.UseVisualStyleBackColor = true;
            destinobutton1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Location = new Point(27, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(509, 57);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Progreso";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(6, 22);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(497, 23);
            progressBar1.TabIndex = 0;
            // 
            // indicadorProgresolabel4
            // 
            indicadorProgresolabel4.AutoSize = true;
            indicadorProgresolabel4.BackColor = SystemColors.Control;
            indicadorProgresolabel4.Location = new Point(25, 307);
            indicadorProgresolabel4.Name = "indicadorProgresolabel4";
            indicadorProgresolabel4.Size = new Size(12, 15);
            indicadorProgresolabel4.TabIndex = 1;
            indicadorProgresolabel4.Text = "-";
            indicadorProgresolabel4.Visible = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(429, 399);
            button2.Name = "button2";
            button2.Size = new Size(143, 23);
            button2.TabIndex = 6;
            button2.Text = "Salir del aplicativo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // informacionLabel
            // 
            informacionLabel.AutoSize = true;
            informacionLabel.Location = new Point(29, 217);
            informacionLabel.Name = "informacionLabel";
            informacionLabel.Size = new Size(12, 15);
            informacionLabel.TabIndex = 7;
            informacionLabel.Text = "-";
            // 
            // comenzarbutton3
            // 
            comenzarbutton3.Location = new Point(287, 177);
            comenzarbutton3.Name = "comenzarbutton3";
            comenzarbutton3.Size = new Size(249, 31);
            comenzarbutton3.TabIndex = 8;
            comenzarbutton3.Text = "Comenzar archivado";
            comenzarbutton3.UseVisualStyleBackColor = true;
            comenzarbutton3.Click += button3_Click;
            // 
            // BW
            // 
            BW.WorkerReportsProgress = true;
            BW.WorkerSupportsCancellation = true;
            BW.DoWork += BW_DoWork;
            BW.ProgressChanged += BW_ProgressChanged;
            BW.RunWorkerCompleted += BW_RunWorkerCompleted;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cambiarOrigenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // cambiarOrigenToolStripMenuItem
            // 
            cambiarOrigenToolStripMenuItem.Image = Properties.Resources.directory;
            cambiarOrigenToolStripMenuItem.Name = "cambiarOrigenToolStripMenuItem";
            cambiarOrigenToolStripMenuItem.Size = new Size(119, 20);
            cambiarOrigenToolStripMenuItem.Text = "Cambiar Origen";
            cambiarOrigenToolStripMenuItem.Click += cambiarOrigenToolStripMenuItem_Click;
            // 
            // logslinkLabel1
            // 
            logslinkLabel1.AutoSize = true;
            logslinkLabel1.Location = new Point(22, 327);
            logslinkLabel1.Name = "logslinkLabel1";
            logslinkLabel1.Size = new Size(12, 15);
            logslinkLabel1.TabIndex = 10;
            logslinkLabel1.TabStop = true;
            logslinkLabel1.Text = "-";
            logslinkLabel1.LinkClicked += logslinkLabel1_LinkClicked;
            // 
            // Loginpanel1
            // 
            Loginpanel1.Controls.Add(label6);
            Loginpanel1.Controls.Add(button3);
            Loginpanel1.Controls.Add(contraseñatextBox2);
            Loginpanel1.Controls.Add(usuariotextBox1);
            Loginpanel1.Controls.Add(label5);
            Loginpanel1.Controls.Add(label4);
            Loginpanel1.Location = new Point(97, 102);
            Loginpanel1.Name = "Loginpanel1";
            Loginpanel1.Size = new Size(390, 172);
            Loginpanel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 10);
            label6.Name = "label6";
            label6.Size = new Size(188, 15);
            label6.TabIndex = 5;
            label6.Text = "Ingrese sus credenciales de acceso";
            // 
            // button3
            // 
            button3.Location = new Point(153, 126);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Ingresar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // contraseñatextBox2
            // 
            contraseñatextBox2.Location = new Point(137, 84);
            contraseñatextBox2.Name = "contraseñatextBox2";
            contraseñatextBox2.PasswordChar = '*';
            contraseñatextBox2.Size = new Size(176, 23);
            contraseñatextBox2.TabIndex = 1;
            contraseñatextBox2.KeyDown += contraseñatextBox2_KeyDown;
            // 
            // usuariotextBox1
            // 
            usuariotextBox1.Location = new Point(137, 52);
            usuariotextBox1.Name = "usuariotextBox1";
            usuariotextBox1.Size = new Size(176, 23);
            usuariotextBox1.TabIndex = 0;
            usuariotextBox1.KeyDown += usuariotextBox1_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 92);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 1;
            label5.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 55);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 0;
            label4.Text = "Usuario:";
            // 
            // controlpanel1
            // 
            controlpanel1.Controls.Add(groupBox3);
            controlpanel1.Controls.Add(indicadorProgresolabel4);
            controlpanel1.Controls.Add(groupBox1);
            controlpanel1.Controls.Add(logslinkLabel1);
            controlpanel1.Controls.Add(destinobutton1);
            controlpanel1.Controls.Add(comenzarbutton3);
            controlpanel1.Controls.Add(groupBox2);
            controlpanel1.Controls.Add(informacionLabel);
            controlpanel1.Location = new Point(14, 32);
            controlpanel1.Name = "controlpanel1";
            controlpanel1.Size = new Size(556, 359);
            controlpanel1.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(porSucursalcheckBox2);
            groupBox3.Controls.Add(sucursalescomboBox1);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(porEmpresacheckBox1);
            groupBox3.Controls.Add(empresasComboBox1);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(18, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(535, 88);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filtrar por";
            // 
            // porSucursalcheckBox2
            // 
            porSucursalcheckBox2.AutoSize = true;
            porSucursalcheckBox2.Enabled = false;
            porSucursalcheckBox2.Location = new Point(10, 51);
            porSucursalcheckBox2.Name = "porSucursalcheckBox2";
            porSucursalcheckBox2.Size = new Size(91, 19);
            porSucursalcheckBox2.TabIndex = 3;
            porSucursalcheckBox2.Text = "Por Sucursal";
            porSucursalcheckBox2.UseVisualStyleBackColor = true;
            porSucursalcheckBox2.CheckedChanged += porSucursalcheckBox2_CheckedChanged;
            // 
            // sucursalescomboBox1
            // 
            sucursalescomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            sucursalescomboBox1.Enabled = false;
            sucursalescomboBox1.FormattingEnabled = true;
            sucursalescomboBox1.Location = new Point(237, 48);
            sucursalescomboBox1.Name = "sucursalescomboBox1";
            sucursalescomboBox1.Size = new Size(287, 23);
            sucursalescomboBox1.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(108, 51);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 5;
            label8.Text = "Seleccione la Sucursal";
            // 
            // cerrarSesionbutton1
            // 
            cerrarSesionbutton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cerrarSesionbutton1.Location = new Point(468, 1);
            cerrarSesionbutton1.Name = "cerrarSesionbutton1";
            cerrarSesionbutton1.Size = new Size(100, 25);
            cerrarSesionbutton1.TabIndex = 13;
            cerrarSesionbutton1.Text = "&Cerrar sesión";
            cerrarSesionbutton1.UseVisualStyleBackColor = true;
            cerrarSesionbutton1.Click += cerrarSesionbutton1_Click;
            // 
            // infoUsuariolabel7
            // 
            infoUsuariolabel7.AutoSize = true;
            infoUsuariolabel7.Location = new Point(17, 362);
            infoUsuariolabel7.Name = "infoUsuariolabel7";
            infoUsuariolabel7.Size = new Size(128, 15);
            infoUsuariolabel7.TabIndex = 11;
            infoUsuariolabel7.Text = "Usuario: Desconectado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(252, 365);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 14;
            label7.Text = "Version 1.0.0.2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 428);
            Controls.Add(label7);
            Controls.Add(infoUsuariolabel7);
            Controls.Add(cerrarSesionbutton1);
            Controls.Add(Loginpanel1);
            Controls.Add(controlpanel1);
            Controls.Add(button2);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Archivador FEL";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            Loginpanel1.ResumeLayout(false);
            Loginpanel1.PerformLayout();
            controlpanel1.ResumeLayout(false);
            controlpanel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox porEmpresacheckBox1;
        private ComboBox empresasComboBox1;
        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker hastaDateTimePicker2;
        private Label label3;
        private DateTimePicker desdeDateTimePicker1;
        private Label label2;
        private Button destinobutton1;
        private GroupBox groupBox2;
        private ProgressBar progressBar1;
        private FolderBrowserDialog FD;
        private Button button2;
        private Label informacionLabel;
        private Button comenzarbutton3;
        private System.ComponentModel.BackgroundWorker BW;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cambiarOrigenToolStripMenuItem;
        private LinkLabel logslinkLabel1;
        private Label indicadorProgresolabel4;
        private Panel Loginpanel1;
        private Button button3;
        private TextBox contraseñatextBox2;
        private TextBox usuariotextBox1;
        private Label label5;
        private Label label4;
        private Panel controlpanel1;
        private Label label6;
        private Button cerrarSesionbutton1;
        private Label infoUsuariolabel7;
        private Label label7;
        private GroupBox groupBox3;
        private CheckBox porSucursalcheckBox2;
        private ComboBox sucursalescomboBox1;
        private Label label8;
    }
}
