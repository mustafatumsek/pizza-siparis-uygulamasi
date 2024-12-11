using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____Pizza_Sipariş_Uygulaması
{
    public partial class hakkimizda : Form
    {
        public hakkimizda()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            resim1 resim1 = new resim1();
            resim1.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            resim2 resim2 = new resim2();
            resim2.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            resim3 resim3 = new resim3();
            resim3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            resim4 resim4 = new resim4();
            resim4.ShowDialog();
        }
    }
}
