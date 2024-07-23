namespace ArchivadorFEL
{
    partial class frmLogs
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            icon = new DataGridViewImageColumn();
            Tipo = new DataGridViewTextBoxColumn();
            nombreCortoEmpresa = new DataGridViewTextBoxColumn();
            Tda = new DataGridViewTextBoxColumn();
            TipoDoc = new DataGridViewTextBoxColumn();
            Serie = new DataGridViewTextBoxColumn();
            DocNo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Archivo = new DataGridViewTextBoxColumn();
            Formato = new DataGridViewTextBoxColumn();
            vacio = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            exportarbutton1 = new Button();
            tipocomboBox1 = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            archivotextBox2 = new TextBox();
            mensajetextBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { icon, Tipo, nombreCortoEmpresa, Tda, TipoDoc, Serie, DocNo, Fecha, Archivo, Formato, vacio });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1026, 461);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // icon
            // 
            icon.HeaderText = "<->";
            icon.ImageLayout = DataGridViewImageCellLayout.Zoom;
            icon.Name = "icon";
            icon.Width = 40;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            // 
            // nombreCortoEmpresa
            // 
            nombreCortoEmpresa.DataPropertyName = "nombreCortoEmpresa";
            nombreCortoEmpresa.HeaderText = "Empresa";
            nombreCortoEmpresa.Name = "nombreCortoEmpresa";
            nombreCortoEmpresa.Width = 130;
            // 
            // Tda
            // 
            Tda.DataPropertyName = "Sucursal";
            Tda.HeaderText = "Sucursal";
            Tda.Name = "Tda";
            Tda.Width = 150;
            // 
            // TipoDoc
            // 
            TipoDoc.DataPropertyName = "TipoDoc";
            TipoDoc.HeaderText = "TipoDoc";
            TipoDoc.Name = "TipoDoc";
            TipoDoc.Width = 150;
            // 
            // Serie
            // 
            Serie.DataPropertyName = "Serie";
            Serie.HeaderText = "Serie";
            Serie.Name = "Serie";
            // 
            // DocNo
            // 
            DocNo.DataPropertyName = "DocNo";
            DocNo.HeaderText = "DocNo";
            DocNo.Name = "DocNo";
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            Fecha.DefaultCellStyle = dataGridViewCellStyle1;
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Archivo
            // 
            Archivo.DataPropertyName = "Archivo";
            Archivo.HeaderText = "Archivo";
            Archivo.Name = "Archivo";
            Archivo.Visible = false;
            // 
            // Formato
            // 
            Formato.DataPropertyName = "formatoArchivo";
            Formato.HeaderText = "Formato";
            Formato.Name = "Formato";
            // 
            // vacio
            // 
            vacio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vacio.HeaderText = "";
            vacio.Name = "vacio";
            // 
            // panel1
            // 
            panel1.Controls.Add(exportarbutton1);
            panel1.Controls.Add(tipocomboBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 32);
            panel1.TabIndex = 1;
            // 
            // exportarbutton1
            // 
            exportarbutton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exportarbutton1.Location = new Point(903, 5);
            exportarbutton1.Name = "exportarbutton1";
            exportarbutton1.Size = new Size(117, 23);
            exportarbutton1.TabIndex = 2;
            exportarbutton1.Text = "Exportar a Excel";
            exportarbutton1.UseVisualStyleBackColor = true;
            exportarbutton1.Click += exportarbutton1_Click;
            // 
            // tipocomboBox1
            // 
            tipocomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            tipocomboBox1.FormattingEnabled = true;
            tipocomboBox1.Location = new Point(57, 4);
            tipocomboBox1.Name = "tipocomboBox1";
            tipocomboBox1.Size = new Size(145, 23);
            tipocomboBox1.TabIndex = 1;
            tipocomboBox1.SelectionChangeCommitted += tipocomboBox1_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 7);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(archivotextBox2);
            panel2.Controls.Add(mensajetextBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1026, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 493);
            panel2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 17);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 5;
            label5.Text = "Detalles";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 20);
            label4.Name = "label4";
            label4.Size = new Size(272, 15);
            label4.TabIndex = 4;
            label4.Text = "_____________________________________________________";
            // 
            // archivotextBox2
            // 
            archivotextBox2.Location = new Point(16, 239);
            archivotextBox2.Multiline = true;
            archivotextBox2.Name = "archivotextBox2";
            archivotextBox2.Size = new Size(267, 134);
            archivotextBox2.TabIndex = 3;
            // 
            // mensajetextBox1
            // 
            mensajetextBox1.Location = new Point(16, 73);
            mensajetextBox1.Multiline = true;
            mensajetextBox1.Name = "mensajetextBox1";
            mensajetextBox1.Size = new Size(267, 134);
            mensajetextBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 221);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 1;
            label3.Text = "Achivo";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 55);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Mensaje";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Archivo de Excel | *.xlsx";
            // 
            // frmLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 493);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmLogs";
            Text = "Logs";
            Load += frmLogs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private ComboBox tipocomboBox1;
        private Label label1;
        private Panel panel2;
        private TextBox mensajetextBox1;
        private Label label3;
        private Label label2;
        private TextBox archivotextBox2;
        private Label label4;
        private Label label5;
        private DataGridViewImageColumn icon;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn nombreCortoEmpresa;
        private DataGridViewTextBoxColumn Tda;
        private DataGridViewTextBoxColumn TipoDoc;
        private DataGridViewTextBoxColumn Serie;
        private DataGridViewTextBoxColumn DocNo;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Archivo;
        private DataGridViewTextBoxColumn vacio;
        private Button exportarbutton1;
        private SaveFileDialog saveFileDialog1;
        private DataGridViewTextBoxColumn Formato;
    }
}