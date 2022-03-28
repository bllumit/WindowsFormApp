namespace App2
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lstOgrenciler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(23, 60);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(219, 29);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(24, 31);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(218, 23);
            this.txtIsim.TabIndex = 1;
            this.txtIsim.TextChanged += new System.EventHandler(this.txtIsim_TextChanged);
            // 
            // lstOgrenciler
            // 
            this.lstOgrenciler.FormattingEnabled = true;
            this.lstOgrenciler.ItemHeight = 15;
            this.lstOgrenciler.Location = new System.Drawing.Point(24, 165);
            this.lstOgrenciler.Name = "lstOgrenciler";
            this.lstOgrenciler.Size = new System.Drawing.Size(218, 199);
            this.lstOgrenciler.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci Adı";
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(24, 126);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(219, 33);
            this.btnGoster.TabIndex = 4;
            this.btnGoster.Text = "Eklenen Kayıtları Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 434);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOgrenciler);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEkle;
        private TextBox txtIsim;
        private ListBox lstOgrenciler;
        private Label label1;
        private Button btnGoster;
    }
}
