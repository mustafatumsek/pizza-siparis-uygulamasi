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
        public static int formYenile = 0;          //form kapatıldığında form1 in yenilenmesini sağlıyor
        public string kartSktAy;                 //son kullanma tarihindeki ayın kartta yazmasını sağlıyor
        public string kartSktYil;                 //son kullanma tarihindeki yılın kartta yazmasını sağlıyor
        public int cvv;                     //cvv kodunun kartta yazmasını sağlıyor
        public static int sifre;            //sms kodu
        public static int sayac = 0;        //sms kodunun yanlış giriş sayısını sayan sayaç



        private void odeme_Load(object sender, EventArgs e)
        {
            txtSms.Text = "CVV Kodu";
            lblOtoIsim.Text = anaMenu.isim;       //karttaki isim bölümüne form1de girilen ismi yazdırıyor
            if (anaMenu.check == 1)
            {
                if (MessageBox.Show("Önceden girilmiş kart bilginiz bulunmaktadır. Sizin için doldurmamızı ister misiniz?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //kullanıcı evet seçeneğini seçerse
                    txtKartNo.Text = anaMenu.kartNo.ToString();
                    txtCvv.Text = anaMenu.cvvNo.ToString();
                    cmbSktAy.SelectedIndex = anaMenu.sktGun;
                    cmbSktYil.SelectedIndex = anaMenu.sktAy;
                }
                else
                {
                    //kullanıcı hayır seçeneğini seçerse
                    anaMenu.check = 0;
                }
            }
        }
        private void txtKartNo_KeyPress(object sender, KeyPressEventArgs e)                  //sadece sayı girilmesini sağlıyor
        {
            anaMenu.check = 0;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCvv_KeyPress(object sender, KeyPressEventArgs e)                  //sadece sayı girilmesini sağlıyor     
        {
            anaMenu.check = 0;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSms_KeyPress(object sender, KeyPressEventArgs e)                  //sadece sayı girilmesini sağlıyor
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)                              //kaydet butonuna basıldığında
        {
            if (lblKartCheck.Text == "invalid")          //kart geçersiz ise
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

        private void cmbSktAy_SelectedIndexChanged(object sender, EventArgs e)
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

            if (cmbSktAy.SelectedIndex == 0) { kartSktAy = "01"; }                  //karttaki skt bölümü için tanımlamalar
            else if (cmbSktAy.SelectedIndex == 1) { kartSktAy = "02"; }
            else if (cmbSktAy.SelectedIndex == 2) { kartSktAy = "03"; }
            else if (cmbSktAy.SelectedIndex == 3) { kartSktAy = "04"; }
            else if (cmbSktAy.SelectedIndex == 4) { kartSktAy = "05"; }
            else if (cmbSktAy.SelectedIndex == 5) { kartSktAy = "06"; }
            else if (cmbSktAy.SelectedIndex == 6) { kartSktAy = "07"; }
            else if (cmbSktAy.SelectedIndex == 7) { kartSktAy = "08"; }
            else if (cmbSktAy.SelectedIndex == 8) { kartSktAy = "09"; }
            else if (cmbSktAy.SelectedIndex == 9) { kartSktAy = "10"; }
            else if (cmbSktAy.SelectedIndex == 10) { kartSktAy = "11"; }
            else if (cmbSktAy.SelectedIndex == 11) { kartSktAy = "12"; }
            label6.Text = kartSktAy;                                                 //karttaki skt kısmına ayı yazdırıyor
            label8.Text = kartSktYil;                                                 //karttaki skt kısmına yılı yazdırıyor
        }

        private void cmbSktYil_SelectedIndexChanged(object sender, EventArgs e)
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

            if (cmbSktYil.SelectedIndex == 0) { kartSktYil = "24"; }                  //karttaki skt bölümü için tanımlamalar
            else if (cmbSktYil.SelectedIndex == 1) { kartSktYil = "25"; }
            else if (cmbSktYil.SelectedIndex == 2) { kartSktYil = "26"; }
            else if (cmbSktYil.SelectedIndex == 3) { kartSktYil = "27"; }
            else if (cmbSktYil.SelectedIndex == 4) { kartSktYil = "28"; }
            else if (cmbSktYil.SelectedIndex == 5) { kartSktYil = "29"; }
            else if (cmbSktYil.SelectedIndex == 6) { kartSktYil = "30"; }
            else if (cmbSktYil.SelectedIndex == 7) { kartSktYil = "31"; }
            else if (cmbSktYil.SelectedIndex == 8) { kartSktYil = "32"; }
            else if (cmbSktYil.SelectedIndex == 9) { kartSktYil = "33"; }
            else if (cmbSktYil.SelectedIndex == 10) { kartSktYil = "34"; }
            label6.Text = kartSktAy;                                                 //karttaki skt kısmına ayı yazdırıyor
            label8.Text = kartSktYil;                                                 //karttaki skt kısmına yılı yazdırıyor
        }

        private void picKartHelp_Click(object sender, EventArgs e)                  //bilgilerirme kutucukları
        {
            MessageBox.Show("Kartınızın ön yüzünde yer alan 16 haneli numaradır.", "Kart Numarası");
        }

        private void picSktHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kartınızın ön yüzünde yer alan gün/ay şeklinde yazılmış 2 haneli numaralardır.", "Son Kullanım Tarihi");
        }

        private void picCvvHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kartınızın arka yüzünde yer alan 3 haneli numaradır.", "CVV");
        }

        private void picSmsHelp_Click(object sender, EventArgs e)
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
                    formYenile += 1;
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
                    anaMenu.kartNo = Convert.ToInt64(txtKartNo.Text);
                    anaMenu.cvvNo = cvv;
                    anaMenu.sktGun = cmbSktAy.SelectedIndex;
                    anaMenu.sktAy = cmbSktYil.SelectedIndex;
                    anaMenu.check = 1;
                }
                if (anaMenu.a % 2 == 0)
                { MessageBox.Show("Siparişiniz onaylanmıştır. En kısa sürede Temasasız teslimat ile adresinize gönderilecektir. Teşekkür ederiz.", "Onaylandı"); }
                else
                { MessageBox.Show("Siparişiniz onaylanmıştır. En kısa sürede teslim edilecektir. Teşekkür ederiz.", "Onaylandı"); }
                formYenile += 1;
                this.Close();
                sayac = 0;
            }
            else
            {
                sayac++;
                if (sayac == 3)         //güvenlik sebebiyle siparişi iptal ediyor
                {
                    MessageBox.Show("3 kez yanlış kod girdiğiniz için siparişiniz iptal olmuştur. Lütfen tekrar deneyiniz.", "Uyarı");
                    formYenile += 1;
                    this.Close();
                    sayac = 0;
                }
                else
                {
                    MessageBox.Show("Doğrulama kodunuz yanlış. Lütfen tekrar deneyiniz. Kodunuz: " + sifre, "Uyarı");
                }
            }
        }

        private void txtKartNo_TextChanged(object sender, EventArgs e)
        {
            txtOtoKartNo.Text = txtKartNo.Text;                         //kart görseline yazdırıyor
            if (txtKartNo.Text.Length == 16)
            {
                lblKartCheck.Text = KrediKartiniBulma(txtKartNo.Text);         //sağlayıcıyı bulma fonksiyonunu çağırıp labela yazdırıyor
            }
        }

        private void txtCvv_TextChanged(object sender, EventArgs e)
        {
            cvv = int.Parse(txtCvv.Text);                             //cvvyi kart görseline yazdırıyor
            lblKartCvv.Text = cvv.ToString();
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

        private void lblKartCheck_TextChanged(object sender, EventArgs e)            //kart doğrulama fonksiyonu çalıştığında
        {
            if (lblKartCheck.Text == "MASTER")
            {
                picService.Image = Resources.master2;
                txtCvv.Enabled = true;
                cmbSktAy.Enabled = true;
                cmbSktYil.Enabled = true;
            }
            if (lblKartCheck.Text == "VISA")
            {
                picService.Image = Resources.visa;
                txtCvv.Enabled = true;
                cmbSktAy.Enabled = true;
                cmbSktYil.Enabled = true;
            }
            if (lblKartCheck.Text == "AEXPRESS")
            {
                picService.Image = Resources.amex;
                txtCvv.Enabled = true;
                cmbSktAy.Enabled = true;
                cmbSktYil.Enabled = true;
            }
            if (lblKartCheck.Text == "DINERS")
            {
                picService.Image = Resources.diners;
                txtCvv.Enabled = true;
                cmbSktAy.Enabled = true;
                cmbSktYil.Enabled = true;
            }
            if (lblKartCheck.Text == "DISCOVERS")
            {
                picService.Image = Resources.discover;
                txtCvv.Enabled = true;
                cmbSktAy.Enabled = true;
                cmbSktYil.Enabled = true;
            }
            if (lblKartCheck.Text == "JCB")
            {
                picService.Image = Resources.JCB;
                txtCvv.Enabled = true;
                cmbSktAy.Enabled = true;
                cmbSktYil.Enabled = true;
            }
            if (lblKartCheck.Text == "invalid")                              //kart geçersiz ise diğer bilgiler girilemiyor
            {
                picService.Image = Resources.gecersiz;
                txtCvv.Enabled = false;
                cmbSktAy.Enabled = false;
                cmbSktYil.Enabled = false;
            }

        }
        private void cmbSktAy_DropDownClosed(object sender, EventArgs e)       //kart bilgileri otomatik doldurulduktan sonra değişiklik yapılırsa tekrar kaydedilsin mi diye sorması için
        {
            anaMenu.check = 0;
        }

        private void cmbSktYil_DropDownClosed(object sender, EventArgs e)       //kart bilgileri otomatik doldurulduktan sonra değişiklik yapılırsa tekrar kaydedilsin mi diye sorması için
        {
            anaMenu.check = 0;
        }

        private void picService_Click(object sender, EventArgs e)
        {
            if (lblKartCheck.Text == "invalid")
            { MessageBox.Show("Girmiş olduğunuz kart numarası geçersizdir. Lütfen kontrol ediniz.", "Uyarı"); }
        }
    }
}