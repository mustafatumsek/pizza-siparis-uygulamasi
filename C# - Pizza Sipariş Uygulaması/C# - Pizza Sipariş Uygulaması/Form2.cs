using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using C____Pizza_Sipariş_Uygulaması.Properties;

namespace C____Pizza_Sipariş_Uygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int a = 0;                   //combobox sayacı
        public int c1 = 1;                  //combobox değiştirildiğinde ayarın değişmemesini sağlıyor
        public int c2 = 1;                  //combobox değiştirildiğinde ayarın değişmemesini sağlıyor
        public static int zzz = 0;          //form kapatıldığında form1 in yenilenmesini sağlıyor
        public string skt1;                 //son kullanma tarihindeki ayın kartta yazmasını sağlıyor
        public string skt2;                 //son kullanma tarihindeki yılın kartta yazmasını sağlıyor
        public int cvv;                     //cvv kodunun kartta yazmasını sağlıyor
        public static int sifre;            //sms kodu
        public static int sayac = 0;        //sms kodunun yanlış giriş sayısını sayan sayaç

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.Text = "CVV Kodu";
            label5.Text = Form1.isim;       //karttaki isim bölümüne form1de girilen ismi yazdırıyor
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)                  //sadece sayı girilmesini sağlıyor
        {
             e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)                  //sadece sayı girilmesini sağlıyor     
        {
             e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)                  //sadece sayı girilmesini sağlıyor
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label10.Text == "invalid")
            { MessageBox.Show("Girmiş olduğunuz kart numarası geçersizdir. Lütfen kontrol ediniz."); }
            else if (textBox1.Text.Length != 16)
            { MessageBox.Show("Lütfen 16 haneli kart numaranızı eksiksiz giriniz.", "Uyarı"); }
            else if (textBox2.Text.Length != 3)
            { MessageBox.Show("Lütfen kartınızın arka yüzündeki 3 haneli CVV kodunu eksiksiz giriniz.", "Uyarı"); }
            else
            {
                Random random = new Random();           //random fonksiyonu ile sms kodu oluşturuyor
                sifre = random.Next(1000, 9999);        //sifre değişkenine tanımlıyor
                MessageBox.Show("Kart bilgileriniz onaylandı. Doğrulama Kodunuz: " + sifre, "Doğrulama");
                textBox3.Enabled = true;
                textBox3.Text = null;
                button2.Enabled = true;
                button1.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (c1 == 1)                                                     //sadece ilk değişimde değişmesini sağlıyor
            {
                a += 1;
                c1 = 7;
            }
            if (a == 2)
            {
                button1.Enabled = true;
            }

            if (comboBox1.SelectedIndex == 0) { skt1 = "01"; }                  //karttaki skt bölümü için tanımlamalar
            else if (comboBox1.SelectedIndex == 1) { skt1 = "02"; }
            else if (comboBox1.SelectedIndex == 2) { skt1 = "03"; }
            else if (comboBox1.SelectedIndex == 3) { skt1 = "04"; }
            else if (comboBox1.SelectedIndex == 4) { skt1 = "05"; }
            else if (comboBox1.SelectedIndex == 5) { skt1 = "06"; }
            else if (comboBox1.SelectedIndex == 6) { skt1 = "07"; }
            else if (comboBox1.SelectedIndex == 7) { skt1 = "08"; }
            else if (comboBox1.SelectedIndex == 8) { skt1 = "09"; }
            else if (comboBox1.SelectedIndex == 9) { skt1 = "10"; }
            else if (comboBox1.SelectedIndex == 10) { skt1 = "11"; }
            else if (comboBox1.SelectedIndex == 11) { skt1 = "12"; }
            label6.Text = skt1;                                                 //karttaki skt kısmına ayı yazdırıyor
            label8.Text = skt2;                                                 //karttaki skt kısmına yılı yazdırıyor
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (c2 == 1)
            {
                a += 1;
                c2 = 7;
            }
            if (a == 2)
            {
                button1.Enabled = true;
            }

            if (comboBox2.SelectedIndex == 0) { skt2 = "24"; }                  //karttaki skt bölümü için tanımlamalar
            else if (comboBox2.SelectedIndex == 1) { skt2 = "25"; }
            else if (comboBox2.SelectedIndex == 2) { skt2 = "26"; }
            else if (comboBox2.SelectedIndex == 3) { skt2 = "27"; }
            else if (comboBox2.SelectedIndex == 4) { skt2 = "28"; }
            else if (comboBox2.SelectedIndex == 5) { skt2 = "29"; }
            else if (comboBox2.SelectedIndex == 6) { skt2 = "30"; }
            else if (comboBox2.SelectedIndex == 7) { skt2 = "31"; }
            else if (comboBox2.SelectedIndex == 8) { skt2 = "32"; }
            else if (comboBox2.SelectedIndex == 9) { skt2 = "33"; }
            else if (comboBox2.SelectedIndex == 10) { skt2 = "34"; }
            label6.Text = skt1;                                                 //karttaki skt kısmına ayı yazdırıyor
            label8.Text = skt2;                                                 //karttaki skt kısmına yılı yazdırıyor
        }

        private void pictureBox1_Click(object sender, EventArgs e)                  //bilgilerirme kutucukları
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
            {
                sayac++;
                if (sayac == 3)         //güvenlik sebebiyle siparişi iptal ediyor
                {
                    MessageBox.Show("3 kez yanlış kod girdiğiniz için siparişiniz iptal olmuştur. Lütfen tekrar deneyiniz.", "Uyarı");         
                    zzz += 1;
                    this.Close();
                    sayac = 0;
                }
                else
                { MessageBox.Show("Lütfen 4 haneli doğrulama kodunuzu eksiksiz giriniz.", "Uyarı"); }
            }
            else if (textBox3.Text == sifre.ToString())         //başarılı sipariş
            {
                if (Form1.a % 2 == 0)
                { MessageBox.Show("Siparişiniz onaylanmıştır. En kısa sürede Temasasız teslimat ile adresinize gönderilecektir. Teşekkür ederiz.", "Onaylandı"); }
                else
                { MessageBox.Show("Siparişiniz onaylanmıştır. En kısa sürede teslim edilecektir. Teşekkür ederiz.", "Onaylandı"); }
                zzz += 1;
                this.Close();
                sayac = 0;
            }
            else
            {
                sayac++;
                if (sayac == 3)         //güvenlik sebebiyle siparişi iptal ediyor
                {
                    MessageBox.Show("3 kez yanlış kod girdiğiniz için siparişiniz iptal olmuştur. Lütfen tekrar deneyiniz.", "Uyarı");     
                    zzz += 1;
                    this.Close();
                    sayac = 0;
                }
                else
                {
                    MessageBox.Show("Doğrulama kodunuz yanlış. Lütfen tekrar deneyiniz. Kodunuz: " + sifre, "Uyarı"); 
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Text = textBox1.Text;                         //kart görseline yazdırıyor
            if (textBox1.Text.Length == 16)
            {
                label10.Text = KrediKartiniBulma(textBox1.Text);         //sağlayıcıyı bulma fonksiyonunu çağırıp labela yazdırıyor
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cvv = int.Parse(textBox2.Text);                             //cvvyi kart görseline yazdırıyor
            label9.Text = cvv.ToString();
        }
        public static string KrediKartiniBulma(string KrediKartiNo)     //kart sağlayıcısını bulma fonskiyonu

        {

            Regex visaRegex = new Regex("^4[0-9]{12}(?:[0-9]{3})?$");

            Regex masterRegex = new Regex("^5[1-5][0-9]{14}$");

            Regex expressRegex = new Regex("^3[47][0-9]{13}$");

            Regex dinersRegex = new Regex("^3(?:0[0-5]|[68][0-9])[0-9]{11}$");

            Regex discoverRegex = new Regex("^6(?:011|5[0-9]{2})[0-9]{12}$");

            Regex jcbRegex = new Regex("^(?:2131|1800|35\\d{3})\\d{11}$");


            if (visaRegex.IsMatch(KrediKartiNo))

                return "VISA";

            else if (masterRegex.IsMatch(KrediKartiNo))

                return "MASTER";

            else if (expressRegex.IsMatch(KrediKartiNo))

                return "AEXPRESS";

            else if (dinersRegex.IsMatch(KrediKartiNo))

                return "DINERS";

            else if (discoverRegex.IsMatch(KrediKartiNo))

                return "DISCOVERS";

            else if (jcbRegex.IsMatch(KrediKartiNo))

                return "JCB";

            else
                return "invalid";
        }

        private void label10_TextChanged(object sender, EventArgs e)            //kart sağlama fonksiyonu çalıştığında
        {
            if (label10.Text == "MASTER") 
            {
                pictureBox5.Image = Resources.master2;
                textBox2.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
            if (label10.Text == "VISA")
            { 
                pictureBox5.Image = Resources.visa;
                textBox2.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
            if (label10.Text == "AEXPRESS") 
            {
                pictureBox5.Image = Resources.amex;
                textBox2.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
            if (label10.Text == "DINERS")
            {
                pictureBox5.Image = Resources.diners;
                textBox2.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
            if (label10.Text == "DISCOVERS")
            {
                pictureBox5.Image = Resources.discover;
                textBox2.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
            if (label10.Text == "JCB")
            {
                pictureBox5.Image = Resources.JCB;
                textBox2.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
            if (label10.Text == "invalid")                              //kart geçersiz ise diğer bilgiler girilemiyor
            { pictureBox5.Image = Resources.gecersiz;
                textBox2.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }

        }
    }
}