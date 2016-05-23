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
    public partial class AdminLogin : Form
    {
        SinemaOtomasyonuEntities db = new SinemaOtomasyonuEntities();
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Admin)
            {
                if (item.AdminUserName == txt_KullaniciAdi.Text && item.AdminPassWord == txtSifre.Text)
                {
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    txt_KullaniciAdi.Text = "";
                    txtSifre.Text = "";
                    MessageBox.Show("Kullanıcı adı veya parola yanlış");
                    return;
                }
            }
        }
    }
}
