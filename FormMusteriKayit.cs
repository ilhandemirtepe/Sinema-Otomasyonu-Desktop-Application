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
    public partial class FormMusteriKayit : Form
    {
      
        public FormMusteriKayit()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            KullaniciForm f = new KullaniciForm();
            f.Show();
            this.Hide();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Musteri m = CreateMusteri();
             label6.Text= InsertMusteri(m);
        }
        public string InsertMusteri(Musteri m) //veritabanından çek verileri
        {
            try
            {
                SinemaOtomasyonuEntities db = new SinemaOtomasyonuEntities();
                db.Musteri.Add(m);
                db.SaveChanges();
                return m.MusteriAdı + "  başarılı bir şekilde kayıt oldunuz";
            }
            catch (Exception e)
            {
                return "Hatanız:" + e;
            }
        }

        private Musteri CreateMusteri() //yeni bir müsşteri eklemeye yarar
        {
            Musteri product = new Musteri();
            product.MusteriAdı = textBoxAdi.Text;
            product.MusteriSoyad = textBoxSoyadi.Text;
            product.MusteriUserName = textBoxKullaniciAdi.Text;
            product.MusteriPassWord = textBoxŞİfre.Text;
            return product;
        }

      
    }
}
