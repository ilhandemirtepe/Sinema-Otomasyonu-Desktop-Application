namespace SinemaOdev.WinFormUI
{
    partial class FormBilet
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
            this.btn_anasayfayaGit = new System.Windows.Forms.Button();
            this.Adı = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFilmAdi = new System.Windows.Forms.ComboBox();
            this.comboBoxFiyat = new System.Windows.Forms.ComboBox();
            this.textBoxKoltukNumarasi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_BiletEkle = new System.Windows.Forms.Button();
            this.btnFilmListele = new System.Windows.Forms.Button();
            this.btnFilmSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_anasayfayaGit
            // 
            this.btn_anasayfayaGit.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_anasayfayaGit.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_anasayfayaGit.Location = new System.Drawing.Point(412, 6);
            this.btn_anasayfayaGit.Name = "btn_anasayfayaGit";
            this.btn_anasayfayaGit.Size = new System.Drawing.Size(149, 35);
            this.btn_anasayfayaGit.TabIndex = 0;
            this.btn_anasayfayaGit.Text = "Anasayfaya Git";
            this.btn_anasayfayaGit.UseVisualStyleBackColor = false;
            this.btn_anasayfayaGit.Click += new System.EventHandler(this.btn_anasayfayaGit_Click);
            // 
            // Adı
            // 
            this.Adı.AutoSize = true;
            this.Adı.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adı.Location = new System.Drawing.Point(12, 12);
            this.Adı.Name = "Adı";
            this.Adı.Size = new System.Drawing.Size(67, 23);
            this.Adı.TabIndex = 11;
            this.Adı.Text = "Film Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Koltuk No";
            // 
            // comboBoxFilmAdi
            // 
            this.comboBoxFilmAdi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBoxFilmAdi.FormattingEnabled = true;
            this.comboBoxFilmAdi.Location = new System.Drawing.Point(104, 15);
            this.comboBoxFilmAdi.Name = "comboBoxFilmAdi";
            this.comboBoxFilmAdi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilmAdi.TabIndex = 17;
            // 
            // comboBoxFiyat
            // 
            this.comboBoxFiyat.FormattingEnabled = true;
            this.comboBoxFiyat.Location = new System.Drawing.Point(104, 51);
            this.comboBoxFiyat.Name = "comboBoxFiyat";
            this.comboBoxFiyat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiyat.TabIndex = 18;
            // 
            // textBoxKoltukNumarasi
            // 
            this.textBoxKoltukNumarasi.Location = new System.Drawing.Point(104, 91);
            this.textBoxKoltukNumarasi.Name = "textBoxKoltukNumarasi";
            this.textBoxKoltukNumarasi.Size = new System.Drawing.Size(121, 20);
            this.textBoxKoltukNumarasi.TabIndex = 21;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(300, 123);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 257);
            this.listBox1.TabIndex = 23;
            // 
            // btn_BiletEkle
            // 
            this.btn_BiletEkle.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_BiletEkle.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_BiletEkle.Location = new System.Drawing.Point(113, 123);
            this.btn_BiletEkle.Name = "btn_BiletEkle";
            this.btn_BiletEkle.Size = new System.Drawing.Size(99, 35);
            this.btn_BiletEkle.TabIndex = 24;
            this.btn_BiletEkle.Text = "Ekle";
            this.btn_BiletEkle.UseVisualStyleBackColor = false;
            this.btn_BiletEkle.Click += new System.EventHandler(this.btn_BiletEkle_Click);
            // 
            // btnFilmListele
            // 
            this.btnFilmListele.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFilmListele.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFilmListele.Location = new System.Drawing.Point(300, 82);
            this.btnFilmListele.Name = "btnFilmListele";
            this.btnFilmListele.Size = new System.Drawing.Size(99, 35);
            this.btnFilmListele.TabIndex = 25;
            this.btnFilmListele.Text = "Listele";
            this.btnFilmListele.UseVisualStyleBackColor = false;
            this.btnFilmListele.Click += new System.EventHandler(this.btnFilmListele_Click);
            // 
            // btnFilmSil
            // 
            this.btnFilmSil.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFilmSil.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFilmSil.Location = new System.Drawing.Point(441, 82);
            this.btnFilmSil.Name = "btnFilmSil";
            this.btnFilmSil.Size = new System.Drawing.Size(119, 35);
            this.btnFilmSil.TabIndex = 26;
            this.btnFilmSil.Text = "Seçileni Sil";
            this.btnFilmSil.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fiyat";
            // 
            // FormBilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(572, 401);
            this.Controls.Add(this.btnFilmSil);
            this.Controls.Add(this.btnFilmListele);
            this.Controls.Add(this.btn_BiletEkle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxKoltukNumarasi);
            this.Controls.Add(this.comboBoxFiyat);
            this.Controls.Add(this.comboBoxFilmAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Adı);
            this.Controls.Add(this.btn_anasayfayaGit);
            this.Name = "FormBilet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBilet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_anasayfayaGit;
        private System.Windows.Forms.Label Adı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFilmAdi;
        private System.Windows.Forms.ComboBox comboBoxFiyat;
        private System.Windows.Forms.TextBox textBoxKoltukNumarasi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_BiletEkle;
        private System.Windows.Forms.Button btnFilmListele;
        private System.Windows.Forms.Button btnFilmSil;
        private System.Windows.Forms.Label label3;
    }
}