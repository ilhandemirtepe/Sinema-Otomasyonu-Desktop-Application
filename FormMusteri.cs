using SinemaOdev.DTO.Salon;
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
    public partial class FormMusteri : Form
    {
        public FormMusteri()
        {
            InitializeComponent();
        }

        private void btn_AnasayfayaGit_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btn_MusteriListele_Click(object sender, EventArgs e)
        {

            MusteriService s = new MusteriService();
            dataGridView1.DataSource = s.ListeleMusterileri();
         
        }
    }
}
