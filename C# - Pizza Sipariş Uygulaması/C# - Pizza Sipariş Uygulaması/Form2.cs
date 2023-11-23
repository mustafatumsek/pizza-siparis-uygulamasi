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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int a = 0;
        public int c1 = 1;
        public int c2 = 1;
        public static int zzz = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.Text = "CVV Kodu";
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 16)
            { MessageBox.Show("Lütfen 16 haneli kart numaranızı eksiksiz giriniz.", "Uyarı"); }
            else if (textBox2.Text.Length != 3)
            { MessageBox.Show("Lütfen kartınızın arka yüzündeki 3 haneli CVV kodunu eksiksiz giriniz.", "Uyarı"); }
            else
            {
                MessageBox.Show("Kart bilgileriniz onaylandı. Lütfen telefonunuza gelen doğrulama kodunu giriniz.", "İşlem tamamlandı");
                textBox3.Enabled = true;
                textBox3.Text = null;
                button2.Enabled = true;
                button1.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (c1 == 1)
            {
                a += 1;
                c1 = 7;
            }
            if (a == 2) { button1.Enabled = true; }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (c2 == 1)
            {
                a += 1;
                c2 = 7;
            }
            if (a == 2) { button1.Enabled = true; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kartınızın ön yüzünde yer alan 16 haneli numaradır.", "Kart Numarası");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kartınızın ön yüzünde yer alan gün/ay şeklinde yazılmış 2 haneli numaralardır.", "Son Kullanım Tarihi");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kartınızın arka yüzünde yer alan 3 haneli numaradır.", "CVV");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (button2.Enabled == true) MessageBox.Show("Telefonunuza B003 kodu ile gelmiş olan 4 haneli size özel oluşturulmuş koddur.", "SMS Kodu");         
            else MessageBox.Show("Kart bilgilerinizi doğru girdiğiniz takdirde 'Kartı Onayla' butonuna bastığınızda telefonunuza B003 kodu ile gelecek olan 4 haneli size özel oluşturulmuş koddur.", "SMS Kodu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length != 4)
            { MessageBox.Show("Lütfen 4 haneli doğrulama kodunuzu eksiksiz giriniz.", "Uyarı"); }
            else
            {
                if (Form1.a % 2 == 0)
                { MessageBox.Show("Siparişiniz onaylanmıştır. En kısa sürede Temasasız teslimat ile adresinize gönderilecektir. Teşekkür ederiz.", "Onaylandı"); }
                else
                { MessageBox.Show("Siparişiniz onaylanmıştır. En kısa sürede teslim edilecektir. Teşekkür ederiz.", "Onaylandı"); }
                zzz += 1;
                this.Close();
            }
        }
    }
}