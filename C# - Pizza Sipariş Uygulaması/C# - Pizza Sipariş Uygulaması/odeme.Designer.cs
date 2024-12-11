namespace C____Pizza_Sipariş_Uygulaması
{
    partial class odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(odeme));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKartNo = new TextBox();
            cmbSktAy = new ComboBox();
            cmbSktYil = new ComboBox();
            label4 = new Label();
            txtCvv = new TextBox();
            txtSms = new TextBox();
            btnOnayla = new Button();
            btnSiparis = new Button();
            picKartHelp = new PictureBox();
            picSktHelp = new PictureBox();
            picSmsHelp = new PictureBox();
            picCvvHelp = new PictureBox();
            kart = new PictureBox();
            lblOtoIsim = new Label();
            txtOtoKartNo = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            picService = new PictureBox();
            picOdemeLogo = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            cbKartiKaydet = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)picKartHelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSktHelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSmsHelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCvvHelp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picService).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOdemeLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 445);
            label1.Name = "label1";
            label1.Size = new Size(100, 27);
            label1.TabIndex = 0;
            label1.Text = "Kart No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(71, 540);
            label2.Name = "label2";
            label2.Size = new Size(62, 27);
            label2.TabIndex = 1;
            label2.Text = "SKT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 639);
            label3.Name = "label3";
            label3.Size = new Size(65, 27);
            label3.TabIndex = 2;
            label3.Text = "CVV:";
            // 
            // txtKartNo
            // 
            txtKartNo.Location = new Point(149, 444);
            txtKartNo.Margin = new Padding(3, 4, 3, 4);
            txtKartNo.MaxLength = 16;
            txtKartNo.Name = "txtKartNo";
            txtKartNo.Size = new Size(171, 27);
            txtKartNo.TabIndex = 3;
            txtKartNo.TextChanged += textBox1_TextChanged;
            txtKartNo.KeyPress += textBox1_KeyPress;
            // 
            // cmbSktAy
            // 
            cmbSktAy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSktAy.Enabled = false;
            cmbSktAy.FormattingEnabled = true;
            cmbSktAy.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cmbSktAy.Location = new Point(149, 539);
            cmbSktAy.Margin = new Padding(3, 4, 3, 4);
            cmbSktAy.Name = "cmbSktAy";
            cmbSktAy.Size = new Size(57, 28);
            cmbSktAy.TabIndex = 4;
            cmbSktAy.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            cmbSktAy.DropDownClosed += comboBox1_DropDownClosed;
            // 
            // cmbSktYil
            // 
            cmbSktYil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSktYil.Enabled = false;
            cmbSktYil.FormattingEnabled = true;
            cmbSktYil.Items.AddRange(new object[] { "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34" });
            cmbSktYil.Location = new Point(263, 539);
            cmbSktYil.Margin = new Padding(3, 4, 3, 4);
            cmbSktYil.Name = "cmbSktYil";
            cmbSktYil.Size = new Size(57, 28);
            cmbSktYil.TabIndex = 5;
            cmbSktYil.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            cmbSktYil.DropDownClosed += comboBox2_DropDownClosed;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 13.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(229, 540);
            label4.Name = "label4";
            label4.Size = new Size(18, 26);
            label4.TabIndex = 6;
            label4.Text = "/";
            // 
            // txtCvv
            // 
            txtCvv.Enabled = false;
            txtCvv.Location = new Point(149, 637);
            txtCvv.Margin = new Padding(3, 4, 3, 4);
            txtCvv.MaxLength = 3;
            txtCvv.Name = "txtCvv";
            txtCvv.Size = new Size(57, 27);
            txtCvv.TabIndex = 7;
            txtCvv.TextChanged += textBox2_TextChanged;
            txtCvv.KeyPress += textBox2_KeyPress;
            // 
            // txtSms
            // 
            txtSms.Enabled = false;
            txtSms.Location = new Point(263, 637);
            txtSms.Margin = new Padding(3, 4, 3, 4);
            txtSms.MaxLength = 4;
            txtSms.Name = "txtSms";
            txtSms.Size = new Size(57, 27);
            txtSms.TabIndex = 8;
            txtSms.Text = "SMS";
            txtSms.KeyPress += textBox3_KeyPress;
            // 
            // btnOnayla
            // 
            btnOnayla.Enabled = false;
            btnOnayla.Location = new Point(91, 721);
            btnOnayla.Margin = new Padding(3, 4, 3, 4);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(114, 53);
            btnOnayla.TabIndex = 9;
            btnOnayla.Text = "Kartı Onayla";
            btnOnayla.UseVisualStyleBackColor = true;
            btnOnayla.Click += button1_Click;
            // 
            // btnSiparis
            // 
            btnSiparis.Enabled = false;
            btnSiparis.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiparis.Location = new Point(229, 721);
            btnSiparis.Margin = new Padding(3, 4, 3, 4);
            btnSiparis.Name = "btnSiparis";
            btnSiparis.Size = new Size(114, 53);
            btnSiparis.TabIndex = 10;
            btnSiparis.Text = "Siparişi Tamamla";
            btnSiparis.UseVisualStyleBackColor = true;
            btnSiparis.Click += button2_Click;
            // 
            // picKartHelp
            // 
            picKartHelp.Image = (Image)resources.GetObject("picKartHelp.Image");
            picKartHelp.Location = new Point(327, 445);
            picKartHelp.Margin = new Padding(3, 4, 3, 4);
            picKartHelp.Name = "picKartHelp";
            picKartHelp.Size = new Size(25, 29);
            picKartHelp.SizeMode = PictureBoxSizeMode.StretchImage;
            picKartHelp.TabIndex = 11;
            picKartHelp.TabStop = false;
            picKartHelp.Click += pictureBox1_Click;
            // 
            // picSktHelp
            // 
            picSktHelp.Image = (Image)resources.GetObject("picSktHelp.Image");
            picSktHelp.Location = new Point(327, 540);
            picSktHelp.Margin = new Padding(3, 4, 3, 4);
            picSktHelp.Name = "picSktHelp";
            picSktHelp.Size = new Size(25, 29);
            picSktHelp.SizeMode = PictureBoxSizeMode.StretchImage;
            picSktHelp.TabIndex = 12;
            picSktHelp.TabStop = false;
            picSktHelp.Click += pictureBox2_Click;
            // 
            // picSmsHelp
            // 
            picSmsHelp.Image = (Image)resources.GetObject("picSmsHelp.Image");
            picSmsHelp.Location = new Point(327, 639);
            picSmsHelp.Margin = new Padding(3, 4, 3, 4);
            picSmsHelp.Name = "picSmsHelp";
            picSmsHelp.Size = new Size(25, 29);
            picSmsHelp.SizeMode = PictureBoxSizeMode.StretchImage;
            picSmsHelp.TabIndex = 13;
            picSmsHelp.TabStop = false;
            picSmsHelp.Click += pictureBox3_Click;
            // 
            // picCvvHelp
            // 
            picCvvHelp.Image = (Image)resources.GetObject("picCvvHelp.Image");
            picCvvHelp.Location = new Point(213, 637);
            picCvvHelp.Margin = new Padding(3, 4, 3, 4);
            picCvvHelp.Name = "picCvvHelp";
            picCvvHelp.Size = new Size(25, 29);
            picCvvHelp.SizeMode = PictureBoxSizeMode.StretchImage;
            picCvvHelp.TabIndex = 14;
            picCvvHelp.TabStop = false;
            picCvvHelp.Click += pictureBox4_Click;
            // 
            // kart
            // 
            kart.Image = (Image)resources.GetObject("kart.Image");
            kart.Location = new Point(-3, 139);
            kart.Name = "kart";
            kart.Size = new Size(433, 281);
            kart.SizeMode = PictureBoxSizeMode.StretchImage;
            kart.TabIndex = 15;
            kart.TabStop = false;
            // 
            // lblOtoIsim
            // 
            lblOtoIsim.AutoSize = true;
            lblOtoIsim.BackColor = Color.White;
            lblOtoIsim.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOtoIsim.Location = new Point(64, 348);
            lblOtoIsim.Name = "lblOtoIsim";
            lblOtoIsim.Size = new Size(36, 20);
            lblOtoIsim.TabIndex = 16;
            lblOtoIsim.Text = "isim";
            // 
            // txtOtoKartNo
            // 
            txtOtoKartNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtOtoKartNo.Location = new Point(64, 303);
            txtOtoKartNo.Mask = "0000-0000-0000-0000";
            txtOtoKartNo.Name = "txtOtoKartNo";
            txtOtoKartNo.ReadOnly = true;
            txtOtoKartNo.Size = new Size(171, 30);
            txtOtoKartNo.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(329, 239);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(346, 239);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 20;
            label7.Text = "/";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(355, 239);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 21;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Location = new Point(349, 272);
            label9.Name = "label9";
            label9.Size = new Size(33, 20);
            label9.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(302, 331);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 23;
            label10.Text = "label10";
            label10.TextChanged += label10_TextChanged;
            // 
            // picService
            // 
            picService.BackColor = Color.White;
            picService.Location = new Point(263, 303);
            picService.Margin = new Padding(3, 4, 3, 4);
            picService.Name = "picService";
            picService.Size = new Size(114, 67);
            picService.SizeMode = PictureBoxSizeMode.StretchImage;
            picService.TabIndex = 24;
            picService.TabStop = false;
            // 
            // picOdemeLogo
            // 
            picOdemeLogo.Image = (Image)resources.GetObject("picOdemeLogo.Image");
            picOdemeLogo.Location = new Point(102, 16);
            picOdemeLogo.Margin = new Padding(3, 4, 3, 4);
            picOdemeLogo.Name = "picOdemeLogo";
            picOdemeLogo.Size = new Size(229, 133);
            picOdemeLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picOdemeLogo.TabIndex = 25;
            picOdemeLogo.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(263, 272);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 26;
            label11.Text = "CVV:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Location = new Point(263, 239);
            label12.Name = "label12";
            label12.Size = new Size(37, 20);
            label12.TabIndex = 27;
            label12.Text = "SKT:";
            // 
            // cbKartiKaydet
            // 
            cbKartiKaydet.AutoSize = true;
            cbKartiKaydet.Location = new Point(79, 688);
            cbKartiKaydet.Margin = new Padding(3, 4, 3, 4);
            cbKartiKaydet.Name = "cbKartiKaydet";
            cbKartiKaydet.Size = new Size(298, 24);
            cbKartiKaydet.TabIndex = 28;
            cbKartiKaydet.Text = "Sonraki alışverişlerim için kartımı kaydet.";
            cbKartiKaydet.UseVisualStyleBackColor = true;
            cbKartiKaydet.Visible = false;
            // 
            // odeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(430, 796);
            Controls.Add(cbKartiKaydet);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(picOdemeLogo);
            Controls.Add(picService);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtOtoKartNo);
            Controls.Add(lblOtoIsim);
            Controls.Add(picCvvHelp);
            Controls.Add(picSmsHelp);
            Controls.Add(picSktHelp);
            Controls.Add(picKartHelp);
            Controls.Add(btnSiparis);
            Controls.Add(btnOnayla);
            Controls.Add(txtSms);
            Controls.Add(txtCvv);
            Controls.Add(label4);
            Controls.Add(cmbSktYil);
            Controls.Add(cmbSktAy);
            Controls.Add(txtKartNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(kart);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "odeme";
            Text = "Ödeme";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)picKartHelp).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSktHelp).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSmsHelp).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCvvHelp).EndInit();
            ((System.ComponentModel.ISupportInitialize)kart).EndInit();
            ((System.ComponentModel.ISupportInitialize)picService).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOdemeLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKartNo;
        private ComboBox cmbSktAy;
        private ComboBox cmbSktYil;
        private Label label4;
        private TextBox txtCvv;
        private TextBox txtSms;
        private Button btnOnayla;
        private Button btnSiparis;
        private PictureBox picKartHelp;
        private PictureBox picSktHelp;
        private PictureBox picSmsHelp;
        private PictureBox picCvvHelp;
        private PictureBox kart;
        private Label lblOtoIsim;
        private MaskedTextBox txtOtoKartNo;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox picService;
        private PictureBox picOdemeLogo;
        private Label label11;
        private Label label12;
        private CheckBox cbKartiKaydet;
    }
}