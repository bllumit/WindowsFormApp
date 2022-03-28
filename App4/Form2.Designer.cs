namespace App4
{
    partial class Form2
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
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikarma = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.txtDeger1 = new System.Windows.Forms.TextBox();
            this.txtDeger2 = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(51, 97);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(57, 23);
            this.btnTopla.TabIndex = 0;
            this.btnTopla.Text = "Toplama";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCikarma
            // 
            this.btnCikarma.Location = new System.Drawing.Point(131, 97);
            this.btnCikarma.Name = "btnCikarma";
            this.btnCikarma.Size = new System.Drawing.Size(58, 23);
            this.btnCikarma.TabIndex = 1;
            this.btnCikarma.Text = "Çıkarma";
            this.btnCikarma.UseVisualStyleBackColor = true;
            this.btnCikarma.Click += new System.EventHandler(this.btnCikarma_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(51, 126);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(57, 23);
            this.btnBolme.TabIndex = 2;
            this.btnBolme.Text = "Bölme";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.btnBolme_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(131, 126);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(58, 23);
            this.btnCarpma.TabIndex = 3;
            this.btnCarpma.Text = "Çarpma";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // txtDeger1
            // 
            this.txtDeger1.Location = new System.Drawing.Point(51, 39);
            this.txtDeger1.Name = "txtDeger1";
            this.txtDeger1.Size = new System.Drawing.Size(138, 23);
            this.txtDeger1.TabIndex = 4;
            // 
            // txtDeger2
            // 
            this.txtDeger2.Location = new System.Drawing.Point(51, 68);
            this.txtDeger2.Name = "txtDeger2";
            this.txtDeger2.Size = new System.Drawing.Size(138, 23);
            this.txtDeger2.TabIndex = 5;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(101, 169);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(40, 15);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "Sonuç";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 213);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtDeger2);
            this.Controls.Add(this.txtDeger1);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnCikarma);
            this.Controls.Add(this.btnTopla);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTopla;
        private Button btnCikarma;
        private Button btnBolme;
        private Button btnCarpma;
        private TextBox txtDeger1;
        private TextBox txtDeger2;
        private Label lblSonuc;
    }
}