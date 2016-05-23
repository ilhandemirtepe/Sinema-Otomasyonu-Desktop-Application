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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            FilmTurService s = new FilmTurService();
            FilmTurEkleDTO dt = new FilmTurEkleDTO();
            dt.FilmTurAdi = textBox1.Text;
            s.EkleYap(dt);
            listboxDoldur();
            textBox1.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listboxDoldur();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            //  FilmTurSilDTO temp = (FilmTurSilDTO)listBox1.SelectedItem;
            //FilmTurSilDTO temp = listBox1.SelectedItem as FilmTurSilDTO;
            FilmTurService s = new FilmTurService();
            FilmTurSilDTO temp = new FilmTurSilDTO();
            temp.FilmTurID = Convert.ToInt32((listBox1.SelectedValue as SomeData).Value);
            temp.FilmTurAdi = (listBox1.SelectedValue as SomeData).Text;
            int sil = int.Parse(listBox1.SelectedIndex.ToString());
            if (sil != 0)
            {
                s.SilmeYap(temp);
                listboxDoldur();
            }




            //using (var dbBlog = new SinemaOtomasyonuEntities())
            //{
            //    string text =listBox1 .SelectedItem.ToString();
            //    if (text != "")
            //    {
            //        var qry = dbBlog.FilmTur.Where(i => i.FilmTurAd == text).Select(d =>d.FilmTurID);
            //        foreach (var a in qry.ToList())
            //        {
            //            MessageBox.Show(a.ToString());
            //            var removeEntry = new FilmTur() { FilmTurID = a };
            //            dbBlog.FilmTur.Attach(removeEntry);
            //            dbBlog.FilmTur.Remove(removeEntry);
            //            dbBlog.SaveChanges();
            //        }
            //    }
            //}

        }
        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxFilmTurAdiGuncelle.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void butonFilmTurAdiGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void listboxDoldur()
        {
            listBox1.DataSource = null;
            FilmTurService s = new FilmTurService();
            List<SomeData> data = new List<SomeData>();
            foreach (var item in s.ListeleFilmTurleri())
            {
                data.Add(new SomeData()
                {

                    Value = item.FilmTurId.ToString(),
                    Text = item.FilmTurAd
                }
            );

            }
            listBox1.DisplayMember = "Text";
            listBox1.DataSource = data;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }

    public class SomeData
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }
}
