namespace SinemaOdev.WinFormUI
{
    partial class FormFilmislemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFilmTurAdi = new System.Windows.Forms.ComboBox();
            this.textBoxFilmAd = new System.Windows.Forms.TextBox();
            this.textBoxFilmSure = new System.Windows.Forms.TextBox();
            this.checkBoxYerlimi = new System.Windows.Forms.CheckBox();
            this.checkBoxBoyutlumu = new System.Windows.Forms.CheckBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.listBoxFilm = new System.Windows.Forms.ListBox();
            this.btnFilmListele = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Tür Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film Süre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(23, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Film Ad";
            // 
            // comboBoxFilmTurAdi
            // 
            this.comboBoxFilmTurAdi.FormattingEnabled = true;
            this.comboBoxFilmTurAdi.Location = new System.Drawing.Point(125, 19);
            this.comboBoxFilmTurAdi.Name = "comboBoxFilmTurAdi";
            this.comboBoxFilmTurAdi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilmTurAdi.TabIndex = 5;
            // 
            // textBoxFilmAd
            // 
            this.textBoxFilmAd.Location = new System.Drawing.Point(125, 58);
            this.textBoxFilmAd.Name = "textBoxFilmAd";
            this.textBoxFilmAd.Size = new System.Drawing.Size(121, 20);
            this.textBoxFilmAd.TabIndex = 6;
            // 
            // textBoxFilmSure
            // 
            this.textBoxFilmSure.Location = new System.Drawing.Point(125, 99);
            this.textBoxFilmSure.Name = "textBoxFilmSure";
            this.textBoxFilmSure.Size = new System.Drawing.Size(121, 20);
            this.textBoxFilmSure.TabIndex = 7;
            // 
            // checkBoxYerlimi
            // 
            this.checkBoxYerlimi.AutoSize = true;
            this.checkBoxYerlimi.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxYerlimi.Location = new System.Drawing.Point(125, 125);
            this.checkBoxYerlimi.Name = "checkBoxYerlimi";
            this.checkBoxYerlimi.Size = new System.Drawing.Size(59, 27);
            this.checkBoxYerlimi.TabIndex = 8;
            this.checkBoxYerlimi.Text = "yerli";
            this.checkBoxYerlimi.UseVisualStyleBackColor = true;
            // 
            // checkBoxBoyutlumu
            // 
            this.checkBoxBoyutlumu.AutoSize = true;
            this.checkBoxBoyutlumu.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxBoyutlumu.Location = new System.Drawing.Point(190, 125);
            this.checkBoxBoyutlumu.Name = "checkBoxBoyutlumu";
            this.checkBoxBoyutlumu.Size = new System.Drawing.Size(80, 27);
            this.checkBoxBoyutlumu.TabIndex = 9;
            this.checkBoxBoyutlumu.Text = "3 boyut";
            this.checkBoxBoyutlumu.UseVisualStyleBackColor = true;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_ekle.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ekle.Location = new System.Drawing.Point(131, 158);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(115, 39);
            this.btn_ekle.TabIndex = 10;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // listBoxFilm
            // 
            this.listBoxFilm.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBoxFilm.FormattingEnabled = true;
            this.listBoxFilm.ItemHeight = 23;
            this.listBoxFilm.Location = new System.Drawing.Point(319, 96);
            this.listBoxFilm.Name = "listBoxFilm";
            this.listBoxFilm.Size = new System.Drawing.Size(188, 257);
            this.listBoxFilm.TabIndex = 11;
            // 
            // btnFilmListele
            // 
            this.btnFilmListele.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFilmListele.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFilmListele.Location = new System.Drawing.Point(319, 58);
            this.btnFilmListele.Name = "btnFilmListele";
            this.btnFilmListele.Size = new System.Drawing.Size(84, 37);
            this.btnFilmListele.TabIndex = 12;
            this.btnFilmListele.Text = "Listele";
            this.btnFilmListele.UseVisualStyleBackColor = false;
            this.btnFilmListele.Click += new System.EventHandler(this.btnFilmListele_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(409, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Anasayfaya Git";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormFilmislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(554, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFilmListele);
            this.Controls.Add(this.listBoxFilm);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.checkBoxBoyutlumu);
            this.Controls.Add(this.checkBoxYerlimi);
            this.Controls.Add(this.textBoxFilmSure);
            this.Controls.Add(this.textBoxFilmAd);
            this.Controls.Add(this.comboBoxFilmTurAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormFilmislemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFilmislemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFilmTurAdi;
        private System.Windows.Forms.TextBox textBoxFilmAd;
        private System.Windows.Forms.TextBox textBoxFilmSure;
        private System.Windows.Forms.CheckBox checkBoxYerlimi;
        private System.Windows.Forms.CheckBox checkBoxBoyutlumu;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ListBox listBoxFilm;
        private System.Windows.Forms.Button btnFilmListele;
        private System.Windows.Forms.Button button1;
    }
}