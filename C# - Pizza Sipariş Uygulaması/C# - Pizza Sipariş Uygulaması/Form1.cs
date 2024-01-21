//07.09.23 İlk projelerimden. Keyifliydi.
//13.09.23 Telefon textboxına sadece sayı girişi yapılması; telefon, adres ve isim soyisim textboxlarına karakter limiti ve tüm girişleri yapmadan kaydet butonunun gelmemesi gibi düzenlemeleri yaptım ve publish ediyorum.
//16.09.23 - 17.09.23 Projeyi muhtemelen tamamladım. Aynı comboboxta birden çok seçim yapıldığında kaydet butonunun gelmesini çözdüm. Uyarıları message box'a çevirdim. Telefon numarasının yalnızca 11 haneyle girilmesini, isim textboxuna sayı yazılamamasını sağladım.
//10.10.23 Uyarı mesajlarına başlık ekledim.
//18.11.23 3 yeni içecek ekledim. Kartla ödeme seçeneğini ve ikinci formu ekledim.
//22.11.23 2. formu tamamladım. Kart no textboxuna 16 haneli giriş yapılmadan, cvv textboxuna 3 haneli giriş yapılmadan, doğrulama kodu textboxuna 4 haneli giriş yapılmadan, kart skt seçilmeden ödememeyi ekledim. Kart no, cvv, doğrulama textboxlarına sadece sayı girişi yapılabilmesini sağladım. Yeni logoyu tasarlayıp ekledim. Formlar arası geçişi sağladım. 3 yeni 1 yeni sos içecek ekledim. Ödeme ekranına bilgi verici butonlar ekledim ve ödeme formunu yeniden tasarladım. Kodları düzenleyip yorum satırladı ekledim ve hataları düzelttim. Ana formu yeniden boyutlandırıp tasarladım ve 2 yeni combobox ekledim.
//19.01.24 temassız kapıda ödeme, kapıda ödeme ve temizleme butonu ile yapılan temizlikleri fonksiyona bağladım.Yorum satırlarını düzenledim. comboboxlardaki küçük hataları giderdim. Küçük fiyat değişiklikleri yaptım. Font düzenlemeleri yaptım. form2'ye kredi kartı görseli, kart tipi öğrenme fonksiyonu, kartın üstüne isim, kart no, skt, cvv yazdırdım.
//21.01.24 Ödeme formundaki kart görselini ve sağlayıcı logolarını yeniden tasarladım. Ödeme ekranı için logo tasarladım. Ödeme sistemini göstermemesi hatasını düzelttim ve diğer ödeme sistemlerini ekledim. Kart tanımsız ise siparişin oluşturulamamasını sağladım. Form2ye yorum satırları ekledim. Form1deki öğeleri yeniden boyutlandırıp yerleştirdim. Telefon numarasının başında 0 yok ise kabul edilmesini önledim ve hata mesajını güncelledim. Comboboxlara yazı yazılmasını önledim. Form2de kayededildikten sonra textboxları ve comboboxları disabled ettim. Listboxdaki görünümü güncelleştirdim. CVV kodunu rastgele bildirim olarak yeniden düzenledim. 3 kez yanlış sms kodu girilmesi durumunda siparişin iptal olması durumunu ekledim.Sufle seçeneğini tatlı promosyon ile değiştirip yeni tatlılar ekledim. Soğan halkası seçeneğini çıtır promosyon olarak değiştirip yeni promosyonlar ekledim. Form1'in başlığını değiştirdim.

namespace C____Pizza_Sipariş_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string isim;
        public static int a = 1;   //temassız teslimat checkbox
        public int fiyat = 0;      //fiyat 
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

        public void temizle()  //temizle butonu ile, 3 kez yanlış sms kodu girildikten sonra ve sipariş oluşturulduktan sonra yapılan temizlik.
        {
            listBox1.Items.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            comboBox10.SelectedIndex = -1;
            comboBox11.SelectedIndex = -1;
            comboBox12.SelectedIndex = -1;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            button1.Visible = false;
            button2.Visible = false;
            groupBox1.Visible = false;
            fiyat = 0;
            a = 1;
            b = 0;
            d = 0;
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
            listBox1.Items.Add("º " + comboBox6.Text);
            listBox1.Items.Add("º " + comboBox1.Text);
            listBox1.Items.Add("º " + comboBox2.Text);
            listBox1.Items.Add("º " + comboBox3.Text);
            listBox1.Items.Add("º " + comboBox4.Text);
            listBox1.Items.Add("º " + comboBox5.Text);
            listBox1.Items.Add(" ");
            listBox1.Items.Add("-----------PROMOSYONLAR------------");
            listBox1.Items.Add("º " + comboBox10.Text);
            listBox1.Items.Add("º " + comboBox9.Text);
            listBox1.Items.Add("º " + comboBox12.Text);
            listBox1.Items.Add("º " + comboBox8.Text);
            listBox1.Items.Add(" ");
            listBox1.Items.Add("--------------İÇECEKLER-----------------");
            listBox1.Items.Add("º " + comboBox7.Text);
            listBox1.Items.Add("º " + comboBox11.Text);
            listBox1.Items.Add("\n");
            groupBox1.Visible = true;
            button2.Visible = true;

            if (comboBox6.SelectedIndex == 0) { fiyat += 15; }          //pizza boyutu          //küçük
            else if (comboBox6.SelectedIndex == 1) { fiyat += 25; }                             //orta
            else if (comboBox6.SelectedIndex == 2) { fiyat += 35; }                             //büyük
            if (comboBox1.SelectedIndex == 1) { fiyat += 5; }           //pizza hamuru          //kalın
            if (comboBox2.SelectedIndex == 1) { fiyat += 8; }           //sucuk                 //sucuklu
            else if (comboBox2.SelectedIndex == 2) { fiyat += 15; }                             //bol sucuklu
            if (comboBox3.SelectedIndex == 1) { fiyat += 2; }           //mantar                //mantarlı
            else if (comboBox3.SelectedIndex == 2) { fiyat += 4; }                              //bol mantarlı
            if (comboBox4.SelectedIndex == 1) { fiyat += 7; }           //mozarella             //mozarellalı
            if (comboBox5.SelectedIndex == 1) { fiyat += 4; }           //zeytin                //zeytinli
            else if (comboBox5.SelectedIndex == 2) { fiyat += 8; }                              //bol zeytinli
            if ((comboBox10.SelectedIndex == 1)) { fiyat += 10; }       //tatlı promosyon       //sufle
            else if ((comboBox10.SelectedIndex ==2)) { fiyat += 6; }                            //sütlaç
            else if ((comboBox10.SelectedIndex == 3)) { fiyat += 7; }                           //kakaolu puding
            else if ((comboBox10.SelectedIndex == 4)) { fiyat += 7; }                           //çilekli puding
            else if ((comboBox10.SelectedIndex == 5)) { fiyat += 7; }                           //muzlu puding
            else if ((comboBox10.SelectedIndex == 5)) { fiyat += 7; }                           //muzlu puding
            else if ((comboBox10.SelectedIndex == 6)) { fiyat += 7; }                           //vanilyalı puding
            else if ((comboBox10.SelectedIndex == 7)) { fiyat += 8; }                           //kazandibi
            if (comboBox9.SelectedIndex == 1) { fiyat += 10; }          //çıtır promosyon       //5'li soğan halkası
            else if (comboBox9.SelectedIndex == 2) { fiyat += 17; }                             //10'lu soğan halkası
            else if (comboBox9.SelectedIndex == 3) { fiyat += 8; }                              //küçük boy patates kızartması
            else if (comboBox9.SelectedIndex == 4) { fiyat += 14; }                             //orta boy patates kızartması
            else if (comboBox9.SelectedIndex == 5) { fiyat += 20; }                             //büyük boy patates kızartması
            else if (comboBox9.SelectedIndex == 6) { fiyat += 30; }                             //dev patates kova
            if (comboBox8.SelectedIndex == 3) { fiyat += 2; }           //ikinci sos            //barbekü sos
            else if (comboBox8.SelectedIndex == 4) { fiyat += 2; }                              //hardal
            else if (comboBox8.SelectedIndex == 5) { fiyat += 2; }                              //acı sos
            else if (comboBox8.SelectedIndex == 6) { fiyat += 3; }                              //sarımsaklı mayonez
            else if (comboBox8.SelectedIndex == 7) { fiyat += 3; }                              //ballı hardallı sos
            else if (comboBox8.SelectedIndex == 8) { fiyat += 3; }                              //buffalo sos
            if (comboBox7.SelectedIndex == 1) { fiyat += 5; }           //birinci içecek        //küçük ayran    
            else if (comboBox7.SelectedIndex == 2) { fiyat += 8; }                              //büyük ayran
            else if (comboBox7.SelectedIndex == 3) { fiyat += 8; }                              //330 mL kola
            else if (comboBox7.SelectedIndex == 4) { fiyat += 8; }                              //330 mL  şekersiz kola
            else if (comboBox7.SelectedIndex == 5) { fiyat += 18; }                             //1 L kola
            else if (comboBox7.SelectedIndex == 6) { fiyat += 18; }                             //1 L şekersiz kola    
            else if (comboBox7.SelectedIndex == 7) { fiyat += 7; }                              //330 mL ice tea şeftali
            else if (comboBox7.SelectedIndex == 8) { fiyat += 7; }                              //330 mL ice tea mango
            else if (comboBox7.SelectedIndex == 9) { fiyat += 17; }                             //1 L ice tea şeftali
            else if (comboBox7.SelectedIndex == 10) { fiyat += 17; }                            //1 L ice tea mango
            else if (comboBox7.SelectedIndex == 11) { fiyat += 8; }                             //400 mL şalgam
            else if (comboBox7.SelectedIndex == 12) { fiyat += 8; }                             //400 mL acı şalgam
            else if (comboBox7.SelectedIndex == 13) { fiyat += 10; }                            //250 mL zafer gazoz
            if (comboBox11.SelectedIndex == 1) { fiyat += 5; }          //ikinci içecek         //küçük ayran 
            else if (comboBox11.SelectedIndex == 2) { fiyat += 8; }                             //büyük ayran
            else if (comboBox11.SelectedIndex == 3) { fiyat += 8; }                             //330 mL kola
            else if (comboBox11.SelectedIndex == 4) { fiyat += 8; }                             //330 mL  şekersiz kola
            else if (comboBox11.SelectedIndex == 5) { fiyat += 18; }                            //1 L kola
            else if (comboBox11.SelectedIndex == 6) { fiyat += 18; }                            //1 L şekersiz kola
            else if (comboBox11.SelectedIndex == 7) { fiyat += 7; }                             //330 mL ice tea şeftali
            else if (comboBox11.SelectedIndex == 8) { fiyat += 7; }                             //330 mL ice tea mango
            else if (comboBox11.SelectedIndex == 9) { fiyat += 17; }                            //1 L ice tea şeftali
            else if (comboBox11.SelectedIndex == 10) { fiyat += 17; }                           //1 L ice tea mango
            else if (comboBox11.SelectedIndex == 11) { fiyat += 8; }                            //400 mL şalgam
            else if (comboBox11.SelectedIndex == 12) { fiyat += 8; }                            //400 mL acı şalgam                        
            else if (comboBox11.SelectedIndex == 13) { fiyat += 10; }                           //250 mL zafer gazoz
            listBox1.Items.Add("TOPLAM= " + fiyat + " TL");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)       //temassız teslimat işaretlendiğinde
        { a += 1; }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)       //kapıda ödeme işaretlendiğinde
        { d += 1; }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) { MessageBox.Show("Lütfen isim soyisminizi giriniz.", "Uyarı"); }                                                                //isim textboxu boş ise
            else if (textBox2.Text.Length == 0) { MessageBox.Show("Lütfen telefon numaranızı giriniz.", "Uyarı"); }                                                         //telefon textboxu boş ise
            else if (textBox2.Text.Length != 11 || Convert.ToInt64(textBox2.Text) >= 10000000000) { MessageBox.Show("Lütfen 11 haneli telefon numaranızı eksiksiz ve başında '0' olacak şekilde giriniz.", "Uyarı"); }      //telefon textboxu yeterli hanede değil ise ve başında 0 yok ise
            else if (Convert.ToInt64(textBox2.Text) < 5000000000 || Convert.ToInt64(textBox2.Text) >= 6000000000) { MessageBox.Show("Lütfen 11 haneli telefon numaranızı eksiksiz ve başında '0' olacak şekilde giriniz.", "Uyarı"); }
            else if (textBox3.Text.Length == 0) { MessageBox.Show("Lütfen adresinizi giriniz.", "Uyarı"); }                                                                 //adres textboxu boş ise
            else
            {
                isim = textBox1.Text;
                if (a % 2 == 0)  //temassız teslimat işaretlenmişse
                {
                    if (d % 2 == 1)  //kapıda ödeme işaretlenmişse
                    {
                        MessageBox.Show("Siparişiniz onaylanmıştır. En kısa sürede Temasasız teslimat ile adresinize gönderilecektir. Teşekkür ederiz.", "Onaylandı");
                        temizle();
                    }
                    else  //kapıda ödeme işaretlenmemişse
                    {
                        Form2 form = new Form2();
                        form.ShowDialog();
                    }
                }
                else if (a % 2 == 1)  //temasssız teslimat işaretlenmemişse
                {
                    if (d % 2 == 1)  //kapıda ödeme işaretlenmişse
                    {
                        MessageBox.Show("Siparişiniz onaylanmıştır. En kısa sürede teslim edilecektir. Teşekkür ederiz.", "Onaylandı");
                        temizle();
                    }
                    else  //kapıda ödeme işaretlenmemişse
                    {
                        Form2 form = new Form2();
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
            if (b == 12) { button1.Visible = true; }    //tüm comboboxlarda seçim yapılmışsa kaydet butonu gözüksün
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)   //sucuk
        {
            while (c3 == 1)
            {
                b += 1;
                c3 += 1;
            }
            if (b == 12) { button1.Visible = true; }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)   //mantar
        {
            while (c4 == 1)
            {
                b += 1;
                c4 += 1;
            }
            if (b == 12) { button1.Visible = true; }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)   //mozarella
        {
            while (c5 == 1)
            {
                b += 1;
                c5 += 1;
            }
            if (b == 12) { button1.Visible = true; }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)   //zeytin
        {
            while (c6 == 1)
            {
                b += 1;
                c6 += 1;
            }
            if (b == 12) { button1.Visible = true; }
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)   //pizza boyutu
        {
            while (c1 == 1)
            {
                b += 1;
                c1 = 7;
            }
            if (b == 12) { button1.Visible = true; }
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)   //birinci içecek
        {
            while (c10 == 1)
            {
                b += 1;
                c10 += 1;
            }
            if (b == 12) { button1.Visible = true; }
        }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)   //ikinci sos
        {
            while (c9 == 1)
            {
                b += 1;
                c9 += 1;
            }
            if (b == 12) { button1.Visible = true; }
        }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)   //soğan halkası
        {
            while (c8 == 1)
            {
                b += 1;
                c8 += 1;
            }
            if (b == 12) { button1.Visible = true; }
        }
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)   //sufle
        {
            while (c7 == 1)
            {
                b += 1;
                c7 += 1;
            }
            if (b == 12) { button1.Visible = true; }
        }
        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)   //ikinci içecek
        {
            while (c11 == 1)
            {
                b += 1;
                c11 += 1;
            }
            if (b == 12) { button1.Visible = true; }
        }
        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)   //birinci sos
        {
            while (c12 == 1)
            {
                b += 1;
                c12 += 1;
            }
            if (b == 12) { button1.Visible = true; }
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
            if (Form2.zzz == 1)     //form1'e tıklandığında eğer form2de sipariş oluşturulduysa
            {
                temizle();
                Form2.zzz = 0;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Form2.zzz == 1)     //form1'de mouse hareket ettiğinde eğer form2de sipariş oluşturulduysa
            {
                temizle();
                Form2.zzz = 0;
            }
        }
    }
}