namespace SinemaOdev.WinFormUI
{
    partial class FormMusteri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_MusteriSil = new System.Windows.Forms.Button();
            this.btn_MusteriListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AnasayfayaGit
            // 
            this.btn_AnasayfayaGit.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_AnasayfayaGit.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_AnasayfayaGit.Location = new System.Drawing.Point(310, 12);
            this.btn_AnasayfayaGit.Name = "btn_AnasayfayaGit";
            this.btn_AnasayfayaGit.Size = new System.Drawing.Size(138, 34);
            this.btn_AnasayfayaGit.TabIndex = 1;
            this.btn_AnasayfayaGit.Text = "Anasayfaya Gİt";
            this.btn_AnasayfayaGit.UseVisualStyleBackColor = false;
            this.btn_AnasayfayaGit.Click += new System.EventHandler(this.btn_AnasayfayaGit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 225);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_MusteriSil
            // 
            this.btn_MusteriSil.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_MusteriSil.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_MusteriSil.Location = new System.Drawing.Point(138, 12);
            this.btn_MusteriSil.Name = "btn_MusteriSil";
            this.btn_MusteriSil.Size = new System.Drawing.Size(106, 34);
            this.btn_MusteriSil.TabIndex = 4;
            this.btn_MusteriSil.Text = "Seçileni Sil";
            this.btn_MusteriSil.UseVisualStyleBackColor = false;
            // 
            // btn_MusteriListele
            // 
            this.btn_MusteriListele.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_MusteriListele.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_MusteriListele.Location = new System.Drawing.Point(12, 12);
            this.btn_MusteriListele.Name = "btn_MusteriListele";
            this.btn_MusteriListele.Size = new System.Drawing.Size(107, 34);
            this.btn_MusteriListele.TabIndex = 5;
            this.btn_MusteriListele.Text = "Listele";
            this.btn_MusteriListele.UseVisualStyleBackColor = false;
            this.btn_MusteriListele.Click += new System.EventHandler(this.btn_MusteriListele_Click);
            // 
            // FormMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(460, 308);
            this.Controls.Add(this.btn_MusteriListele);
            this.Controls.Add(this.btn_MusteriSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_AnasayfayaGit);
            this.Name = "FormMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMusteri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AnasayfayaGit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_MusteriSil;
        private System.Windows.Forms.Button btn_MusteriListele;
    }
}