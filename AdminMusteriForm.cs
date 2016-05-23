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
    public partial class AdminMusteriForm : Form
    {
        public AdminMusteriForm()
        {
            InitializeComponent();
        }

      


     

        private void label2_Click(object sender, EventArgs e)
        {
            KullaniciForm f = new KullaniciForm();
            f.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AdminLogin f = new AdminLogin();
            f.Show();
            this.Hide();
        }
    }
}
