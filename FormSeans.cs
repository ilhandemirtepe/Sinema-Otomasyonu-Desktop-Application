using SinemaOdev.DTO.Film;
using SinemaOdev.DTO.Seans;
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
    public partial class FormSeans : Form
    {
        SinemaOtomasyonuEntities db = new SinemaOtomasyonuEntities();
        public FormSeans()
        {
            InitializeComponent();

            comboBoxFilm.DisplayMember = "FilmAd";
            comboBoxFilm.ValueMember = "FilmID ";
            comboBoxFilm.DataSource = db.Film.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnEkleSeans_Click(object sender, EventArgs e)
        {
            SeansService s = new SeansService();
            SeansEkleDTO dt = new SeansEkleDTO();
            Film temp = (Film)comboBoxFilm.SelectedItem;
            dt.FilmID = temp.FilmID;
            dt.KacinciSaat =(int)(numericUpDownSaat.Value) ;
            s.EkleYap(dt);
        }

        private void btnListeleSeans_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SeansService s = new SeansService();
            foreach (var item in s.ListeleSeans())
            {
                listBox1.Items.Add(item.SeansSaat);
            }
        }
    }
}
