//07.09.23 İlk projelerimden. Keyifliydi.
//13.09.23 Telefon textboxına sadece sayı girişi yapılması; telefon, adres ve isim soyisim textboxlarına karakter limiti ve tüm girişleri yapmadan kaydet butonunun gelmemesi gibi düzenlemeleri yaptım ve publish ediyorum.
//16.09.23 - 17.09.23 Projeyi muhtemelen tamamladım. Aynı comboboxta birden çok seçim yapıldığında kaydet butonunun gelmesini çözdüm. Uyarıları message box'a çevirdim. Telefon numarasının yalnızca 11 haneyle girilmesini, isim textboxuna sayı yazılamamasını sağladım.
//10.10.23 Uyarı mesajlarına başlık ekledim.
//18.11.23 3 yeni içecek ekledim. Kartla ödeme seçeneğini ve ikinci formu ekledim.
//22.11.23 2. formu tamamladım. Kart no textboxuna 16 haneli giriş yapılmadan, cvv textboxuna 3 haneli giriş yapılmadan, doğrulama kodu textboxuna 4 haneli giriş yapılmadan, kart skt seçilmeden ödememeyi ekledim. Kart no, cvv, doğrulama textboxlarına sadece sayı girişi yapılabilmesini sağladım. Yeni logoyu tasarlayıp ekledim. Formlar arası geçişi sağladım. 3 yeni 1 yeni sos içecek ekledim. Ödeme ekranına bilgi verici butonlar ekledim ve ödeme formunu yeniden tasarladım. Kodları düzenleyip yorum satırladı ekledim ve hataları düzelttim. Ana formu yeniden boyutlandırıp tasarladım ve 2 yeni combobox ekledim.

namespace C____Pizza_Sipariş_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int a = 1;   //temassız teslimat checkbox
        public int fiyat = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            fiyat = 0;
            listBox1.Items.Clear();
            listBox1.Items.Add("PİZZA");
            listBox1.Items.Add(comboBox6.Text);
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(comboBox2.Text);
            listBox1.Items.Add(comboBox3.Text);
            listBox1.Items.Add(comboBox4.Text);
            listBox1.Items.Add(comboBox5.Text);
            listBox1.Items.Add(" ");
            listBox1.Items.Add("PROMOSYONLAR");
            listBox1.Items.Add(comboBox10.Text);
            listBox1.Items.Add(comboBox9.Text);
            listBox1.Items.Add(comboBox12.Text);
            listBox1.Items.Add(comboBox8.Text);
            listBox1.Items.Add(" ");
            listBox1.Items.Add("İÇECEKLER");
            listBox1.Items.Add(comboBox7.Text);
            listBox1.Items.Add(comboBox11.Text);
            listBox1.Items.Add("\n");
            groupBox1.Visible = true;
            button2.Visible = true;

            if (comboBox6.SelectedIndex == 0) { fiyat += 15; }          //pizza boyutu
            else if (comboBox6.SelectedIndex == 1) { fiyat += 25; }
            else if (comboBox6.SelectedIndex == 2) { fiyat += 35; }
            if (comboBox1.SelectedIndex == 1) { fiyat += 5; }           //pizza hamuru
            if (comboBox2.SelectedIndex == 1) { fiyat += 8; }           //sucuk
            else if (comboBox2.SelectedIndex == 2) { fiyat += 15; }
            if (comboBox3.SelectedIndex == 1) { fiyat += 2; }           //mantar  
            else if (comboBox3.SelectedIndex == 2) { fiyat += 4; }
            if (comboBox4.SelectedIndex == 1) { fiyat += 7; }           //mozarella
            if (comboBox5.SelectedIndex == 1) { fiyat += 4; }           //zeytin
            else if (comboBox5.SelectedIndex == 2) { fiyat += 8; }
            if ((comboBox10.SelectedIndex == 1)) { fiyat += 10; }       //sufle
            if (comboBox9.SelectedIndex == 1) { fiyat += 10; }          //soğan halkası
            else if (comboBox9.SelectedIndex == 2) { fiyat += 17; }
            if (comboBox8.SelectedIndex == 3) { fiyat += 2; }           //ikinci sos
            else if (comboBox8.SelectedIndex == 4) { fiyat += 2; }
            else if (comboBox8.SelectedIndex == 5) { fiyat += 2; }
            else if (comboBox8.SelectedIndex == 6) { fiyat += 3; }
            else if (comboBox8.SelectedIndex == 7) { fiyat += 3; }
            if (comboBox7.SelectedIndex == 1) { fiyat += 5; }           //birinci içecek 
            else if (comboBox7.SelectedIndex == 2) { fiyat += 8; }
            else if (comboBox7.SelectedIndex == 3) { fiyat += 8; }
            else if (comboBox7.SelectedIndex == 4) { fiyat += 8; }
            else if (comboBox7.SelectedIndex == 5) { fiyat += 18; }
            else if (comboBox7.SelectedIndex == 6) { fiyat += 18; }
            else if (comboBox7.SelectedIndex == 7) { fiyat += 7; }
            else if (comboBox7.SelectedIndex == 8) { fiyat += 7; }
            else if (comboBox7.SelectedIndex == 9) { fiyat += 17; }
            else if (comboBox7.SelectedIndex == 10) { fiyat += 17; }
            else if (comboBox7.SelectedIndex == 11) { fiyat += 6; }
            else if (comboBox7.SelectedIndex == 12) { fiyat += 6; }
            else if (comboBox7.SelectedIndex == 13) { fiyat += 18; }
            else if (comboBox7.SelectedIndex == 14) { fiyat += 10; }
            if (comboBox11.SelectedIndex == 1) { fiyat += 5; }          //ikinci içecek 
            else if (comboBox11.SelectedIndex == 2) { fiyat += 8; }
            else if (comboBox11.SelectedIndex == 3) { fiyat += 8; }
            else if (comboBox11.SelectedIndex == 4) { fiyat += 8; }
            else if (comboBox11.SelectedIndex == 5) { fiyat += 18; }
            else if (comboBox11.SelectedIndex == 6) { fiyat += 18; }
            else if (comboBox11.SelectedIndex == 7) { fiyat += 7; }
            else if (comboBox11.SelectedIndex == 8) { fiyat += 7; }
            else if (comboBox11.SelectedIndex == 9) { fiyat += 17; }
            else if (comboBox11.SelectedIndex == 10) { fiyat += 17; }
            else if (comboBox11.SelectedIndex == 11) { fiyat += 6; }
            else if (comboBox11.SelectedIndex == 12) { fiyat += 6; }
            else if (comboBox11.SelectedIndex == 13) { fiyat += 18; }
            else if (comboBox11.SelectedIndex == 14) { fiyat += 10; }
            listBox1.Items.Add("TOPLAM= " + fiyat + " TL");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            a += 1;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            d += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) { MessageBox.Show("Lütfen isim soyisminizi giriniz.", "Uyarı"); }
            else if (textBox2.Text.Length == 0) { MessageBox.Show("Lütfen telefon numaranızı giriniz.", "Uyarı"); }
            else if (textBox2.Text.Length != 11) { MessageBox.Show("Lütfen 11 haneli telefon numaranızı boşluksuz ve başında '0' olacak şekilde giriniz.", "Uyarı"); }
            else if (textBox3.Text.Length == 0) { MessageBox.Show("Lütfen adresinizi giriniz.", "Uyarı"); }
            else
            {
                if (a % 2 == 0)
                {
                    if (d % 2 == 1)
                    {
                        MessageBox.Show("Siparişiniz onaylanmıştır. En kısa sürede Temasasız teslimat ile adresinize gönderilecektir. Teşekkür ederiz.", "Onaylandı");
                        listBox1.Items.Clear();
                        fiyat = 0;
                        a = 1;
                        b = 0;
                        d = 0;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
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
                        button2.Visible = false;
                        groupBox1.Visible = false;
                        textBox1.Text = string.Empty;
                        textBox2.Text = string.Empty;
                        textBox3.Text = string.Empty;
                        button1.Visible = false;
                    }
                    else
                    {
                        Form2 form = new Form2();
                        form.ShowDialog();
                    }

                }
                else if (a % 2 == 1)
                {
                    if (d % 2 == 1)
                    {
                        MessageBox.Show("Siparişiniz onaylanmıştır. En kısa sürede teslim edilecektir. Teşekkür ederiz.", "Onaylandı");
                        listBox1.Items.Clear();
                        fiyat = 0;
                        a = 1;
                        b = 0;
                        d = 0;
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
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
                        textBox1.Text = string.Empty;
                        textBox2.Text = string.Empty;
                        textBox3.Text = string.Empty;
                        button1.Visible = false;
                        button2.Visible = false;
                        groupBox1.Visible = false;
                    }
                    else
                    {
                        Form2 form = new Form2();
                        form.ShowDialog();
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)    //temizle
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
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            fiyat = 0;
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
            button1.Visible = false;
            button2.Visible = false;
            groupBox1.Visible = false;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)   //pizza hamuru
        {
            while (c2 == 1)
            {
                b += 1;
                c2 += 1;
            }
            if (b == 12) { button1.Visible = true; }
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
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (Form2.zzz == 1)
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
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                fiyat = 0;
                b = 0;
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
                d = 0;
                button1.Visible = false;
                button2.Visible = false;
                groupBox1.Visible = false;
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                Form2.zzz = 0;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Form2.zzz == 1)
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
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                fiyat = 0;
                b = 0;
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
                d = 0;
                button1.Visible = false;
                button2.Visible = false;
                groupBox1.Visible = false;
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                Form2.zzz = 0;
            }
        }
    }
}