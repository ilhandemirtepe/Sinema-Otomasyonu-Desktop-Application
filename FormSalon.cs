using SinemaOdev.DTO.Salon;
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
    public partial class FormSalon : Form
    {

        SinemaOtomasyonuEntities db = new SinemaOtomasyonuEntities();
        public FormSalon()
        {
            InitializeComponent();

            comboBoxSeans.DisplayMember = "SeansSaat";
            comboBoxSeans.ValueMember = "SeansID ";
            comboBoxSeans.DataSource = db.Seans.ToList();
        }

        private void btn_AnasayfayaGit_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            SalonService s = new SalonService();
            SalonEkleDTO dt = new SalonEkleDTO();
            Seans temp = (Seans)comboBoxSeans.SelectedItem;
            dt.SeansID = temp.SeansID;
            dt.SalonCapasity = (int)(numericUpDownKapasite.Value);
            dt.SalonRowSayisi=(int)(numericUpDownKoltukSayisi.Value);
            dt.SalonaName = textBoxSalonAdi.Text;
            s.EkleYap(dt);
            textBoxSalonAdi.Text = "";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SalonService s = new SalonService();
            foreach (var item in s.ListeleSalon())
            {
                listBox1.Items.Add(item.SalonAd);
            }
        }
    }
}
