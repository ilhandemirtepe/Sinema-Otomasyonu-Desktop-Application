using SinemaOdev.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinemaOdev.Service;
using SinemaOdev.DTO.Bilet;
namespace SinemaOdev.WinFormUI
{
    public partial class FormBilet : Form
    {
        SinemaOtomasyonuEntities db = new SinemaOtomasyonuEntities();

        public FormBilet()
        {
            InitializeComponent();
            comboBoxFilmAdi.DisplayMember = "FilmAd";
            comboBoxFilmAdi.ValueMember = "FilmID ";
            comboBoxFilmAdi.DataSource = db.Film.ToList();


            comboBoxFiyat.DisplayMember = "SatisFiyat";
            comboBoxFiyat.ValueMember = "SatisID ";
            comboBoxFiyat.DataSource = db.Satis.ToList();

        }

        private void btn_anasayfayaGit_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btn_BiletEkle_Click(object sender, EventArgs e)
        {

            Biletservice s = new Biletservice();
            BiletEkleDTO dt = new BiletEkleDTO();
            Film temp2 = (Film)comboBoxFilmAdi.SelectedItem;
            Satis temp3 = (Satis)comboBoxFiyat.SelectedItem;
            dt.FilmNumber = temp2.FilmID;
            dt.SatisNumber=temp3.SatisID;
            dt.ChairNumber = textBoxKoltukNumarasi.Text;
            s.EkleYap(dt);
        }

        private void btnFilmListele_Click(object sender, EventArgs e)
        {
            Biletservice s = new Biletservice();
            foreach (var item in s.ListeleFilm())
            {
                listBox1.Items.Add(item.SatisID);
            }

        }
    }
}
