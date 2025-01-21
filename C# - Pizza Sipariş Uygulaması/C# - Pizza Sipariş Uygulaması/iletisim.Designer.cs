namespace C____Pizza_Sipariş_Uygulaması
{
    partial class iletisim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iletisim));
            picKonum = new PictureBox();
            lblAdresBaslik = new Label();
            lblAdres = new Label();
            lblTelefon = new Label();
            lblTelefonBaslik = new Label();
            lblWebBaslik = new Label();
            lblIletisim = new Label();
            lblAdiniz = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            lblSoyadiniz = new Label();
            txtEposta = new TextBox();
            lblEposta = new Label();
            lblMesajiniz = new Label();
            txtMesaj = new TextBox();
            btnGonder = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            lblWeb = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picKonum).BeginInit();
            SuspendLayout();
            // 
            // picKonum
            // 
            picKonum.Image = (Image)resources.GetObject("picKonum.Image");
            picKonum.Location = new Point(14, 16);
            picKonum.Margin = new Padding(3, 4, 3, 4);
            picKonum.Name = "picKonum";
            picKonum.Size = new Size(502, 355);
            picKonum.SizeMode = PictureBoxSizeMode.StretchImage;
            picKonum.TabIndex = 0;
            picKonum.TabStop = false;
            picKonum.Click += picKonum_Click;
            // 
            // lblAdresBaslik
            // 
            lblAdresBaslik.AutoSize = true;
            lblAdresBaslik.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdresBaslik.Location = new Point(535, 16);
            lblAdresBaslik.Name = "lblAdresBaslik";
            lblAdresBaslik.Size = new Size(85, 31);
            lblAdresBaslik.TabIndex = 1;
            lblAdresBaslik.Text = "Adres";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdres.Location = new Point(535, 68);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(380, 18);
            lblAdres.TabIndex = 2;
            lblAdres.Text = "Hoşnudiye, Nayman Sk. No:4, 26130 Tepebaşı/Eskişehir";
            lblAdres.Click += lblAdres_Click;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefon.Location = new Point(535, 205);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(118, 18);
            lblTelefon.TabIndex = 4;
            lblTelefon.Text = "0(222) 500 23 26";
            lblTelefon.Click += lblTelefon_Click;
            // 
            // lblTelefonBaslik
            // 
            lblTelefonBaslik.AutoSize = true;
            lblTelefonBaslik.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefonBaslik.Location = new Point(535, 153);
            lblTelefonBaslik.Name = "lblTelefonBaslik";
            lblTelefonBaslik.Size = new Size(105, 31);
            lblTelefonBaslik.TabIndex = 3;
            lblTelefonBaslik.Text = "Telefon";
            // 
            // lblWebBaslik
            // 
            lblWebBaslik.AutoSize = true;
            lblWebBaslik.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblWebBaslik.Location = new Point(535, 291);
            lblWebBaslik.Name = "lblWebBaslik";
            lblWebBaslik.Size = new Size(69, 31);
            lblWebBaslik.TabIndex = 7;
            lblWebBaslik.Text = "Web";
            // 
            // lblIletisim
            // 
            lblIletisim.AutoSize = true;
            lblIletisim.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblIletisim.Location = new Point(14, 389);
            lblIletisim.Name = "lblIletisim";
            lblIletisim.Size = new Size(150, 31);
            lblIletisim.TabIndex = 9;
            lblIletisim.Text = "Bize Ulaşın";
            // 
            // lblAdiniz
            // 
            lblAdiniz.AutoSize = true;
            lblAdiniz.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdiniz.Location = new Point(14, 456);
            lblAdiniz.Name = "lblAdiniz";
            lblAdiniz.Size = new Size(67, 24);
            lblAdiniz.TabIndex = 10;
            lblAdiniz.Text = "Adınız:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(121, 453);
            txtAd.Margin = new Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(154, 27);
            txtAd.TabIndex = 11;
            txtAd.KeyPress += txtAd_KeyPress;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(121, 500);
            txtSoyad.Margin = new Padding(3, 4, 3, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(154, 27);
            txtSoyad.TabIndex = 13;
            txtSoyad.KeyPress += txtSoyad_KeyPress;
            // 
            // lblSoyadiniz
            // 
            lblSoyadiniz.AutoSize = true;
            lblSoyadiniz.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoyadiniz.Location = new Point(14, 503);
            lblSoyadiniz.Name = "lblSoyadiniz";
            lblSoyadiniz.Size = new Size(96, 24);
            lblSoyadiniz.TabIndex = 12;
            lblSoyadiniz.Text = "Soyadınız:";
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(121, 552);
            txtEposta.Margin = new Padding(3, 4, 3, 4);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(154, 27);
            txtEposta.TabIndex = 17;
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEposta.Location = new Point(14, 555);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(79, 24);
            lblEposta.TabIndex = 16;
            lblEposta.Text = "E-posta:";
            // 
            // lblMesajiniz
            // 
            lblMesajiniz.AutoSize = true;
            lblMesajiniz.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMesajiniz.Location = new Point(304, 456);
            lblMesajiniz.Name = "lblMesajiniz";
            lblMesajiniz.Size = new Size(93, 24);
            lblMesajiniz.TabIndex = 18;
            lblMesajiniz.Text = "Mesajınız:";
            // 
            // txtMesaj
            // 
            txtMesaj.Location = new Point(405, 451);
            txtMesaj.Margin = new Padding(3, 4, 3, 4);
            txtMesaj.Multiline = true;
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(495, 79);
            txtMesaj.TabIndex = 19;
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(787, 551);
            btnGonder.Margin = new Padding(3, 4, 3, 4);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(113, 31);
            btnGonder.TabIndex = 20;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(101, 463);
            label12.Name = "label12";
            label12.Size = new Size(15, 20);
            label12.TabIndex = 21;
            label12.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(101, 563);
            label13.Name = "label13";
            label13.Size = new Size(15, 20);
            label13.TabIndex = 22;
            label13.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(384, 511);
            label14.Name = "label14";
            label14.Size = new Size(15, 20);
            label14.TabIndex = 23;
            label14.Text = "*";
            // 
            // lblWeb
            // 
            lblWeb.AutoSize = true;
            lblWeb.Location = new Point(535, 344);
            lblWeb.Name = "lblWeb";
            lblWeb.Size = new Size(164, 20);
            lblWeb.TabIndex = 24;
            lblWeb.TabStop = true;
            lblWeb.Text = "www.bavyerapizza.com";
            lblWeb.LinkClicked += lblWeb_LinkClicked;
            // 
            // iletisim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(914, 600);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(btnGonder);
            Controls.Add(txtMesaj);
            Controls.Add(lblMesajiniz);
            Controls.Add(txtEposta);
            Controls.Add(lblEposta);
            Controls.Add(txtSoyad);
            Controls.Add(lblSoyadiniz);
            Controls.Add(txtAd);
            Controls.Add(lblAdiniz);
            Controls.Add(lblIletisim);
            Controls.Add(lblWebBaslik);
            Controls.Add(lblTelefon);
            Controls.Add(lblTelefonBaslik);
            Controls.Add(lblAdres);
            Controls.Add(lblAdresBaslik);
            Controls.Add(picKonum);
            Controls.Add(lblWeb);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "iletisim";
            Text = "İletişim";
            ((System.ComponentModel.ISupportInitialize)picKonum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picKonum;
        private Label lblAdresBaslik;
        private Label lblAdres;
        private Label lblTelefon;
        private Label lblTelefonBaslik;
        private Label lblWebBaslik;
        private Label lblIletisim;
        private Label lblAdiniz;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label lblSoyadiniz;
        private TextBox txtEposta;
        private Label lblEposta;
        private Label lblMesajiniz;
        private TextBox txtMesaj;
        private Button btnGonder;
        private Label label12;
        private Label label13;
        private Label label14;
        private LinkLabel lblWeb;
    }
}