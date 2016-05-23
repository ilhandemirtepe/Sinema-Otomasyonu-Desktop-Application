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

namespace SinemaOdev.WinFormUI
{
    public partial class KullaniciForm : Form
    {
        public KullaniciForm()
        {
            InitializeComponent();
        }
        SinemaOtomasyonuEntities db = new SinemaOtomasyonuEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Musteri)
            {
                if( textBoxKullaniciAdi.Text==item.MusteriUserName &&  textBoxSifre.Text==item.MusteriPassWord)
                {
                    Kullaniciislemleri f = new Kullaniciislemleri();
                    f.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    textBoxKullaniciAdi.Text = "";
                    textBoxSifre.Text = "";
                    MessageBox.Show("Kullanıcı adı veya parola yanlış");
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMusteriKayit f = new FormMusteriKayit();
            f.Show();
            this.Hide();
            return;
        }
    }
}
