namespace ArchivadorFEL
{
    partial class frmCambiarOrigen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarOrigen));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            FD = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Origen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 26);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 1;
            label2.Text = "-";
            // 
            // button1
            // 
            button1.Location = new Point(126, 78);
            button1.Name = "button1";
            button1.Size = new Size(189, 23);
            button1.TabIndex = 2;
            button1.Text = "Seleccionar directorio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(321, 78);
            button2.Name = "button2";
            button2.Size = new Size(124, 23);
            button2.TabIndex = 3;
            button2.Text = "Guardar cambios";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmCambiarOrigen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 113);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCambiarOrigen";
            Text = "Seleccione el nuevo origen";
            Load += frmCambiarOrigen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private FolderBrowserDialog FD;
    }
}