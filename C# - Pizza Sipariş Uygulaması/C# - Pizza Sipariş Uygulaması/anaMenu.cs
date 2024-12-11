//10.06.24 Form isimlerini güncelledim.
//22.09.24 SMS doğrulama mesajını güncelledim. Ana menü form ismini güncelledim. 
//09.10.24 İletişim formundaki harita ve web sitesi yönlendirmelerini yaptım.
//14.11.24 İndirim kodları eklendi.
//15.11.24 yeni indirim kodu eklendi ve listboxa indirimli fiyat yansıtıldı.
//16.11.24 Önceden kart bilgisi kaydedilmişse ama yeni siparişte farklı isim girilmişse kart bilgilerinin oto doldurulmaması sağlandı.
using System.Diagnostics.Eventing.Reader;

namespace C____Pizza_Sipariş_Uygulaması
{
    public partial class anaMenu : Form
    {
        public anaMenu()
        {
            InitializeComponent();
        }
        public static string isim; //ödeme formunda kartın üzerinde isim yazması için
        public static int a = 1;   //temassız teslimat checkbox
        public static int cvvno, sktay, sktgun, check;  //kart kaydedilirse otomatik doldurulan bilgiler
        public static long kartno; //kart kaydedilirse otomatik doldurulan kart numarası
        public static int fiyat = 0;      //fiyat 
        public int b = 0;          //combobox sayacı
        public int c1 = 1;         //comboboxlar
        public int c2 = 1;
        public int c3 = 1;
        public int c4 = 1;
        public int c5 = 1;
        public int c6 = 1;
        public int c7 = 1;
        public int c8 = 1;
        public int c9 = 1;
        public int c10 = 1;
        public int c11 = 1;
        public int c12 = 1;
        public int d = 0;          //ödeme türü checkbox
        public int f = 0;           //indirim butonu check
        public static int eskifiyat = 0;        //indirim kodu girilirse kaçtan düştüğünü gösteren değişken
        public string eskiisim;

        public void temizle()  //temizle butonu ile, menustripteki temizle seçeneği ile, contextmenustripteki seçimleri temizle seçeneği ile, 3 kez yanlış sms kodu girildikten sonra ve sipariş oluşturulduktan sonra yapılan temizlik.
        {
            listBox1.Items.Clear();
            cmbHamur.SelectedIndex = -1;
            cmbSucuk.SelectedIndex = -1;
            cmbMantar.SelectedIndex = -1;
            cmbPeynir.SelectedIndex = -1;
            cmbZeytin.SelectedIndex = -1;
            cmbBoyut.SelectedIndex = -1;
            cmbİcecek1.SelectedIndex = -1;
            cmbSos2.SelectedIndex = -1;
            cmbCıtır.SelectedIndex = -1;
            cmbTatlı.SelectedIndex = -1;
            cmbİcecek2.SelectedIndex = -1;
            cmbSos1.SelectedIndex = -1;
            txtIsimSoyisim.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            txtAdres.Text = string.Empty;
            cbTemassız.Checked = false;
            cbKapıda.Checked = false;
            btnKaydet.Visible = false;
            btnSiparis.Visible = false;
            gbTeslimat.Visible = false;
            txtIndirimKodu.Visible = false;
            btnIndirimKodu.Visible = true;
            btnIndirimKodu.Text = ("İndirim Kodum Var");
            fiyat = 0;
            eskifiyat = 0;
            a = 1;
            b = 0;
            d = 0;
            f = 0;
            c1 = 1;
            c2 = 1;
            c3 = 1;
            c4 = 1;
            c5 = 1;
            c6 = 1;
            c7 = 1;
            c8 = 1;
            c9 = 1;
            c10 = 1;
            c11 = 1;
            c12 = 1;
        }

        private void button1_Click(object sender, EventArgs e)  //kaydet butonu
        {
            fiyat = 0;
            listBox1.Items.Clear();
            listBox1.Items.Add("                 SİPARİŞ BİLGİLERİ");       //bu başlıklar her cihazda simetrik olmayabilir kontrol edilmesi lazım
            listBox1.Items.Add("");
            listBox1.Items.Add("-----------------PİZZA-------------------");
            listBox1.Items.Add("º " + cmbBoyut.Text);
            listBox1.Items.Add("º " + cmbHamur.Text);
            listBox1.Items.Add("º " + cmbSucuk.Text);
            listBox1.Items.Add("º " + cmbMantar.Text);
            listBox1.Items.Add("º " + cmbPeynir.Text);
            listBox1.Items.Add("º " + cmbZeytin.Text);
            listBox1.Items.Add(" ");
            listBox1.Items.Add("-----------PROMOSYONLAR------------");
            listBox1.Items.Add("º " + cmbTatlı.Text);
            listBox1.Items.Add("º " + cmbCıtır.Text);
            listBox1.Items.Add("º " + cmbSos1.Text);
            listBox1.Items.Add("º " + cmbSos2.Text);
            listBox1.Items.Add(" ");
            listBox1.Items.Add("--------------İÇECEKLER-----------------");
            listBox1.Items.Add("º " + cmbİcecek1.Text);
            listBox1.Items.Add("º " + cmbİcecek2.Text);
            listBox1.Items.Add("\n");
            gbTeslimat.Visible = true;
            btnSiparis.Visible = true;
            txtIndirimKodu.Visible = false;
            btnIndirimKodu.Visible = false;
            if (cmbBoyut.SelectedIndex == 0) { fiyat += 15; }          //pizza boyutu          //küçük
            else if (cmbBoyut.SelectedIndex == 1) { fiyat += 25; }                             //orta
            else if (cmbBoyut.SelectedIndex == 2) { fiyat += 35; }                             //büyük
            if (cmbHamur.SelectedIndex == 1) { fiyat += 5; }           //pizza hamuru          //kalın
            if (cmbSucuk.SelectedIndex == 1) { fiyat += 8; }           //sucuk                 //sucuklu
            else if (cmbSucuk.SelectedIndex == 2) { fiyat += 15; }                             //bol sucuklu
            if (cmbMantar.SelectedIndex == 1) { fiyat += 2; }           //mantar                //mantarlı
            else if (cmbMantar.SelectedIndex == 2) { fiyat += 4; }                              //bol mantarlı
            if (cmbPeynir.SelectedIndex == 1) { fiyat += 7; }           //peynir                //emmental
            else if (cmbPeynir.SelectedIndex == 2) { fiyat += 7; }                              //provolone
            if (cmbZeytin.SelectedIndex == 1) { fiyat += 4; }           //zeytin                //zeytinli
            else if (cmbZeytin.SelectedIndex == 2) { fiyat += 8; }                              //bol zeytinli
            if ((cmbTatlı.SelectedIndex == 1)) { fiyat += 10; }       //tatlı promosyon       //sufle
            else if ((cmbTatlı.SelectedIndex == 2)) { fiyat += 6; }                            //sütlaç
            else if ((cmbTatlı.SelectedIndex == 3)) { fiyat += 7; }                           //kakaolu puding
            else if ((cmbTatlı.SelectedIndex == 4)) { fiyat += 7; }                           //çilekli puding
            else if ((cmbTatlı.SelectedIndex == 5)) { fiyat += 7; }                           //muzlu puding
            else if ((cmbTatlı.SelectedIndex == 5)) { fiyat += 7; }                           //muzlu puding
            else if ((cmbTatlı.SelectedIndex == 6)) { fiyat += 7; }                           //vanilyalı puding
            else if ((cmbTatlı.SelectedIndex == 7)) { fiyat += 8; }                           //kazandibi
            else if ((cmbTatlı.SelectedIndex == 8)) { fiyat += 8; }                           //güllaç
            else if ((cmbTatlı.SelectedIndex == 9)) { fiyat += 8; }                           //muhallebi
            else if ((cmbTatlı.SelectedIndex == 10)) { fiyat += 8; }                          //supangle
            if (cmbCıtır.SelectedIndex == 1) { fiyat += 10; }          //çıtır promosyon       //5'li soğan halkası
            else if (cmbCıtır.SelectedIndex == 2) { fiyat += 17; }                             //10'lu soğan halkası
            else if (cmbCıtır.SelectedIndex == 3) { fiyat += 8; }                              //küçük boy patates kızartması
            else if (cmbCıtır.SelectedIndex == 4) { fiyat += 14; }                             //orta boy patates kızartması
            else if (cmbCıtır.SelectedIndex == 5) { fiyat += 20; }                             //büyük boy patates kızartması
            else if (cmbCıtır.SelectedIndex == 6) { fiyat += 30; }                             //dev patates kova
            else if (cmbCıtır.SelectedIndex == 7) { fiyat += 8; }                              //4'lü cheese sticks
            else if (cmbCıtır.SelectedIndex == 8) { fiyat += 10; }                             //6'lı cheese sticks
            else if (cmbCıtır.SelectedIndex == 9) { fiyat += 13; }                             //8'li cheese sticks
            else if (cmbCıtır.SelectedIndex == 10) { fiyat += 17; }                             //10'lu soğan halkası
            else if (cmbCıtır.SelectedIndex == 11) { fiyat += 8; }                              //küçük boy tırtıklı patates
            else if (cmbCıtır.SelectedIndex == 12) { fiyat += 14; }                             //orta boy tırtıklı patates
            else if (cmbCıtır.SelectedIndex == 13) { fiyat += 20; }                             //büyük boy tırtıklı patates
            if (cmbSos2.SelectedIndex == 3) { fiyat += 2; }           //ikinci sos            //barbekü sos
            else if (cmbSos2.SelectedIndex == 4) { fiyat += 2; }                              //hardal
            else if (cmbSos2.SelectedIndex == 5) { fiyat += 2; }                              //acı sos
            else if (cmbSos2.SelectedIndex == 6) { fiyat += 3; }                              //sarımsaklı mayonez
            else if (cmbSos2.SelectedIndex == 7) { fiyat += 3; }                              //ballı hardallı sos
            else if (cmbSos2.SelectedIndex == 8) { fiyat += 3; }                              //buffalo sos
            if (cmbİcecek1.SelectedIndex == 1) { fiyat += 5; }           //birinci içecek        //küçük ayran    
            else if (cmbİcecek1.SelectedIndex == 2) { fiyat += 8; }                              //büyük ayran
            else if (cmbİcecek1.SelectedIndex == 3) { fiyat += 8; }                              //330 mL kola
            else if (cmbİcecek1.SelectedIndex == 4) { fiyat += 8; }                              //330 mL  şekersiz kola
            else if (cmbİcecek1.SelectedIndex == 5) { fiyat += 18; }                             //1 L kola
            else if (cmbİcecek1.SelectedIndex == 6) { fiyat += 18; }                             //1 L şekersiz kola    
            else if (cmbİcecek1.SelectedIndex == 7) { fiyat += 7; }                              //330 mL ice tea şeftali
            else if (cmbİcecek1.SelectedIndex == 8) { fiyat += 7; }                              //330 mL ice tea mango
            else if (cmbİcecek1.SelectedIndex == 9) { fiyat += 17; }                             //1 L ice tea şeftali
            else if (cmbİcecek1.SelectedIndex == 10) { fiyat += 17; }                            //1 L ice tea mango
            else if (cmbİcecek1.SelectedIndex == 11) { fiyat += 8; }                             //400 mL şalgam
            else if (cmbİcecek1.SelectedIndex == 12) { fiyat += 8; }                             //400 mL acı şalgam
            else if (cmbİcecek1.SelectedIndex == 13) { fiyat += 10; }                            //250 mL zafer gazoz sade
            else if (cmbİcecek1.SelectedIndex == 14) { fiyat += 10; }                            //250 mL zafer gazoz portakallı
            else if (cmbİcecek1.SelectedIndex == 15) { fiyat += 2; }                             //500 mL su
            if (cmbİcecek2.SelectedIndex == 1) { fiyat += 5; }          //ikinci içecek         //küçük ayran 
            else if (cmbİcecek2.SelectedIndex == 2) { fiyat += 8; }                             //büyük ayran
            else if (cmbİcecek2.SelectedIndex == 3) { fiyat += 8; }                             //330 mL kola
            else if (cmbİcecek2.SelectedIndex == 4) { fiyat += 8; }                             //330 mL  şekersiz kola
            else if (cmbİcecek2.SelectedIndex == 5) { fiyat += 18; }                            //1 L kola
            else if (cmbİcecek2.SelectedIndex == 6) { fiyat += 18; }                            //1 L şekersiz kola
            else if (cmbİcecek2.SelectedIndex == 7) { fiyat += 7; }                             //330 mL ice tea şeftali
            else if (cmbİcecek2.SelectedIndex == 8) { fiyat += 7; }                             //330 mL ice tea mango
            else if (cmbİcecek2.SelectedIndex == 9) { fiyat += 17; }                            //1 L ice tea şeftali
            else if (cmbİcecek2.SelectedIndex == 10) { fiyat += 17; }                           //1 L ice tea mango
            else if (cmbİcecek2.SelectedIndex == 11) { fiyat += 8; }                            //400 mL şalgam
            else if (cmbİcecek2.SelectedIndex == 12) { fiyat += 8; }                            //400 mL acı şalgam                        
            else if (cmbİcecek2.SelectedIndex == 13) { fiyat += 10; }                           //250 mL zafer gazoz sade
            else if (cmbİcecek1.SelectedIndex == 14) { fiyat += 10; }                            //250 mL zafer gazoz portakallı
            else if (cmbİcecek1.SelectedIndex == 15) { fiyat += 2; }                             //500 mL su
            if (f == 0) { listBox1.Items.Add("TOPLAM= " + fiyat + " TL"); }
            else 
            {
                eskifiyat = fiyat;
                fiyat = Convert.ToInt16((fiyat * 85)/100);
                listBox1.Items.Add("TOPLAM= " + eskifiyat + " INDIRIMLI: " + fiyat + " TL"); }
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)       //temassız teslimat işaretlendiğinde
        { a += 1; }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)       //kapıda ödeme işaretlendiğinde
        { d += 1; }

        private void button2_Click(object sender, EventArgs e)      //sipariş ver butonu
        {
            if (txtIsimSoyisim.Text.Length == 0) { MessageBox.Show("Lütfen isim soyisminizi giriniz.", "Uyarı"); }                                                                //isim textboxu boş ise
            else if (txtTelefon.Text.Length == 0) { MessageBox.Show("Lütfen telefon numaranızı giriniz.", "Uyarı"); }                                                         //telefon textboxu boş ise
            else if (txtTelefon.Text.Length != 11 || Convert.ToInt64(txtTelefon.Text) >= 10000000000) { MessageBox.Show("Lütfen 11 haneli telefon numaranızı eksiksiz ve başında '0' olacak şekilde giriniz.", "Uyarı"); }      //telefon textboxu yeterli hanede değil ise ve başında 0 yok ise
            else if (Convert.ToInt64(txtTelefon.Text) < 5000000000 || Convert.ToInt64(txtTelefon.Text) >= 6000000000) { MessageBox.Show("Lütfen 11 haneli telefon numaranızı eksiksiz ve başında '0' olacak şekilde giriniz.", "Uyarı"); }      //telefon numarası yeterli hanede değilse
            else if (txtAdres.Text.Length == 0) { MessageBox.Show("Lütfen adresinizi giriniz.", "Uyarı"); }                                                                 //adres textboxu boş ise
            else
            {
                isim = txtIsimSoyisim.Text;
                if (isim != eskiisim) { check = 0; }
                if (a % 2 == 0)  //temassız teslimat işaretlenmişse
                {
                    if (d % 2 == 1)  //kapıda ödeme işaretlenmişse
                    {
                        MessageBox.Show("Siparişiniz onaylanmıştır. En kısa sürede Temasasız teslimat ile adresinize gönderilecektir. Teşekkür ederiz.", "Onaylandı");
                        eskiisim = isim;
                        temizle();
                    }
                    else  //kapıda ödeme işaretlenmemişse
                    {
                        eskiisim = isim;
                        odeme form = new odeme();
                        form.ShowDialog();
                    }
                }
                else if (a % 2 == 1)  //temasssız teslimat işaretlenmemişse
                {
                    if (d % 2 == 1)  //kapıda ödeme işaretlenmişse
                    {
                        MessageBox.Show("Siparişiniz onaylanmıştır. En kısa sürede teslim edilecektir. Teşekkür ederiz.", "Onaylandı");
                        eskiisim = isim;
                        temizle();
                    }
                    else  //kapıda ödeme işaretlenmemişse
                    {
                        eskiisim = isim;
                        odeme form = new odeme();
                        form.ShowDialog();
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)    //temizle butonu
        { temizle(); }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)   //pizza hamuru
        {
            while (c2 == 1)
            {
                b += 1;                                 //comboboxtan seçim yapıldığında değer artsın
                c2 += 1;                                //sadece bir kez artabilmesi için
            }
            if (b == 12) { btnKaydet.Visible = true; }    //tüm comboboxlarda seçim yapılmışsa kaydet butonu gözüksün
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)   //sucuk
        {
            while (c3 == 1)
            {
                b += 1;
                c3 += 1;
            }
            if (b == 12) { btnKaydet.Visible = true; }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)   //mantar
        {
            while (c4 == 1)
            {
                b += 1;
                c4 += 1;
            }
            if (b == 12) { btnKaydet.Visible = true; }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)   //mozarella
        {
            while (c5 == 1)
            {
                b += 1;
                c5 += 1;
            }
            if (b == 12) { btnKaydet.Visible = true; }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)   //zeytin
        {
            while (c6 == 1)
            {
                b += 1;
                c6 += 1;
            }
            if (b == 12) { btnKaydet.Visible = true; }
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)   //pizza boyutu
        {
            while (c1 == 1)
            {
                b += 1;
                c1 = 7;
            }
            if (b == 12) { btnKaydet.Visible = true; }
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)   //birinci içecek
        {
            while (c10 == 1)
            {
                b += 1;
                c10 += 1;
            }
            if (b == 12) { btnKaydet.Visible = true; }
        }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)   //ikinci sos
        {
            while (c9 == 1)
            {
                b += 1;
                c9 += 1;
            }
            if (b == 12) { btnKaydet.Visible = true; }
        }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)   //soğan halkası
        {
            while (c8 == 1)
            {
                b += 1;
                c8 += 1;
            }
            if (b == 12) { btnKaydet.Visible = true; }
        }
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)   //sufle
        {
            while (c7 == 1)
            {
                b += 1;
                c7 += 1;
            }
            if (b == 12) { btnKaydet.Visible = true; }
        }
        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)   //ikinci içecek
        {
            while (c11 == 1)
            {
                b += 1;
                c11 += 1;
            }
            if (b == 12) { btnKaydet.Visible = true; }
        }
        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)   //birinci sos
        {
            while (c12 == 1)
            {
                b += 1;
                c12 += 1;
            }
            if (b == 12) { btnKaydet.Visible = true; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); }       //telefon textboxuna sadece sayı girilebilmesi

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)     //isim textboxuna sadece harf girilebilmesi
                && !char.IsSeparator(e.KeyChar);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (odeme.zzz == 1)     //form1'e tıklandığında eğer form2de sipariş oluşturulduysa
            {
                temizle();
                odeme.zzz = 0;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (odeme.zzz == 1)     //form1'de mouse hareket ettiğinde eğer form2de sipariş oluşturulduysa
            {
                temizle();
                odeme.zzz = 0;
            }
        }

        private void bizKimizToolStripMenuItem_Click(object sender, EventArgs e)            //menustripteki biz kimiz seçeneği
        {
            hakkimizda form = new hakkimizda();
            form.ShowDialog();
        }

        private void güncellemeNotlarıToolStripMenuItem_Click(object sender, EventArgs e)       //menustripteki güncelleme notları seçeneği
        {
            MessageBox.Show("7 Eylül 2023 - 0.1\nBavyera Pizza Uygulaması'nın yapımına başlandı.Uygulama ana hatlarıyla oluşturuldu.\n\n" +
                "13 Eylül 2023 - 0.2\nTextboxlara yalnızca sayı giriş yapılması, textboxlara karakter limiti ve tüm seçimler yapılmadan kaydet butonunun gelmemesi gibi özellikler eklendi.\n\n" +
                "17 Eylül 2023 - 1.0\nBavyera Pizza uygulaması yayınlandı. Aynı comboboxta birden çok seçim yapıldığında kaydet butonunun gelmesi sorunu çözüldü. Label olan uyarı mesajları messageboxa çevrildi. Telefon numarası yalnızca 11 hane olarak ayarlandı. İsim textboxuna rakam girişi engellendi.\n\n" +
                "10 Ekim 2023 - 1.0.1\nUyarı mesajlarına başlık eklendi.\n\n" +
                "18 Kasım 2023 - 1.1\nKartla ödeme seçeneği ve 2. form eklendi. 3 yeni içecek eklendi.\n\n" +
                "22 Kasım 2023 - 1.2\n2. Form kullanıma hazır hale getirildi. Kart no textboxuna 16, cvv textboxuna 3, doğrulama kodu textboxuna 4 haneli giriş yapılmadan ve skt seçilmeden ödeme alınmaması sağlandı. Bu textboxlara yalnızca sayı girişi yapılması sağlandı. Yeni logo eklendi. Formlar arası geçiş sağlandı. 3 yeni sos, 1 yeni içecek eklendi. 2. Forma bilgi verici butonlar eklendi. Kodlar düzenlenip yorum satırları eklendi ve hatalar düzeltildi. Ana form yeniden boyutlandırıldı. İkinci sos ve ikinci içecek seçenekleri eklendi.\n\n" +
                "19 Ocak 2024 - 1.3\nKapıda ödeme ile yapılan ödemelerde ve temizleme butonu ile yapılan temizlikler fonksiyona bağlandı. Yorum satırları düzenlendi. Hatalar düzeltildi. Fiyat düzenlemeleri yapıldı. Font düzenlemeleri yapıldı. Form2'ye kart görseli, kart tipi öğrenme fonksiyonu, kartın üzerinde isim, cvv ve skt yazması özellikleri eklendi.\n\n" +
                "21 Ocak 2024 - 1.4\nÖdeme formundaki kart görseli ve sağlayıcı logoları yeniden tasarlandı. Ödeme ekranı için logo eklendi. Ödeme sisteminin gözükmemesi hatası düzeltildi ve diğer ödeme sistemleri eklendi. Kart tanımsız ise siparişin oluşturulamaması sağlandı. Form2'ye yorum satırları eklendi. Form1'deki öğeler yeniden boyutlandırılıp yerleştirildi. Telefon numarasının başında 0 yok ise kabul edilmemesi sağlandı. Comboboxlara yazı yazılması önlendi. Kart onaylandıktan sonra textboxlar ve comboboxların kapanması sağlandı. Listboxun görünüşü güncelleştirildi. SMS kodu rastgele messagebox olarak yeniden düzenlendi. 3 kez yanlış sms kodu girilmesi durumunda siparişin iptal edilmesi sağlandı. Sufle seçeneği tatlı promosyon olarak değiştirilip yeni tatlılar eklendi. Soğan halkası seçeneği çıtır promosyon olarak değiştirilip eni promosyonlar eklendi. Form1'in başlığı değiştirildi.\n\n" +
                "22 Ocak 2024 - 1.4.1\nKart kaydetme seçeneği eklendi. Kart bilgileri onaylandıktan sonra kaydet checkboxunun çıkması ve kaydedilmiş ise tekrar sipariş verildiğinde bilgilerin doldurulmasının istenip istenmediğini soran messagebox eklendi. Doldurulması durumunda kart onaylandığında tekrar kaydet seçeneği çıkmaması ancak bilgiler değiştirilirse çıkması sağlandı. Ana forma menustrip eklendi. Hakkımızda, güncelleme notları ve iletişim bölümleri eklendi.İkonlar değiştirildi.\n\n" +
                "23 Ocak 2024 - 1.4.2\nKart kaydetme özelliğinin hataları giderildi. Menustripe seçenekler menüsü, altına çıkış yapma ve temizleme fonksiyonları eklendi. Yorum satırları düzenlendi.\n\n" +
                "27 Ocak 2024 - 1.4.3\nContextmenustrip özelliği ve altına temizleme fonksiyonu eklendi.\n\n" +
                "22 Nisan 2024 - 1.4.4\nKullanım koşulları ve gizlilik sözleşmesi eklendi. Hatalar giderildi.\n\n" +
                "Güncel Sürüm: 1.4.4", "Güncelleme Notları");
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iletisim iletisim = new iletisim();
            iletisim.ShowDialog();
        }
        private void seçimleriTemizleToolStripMenuItem_Click(object sender, EventArgs e)        //menustripteki temizle seçeneği
        {
            temizle();
        }
        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)                //menustripteki kapama seçeneği
        {
            this.Close();
        }

        private void seçimleriTemizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void kullanımKoşullarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanimkosullari kullanimkosullari = new kullanimkosullari();
            kullanimkosullari.ShowDialog();
        }

        private void indirimKodu_Click(object sender, EventArgs e)                  //İndirim kodu butonu
        {
            if (f == 0)      //İlk kez tıklanmışsa
            {
                txtIndirimKodu.Visible = true;
                btnIndirimKodu.Text = "Kaydet";
                f++;
            }
            else                    //İlk kez tıklanmıyorsa
            {
                if (txtIndirimKodu.Text == ("EMREDIKBAS15"))                  //emre indirim kodu
                {
                    MessageBox.Show(txtIndirimKodu.Text + "EMREDIKBAS15 koduna özel %15 indiriminiz tanımlanmıştır.", "Kod Başarılı");
                    btnIndirimKodu.Visible = false;
                    txtIndirimKodu.Visible=false;
                }

                else if (txtIndirimKodu.Text == ("BARIS15"))                  //barış indirim kodu
                {
                    MessageBox.Show(txtIndirimKodu.Text + " koduna özel %15 indiriminiz tanımlanmıştır.", "Kod Başarılı");
                    btnIndirimKodu.Visible = false;
                    txtIndirimKodu.Visible = false;
                }
                else { MessageBox.Show("Geçersiz kod girdiniz. Lütfen tekrar deneyiniz.", "Başarısız kod"); }                   //geçersiz kod girildiğinde
            }

            
        }
    }
}