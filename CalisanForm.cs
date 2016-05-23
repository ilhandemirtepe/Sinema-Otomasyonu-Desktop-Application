using SinemaOdev.DTO.Calisan;
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
    public partial class CalisanForm : Form
    {
        public CalisanForm()
        {
            InitializeComponent();
        }

        private void btn_AnasayfayaGit_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnEkleCalisan_Click(object sender, EventArgs e)
        {
            CalisanService s = new CalisanService();
            CalisanEkleDTO dt = new CalisanEkleDTO();
            dt.CalisanName = textBoxAdi.Text;
            dt.CalisanPassword = textBoxŞifre.Text;
            dt.CalisanSurname = textBoxSoyadi.Text;
            dt.CalisanTcNumara = textBoxTCNumara.Text;
            dt.CalisanUsername = textBoxKullaniciAdi.Text;
            
      
            s.EkleYap(dt);
            textBoxAdi.Text = "";
            textBoxKullaniciAdi.Text = "";
            textBoxŞifre.Text = "";
            textBoxSoyadi.Text = "";
            textBoxTCNumara.Text = "";
        }

        private void btnCalisanListele_Click(object sender, EventArgs e)
        {

            listBoxCalisan.Items.Clear();
            CalisanService s = new CalisanService();
            foreach (var item in s.ListeleCalisanlari())
            {
                listBoxCalisan.Items.Add(item.CalisanAd);
            }
        }

        private void btnSilCalisan_Click(object sender, EventArgs e)
        {

        }
    }
}
