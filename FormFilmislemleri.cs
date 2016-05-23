using SinemaOdev.DTO.Film;
using SinemaOdev.DTO.FilmTur;
using SinemaOdev.ORM;
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

namespace SinemaOdev.WinFormUI
{
    public partial class FormFilmislemleri : Form
    {
        SinemaOtomasyonuEntities db = new SinemaOtomasyonuEntities();
        public FormFilmislemleri()
        {
            InitializeComponent();   
            comboBoxFilmTurAdi.DisplayMember = "FilmTurAd";
            comboBoxFilmTurAdi.ValueMember = "FilmTurID ";
            comboBoxFilmTurAdi.DataSource = db.FilmTur.ToList();

        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            FilmService s = new FilmService();
            FilmEkleDTO dt = new FilmEkleDTO();
            FilmTur temp = (FilmTur)comboBoxFilmTurAdi.SelectedItem;
            dt.FilmTurID = temp.FilmTurID;
            dt.FilmAdi = textBoxFilmAd.Text;
            dt.FilmSure =Convert.ToInt32(textBoxFilmSure.Text);
            dt.UcboyutluDurumu = Convert.ToBoolean( checkBoxBoyutlumu.Checked);
            dt.YerliDurumu = Convert.ToBoolean(checkBoxYerlimi.Checked);
            s.EkleYap(dt);
        }

        private void btnFilmListele_Click(object sender, EventArgs e)
        {
            listBoxFilm.Items.Clear();
            FilmService s = new FilmService();
            foreach (var item in s.ListeleFilm())
            {
                listBoxFilm.Items.Add(item.FilmAd);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
