namespace SinemaOdev.WinFormUI
{
    partial class Form3
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
            this.btn_ekle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butonFilmTurAdiGuncelle = new System.Windows.Forms.Button();
            this.textBoxFilmTurAdiGuncelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_ekle.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ekle.Location = new System.Drawing.Point(52, 26);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 32);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // butonFilmTurAdiGuncelle
            // 
            this.butonFilmTurAdiGuncelle.BackColor = System.Drawing.Color.OrangeRed;
            this.butonFilmTurAdiGuncelle.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.butonFilmTurAdiGuncelle.Location = new System.Drawing.Point(381, 115);
            this.butonFilmTurAdiGuncelle.Name = "butonFilmTurAdiGuncelle";
            this.butonFilmTurAdiGuncelle.Size = new System.Drawing.Size(75, 34);
            this.butonFilmTurAdiGuncelle.TabIndex = 6;
            this.butonFilmTurAdiGuncelle.Text = "Güncelle";
            this.butonFilmTurAdiGuncelle.UseVisualStyleBackColor = false;
            this.butonFilmTurAdiGuncelle.Click += new System.EventHandler(this.butonFilmTurAdiGuncelle_Click);
            // 
            // textBoxFilmTurAdiGuncelle
            // 
            this.textBoxFilmTurAdiGuncelle.Location = new System.Drawing.Point(369, 83);
            this.textBoxFilmTurAdiGuncelle.Name = "textBoxFilmTurAdiGuncelle";
            this.textBoxFilmTurAdiGuncelle.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilmTurAdiGuncelle.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(267, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Film Tür Adı";
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.OrangeRed;
            this.sil.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.sil.Location = new System.Drawing.Point(136, 75);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(97, 34);
            this.sil.TabIndex = 9;
            this.sil.Text = "Seçileni Sil";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(49, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 257);
            this.listBox1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(355, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "Anasayfaya Git";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(496, 438);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFilmTurAdiGuncelle);
            this.Controls.Add(this.butonFilmTurAdiGuncelle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_ekle);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butonFilmTurAdiGuncelle;
        private System.Windows.Forms.TextBox textBoxFilmTurAdiGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}