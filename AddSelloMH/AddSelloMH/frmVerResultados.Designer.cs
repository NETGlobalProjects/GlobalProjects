namespace AddSelloMH
{
    partial class frmVerResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerResultados));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dealer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoGeneracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelloRecibido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conRespuesta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Json = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodPais,
            this.Dealer,
            this.Tda,
            this.TipoDoc,
            this.Serie,
            this.DocNo,
            this.CodigoGeneracion,
            this.SelloRecibido,
            this.conRespuesta,
            this.Json,
            this.vacio});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1596, 789);
            this.dataGridView1.TabIndex = 0;
            // 
            // CodPais
            // 
            this.CodPais.DataPropertyName = "CodPais";
            this.CodPais.HeaderText = "CodPais";
            this.CodPais.MinimumWidth = 6;
            this.CodPais.Name = "CodPais";
            this.CodPais.Visible = false;
            this.CodPais.Width = 125;
            // 
            // Dealer
            // 
            this.Dealer.DataPropertyName = "Dealer";
            this.Dealer.HeaderText = "Dealer";
            this.Dealer.MinimumWidth = 6;
            this.Dealer.Name = "Dealer";
            this.Dealer.Width = 80;
            // 
            // Tda
            // 
            this.Tda.DataPropertyName = "Tda";
            this.Tda.HeaderText = "Tda";
            this.Tda.MinimumWidth = 6;
            this.Tda.Name = "Tda";
            this.Tda.Width = 90;
            // 
            // TipoDoc
            // 
            this.TipoDoc.DataPropertyName = "TipoDoc";
            this.TipoDoc.HeaderText = "TipoDoc";
            this.TipoDoc.MinimumWidth = 6;
            this.TipoDoc.Name = "TipoDoc";
            this.TipoDoc.Width = 90;
            // 
            // Serie
            // 
            this.Serie.DataPropertyName = "Serie";
            this.Serie.HeaderText = "Serie";
            this.Serie.MinimumWidth = 6;
            this.Serie.Name = "Serie";
            this.Serie.Width = 125;
            // 
            // DocNo
            // 
            this.DocNo.DataPropertyName = "DocNo";
            this.DocNo.HeaderText = "DocNo";
            this.DocNo.MinimumWidth = 6;
            this.DocNo.Name = "DocNo";
            this.DocNo.Width = 125;
            // 
            // CodigoGeneracion
            // 
            this.CodigoGeneracion.DataPropertyName = "CodigoGeneracion";
            this.CodigoGeneracion.HeaderText = "CodigoGeneracion";
            this.CodigoGeneracion.MinimumWidth = 6;
            this.CodigoGeneracion.Name = "CodigoGeneracion";
            this.CodigoGeneracion.Width = 250;
            // 
            // SelloRecibido
            // 
            this.SelloRecibido.DataPropertyName = "SelloRecibido";
            this.SelloRecibido.HeaderText = "SelloRecibido";
            this.SelloRecibido.MinimumWidth = 6;
            this.SelloRecibido.Name = "SelloRecibido";
            this.SelloRecibido.Width = 250;
            // 
            // conRespuesta
            // 
            this.conRespuesta.DataPropertyName = "conRespuesta";
            this.conRespuesta.HeaderText = "ConRespuesta";
            this.conRespuesta.MinimumWidth = 6;
            this.conRespuesta.Name = "conRespuesta";
            this.conRespuesta.Width = 125;
            // 
            // Json
            // 
            this.Json.DataPropertyName = "Json";
            this.Json.HeaderText = "Json";
            this.Json.MinimumWidth = 6;
            this.Json.Name = "Json";
            this.Json.Width = 300;
            // 
            // vacio
            // 
            this.vacio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vacio.HeaderText = "";
            this.vacio.MinimumWidth = 6;
            this.vacio.Name = "vacio";
            // 
            // frmVerResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 789);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerResultados";
            this.Text = "Ver resultados";
            this.Load += new System.EventHandler(this.frmVerResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dealer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoGeneracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelloRecibido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn conRespuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Json;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacio;
    }
}