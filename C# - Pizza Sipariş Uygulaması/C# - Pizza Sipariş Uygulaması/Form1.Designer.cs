namespace C____Pizza_Sipariş_Uygulaması
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            button1 = new Button();
            comboBox6 = new ComboBox();
            comboBox7 = new ComboBox();
            comboBox8 = new ComboBox();
            comboBox9 = new ComboBox();
            comboBox10 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox2 = new CheckBox();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label15 = new Label();
            comboBox11 = new ComboBox();
            comboBox12 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(379, 138);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(218, 319);
            listBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İnce Hamur", "Kalın Hamur (+5 TL)" });
            comboBox1.Location = new Point(44, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Sucuksuz", "Sucuklu (+8 TL)", "Bol Sucuklu (+15 TL)" });
            comboBox2.Location = new Point(44, 267);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Mantarsız", "Mantarlı (+2 TL)", "Bol Mantarlı (+4 TL)" });
            comboBox3.Location = new Point(44, 320);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 3;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Mozarellasız", "Mozerellalı (+7 TL)" });
            comboBox4.Location = new Point(44, 377);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 4;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Zeytinsiz", "Zeytinli (+4 TL)", "Bol Zeytinli (+8 TL)" });
            comboBox5.Location = new Point(44, 434);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 5;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(44, 479);
            button1.Name = "button1";
            button1.Size = new Size(281, 46);
            button1.TabIndex = 6;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Küçük Boy (15 TL)", "Orta Boy (25 TL)", "Büyük Boy (35 TL)" });
            comboBox6.Location = new Point(44, 159);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 11;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "İçecek İstemiyorum.", "Küçük Ayran (+5 TL)", "Büyük Ayran (+8 TL)", "330 mL Kola (+8 TL)", "330 mL Şekersiz Kola (+8 TL)", "1L Kola (+18 TL)", "1L Şekersiz Kola (+18 TL)", "330 mL Ice-Tea Şeftali (+7 TL)", "330 mL Ice-Tea Mango (+7 TL)", "1L Ice-Tea Şeftali (+17 TL)", "1L Ice-Tea Mango (+17 TL)", "400 mL Şalgam (+6 TL)", "400 mL Acı Şalgam (+6 TL)", "1L Şekersiz Kola (+18 TL)", "250 mL Zafer Gazoz (+10 TL) " });
            comboBox7.Location = new Point(204, 377);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(121, 23);
            comboBox7.TabIndex = 10;
            comboBox7.SelectedIndexChanged += comboBox7_SelectedIndexChanged;
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "Sos İstemiyorum.", "Ketçap (ÜCRETSİZ)", "Mayonez (ÜCRETSİZ)", "BBQ Sos (+2 TL)", "Hardal (+2 TL)", "Acı Sos (+2 TL)", "Sarımsaklı Mayonez (+3 TL)", "Ballı Hardallı Sos (+3 TL)", "Buffalo Sos (+3 TL)" });
            comboBox8.Location = new Point(204, 320);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(121, 23);
            comboBox8.TabIndex = 9;
            comboBox8.SelectedIndexChanged += comboBox8_SelectedIndexChanged;
            // 
            // comboBox9
            // 
            comboBox9.FormattingEnabled = true;
            comboBox9.Items.AddRange(new object[] { "Soğan Halkası istemiyorum.", "5'li Soğan Halkası (+10 TL)", "10'lu Soğan Halkası (+17 TL)" });
            comboBox9.Location = new Point(204, 212);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(121, 23);
            comboBox9.TabIndex = 8;
            comboBox9.SelectedIndexChanged += comboBox9_SelectedIndexChanged;
            // 
            // comboBox10
            // 
            comboBox10.FormattingEnabled = true;
            comboBox10.Items.AddRange(new object[] { "Sufle İstemiyorum", "Sufle (+10 TL)" });
            comboBox10.Location = new Point(204, 159);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(121, 23);
            comboBox10.TabIndex = 7;
            comboBox10.SelectedIndexChanged += comboBox10_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 26);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 13;
            label2.Text = "İsim Soyisim:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 22);
            textBox1.MaxLength = 35;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 14;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 80);
            textBox2.MaxLength = 11;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 16;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 80);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 15;
            label3.Text = "Telefon:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(137, 133);
            textBox3.MaxLength = 200;
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 104);
            textBox3.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(44, 137);
            label5.Name = "label5";
            label5.Size = new Size(103, 19);
            label5.TabIndex = 19;
            label5.Text = "Pizza Boyutu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 192);
            label6.Name = "label6";
            label6.Size = new Size(110, 19);
            label6.TabIndex = 20;
            label6.Text = "Pizza Hamuru";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(44, 245);
            label7.Name = "label7";
            label7.Size = new Size(54, 19);
            label7.TabIndex = 21;
            label7.Text = "Sucuk";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(44, 298);
            label8.Name = "label8";
            label8.Size = new Size(58, 19);
            label8.TabIndex = 22;
            label8.Text = "Mantar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(44, 355);
            label9.Name = "label9";
            label9.Size = new Size(79, 19);
            label9.TabIndex = 23;
            label9.Text = "Mozarella";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(44, 412);
            label10.Name = "label10";
            label10.Size = new Size(53, 19);
            label10.TabIndex = 24;
            label10.Text = "Zeytin";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(204, 137);
            label11.Name = "label11";
            label11.Size = new Size(46, 19);
            label11.TabIndex = 25;
            label11.Text = "Sufle";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(204, 190);
            label12.Name = "label12";
            label12.Size = new Size(114, 19);
            label12.TabIndex = 26;
            label12.Text = "Soğan Halkası";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(204, 298);
            label13.Name = "label13";
            label13.Size = new Size(78, 19);
            label13.TabIndex = 27;
            label13.Text = "İkinci Sos";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(204, 355);
            label14.Name = "label14";
            label14.Size = new Size(104, 19);
            label14.TabIndex = 28;
            label14.Text = "Birinci İçecek";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(400, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(137, 260);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(173, 19);
            checkBox1.TabIndex = 30;
            checkBox1.Text = "Temassız teslimat istiyorum.";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(659, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 320);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Teslimat Bilgileri";
            groupBox1.Visible = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Cursor = Cursors.Hand;
            checkBox2.Location = new Point(137, 288);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(176, 19);
            checkBox2.TabIndex = 31;
            checkBox2.Text = "Ödemeyi kapıda yapacağım.";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(66, 137);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 17;
            label4.Text = "Adres:";
            // 
            // button2
            // 
            button2.Location = new Point(659, 479);
            button2.Name = "button2";
            button2.Size = new Size(316, 46);
            button2.TabIndex = 33;
            button2.Text = "Onayla";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(900, 531);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(75, 23);
            button3.TabIndex = 34;
            button3.Text = "Temizle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(205, 412);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 38;
            label1.Text = "İkinci İçecek";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(204, 245);
            label15.Name = "label15";
            label15.Size = new Size(86, 19);
            label15.TabIndex = 37;
            label15.Text = "Birinci Sos";
            // 
            // comboBox11
            // 
            comboBox11.FormattingEnabled = true;
            comboBox11.Items.AddRange(new object[] { "İçecek İstemiyorum.", "Küçük Ayran (+5 TL)", "Büyük Ayran (+8 TL)", "330 mL Kola (+8 TL)", "330 mL Şekersiz Kola (+8 TL)", "1L Kola (+18 TL)", "1L Şekersiz Kola (+18 TL)", "330 mL Ice-Tea Şeftali (+7 TL)", "330 mL Ice-Tea Mango (+7 TL)", "1L Ice-Tea Şeftali (+17 TL)", "1L Ice-Tea Mango (+17 TL)", "400 mL Şalgam (+6 TL)", "400 mL Acı Şalgam (+6 TL)", "1L Şekersiz Kola (+18 TL)", "250 mL Zafer Gazoz (+10 TL) " });
            comboBox11.Location = new Point(205, 434);
            comboBox11.Name = "comboBox11";
            comboBox11.Size = new Size(121, 23);
            comboBox11.TabIndex = 36;
            comboBox11.SelectedIndexChanged += comboBox11_SelectedIndexChanged;
            // 
            // comboBox12
            // 
            comboBox12.FormattingEnabled = true;
            comboBox12.Items.AddRange(new object[] { "Sos İstemiyorum.", "Ketçap (ÜCRETSİZ)", "Mayonez (ÜCRETSİZ)", "BBQ Sos (ÜCRETSİZ)", "Hardal (ÜCRETSİZ)", "Acı Sos (ÜCRETSİZ)", "Sarımsaklı Mayonez (ÜCRETSİZ))", "Ballı Hardallı Sos (ÜCRETSİZ)", "Buffalo Sos (ÜCRETSİZ)" });
            comboBox12.Location = new Point(204, 267);
            comboBox12.Name = "comboBox12";
            comboBox12.Size = new Size(121, 23);
            comboBox12.TabIndex = 35;
            comboBox12.SelectedIndexChanged += comboBox12_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(987, 570);
            Controls.Add(label1);
            Controls.Add(label15);
            Controls.Add(comboBox11);
            Controls.Add(comboBox12);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox6);
            Controls.Add(comboBox7);
            Controls.Add(comboBox8);
            Controls.Add(comboBox9);
            Controls.Add(comboBox10);
            Controls.Add(button1);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Pizza Sipariş Uygulaması";
            Load += Form1_Load;
            Click += Form1_Click;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private Button button1;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private ComboBox comboBox10;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button3;
        private Label label4;
        private CheckBox checkBox2;
        private Label label1;
        private Label label15;
        private ComboBox comboBox11;
        private ComboBox comboBox12;
    }
}