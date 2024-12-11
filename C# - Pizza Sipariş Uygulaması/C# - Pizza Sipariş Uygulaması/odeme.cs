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
    public partial class odeme : Form
    {
        public odeme()
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
            txtSms.Text = "CVV Kodu";
            lblOtoIsim.Text = anaMenu.isim;       //karttaki isim bölümüne form1de girilen ismi yazdırıyor
            if (anaMenu.check == 1)
            {
                if (MessageBox.Show("Önceden girilmiş kart bilginiz bulunmaktadır. Sizin için doldurmamızı ister misiniz?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //kullanıcı evet seçeneğini seçerse
                    txtKartNo.Text = anaMenu.kartno.ToString();
                    txtCvv.Text = anaMenu.cvvno.ToString();
                    cmbSktAy.SelectedIndex = anaMenu.sktgun;
                    cmbSktYil.SelectedIndex = anaMenu.sktay;
                }
                else
                {
                    //kullanıcı hayır seçeneğini seçerse
                    anaMenu.check = 0;
                }
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)                  //sadece sayı girilmesini sağlıyor
        {
            anaMenu.check = 0;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)                  //sadece sayı girilmesini sağlıyor     
        {
            anaMenu.check = 0;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)                  //sadece sayı girilmesini sağlıyor
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)                              //kaydet butonuna basıldığında
        {
            if (label10.Text == "invalid")          //kart geçersiz ise
            { MessageBox.Show("Girmiş olduğunuz kart numarası geçersizdir. Lütfen kontrol ediniz."); }
            else if (txtKartNo.Text.Length != 16)    //kart no 16 haneli değilse
            { MessageBox.Show("Lütfen 16 haneli kart numaranızı eksiksiz giriniz.", "Uyarı"); }
            else if (txtCvv.Text.Length != 3)     //cvv 3 haneli değilse
            { MessageBox.Show("Lütfen kartınızın arka yüzündeki 3 haneli CVV kodunu eksiksiz giriniz.", "Uyarı"); }
            else
            {                                           //kart başarıyla tanımlanırsa
                Random random = new Random();           //random fonksiyonu ile sms kodu oluşturuyor
                sifre = random.Next(1000, 9999);        //sifre değişkenine tanımlıyor
                MessageBox.Show("Son 4 hanesi " + txtKartNo.Text.Substring(12) + " olan kartınızla " + anaMenu.fiyat + " TL tutarinda harcamaniz icin dogrulama kodunuz: " + sifre + " B003", "Doğrulama");
                txtSms.Enabled = true;                //sms kodu textboxunu aktif ediyor
                txtSms.Text = null;                   //sms kodu textboxunun yazısını siliyor
                btnSiparis.Enabled = true;                 //siparişi oluştur botununu aktif ediyor
                btnOnayla.Enabled = false;                //kaydet butonunu deaktif ediyor
                cmbSktAy.Enabled = false;              //kart bilgileri girişlerinin hepsini deaktif ediyor
                cmbSktYil.Enabled = false;
                txtKartNo.Enabled = false;
                txtCvv.Enabled = false;

                if (anaMenu.check == 1) { cbKartiKaydet.Visible = false; }    //eğer önceki siparişte kart bilgileri kaydedilmişse, doldurulmuşsa ve değiştirilmemişse tekrar kartı kaydet checkboxunu göstermiyor
                else { cbKartiKaydet.Visible = true; }                      //kartı kaydet checkboxunu gösteriyor
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (c1 == 1)                                                     //sadece ilk değişimde değişmesini sağlıyor
            {
                a += 1;
                c1 = 7;
            }
            if (a == 2)                                                         //hem ay hem yıl girilmişse kaydet butonunu aktif ediyor
            {
                btnOnayla.Enabled = true;
            }

            if (cmbSktAy.SelectedIndex == 0) { skt1 = "01"; }                  //karttaki skt bölümü için tanımlamalar
            else if (cmbSktAy.SelectedIndex == 1) { skt1 = "02"; }
            else if (cmbSktAy.SelectedIndex == 2) { skt1 = "03"; }
            else if (cmbSktAy.SelectedIndex == 3) { skt1 = "04"; }
            else if (cmbSktAy.SelectedIndex == 4) { skt1 = "05"; }
            else if (cmbSktAy.SelectedIndex == 5) { skt1 = "06"; }
            else if (cmbSktAy.SelectedIndex == 6) { skt1 = "07"; }
            else if (cmbSktAy.SelectedIndex == 7) { skt1 = "08"; }
            else if (cmbSktAy.SelectedIndex == 8) { skt1 = "09"; }
            else if (cmbSktAy.SelectedIndex == 9) { skt1 = "10"; }
            else if (cmbSktAy.SelectedIndex == 10) { skt1 = "11"; }
            else if (cmbSktAy.SelectedIndex == 11) { skt1 = "12"; }
            label6.Text = skt1;                                                 //karttaki skt kısmına ayı yazdırıyor
            label8.Text = skt2;                                                 //karttaki skt kısmına yılı yazdırıyor
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (c2 == 1)                                                     //sadece ilk değişimde değişmesini sağlıyor
            {
                a += 1;
                c2 = 7;
            }
            if (a == 2)                                                         //hem ay hem yıl girilmişse kaydet butonunu aktif ediyor
            {
                btnOnayla.Enabled = true;
            }

            if (cmbSktYil.SelectedIndex == 0) { skt2 = "24"; }                  //karttaki skt bölümü için tanımlamalar
            else if (cmbSktYil.SelectedIndex == 1) { skt2 = "25"; }
            else if (cmbSktYil.SelectedIndex == 2) { skt2 = "26"; }
            else if (cmbSktYil.SelectedIndex == 3) { skt2 = "27"; }
            else if (cmbSktYil.SelectedIndex == 4) { skt2 = "28"; }
            else if (cmbSktYil.SelectedIndex == 5) { skt2 = "29"; }
            else if (cmbSktYil.SelectedIndex == 6) { skt2 = "30"; }
            else if (cmbSktYil.SelectedIndex == 7) { skt2 = "31"; }
            else if (cmbSktYil.SelectedIndex == 8) { skt2 = "32"; }
            else if (cmbSktYil.SelectedIndex == 9) { skt2 = "33"; }
            else if (cmbSktYil.SelectedIndex == 10) { skt2 = "34"; }
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
            if (btnSiparis.Enabled == true) MessageBox.Show("Telefonunuza B003 kodu ile gelmiş olan 4 haneli size özel oluşturulmuş koddur.", "SMS Kodu");
            else MessageBox.Show("Kart bilgilerinizi doğru girdiğiniz takdirde 'Kartı Onayla' butonuna bastığınızda telefonunuza B003 kodu ile gelecek olan 4 haneli size özel oluşturulmuş koddur.", "SMS Kodu");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSms.Text.Length != 4)
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
            else if (txtSms.Text == sifre.ToString())         //başarılı sipariş
            {
                if (cbKartiKaydet.Checked == true)
                {
                    anaMenu.kartno = Convert.ToInt64(txtKartNo.Text);
                    anaMenu.cvvno = cvv;
                    anaMenu.sktgun = cmbSktAy.SelectedIndex;
                    anaMenu.sktay = cmbSktYil.SelectedIndex;
                    anaMenu.check = 1;
                }
                if (anaMenu.a % 2 == 0)
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
            txtOtoKartNo.Text = txtKartNo.Text;                         //kart görseline yazdırıyor
            if (txtKartNo.Text.Length == 16)
            {
                label10.Text = KrediKartiniBulma(txtKartNo.Text);         //sağlayıcıyı bulma fonksiyonunu çağırıp labela yazdırıyor
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cvv = int.Parse(txtCvv.Text);                             //cvvyi kart görseline yazdırıyor
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

        private void label10_TextChanged(object sender, EventArgs e)            //kart doğrulama fonksiyonu çalıştığında
        {
            if (label10.Text == "MASTER")
            {
                picService.Image = Resources.master2;
                txtCvv.Enabled = true;
                cmbSktAy.Enabled = true;
                cmbSktYil.Enabled = true;
            }
            if (label10.Text == "VISA")
            {
                picService.Image = Resources.visa;
                txtCvv.Enabled = true;
                cmbSktAy.Enabled = true;
                cmbSktYil.Enabled = true;
            }
            if (label10.Text == "AEXPRESS")
            {
                picService.Image = Resources.amex;
                txtCvv.Enabled = true;
                cmbSktAy.Enabled = true;
                cmbSktYil.Enabled = true;
            }
            if (label10.Text == "DINERS")
            {
                picService.Image = Resources.diners;
                txtCvv.Enabled = true;
                cmbSktAy.Enabled = true;
                cmbSktYil.Enabled = true;
            }
            if (label10.Text == "DISCOVERS")
            {
                picService.Image = Resources.discover;
                txtCvv.Enabled = true;
                cmbSktAy.Enabled = true;
                cmbSktYil.Enabled = true;
            }
            if (label10.Text == "JCB")
            {
                picService.Image = Resources.JCB;
                txtCvv.Enabled = true;
                cmbSktAy.Enabled = true;
                cmbSktYil.Enabled = true;
            }
            if (label10.Text == "invalid")                              //kart geçersiz ise diğer bilgiler girilemiyor
            {
                picService.Image = Resources.gecersiz;
                txtCvv.Enabled = false;
                cmbSktAy.Enabled = false;
                cmbSktYil.Enabled = false;
            }

        }
        private void comboBox1_DropDownClosed(object sender, EventArgs e)       //kart bilgileri otomatik doldurulduktan sonra değişiklik yapılırsa tekrar kaydedilsin mi diye sorması için
        {
            anaMenu.check = 0;
        }

        private void comboBox2_DropDownClosed(object sender, EventArgs e)       //kart bilgileri otomatik doldurulduktan sonra değişiklik yapılırsa tekrar kaydedilsin mi diye sorması için
        {
            anaMenu.check = 0;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (label10.Text == "invalid")
            { MessageBox.Show("Girmiş olduğunuz kart numarası geçersizdir. Lütfen kontrol ediniz.", "Uyarı"); }
        }
    }
}