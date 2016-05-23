namespace SinemaOdev.WinFormUI
{
    partial class FormSeans
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSaat = new System.Windows.Forms.NumericUpDown();
            this.btnListeleSeans = new System.Windows.Forms.Button();
            this.btnEkleSeans = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFilm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaat)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(255, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Anasayfaya Git";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saat";
            // 
            // numericUpDownSaat
            // 
            this.numericUpDownSaat.Location = new System.Drawing.Point(69, 12);
            this.numericUpDownSaat.Name = "numericUpDownSaat";
            this.numericUpDownSaat.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSaat.TabIndex = 2;
            // 
            // btnListeleSeans
            // 
            this.btnListeleSeans.BackColor = System.Drawing.Color.OrangeRed;
            this.btnListeleSeans.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnListeleSeans.Location = new System.Drawing.Point(16, 122);
            this.btnListeleSeans.Name = "btnListeleSeans";
            this.btnListeleSeans.Size = new System.Drawing.Size(74, 35);
            this.btnListeleSeans.TabIndex = 3;
            this.btnListeleSeans.Text = "Listele";
            this.btnListeleSeans.UseVisualStyleBackColor = false;
            this.btnListeleSeans.Click += new System.EventHandler(this.btnListeleSeans_Click);
            // 
            // btnEkleSeans
            // 
            this.btnEkleSeans.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEkleSeans.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEkleSeans.Location = new System.Drawing.Point(16, 68);
            this.btnEkleSeans.Name = "btnEkleSeans";
            this.btnEkleSeans.Size = new System.Drawing.Size(96, 38);
            this.btnEkleSeans.TabIndex = 4;
            this.btnEkleSeans.Text = "Ekle";
            this.btnEkleSeans.UseVisualStyleBackColor = false;
            this.btnEkleSeans.Click += new System.EventHandler(this.btnEkleSeans_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(16, 163);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 165);
            this.listBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Film";
            // 
            // comboBoxFilm
            // 
            this.comboBoxFilm.FormattingEnabled = true;
            this.comboBoxFilm.Location = new System.Drawing.Point(69, 43);
            this.comboBoxFilm.Name = "comboBoxFilm";
            this.comboBoxFilm.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilm.TabIndex = 7;
            // 
            // FormSeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(386, 340);
            this.Controls.Add(this.comboBoxFilm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEkleSeans);
            this.Controls.Add(this.btnListeleSeans);
            this.Controls.Add(this.numericUpDownSaat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormSeans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSeans";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownSaat;
        private System.Windows.Forms.Button btnListeleSeans;
        private System.Windows.Forms.Button btnEkleSeans;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFilm;
    }
}