using SinemaOdev.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinemaOdev.DTO.FilmTur;

namespace SinemaOdev.WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void btn_Form3Getir_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormFilmislemleri f = new FormFilmislemleri();
            this.Hide();
            f.Show();
        }

        private void btn_salon_Click(object sender, EventArgs e)
        {
            FormSalon f = new FormSalon();
            this.Hide();
            f.Show();
        }

        private void btn_seans_Click(object sender, EventArgs e)
        {
            FormSeans f = new FormSeans();
            this.Hide();
            f.Show();
        }

        private void btn_calisan_Click(object sender, EventArgs e)
        {
            CalisanForm f = new CalisanForm();
            this.Hide();
            f.Show();
        }

        private void btn_bilet_Click(object sender, EventArgs e)
        {
            FormBilet f = new FormBilet();
            this.Hide();
            f.Show();
        }

        private void btn_satis_Click(object sender, EventArgs e)
        {
            FormSatis f = new FormSatis();
            this.Hide();
            f.Show();
        }

        private void btn_musteri_Click(object sender, EventArgs e)
        {
            FormMusteri f = new FormMusteri();
            this.Hide();
            f.Show();
        }

      
    }
}
