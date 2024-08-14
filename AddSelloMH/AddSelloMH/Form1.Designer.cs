namespace AddSelloMH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descargarJsonheckBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hastaDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.desdeDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.documentosSinRespuestalabel11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.documentosConRespuestalabel9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.documentosConteoLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.empresasConteolabel5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descargarJsonheckBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.hastaDateTimePicker2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.desdeDateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(368, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rangos";
            // 
            // descargarJsonheckBox1
            // 
            this.descargarJsonheckBox1.AutoSize = true;
            this.descargarJsonheckBox1.Checked = true;
            this.descargarJsonheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.descargarJsonheckBox1.Location = new System.Drawing.Point(87, 95);
            this.descargarJsonheckBox1.Name = "descargarJsonheckBox1";
            this.descargarJsonheckBox1.Size = new System.Drawing.Size(214, 20);
            this.descargarJsonheckBox1.TabIndex = 5;
            this.descargarJsonheckBox1.Text = "Descargar JSON de respuesta";
            this.descargarJsonheckBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hastaDateTimePicker2
            // 
            this.hastaDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaDateTimePicker2.Location = new System.Drawing.Point(87, 60);
            this.hastaDateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.hastaDateTimePicker2.Name = "hastaDateTimePicker2";
            this.hastaDateTimePicker2.Size = new System.Drawing.Size(141, 22);
            this.hastaDateTimePicker2.TabIndex = 3;
            this.hastaDateTimePicker2.ValueChanged += new System.EventHandler(this.hastaDateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // desdeDateTimePicker1
            // 
            this.desdeDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdeDateTimePicker1.Location = new System.Drawing.Point(87, 32);
            this.desdeDateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.desdeDateTimePicker1.Name = "desdeDateTimePicker1";
            this.desdeDateTimePicker1.Size = new System.Drawing.Size(141, 22);
            this.desdeDateTimePicker1.TabIndex = 1;
            this.desdeDateTimePicker1.ValueChanged += new System.EventHandler(this.desdeDateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 165);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(819, 28);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "...";
            this.label3.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.documentosSinRespuestalabel11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.documentosConRespuestalabel9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.documentosConteoLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.empresasConteolabel5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(393, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(441, 126);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(275, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ver resultados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // documentosSinRespuestalabel11
            // 
            this.documentosSinRespuestalabel11.AutoSize = true;
            this.documentosSinRespuestalabel11.ForeColor = System.Drawing.Color.Red;
            this.documentosSinRespuestalabel11.Location = new System.Drawing.Point(213, 95);
            this.documentosSinRespuestalabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.documentosSinRespuestalabel11.Name = "documentosSinRespuestalabel11";
            this.documentosSinRespuestalabel11.Size = new System.Drawing.Size(14, 16);
            this.documentosSinRespuestalabel11.TabIndex = 7;
            this.documentosSinRespuestalabel11.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 95);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Docs. sin respuesta";
            // 
            // documentosConRespuestalabel9
            // 
            this.documentosConRespuestalabel9.AutoSize = true;
            this.documentosConRespuestalabel9.ForeColor = System.Drawing.Color.Green;
            this.documentosConRespuestalabel9.Location = new System.Drawing.Point(213, 71);
            this.documentosConRespuestalabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.documentosConRespuestalabel9.Name = "documentosConRespuestalabel9";
            this.documentosConRespuestalabel9.Size = new System.Drawing.Size(14, 16);
            this.documentosConRespuestalabel9.TabIndex = 5;
            this.documentosConRespuestalabel9.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Docs. con respuesta";
            // 
            // documentosConteoLabel
            // 
            this.documentosConteoLabel.AutoSize = true;
            this.documentosConteoLabel.Location = new System.Drawing.Point(213, 48);
            this.documentosConteoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.documentosConteoLabel.Name = "documentosConteoLabel";
            this.documentosConteoLabel.Size = new System.Drawing.Size(14, 16);
            this.documentosConteoLabel.TabIndex = 3;
            this.documentosConteoLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Documentos a consultar";
            // 
            // empresasConteolabel5
            // 
            this.empresasConteolabel5.AutoSize = true;
            this.empresasConteolabel5.Location = new System.Drawing.Point(213, 25);
            this.empresasConteolabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empresasConteolabel5.Name = "empresasConteolabel5";
            this.empresasConteolabel5.Size = new System.Drawing.Size(14, 16);
            this.empresasConteolabel5.TabIndex = 1;
            this.empresasConteolabel5.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Empresa(s)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 208);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Verificador sello MH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker hastaDateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker desdeDateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label documentosSinRespuestalabel11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label documentosConRespuestalabel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label documentosConteoLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label empresasConteolabel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox descargarJsonheckBox1;
        private System.Windows.Forms.Button button2;
    }
}

