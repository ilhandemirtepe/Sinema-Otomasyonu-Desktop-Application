namespace SinemaOdev.WinFormUI
{
    partial class FormSalon
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
            this.btn_AnasayfayaGit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSalonAdi = new System.Windows.Forms.TextBox();
            this.numericUpDownKapasite = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKoltukSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSecileniSil = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSeans = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKapasite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKoltukSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AnasayfayaGit
            // 
            this.btn_AnasayfayaGit.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_AnasayfayaGit.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_AnasayfayaGit.Location = new System.Drawing.Point(296, 12);
            this.btn_AnasayfayaGit.Name = "btn_AnasayfayaGit";
            this.btn_AnasayfayaGit.Size = new System.Drawing.Size(140, 34);
            this.btn_AnasayfayaGit.TabIndex = 0;
            this.btn_AnasayfayaGit.Text = "Anasayfaya Git";
            this.btn_AnasayfayaGit.UseVisualStyleBackColor = false;
            this.btn_AnasayfayaGit.Click += new System.EventHandler(this.btn_AnasayfayaGit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Koltuk Sayisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = " Kapasite";
            // 
            // textBoxSalonAdi
            // 
            this.textBoxSalonAdi.Location = new System.Drawing.Point(113, 42);
            this.textBoxSalonAdi.Name = "textBoxSalonAdi";
            this.textBoxSalonAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalonAdi.TabIndex = 4;
            // 
            // numericUpDownKapasite
            // 
            this.numericUpDownKapasite.Font = new System.Drawing.Font("Segoe Print", 6F, System.Drawing.FontStyle.Bold);
            this.numericUpDownKapasite.Location = new System.Drawing.Point(113, 74);
            this.numericUpDownKapasite.Name = "numericUpDownKapasite";
            this.numericUpDownKapasite.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownKapasite.TabIndex = 7;
            // 
            // numericUpDownKoltukSayisi
            // 
            this.numericUpDownKoltukSayisi.Font = new System.Drawing.Font("Segoe Print", 6F, System.Drawing.FontStyle.Bold);
            this.numericUpDownKoltukSayisi.Location = new System.Drawing.Point(113, 102);
            this.numericUpDownKoltukSayisi.Name = "numericUpDownKoltukSayisi";
            this.numericUpDownKoltukSayisi.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownKoltukSayisi.TabIndex = 8;
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSalonEkle.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSalonEkle.Location = new System.Drawing.Point(113, 130);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(76, 34);
            this.btnSalonEkle.TabIndex = 9;
            this.btnSalonEkle.Text = "Ekle";
            this.btnSalonEkle.UseVisualStyleBackColor = false;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.OrangeRed;
            this.btnListele.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnListele.Location = new System.Drawing.Point(238, 105);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(85, 34);
            this.btnListele.TabIndex = 10;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSecileniSil
            // 
            this.btnSecileniSil.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSecileniSil.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSecileniSil.Location = new System.Drawing.Point(346, 105);
            this.btnSecileniSil.Name = "btnSecileniSil";
            this.btnSecileniSil.Size = new System.Drawing.Size(90, 34);
            this.btnSecileniSil.TabIndex = 11;
            this.btnSecileniSil.Text = "Seçileni Sil";
            this.btnSecileniSil.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(238, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 188);
            this.listBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seans";
            // 
            // comboBoxSeans
            // 
            this.comboBoxSeans.FormattingEnabled = true;
            this.comboBoxSeans.Location = new System.Drawing.Point(113, 12);
            this.comboBoxSeans.Name = "comboBoxSeans";
            this.comboBoxSeans.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSeans.TabIndex = 14;
            // 
            // FormSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(448, 363);
            this.Controls.Add(this.comboBoxSeans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSecileniSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSalonEkle);
            this.Controls.Add(this.numericUpDownKoltukSayisi);
            this.Controls.Add(this.numericUpDownKapasite);
            this.Controls.Add(this.textBoxSalonAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AnasayfayaGit);
            this.Name = "FormSalon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSalon";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKapasite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKoltukSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AnasayfayaGit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSalonAdi;
        private System.Windows.Forms.NumericUpDown numericUpDownKapasite;
        private System.Windows.Forms.NumericUpDown numericUpDownKoltukSayisi;
        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSecileniSil;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSeans;
    }
}