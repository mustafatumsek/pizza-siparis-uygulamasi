namespace C____Pizza_Sipariş_Uygulaması
{
    partial class anaMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaMenu));
            lbListe = new ListBox();
            cmbHamur = new ComboBox();
            cmbSucuk = new ComboBox();
            cmbMantar = new ComboBox();
            cmbPeynir = new ComboBox();
            cmbZeytin = new ComboBox();
            btnKaydet = new Button();
            cmbBoyut = new ComboBox();
            cmbİcecek1 = new ComboBox();
            cmbSos2 = new ComboBox();
            cmbCıtır = new ComboBox();
            cmbTatlı = new ComboBox();
            lblAdSoyad = new Label();
            txtIsimSoyisim = new TextBox();
            txtTelefon = new TextBox();
            lblTelefon = new Label();
            txtAdres = new TextBox();
            lblBoyut = new Label();
            lblHamur = new Label();
            lblSucuk = new Label();
            lblMantar = new Label();
            lblPeynir = new Label();
            lblZeytin = new Label();
            lblTatli = new Label();
            lblCitir = new Label();
            lblSos2 = new Label();
            lblIcecek1 = new Label();
            picLogo = new PictureBox();
            cbTemassız = new CheckBox();
            gbTeslimat = new GroupBox();
            cbKapida = new CheckBox();
            lblAdres = new Label();
            btnSiparis = new Button();
            btnTemizle = new Button();
            lblIcecek2 = new Label();
            lblSos1 = new Label();
            cmbİcecek2 = new ComboBox();
            cmbSos1 = new ComboBox();
            menuStrip1 = new MenuStrip();
            hakkımızdaToolStripMenuItem = new ToolStripMenuItem();
            bizKimizToolStripMenuItem = new ToolStripMenuItem();
            güncellemeNotlarıToolStripMenuItem = new ToolStripMenuItem();
            iletişimToolStripMenuItem = new ToolStripMenuItem();
            kullanımKoşullarıToolStripMenuItem = new ToolStripMenuItem();
            ayarlarToolStripMenuItem = new ToolStripMenuItem();
            seçimleriTemizleToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            seçimleriTemizleToolStripMenuItem1 = new ToolStripMenuItem();
            btnIndirimKodu = new Button();
            txtIndirimKodu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            gbTeslimat.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbListe
            // 
            lbListe.FormattingEnabled = true;
            lbListe.ItemHeight = 20;
            lbListe.Location = new Point(440, 184);
            lbListe.Margin = new Padding(3, 4, 3, 4);
            lbListe.Name = "lbListe";
            lbListe.Size = new Size(249, 424);
            lbListe.TabIndex = 0;
            // 
            // cmbHamur
            // 
            cmbHamur.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHamur.FormattingEnabled = true;
            cmbHamur.Items.AddRange(new object[] { "İnce Hamur", "Kalın Hamur (+5 TL)" });
            cmbHamur.Location = new Point(25, 285);
            cmbHamur.Margin = new Padding(3, 4, 3, 4);
            cmbHamur.Name = "cmbHamur";
            cmbHamur.Size = new Size(171, 28);
            cmbHamur.TabIndex = 2;
            cmbHamur.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbSucuk
            // 
            cmbSucuk.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSucuk.FormattingEnabled = true;
            cmbSucuk.Items.AddRange(new object[] { "Sucuksuz", "Sucuklu (+8 TL)", "Bol Sucuklu (+15 TL)" });
            cmbSucuk.Location = new Point(25, 356);
            cmbSucuk.Margin = new Padding(3, 4, 3, 4);
            cmbSucuk.Name = "cmbSucuk";
            cmbSucuk.Size = new Size(171, 28);
            cmbSucuk.TabIndex = 3;
            cmbSucuk.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cmbMantar
            // 
            cmbMantar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMantar.FormattingEnabled = true;
            cmbMantar.Items.AddRange(new object[] { "Mantarsız", "Mantarlı (+2 TL)", "Bol Mantarlı (+4 TL)" });
            cmbMantar.Location = new Point(25, 427);
            cmbMantar.Margin = new Padding(3, 4, 3, 4);
            cmbMantar.Name = "cmbMantar";
            cmbMantar.Size = new Size(171, 28);
            cmbMantar.TabIndex = 4;
            cmbMantar.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // cmbPeynir
            // 
            cmbPeynir.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeynir.FormattingEnabled = true;
            cmbPeynir.Items.AddRange(new object[] { "Mozarella", "Emmental (+7 TL)", "Provolone (+7 TL)" });
            cmbPeynir.Location = new Point(25, 503);
            cmbPeynir.Margin = new Padding(3, 4, 3, 4);
            cmbPeynir.Name = "cmbPeynir";
            cmbPeynir.Size = new Size(171, 28);
            cmbPeynir.TabIndex = 5;
            cmbPeynir.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // cmbZeytin
            // 
            cmbZeytin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbZeytin.FormattingEnabled = true;
            cmbZeytin.Items.AddRange(new object[] { "Zeytinsiz", "Zeytinli (+4 TL)", "Bol Zeytinli (+8 TL)" });
            cmbZeytin.Location = new Point(25, 579);
            cmbZeytin.Margin = new Padding(3, 4, 3, 4);
            cmbZeytin.Name = "cmbZeytin";
            cmbZeytin.Size = new Size(171, 28);
            cmbZeytin.TabIndex = 6;
            cmbZeytin.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(25, 639);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(370, 61);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Visible = false;
            btnKaydet.Click += button1_Click;
            // 
            // cmbBoyut
            // 
            cmbBoyut.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoyut.FormattingEnabled = true;
            cmbBoyut.Items.AddRange(new object[] { "Küçük Boy (15 TL)", "Orta Boy (25 TL)", "Büyük Boy (35 TL)" });
            cmbBoyut.Location = new Point(25, 212);
            cmbBoyut.Margin = new Padding(3, 4, 3, 4);
            cmbBoyut.Name = "cmbBoyut";
            cmbBoyut.Size = new Size(171, 28);
            cmbBoyut.TabIndex = 1;
            cmbBoyut.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // cmbİcecek1
            // 
            cmbİcecek1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbİcecek1.FormattingEnabled = true;
            cmbİcecek1.Items.AddRange(new object[] { "İçecek İstemiyorum.", "Küçük Ayran (+5 TL)", "Büyük Ayran (+8 TL)", "330 mL Kola (+8 TL)", "330 mL Şekersiz Kola (+8 TL)", "1L Kola (+18 TL)", "1L Şekersiz Kola (+18 TL)", "330 mL Ice-Tea Şeftali (+7 TL)", "330 mL Ice-Tea Mango (+7 TL)", "1L Ice-Tea Şeftali (+17 TL)", "1L Ice-Tea Mango (+17 TL)", "400 mL Şalgam (+8 TL)", "400 mL Acı Şalgam (+8 TL)", "250 mL Zafer Gazoz Sade (+10 TL) ", "250 mL Zafer Gazoz Portakallı (+10 TL) ", "500 mL Su (+2 TL)" });
            cmbİcecek1.Location = new Point(224, 503);
            cmbİcecek1.Margin = new Padding(3, 4, 3, 4);
            cmbİcecek1.Name = "cmbİcecek1";
            cmbİcecek1.Size = new Size(171, 28);
            cmbİcecek1.TabIndex = 11;
            cmbİcecek1.SelectedIndexChanged += comboBox7_SelectedIndexChanged;
            // 
            // cmbSos2
            // 
            cmbSos2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSos2.FormattingEnabled = true;
            cmbSos2.Items.AddRange(new object[] { "Sos İstemiyorum.", "Ketçap (ÜCRETSİZ)", "Mayonez (ÜCRETSİZ)", "BBQ Sos (+2 TL)", "Hardal (+2 TL)", "Acı Sos (+2 TL)", "Sarımsaklı Mayonez (+3 TL)", "Ballı Hardallı Sos (+3 TL)", "Buffalo Sos (+3 TL)" });
            cmbSos2.Location = new Point(224, 427);
            cmbSos2.Margin = new Padding(3, 4, 3, 4);
            cmbSos2.Name = "cmbSos2";
            cmbSos2.Size = new Size(171, 28);
            cmbSos2.TabIndex = 10;
            cmbSos2.SelectedIndexChanged += comboBox8_SelectedIndexChanged;
            // 
            // cmbCıtır
            // 
            cmbCıtır.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCıtır.FormattingEnabled = true;
            cmbCıtır.Items.AddRange(new object[] { "Promosyon istemiyorum.", "5'li Soğan Halkası (+10 TL)", "10'lu Soğan Halkası (+17 TL)", "Küçük Boy Patates Kızartması (+8 TL)", "Orta Boy Patates Kızartması (+14 TL)", "Büyük Boy Patates Kızartması (+20 TL)", "Dev Patates Kova (+30 TL)", "4'lü Cheese Sticks (+8 TL)", "6'li Cheese Sticks (+10 TL)", "8'li Cheese Sticks (+13 TL)", "Küçük Boy Çıtır Patates (+8 TL)", "Orta Boy Çıtır Patates (+14 TL)", "Büyük Boy Çıtır Patates (+20 TL)" });
            cmbCıtır.Location = new Point(224, 283);
            cmbCıtır.Margin = new Padding(3, 4, 3, 4);
            cmbCıtır.Name = "cmbCıtır";
            cmbCıtır.Size = new Size(171, 28);
            cmbCıtır.TabIndex = 8;
            cmbCıtır.SelectedIndexChanged += comboBox9_SelectedIndexChanged;
            // 
            // cmbTatlı
            // 
            cmbTatlı.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTatlı.FormattingEnabled = true;
            cmbTatlı.Items.AddRange(new object[] { "Tatlı İstemiyorum", "Sufle (+10 TL)", "Sütlaç (+ 6 TL)", "Kakaolu Puding (+ 7 TL)", "Çilekli Puding (+ 7 TL)", "Muzlu Puding (+ 7 TL)", "Vanilyalı Puding (+ 7 TL)", "Kazandibi (+8 TL)", "Güllaç (+8 TL)", "Muhallebi (+8 TL)", "Supangle (+8 TL)" });
            cmbTatlı.Location = new Point(224, 212);
            cmbTatlı.Margin = new Padding(3, 4, 3, 4);
            cmbTatlı.Name = "cmbTatlı";
            cmbTatlı.Size = new Size(171, 28);
            cmbTatlı.TabIndex = 7;
            cmbTatlı.SelectedIndexChanged += comboBox10_SelectedIndexChanged;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdSoyad.Location = new Point(30, 35);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(126, 23);
            lblAdSoyad.TabIndex = 13;
            lblAdSoyad.Text = "İsim Soyisim:";
            // 
            // txtIsimSoyisim
            // 
            txtIsimSoyisim.Location = new Point(166, 32);
            txtIsimSoyisim.Margin = new Padding(3, 4, 3, 4);
            txtIsimSoyisim.MaxLength = 35;
            txtIsimSoyisim.Name = "txtIsimSoyisim";
            txtIsimSoyisim.Size = new Size(197, 27);
            txtIsimSoyisim.TabIndex = 14;
            txtIsimSoyisim.KeyPress += textBox1_KeyPress;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(166, 107);
            txtTelefon.Margin = new Padding(3, 4, 3, 4);
            txtTelefon.MaxLength = 11;
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(197, 27);
            txtTelefon.TabIndex = 16;
            txtTelefon.KeyPress += textBox2_KeyPress;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefon.Location = new Point(73, 107);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(79, 23);
            lblTelefon.TabIndex = 15;
            lblTelefon.Text = "Telefon:";
            lblTelefon.TextAlign = ContentAlignment.TopRight;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(166, 177);
            txtAdres.Margin = new Padding(3, 4, 3, 4);
            txtAdres.MaxLength = 200;
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(197, 137);
            txtAdres.TabIndex = 18;
            // 
            // lblBoyut
            // 
            lblBoyut.AutoSize = true;
            lblBoyut.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBoyut.Location = new Point(25, 183);
            lblBoyut.Name = "lblBoyut";
            lblBoyut.Size = new Size(122, 23);
            lblBoyut.TabIndex = 19;
            lblBoyut.Text = "Pizza Boyutu";
            // 
            // lblHamur
            // 
            lblHamur.AutoSize = true;
            lblHamur.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHamur.Location = new Point(25, 256);
            lblHamur.Name = "lblHamur";
            lblHamur.Size = new Size(129, 23);
            lblHamur.TabIndex = 20;
            lblHamur.Text = "Pizza Hamuru";
            // 
            // lblSucuk
            // 
            lblSucuk.AutoSize = true;
            lblSucuk.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSucuk.Location = new Point(25, 327);
            lblSucuk.Name = "lblSucuk";
            lblSucuk.Size = new Size(63, 23);
            lblSucuk.TabIndex = 21;
            lblSucuk.Text = "Sucuk";
            // 
            // lblMantar
            // 
            lblMantar.AutoSize = true;
            lblMantar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMantar.Location = new Point(25, 397);
            lblMantar.Name = "lblMantar";
            lblMantar.Size = new Size(72, 23);
            lblMantar.TabIndex = 22;
            lblMantar.Text = "Mantar";
            // 
            // lblPeynir
            // 
            lblPeynir.AutoSize = true;
            lblPeynir.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeynir.Location = new Point(25, 473);
            lblPeynir.Name = "lblPeynir";
            lblPeynir.Size = new Size(65, 23);
            lblPeynir.TabIndex = 23;
            lblPeynir.Text = "Peynir";
            // 
            // lblZeytin
            // 
            lblZeytin.AutoSize = true;
            lblZeytin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblZeytin.Location = new Point(25, 549);
            lblZeytin.Name = "lblZeytin";
            lblZeytin.Size = new Size(63, 23);
            lblZeytin.TabIndex = 24;
            lblZeytin.Text = "Zeytin";
            // 
            // lblTatli
            // 
            lblTatli.AutoSize = true;
            lblTatli.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTatli.Location = new Point(224, 183);
            lblTatli.Name = "lblTatli";
            lblTatli.Size = new Size(152, 23);
            lblTatli.TabIndex = 25;
            lblTatli.Text = "Tatlı Promosyon";
            // 
            // lblCitir
            // 
            lblCitir.AutoSize = true;
            lblCitir.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCitir.Location = new Point(224, 253);
            lblCitir.Name = "lblCitir";
            lblCitir.Size = new Size(154, 23);
            lblCitir.TabIndex = 26;
            lblCitir.Text = "Çıtır Promosyon";
            // 
            // lblSos2
            // 
            lblSos2.AutoSize = true;
            lblSos2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSos2.Location = new Point(224, 397);
            lblSos2.Name = "lblSos2";
            lblSos2.Size = new Size(94, 23);
            lblSos2.TabIndex = 27;
            lblSos2.Text = "İkinci Sos";
            // 
            // lblIcecek1
            // 
            lblIcecek1.AutoSize = true;
            lblIcecek1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIcecek1.Location = new Point(224, 473);
            lblIcecek1.Name = "lblIcecek1";
            lblIcecek1.Size = new Size(126, 23);
            lblIcecek1.TabIndex = 28;
            lblIcecek1.Text = "Birinci İçecek";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(440, 0);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(249, 223);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 29;
            picLogo.TabStop = false;
            // 
            // cbTemassız
            // 
            cbTemassız.AutoSize = true;
            cbTemassız.Cursor = Cursors.Hand;
            cbTemassız.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbTemassız.Location = new Point(174, 347);
            cbTemassız.Margin = new Padding(3, 4, 3, 4);
            cbTemassız.Name = "cbTemassız";
            cbTemassız.Size = new Size(191, 21);
            cbTemassız.TabIndex = 30;
            cbTemassız.Text = "Temassız teslimat istiyorum.";
            cbTemassız.UseVisualStyleBackColor = true;
            cbTemassız.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // gbTeslimat
            // 
            gbTeslimat.Controls.Add(cbKapida);
            gbTeslimat.Controls.Add(txtAdres);
            gbTeslimat.Controls.Add(cbTemassız);
            gbTeslimat.Controls.Add(lblAdSoyad);
            gbTeslimat.Controls.Add(txtIsimSoyisim);
            gbTeslimat.Controls.Add(lblTelefon);
            gbTeslimat.Controls.Add(txtTelefon);
            gbTeslimat.Controls.Add(lblAdres);
            gbTeslimat.Location = new Point(744, 183);
            gbTeslimat.Margin = new Padding(3, 4, 3, 4);
            gbTeslimat.Name = "gbTeslimat";
            gbTeslimat.Padding = new Padding(3, 4, 3, 4);
            gbTeslimat.Size = new Size(370, 427);
            gbTeslimat.TabIndex = 31;
            gbTeslimat.TabStop = false;
            gbTeslimat.Text = "Teslimat Bilgileri";
            gbTeslimat.Visible = false;
            // 
            // cbKapida
            // 
            cbKapida.AutoSize = true;
            cbKapida.Cursor = Cursors.Hand;
            cbKapida.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbKapida.Location = new Point(174, 384);
            cbKapida.Margin = new Padding(3, 4, 3, 4);
            cbKapida.Name = "cbKapida";
            cbKapida.Size = new Size(195, 21);
            cbKapida.TabIndex = 31;
            cbKapida.Text = "Ödemeyi kapıda yapacağım.";
            cbKapida.UseVisualStyleBackColor = true;
            cbKapida.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdres.Location = new Point(85, 183);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(68, 23);
            lblAdres.TabIndex = 17;
            lblAdres.Text = "Adres:";
            // 
            // btnSiparis
            // 
            btnSiparis.Location = new Point(744, 639);
            btnSiparis.Margin = new Padding(3, 4, 3, 4);
            btnSiparis.Name = "btnSiparis";
            btnSiparis.Size = new Size(370, 61);
            btnSiparis.TabIndex = 33;
            btnSiparis.Text = "Onayla";
            btnSiparis.UseVisualStyleBackColor = true;
            btnSiparis.Visible = false;
            btnSiparis.Click += button2_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(1029, 708);
            btnTemizle.Margin = new Padding(3, 4, 3, 4);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.RightToLeft = RightToLeft.No;
            btnTemizle.Size = new Size(86, 31);
            btnTemizle.TabIndex = 34;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += button3_Click;
            // 
            // lblIcecek2
            // 
            lblIcecek2.AutoSize = true;
            lblIcecek2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIcecek2.Location = new Point(225, 549);
            lblIcecek2.Name = "lblIcecek2";
            lblIcecek2.Size = new Size(118, 23);
            lblIcecek2.TabIndex = 38;
            lblIcecek2.Text = "İkinci İçecek";
            // 
            // lblSos1
            // 
            lblSos1.AutoSize = true;
            lblSos1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSos1.Location = new Point(224, 327);
            lblSos1.Name = "lblSos1";
            lblSos1.Size = new Size(102, 23);
            lblSos1.TabIndex = 37;
            lblSos1.Text = "Birinci Sos";
            // 
            // cmbİcecek2
            // 
            cmbİcecek2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbİcecek2.FormattingEnabled = true;
            cmbİcecek2.Items.AddRange(new object[] { "İçecek İstemiyorum.", "Küçük Ayran (+5 TL)", "Büyük Ayran (+8 TL)", "330 mL Kola (+8 TL)", "330 mL Şekersiz Kola (+8 TL)", "1L Kola (+18 TL)", "1L Şekersiz Kola (+18 TL)", "330 mL Ice-Tea Şeftali (+7 TL)", "330 mL Ice-Tea Mango (+7 TL)", "1L Ice-Tea Şeftali (+17 TL)", "1L Ice-Tea Mango (+17 TL)", "400 mL Şalgam (+8 TL)", "400 mL Acı Şalgam (+8 TL)", "250 mL Zafer Gazoz Sade (+10 TL) ", "250 mL Zafer Gazoz Portakallı (+10 TL) ", "500 mL Su (+2 TL)" });
            cmbİcecek2.Location = new Point(225, 579);
            cmbİcecek2.Margin = new Padding(3, 4, 3, 4);
            cmbİcecek2.Name = "cmbİcecek2";
            cmbİcecek2.Size = new Size(171, 28);
            cmbİcecek2.TabIndex = 12;
            cmbİcecek2.SelectedIndexChanged += comboBox11_SelectedIndexChanged;
            // 
            // cmbSos1
            // 
            cmbSos1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSos1.FormattingEnabled = true;
            cmbSos1.Items.AddRange(new object[] { "Sos İstemiyorum.", "Ketçap (ÜCRETSİZ)", "Mayonez (ÜCRETSİZ)", "BBQ Sos (ÜCRETSİZ)", "Hardal (ÜCRETSİZ)", "Acı Sos (ÜCRETSİZ)", "Sarımsaklı Mayonez (ÜCRETSİZ))", "Ballı Hardallı Sos (ÜCRETSİZ)", "Buffalo Sos (ÜCRETSİZ)" });
            cmbSos1.Location = new Point(224, 356);
            cmbSos1.Margin = new Padding(3, 4, 3, 4);
            cmbSos1.Name = "cmbSos1";
            cmbSos1.Size = new Size(171, 28);
            cmbSos1.TabIndex = 9;
            cmbSos1.SelectedIndexChanged += comboBox12_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImage = Properties.Resources.turuncu;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hakkımızdaToolStripMenuItem, ayarlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1128, 30);
            menuStrip1.TabIndex = 39;
            menuStrip1.Text = "menuStrip1";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            hakkımızdaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bizKimizToolStripMenuItem, güncellemeNotlarıToolStripMenuItem, iletişimToolStripMenuItem, kullanımKoşullarıToolStripMenuItem });
            hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            hakkımızdaToolStripMenuItem.Size = new Size(101, 24);
            hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // bizKimizToolStripMenuItem
            // 
            bizKimizToolStripMenuItem.Name = "bizKimizToolStripMenuItem";
            bizKimizToolStripMenuItem.Size = new Size(220, 26);
            bizKimizToolStripMenuItem.Text = "Biz Kimiz?";
            bizKimizToolStripMenuItem.Click += bizKimizToolStripMenuItem_Click;
            // 
            // güncellemeNotlarıToolStripMenuItem
            // 
            güncellemeNotlarıToolStripMenuItem.Name = "güncellemeNotlarıToolStripMenuItem";
            güncellemeNotlarıToolStripMenuItem.Size = new Size(220, 26);
            güncellemeNotlarıToolStripMenuItem.Text = "Güncelleme Notları";
            güncellemeNotlarıToolStripMenuItem.Click += güncellemeNotlarıToolStripMenuItem_Click;
            // 
            // iletişimToolStripMenuItem
            // 
            iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            iletişimToolStripMenuItem.Size = new Size(220, 26);
            iletişimToolStripMenuItem.Text = "İletişim";
            iletişimToolStripMenuItem.Click += iletişimToolStripMenuItem_Click;
            // 
            // kullanımKoşullarıToolStripMenuItem
            // 
            kullanımKoşullarıToolStripMenuItem.Name = "kullanımKoşullarıToolStripMenuItem";
            kullanımKoşullarıToolStripMenuItem.Size = new Size(220, 26);
            kullanımKoşullarıToolStripMenuItem.Text = "Kullanım Koşulları";
            kullanımKoşullarıToolStripMenuItem.Click += kullanımKoşullarıToolStripMenuItem_Click;
            // 
            // ayarlarToolStripMenuItem
            // 
            ayarlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { seçimleriTemizleToolStripMenuItem, çıkışYapToolStripMenuItem });
            ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            ayarlarToolStripMenuItem.Size = new Size(70, 24);
            ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // seçimleriTemizleToolStripMenuItem
            // 
            seçimleriTemizleToolStripMenuItem.Name = "seçimleriTemizleToolStripMenuItem";
            seçimleriTemizleToolStripMenuItem.Size = new Size(208, 26);
            seçimleriTemizleToolStripMenuItem.Text = "Seçimleri Temizle";
            seçimleriTemizleToolStripMenuItem.Click += seçimleriTemizleToolStripMenuItem_Click;
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(208, 26);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { seçimleriTemizleToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(195, 28);
            // 
            // seçimleriTemizleToolStripMenuItem1
            // 
            seçimleriTemizleToolStripMenuItem1.Name = "seçimleriTemizleToolStripMenuItem1";
            seçimleriTemizleToolStripMenuItem1.Size = new Size(194, 24);
            seçimleriTemizleToolStripMenuItem1.Text = "Seçimleri Temizle";
            seçimleriTemizleToolStripMenuItem1.Click += seçimleriTemizleToolStripMenuItem1_Click;
            // 
            // btnIndirimKodu
            // 
            btnIndirimKodu.Location = new Point(230, 709);
            btnIndirimKodu.Name = "btnIndirimKodu";
            btnIndirimKodu.Size = new Size(165, 29);
            btnIndirimKodu.TabIndex = 40;
            btnIndirimKodu.Text = "İndirim Kodum Var";
            btnIndirimKodu.UseVisualStyleBackColor = true;
            btnIndirimKodu.Click += indirimKodu_Click;
            // 
            // txtIndirimKodu
            // 
            txtIndirimKodu.Location = new Point(29, 711);
            txtIndirimKodu.Name = "txtIndirimKodu";
            txtIndirimKodu.Size = new Size(195, 27);
            txtIndirimKodu.TabIndex = 41;
            txtIndirimKodu.Visible = false;
            // 
            // anaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(1128, 760);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(txtIndirimKodu);
            Controls.Add(btnIndirimKodu);
            Controls.Add(lblIcecek2);
            Controls.Add(lblSos1);
            Controls.Add(cmbİcecek2);
            Controls.Add(cmbSos1);
            Controls.Add(lbListe);
            Controls.Add(btnTemizle);
            Controls.Add(btnSiparis);
            Controls.Add(gbTeslimat);
            Controls.Add(picLogo);
            Controls.Add(lblIcecek1);
            Controls.Add(lblSos2);
            Controls.Add(lblCitir);
            Controls.Add(lblTatli);
            Controls.Add(lblZeytin);
            Controls.Add(lblPeynir);
            Controls.Add(lblMantar);
            Controls.Add(lblSucuk);
            Controls.Add(lblHamur);
            Controls.Add(lblBoyut);
            Controls.Add(cmbBoyut);
            Controls.Add(cmbİcecek1);
            Controls.Add(cmbSos2);
            Controls.Add(cmbCıtır);
            Controls.Add(cmbTatlı);
            Controls.Add(btnKaydet);
            Controls.Add(cmbZeytin);
            Controls.Add(cmbPeynir);
            Controls.Add(cmbMantar);
            Controls.Add(cmbSucuk);
            Controls.Add(cmbHamur);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "anaMenu";
            Text = "Bavyera Pizza Sipariş Uygulaması";
            Click += Form1_Click;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            gbTeslimat.ResumeLayout(false);
            gbTeslimat.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbListe;
        private ComboBox cmbHamur;
        private ComboBox cmbSucuk;
        private ComboBox cmbMantar;
        private ComboBox cmbPeynir;
        private ComboBox cmbZeytin;
        private Button btnKaydet;
        private ComboBox cmbBoyut;
        private ComboBox cmbİcecek1;
        private ComboBox cmbSos2;
        private ComboBox cmbCıtır;
        private ComboBox cmbTatlı;
        private Label lblAdSoyad;
        private TextBox txtIsimSoyisim;
        private TextBox txtTelefon;
        private Label lblTelefon;
        private TextBox txtAdres;
        private Label lblBoyut;
        private Label lblHamur;
        private Label lblSucuk;
        private Label lblMantar;
        private Label lblPeynir;
        private Label lblZeytin;
        private Label lblTatli;
        private Label lblCitir;
        private Label lblSos2;
        private Label lblIcecek1;
        private PictureBox picLogo;
        private CheckBox cbTemassız;
        private GroupBox gbTeslimat;
        private Button btnSiparis;
        private Button btnTemizle;
        private Label lblAdres;
        private CheckBox cbKapida;
        private Label lblIcecek2;
        private Label lblSos1;
        private ComboBox cmbİcecek2;
        private ComboBox cmbSos1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private ToolStripMenuItem bizKimizToolStripMenuItem;
        private ToolStripMenuItem güncellemeNotlarıToolStripMenuItem;
        private ToolStripMenuItem iletişimToolStripMenuItem;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem seçimleriTemizleToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem seçimleriTemizleToolStripMenuItem1;
        private ToolStripMenuItem kullanımKoşullarıToolStripMenuItem;
        private Button btnIndirimKodu;
        private TextBox txtIndirimKodu;
    }
}