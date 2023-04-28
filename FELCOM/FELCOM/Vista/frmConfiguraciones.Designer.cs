using System.Windows.Forms;

namespace FELCOM.Vista
{
    partial class frmConfiguraciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguraciones));
            this.cancelarbutton1 = new System.Windows.Forms.Button();
            this.Aceptarbutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.raiztextBox1 = new System.Windows.Forms.TextBox();
            this.procesadostextBox2 = new System.Windows.Forms.TextBox();
            this.respuestastextBox3 = new System.Windows.Forms.TextBox();
            this.errorestextBox4 = new System.Windows.Forms.TextBox();
            this.explorarRaizbutton1 = new System.Windows.Forms.Button();
            this.explorarProcesadosbutton2 = new System.Windows.Forms.Button();
            this.explorarRespuestasbutton3 = new System.Windows.Forms.Button();
            this.explorarErroresbutton4 = new System.Windows.Forms.Button();
            this.exploraropenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.tiemponumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.urlWStextBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.usuarioWStextBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.peticionesParalelasnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.contraseñaWStextBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.procesandotextBox1 = new System.Windows.Forms.TextBox();
            this.proceasandobutton1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.puertoSMTPtextBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.servidorSMTPtextBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.contraseñaCorreotextBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.correotextBox2 = new System.Windows.Forms.TextBox();
            this.usuarioCorreotextBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.explorarfolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.tiemponumericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peticionesParalelasnumericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelarbutton1
            // 
            this.cancelarbutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarbutton1.Location = new System.Drawing.Point(448, 542);
            this.cancelarbutton1.Name = "cancelarbutton1";
            this.cancelarbutton1.Size = new System.Drawing.Size(75, 23);
            this.cancelarbutton1.TabIndex = 0;
            this.cancelarbutton1.Text = "&Cancelar";
            this.cancelarbutton1.UseVisualStyleBackColor = true;
            // 
            // Aceptarbutton2
            // 
            this.Aceptarbutton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Aceptarbutton2.Location = new System.Drawing.Point(367, 542);
            this.Aceptarbutton2.Name = "Aceptarbutton2";
            this.Aceptarbutton2.Size = new System.Drawing.Size(75, 23);
            this.Aceptarbutton2.TabIndex = 1;
            this.Aceptarbutton2.Text = "&Aceptar";
            this.Aceptarbutton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carpeta raíz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(49, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carpeta Procesados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(49, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carpeta Respuestas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(49, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Carpeta Errores";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // raiztextBox1
            // 
            this.raiztextBox1.Enabled = false;
            this.raiztextBox1.Location = new System.Drawing.Point(180, 23);
            this.raiztextBox1.Name = "raiztextBox1";
            this.raiztextBox1.Size = new System.Drawing.Size(295, 20);
            this.raiztextBox1.TabIndex = 0;
            // 
            // procesadostextBox2
            // 
            this.procesadostextBox2.Enabled = false;
            this.procesadostextBox2.Location = new System.Drawing.Point(180, 72);
            this.procesadostextBox2.Name = "procesadostextBox2";
            this.procesadostextBox2.Size = new System.Drawing.Size(295, 20);
            this.procesadostextBox2.TabIndex = 1;
            // 
            // respuestastextBox3
            // 
            this.respuestastextBox3.Enabled = false;
            this.respuestastextBox3.Location = new System.Drawing.Point(180, 98);
            this.respuestastextBox3.Name = "respuestastextBox3";
            this.respuestastextBox3.Size = new System.Drawing.Size(295, 20);
            this.respuestastextBox3.TabIndex = 2;
            // 
            // errorestextBox4
            // 
            this.errorestextBox4.Enabled = false;
            this.errorestextBox4.Location = new System.Drawing.Point(180, 124);
            this.errorestextBox4.Name = "errorestextBox4";
            this.errorestextBox4.Size = new System.Drawing.Size(295, 20);
            this.errorestextBox4.TabIndex = 3;
            // 
            // explorarRaizbutton1
            // 
            this.explorarRaizbutton1.Location = new System.Drawing.Point(478, 23);
            this.explorarRaizbutton1.Name = "explorarRaizbutton1";
            this.explorarRaizbutton1.Size = new System.Drawing.Size(27, 20);
            this.explorarRaizbutton1.TabIndex = 10;
            this.explorarRaizbutton1.Text = "...";
            this.explorarRaizbutton1.UseVisualStyleBackColor = true;
            // 
            // explorarProcesadosbutton2
            // 
            this.explorarProcesadosbutton2.Location = new System.Drawing.Point(478, 72);
            this.explorarProcesadosbutton2.Name = "explorarProcesadosbutton2";
            this.explorarProcesadosbutton2.Size = new System.Drawing.Size(27, 20);
            this.explorarProcesadosbutton2.TabIndex = 11;
            this.explorarProcesadosbutton2.Text = "...";
            this.explorarProcesadosbutton2.UseVisualStyleBackColor = true;
            // 
            // explorarRespuestasbutton3
            // 
            this.explorarRespuestasbutton3.Location = new System.Drawing.Point(478, 98);
            this.explorarRespuestasbutton3.Name = "explorarRespuestasbutton3";
            this.explorarRespuestasbutton3.Size = new System.Drawing.Size(27, 20);
            this.explorarRespuestasbutton3.TabIndex = 12;
            this.explorarRespuestasbutton3.Text = "...";
            this.explorarRespuestasbutton3.UseVisualStyleBackColor = true;
            // 
            // explorarErroresbutton4
            // 
            this.explorarErroresbutton4.Location = new System.Drawing.Point(478, 124);
            this.explorarErroresbutton4.Name = "explorarErroresbutton4";
            this.explorarErroresbutton4.Size = new System.Drawing.Size(27, 20);
            this.explorarErroresbutton4.TabIndex = 13;
            this.explorarErroresbutton4.Text = "...";
            this.explorarErroresbutton4.UseVisualStyleBackColor = true;
            // 
            // exploraropenFileDialog1
            // 
            this.exploraropenFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(49, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tiempo Escaneo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tiemponumericUpDown1
            // 
            this.tiemponumericUpDown1.Location = new System.Drawing.Point(181, 153);
            this.tiemponumericUpDown1.Name = "tiemponumericUpDown1";
            this.tiemponumericUpDown1.Size = new System.Drawing.Size(82, 20);
            this.tiemponumericUpDown1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(269, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Segundos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // urlWStextBox5
            // 
            this.urlWStextBox5.Location = new System.Drawing.Point(180, 28);
            this.urlWStextBox5.Name = "urlWStextBox5";
            this.urlWStextBox5.Size = new System.Drawing.Size(295, 20);
            this.urlWStextBox5.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(49, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "URL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usuarioWStextBox6
            // 
            this.usuarioWStextBox6.Location = new System.Drawing.Point(180, 55);
            this.usuarioWStextBox6.Name = "usuarioWStextBox6";
            this.usuarioWStextBox6.Size = new System.Drawing.Size(155, 20);
            this.usuarioWStextBox6.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(49, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "Usuario";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.peticionesParalelasnumericUpDown1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.contraseñaWStextBox7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.urlWStextBox5);
            this.groupBox1.Controls.Add(this.usuarioWStextBox6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(3, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 149);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Web Service";
            // 
            // peticionesParalelasnumericUpDown1
            // 
            this.peticionesParalelasnumericUpDown1.Location = new System.Drawing.Point(182, 108);
            this.peticionesParalelasnumericUpDown1.Name = "peticionesParalelasnumericUpDown1";
            this.peticionesParalelasnumericUpDown1.Size = new System.Drawing.Size(81, 20);
            this.peticionesParalelasnumericUpDown1.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(49, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 14);
            this.label15.TabIndex = 23;
            this.label15.Text = "Procesos en listado";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contraseñaWStextBox7
            // 
            this.contraseñaWStextBox7.Location = new System.Drawing.Point(180, 81);
            this.contraseñaWStextBox7.Name = "contraseñaWStextBox7";
            this.contraseñaWStextBox7.Size = new System.Drawing.Size(155, 20);
            this.contraseñaWStextBox7.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(49, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 14);
            this.label9.TabIndex = 21;
            this.label9.Text = "Contraseña";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.procesandotextBox1);
            this.groupBox2.Controls.Add(this.proceasandobutton1);
            this.groupBox2.Controls.Add(this.raiztextBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tiemponumericUpDown1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.explorarErroresbutton4);
            this.groupBox2.Controls.Add(this.procesadostextBox2);
            this.groupBox2.Controls.Add(this.explorarRespuestasbutton3);
            this.groupBox2.Controls.Add(this.respuestastextBox3);
            this.groupBox2.Controls.Add(this.explorarProcesadosbutton2);
            this.groupBox2.Controls.Add(this.errorestextBox4);
            this.groupBox2.Controls.Add(this.explorarRaizbutton1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 186);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(49, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 14);
            this.label16.TabIndex = 18;
            this.label16.Text = "Carpeta Procesando";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // procesandotextBox1
            // 
            this.procesandotextBox1.Enabled = false;
            this.procesandotextBox1.Location = new System.Drawing.Point(180, 48);
            this.procesandotextBox1.Name = "procesandotextBox1";
            this.procesandotextBox1.Size = new System.Drawing.Size(295, 20);
            this.procesandotextBox1.TabIndex = 17;
            // 
            // proceasandobutton1
            // 
            this.proceasandobutton1.Location = new System.Drawing.Point(478, 48);
            this.proceasandobutton1.Name = "proceasandobutton1";
            this.proceasandobutton1.Size = new System.Drawing.Size(27, 20);
            this.proceasandobutton1.TabIndex = 19;
            this.proceasandobutton1.Text = "...";
            this.proceasandobutton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.puertoSMTPtextBox5);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.servidorSMTPtextBox4);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.contraseñaCorreotextBox1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.correotextBox2);
            this.groupBox3.Controls.Add(this.usuarioCorreotextBox3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(3, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 169);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notificaciones";
            // 
            // puertoSMTPtextBox5
            // 
            this.puertoSMTPtextBox5.Location = new System.Drawing.Point(180, 133);
            this.puertoSMTPtextBox5.Name = "puertoSMTPtextBox5";
            this.puertoSMTPtextBox5.Size = new System.Drawing.Size(155, 20);
            this.puertoSMTPtextBox5.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(48, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 14);
            this.label14.TabIndex = 25;
            this.label14.Text = "Puerto";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // servidorSMTPtextBox4
            // 
            this.servidorSMTPtextBox4.Location = new System.Drawing.Point(180, 107);
            this.servidorSMTPtextBox4.Name = "servidorSMTPtextBox4";
            this.servidorSMTPtextBox4.Size = new System.Drawing.Size(155, 20);
            this.servidorSMTPtextBox4.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(49, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 14);
            this.label13.TabIndex = 23;
            this.label13.Text = "Servidor SMTP";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contraseñaCorreotextBox1
            // 
            this.contraseñaCorreotextBox1.Location = new System.Drawing.Point(180, 81);
            this.contraseñaCorreotextBox1.Name = "contraseñaCorreotextBox1";
            this.contraseñaCorreotextBox1.Size = new System.Drawing.Size(155, 20);
            this.contraseñaCorreotextBox1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(49, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 14);
            this.label10.TabIndex = 21;
            this.label10.Text = "Contraseña";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // correotextBox2
            // 
            this.correotextBox2.Location = new System.Drawing.Point(180, 28);
            this.correotextBox2.Name = "correotextBox2";
            this.correotextBox2.Size = new System.Drawing.Size(295, 20);
            this.correotextBox2.TabIndex = 0;
            // 
            // usuarioCorreotextBox3
            // 
            this.usuarioCorreotextBox3.Location = new System.Drawing.Point(180, 55);
            this.usuarioCorreotextBox3.Name = "usuarioCorreotextBox3";
            this.usuarioCorreotextBox3.Size = new System.Drawing.Size(155, 20);
            this.usuarioCorreotextBox3.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(49, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 14);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cuenta correo";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(49, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 14);
            this.label12.TabIndex = 19;
            this.label12.Text = "Usuario";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.cancelarbutton1);
            this.panelEx1.Controls.Add(this.groupBox3);
            this.panelEx1.Controls.Add(this.Aceptarbutton2);
            this.panelEx1.Controls.Add(this.groupBox1);
            this.panelEx1.Controls.Add(this.groupBox2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(535, 577);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 24;
            // 
            // frmConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 577);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfiguraciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuraciones";
            ((System.ComponentModel.ISupportInitialize)(this.tiemponumericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peticionesParalelasnumericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelarbutton1;
        private System.Windows.Forms.Button Aceptarbutton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox raiztextBox1;
        private System.Windows.Forms.TextBox procesadostextBox2;
        private System.Windows.Forms.TextBox respuestastextBox3;
        private System.Windows.Forms.TextBox errorestextBox4;
        private System.Windows.Forms.Button explorarRaizbutton1;
        private System.Windows.Forms.Button explorarProcesadosbutton2;
        private System.Windows.Forms.Button explorarRespuestasbutton3;
        private System.Windows.Forms.Button explorarErroresbutton4;
        private System.Windows.Forms.OpenFileDialog exploraropenFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown tiemponumericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox urlWStextBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox usuarioWStextBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox contraseñaWStextBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox contraseñaCorreotextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox correotextBox2;
        private System.Windows.Forms.TextBox usuarioCorreotextBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox puertoSMTPtextBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox servidorSMTPtextBox4;
        private System.Windows.Forms.Label label13;
        private FolderBrowserDialog explorarfolderBrowserDialog1;
        private NumericUpDown peticionesParalelasnumericUpDown1;
        private Label label15;
        private Label label16;
        private TextBox procesandotextBox1;
        private Button proceasandobutton1;
        private DevComponents.DotNetBar.PanelEx panelEx1;

        public Button Cancelarbutton1 { get => cancelarbutton1; set => cancelarbutton1 = value; }
        public Button Aceptarbutton21 { get => Aceptarbutton2; set => Aceptarbutton2 = value; }
        public TextBox RaiztextBox1 { get => raiztextBox1; set => raiztextBox1 = value; }
        public TextBox ProcesadostextBox2 { get => procesadostextBox2; set => procesadostextBox2 = value; }
        public TextBox RespuestastextBox3 { get => respuestastextBox3; set => respuestastextBox3 = value; }
        public TextBox ErrorestextBox4 { get => errorestextBox4; set => errorestextBox4 = value; }
        public Button ExplorarRaizbutton1 { get => explorarRaizbutton1; set => explorarRaizbutton1 = value; }
        public Button ExplorarProcesadosbutton2 { get => explorarProcesadosbutton2; set => explorarProcesadosbutton2 = value; }
        public Button ExplorarRespuestasbutton3 { get => explorarRespuestasbutton3; set => explorarRespuestasbutton3 = value; }
        public Button ExplorarErroresbutton4 { get => explorarErroresbutton4; set => explorarErroresbutton4 = value; }
        public OpenFileDialog ExploraropenFileDialog1 { get => exploraropenFileDialog1; set => exploraropenFileDialog1 = value; }
        public NumericUpDown TiemponumericUpDown1 { get => tiemponumericUpDown1; set => tiemponumericUpDown1 = value; }
        public TextBox UrlWStextBox5 { get => urlWStextBox5; set => urlWStextBox5 = value; }
        public TextBox UsuarioWStextBox6 { get => usuarioWStextBox6; set => usuarioWStextBox6 = value; }
        public TextBox ContraseñaWStextBox7 { get => contraseñaWStextBox7; set => contraseñaWStextBox7 = value; }
        public TextBox ContraseñaCorreotextBox1 { get => contraseñaCorreotextBox1; set => contraseñaCorreotextBox1 = value; }
        public TextBox CorreotextBox2 { get => correotextBox2; set => correotextBox2 = value; }
        public TextBox UsuarioCorreotextBox3 { get => usuarioCorreotextBox3; set => usuarioCorreotextBox3 = value; }
        public TextBox PuertoSMTPtextBox5 { get => puertoSMTPtextBox5; set => puertoSMTPtextBox5 = value; }
        public TextBox ServidorSMTPtextBox4 { get => servidorSMTPtextBox4; set => servidorSMTPtextBox4 = value; }
        public FolderBrowserDialog ExplorarfolderBrowserDialog1 { get => explorarfolderBrowserDialog1; set => explorarfolderBrowserDialog1 = value; }
        public NumericUpDown PeticionesParalelasnumericUpDown1 { get => peticionesParalelasnumericUpDown1; set => peticionesParalelasnumericUpDown1 = value; }
        public TextBox ProcesandotextBox1 { get => procesandotextBox1; set => procesandotextBox1 = value; }
        public Button Proceasandobutton1 { get => proceasandobutton1; set => proceasandobutton1 = value; }
    }
}