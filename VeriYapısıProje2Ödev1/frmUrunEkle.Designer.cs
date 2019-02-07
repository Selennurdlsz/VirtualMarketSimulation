namespace VeriYapısıProje2Ödev1
{
    partial class frmUrunEkle
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
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.cmbbxKategoriler = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtEklenecekUrunAdi = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUrunMiktari = new System.Windows.Forms.Label();
            this.lblMaliyet = new System.Windows.Forms.Label();
            this.lblSatışFiyati = new System.Windows.Forms.Label();
            this.txtUrunMiktari = new System.Windows.Forms.TextBox();
            this.txtMaliyet = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunAciklamasi = new System.Windows.Forms.TextBox();
            this.lblUrunAcıklamasi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArananUrunAdi = new System.Windows.Forms.TextBox();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.txtSilinecekUrun = new System.Windows.Forms.TextBox();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbbxKategorier1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUrunMaliyetiGuncelle = new System.Windows.Forms.TextBox();
            this.txtUrunFiyatiGuncelle = new System.Windows.Forms.TextBox();
            this.txtUrunMiktariGuncelle = new System.Windows.Forms.TextBox();
            this.txtUrunModelGuncelle = new System.Windows.Forms.TextBox();
            this.txtUrunMarkaGuncelle = new System.Windows.Forms.TextBox();
            this.txtUrunAdıGuncelle = new System.Windows.Forms.TextBox();
            this.txtUrunAcıklamasıGuncelle = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAra2 = new System.Windows.Forms.Button();
            this.lblAra = new System.Windows.Forms.Label();
            this.txtAranacakUrun2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.Blue;
            this.btnUrunEkle.Location = new System.Drawing.Point(82, 358);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(96, 36);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "EKLE";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // cmbbxKategoriler
            // 
            this.cmbbxKategoriler.FormattingEnabled = true;
            this.cmbbxKategoriler.Items.AddRange(new object[] {
            "Bilgisayar",
            "Beyaz Eşya",
            "Giyim",
            "Kırtasiye_Ofis",
            "YapıMarket",
            " Bahçe",
            "Tekstil",
            "Yiyecek"});
            this.cmbbxKategoriler.Location = new System.Drawing.Point(102, 59);
            this.cmbbxKategoriler.Name = "cmbbxKategoriler";
            this.cmbbxKategoriler.Size = new System.Drawing.Size(121, 24);
            this.cmbbxKategoriler.TabIndex = 1;
            // 
            // txtEklenecekUrunAdi
            // 
            this.txtEklenecekUrunAdi.Location = new System.Drawing.Point(123, 106);
            this.txtEklenecekUrunAdi.Name = "txtEklenecekUrunAdi";
            this.txtEklenecekUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtEklenecekUrunAdi.TabIndex = 2;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(123, 140);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 22);
            this.txtMarka.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(123, 168);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 4;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(38, 109);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(63, 17);
            this.lblUrunAdi.TabIndex = 5;
            this.lblUrunAdi.Text = "UrunAdi:";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(50, 143);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(51, 17);
            this.lblMarka.TabIndex = 6;
            this.lblMarka.Text = "Marka:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(51, 173);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 17);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lütfen Ürün Kategorisi Giriniz:";
            // 
            // lblUrunMiktari
            // 
            this.lblUrunMiktari.AutoSize = true;
            this.lblUrunMiktari.Location = new System.Drawing.Point(13, 207);
            this.lblUrunMiktari.Name = "lblUrunMiktari";
            this.lblUrunMiktari.Size = new System.Drawing.Size(88, 17);
            this.lblUrunMiktari.TabIndex = 9;
            this.lblUrunMiktari.Text = "Ürün Miktarı:";
            // 
            // lblMaliyet
            // 
            this.lblMaliyet.AutoSize = true;
            this.lblMaliyet.Location = new System.Drawing.Point(51, 240);
            this.lblMaliyet.Name = "lblMaliyet";
            this.lblMaliyet.Size = new System.Drawing.Size(56, 17);
            this.lblMaliyet.TabIndex = 10;
            this.lblMaliyet.Text = "Maliyet:";
            // 
            // lblSatışFiyati
            // 
            this.lblSatışFiyati.AutoSize = true;
            this.lblSatışFiyati.Location = new System.Drawing.Point(30, 273);
            this.lblSatışFiyati.Name = "lblSatışFiyati";
            this.lblSatışFiyati.Size = new System.Drawing.Size(80, 17);
            this.lblSatışFiyati.TabIndex = 11;
            this.lblSatışFiyati.Text = "Satış Fiyatı:";
            // 
            // txtUrunMiktari
            // 
            this.txtUrunMiktari.Location = new System.Drawing.Point(123, 207);
            this.txtUrunMiktari.Name = "txtUrunMiktari";
            this.txtUrunMiktari.Size = new System.Drawing.Size(100, 22);
            this.txtUrunMiktari.TabIndex = 12;
            // 
            // txtMaliyet
            // 
            this.txtMaliyet.Location = new System.Drawing.Point(123, 240);
            this.txtMaliyet.Name = "txtMaliyet";
            this.txtMaliyet.Size = new System.Drawing.Size(100, 22);
            this.txtMaliyet.TabIndex = 13;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(123, 273);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(100, 22);
            this.txtSatisFiyati.TabIndex = 14;
            // 
            // txtUrunAciklamasi
            // 
            this.txtUrunAciklamasi.Location = new System.Drawing.Point(136, 313);
            this.txtUrunAciklamasi.Name = "txtUrunAciklamasi";
            this.txtUrunAciklamasi.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAciklamasi.TabIndex = 15;
            // 
            // lblUrunAcıklamasi
            // 
            this.lblUrunAcıklamasi.AutoSize = true;
            this.lblUrunAcıklamasi.Location = new System.Drawing.Point(4, 313);
            this.lblUrunAcıklamasi.Name = "lblUrunAcıklamasi";
            this.lblUrunAcıklamasi.Size = new System.Drawing.Size(113, 17);
            this.lblUrunAcıklamasi.TabIndex = 16;
            this.lblUrunAcıklamasi.Text = "Ürün Açıklaması:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "YENİ ÜRÜN EKLEME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "ÜRÜN ARA";
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(276, 12);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(23, 409);
            this.separatorControl1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Aradığınız ürün adını girin:";
            this.label4.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtArananUrunAdi
            // 
            this.txtArananUrunAdi.Location = new System.Drawing.Point(359, 106);
            this.txtArananUrunAdi.Name = "txtArananUrunAdi";
            this.txtArananUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtArananUrunAdi.TabIndex = 21;
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.BackColor = System.Drawing.Color.Blue;
            this.btnUrunAra.Location = new System.Drawing.Point(484, 98);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(89, 38);
            this.btnUrunAra.TabIndex = 22;
            this.btnUrunAra.Text = "ARA";
            this.btnUrunAra.UseVisualStyleBackColor = false;
            this.btnUrunAra.Click += new System.EventHandler(this.btnUrunAra_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.Blue;
            this.btnUrunSil.Location = new System.Drawing.Point(484, 263);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(89, 37);
            this.btnUrunSil.TabIndex = 23;
            this.btnUrunSil.Text = "SİL";
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "ÜRÜN SİL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Silmek istediğiniz ürünün adını girin:";
            this.label6.Click += new System.EventHandler(this.btnUrunAra_Click);
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(276, 188);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(352, 23);
            this.separatorControl2.TabIndex = 26;
            // 
            // txtSilinecekUrun
            // 
            this.txtSilinecekUrun.Location = new System.Drawing.Point(359, 277);
            this.txtSilinecekUrun.Name = "txtSilinecekUrun";
            this.txtSilinecekUrun.Size = new System.Drawing.Size(100, 22);
            this.txtSilinecekUrun.TabIndex = 27;
            // 
            // separatorControl3
            // 
            this.separatorControl3.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl3.Location = new System.Drawing.Point(613, 28);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(31, 375);
            this.separatorControl3.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(712, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "ÜRÜN GÜNCELLE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(660, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Lütfen Ürün Kategorisi Giriniz:";
            // 
            // cmbbxKategorier1
            // 
            this.cmbbxKategorier1.FormattingEnabled = true;
            this.cmbbxKategorier1.Items.AddRange(new object[] {
            "Bilgisayar",
            "Beyaz Eşya",
            "Giyim",
            "Kırtasiye_Ofis",
            "YapıMarket",
            " Bahçe",
            "Tekstil",
            "Yiyecek"});
            this.cmbbxKategorier1.Location = new System.Drawing.Point(759, 59);
            this.cmbbxKategorier1.Name = "cmbbxKategorier1";
            this.cmbbxKategorier1.Size = new System.Drawing.Size(121, 24);
            this.cmbbxKategorier1.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(719, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "UrunAdi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(724, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Marka:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(728, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Model:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(687, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Ürün Miktarı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(719, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "Maliyet:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(698, 308);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Satış Fiyatı:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(665, 368);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 17);
            this.label15.TabIndex = 38;
            this.label15.Text = "Ürün Açıklaması:";
            // 
            // txtUrunMaliyetiGuncelle
            // 
            this.txtUrunMaliyetiGuncelle.Location = new System.Drawing.Point(802, 337);
            this.txtUrunMaliyetiGuncelle.Name = "txtUrunMaliyetiGuncelle";
            this.txtUrunMaliyetiGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtUrunMaliyetiGuncelle.TabIndex = 39;
            // 
            // txtUrunFiyatiGuncelle
            // 
            this.txtUrunFiyatiGuncelle.Location = new System.Drawing.Point(802, 308);
            this.txtUrunFiyatiGuncelle.Name = "txtUrunFiyatiGuncelle";
            this.txtUrunFiyatiGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtUrunFiyatiGuncelle.TabIndex = 40;
            // 
            // txtUrunMiktariGuncelle
            // 
            this.txtUrunMiktariGuncelle.Location = new System.Drawing.Point(802, 278);
            this.txtUrunMiktariGuncelle.Name = "txtUrunMiktariGuncelle";
            this.txtUrunMiktariGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtUrunMiktariGuncelle.TabIndex = 41;
            // 
            // txtUrunModelGuncelle
            // 
            this.txtUrunModelGuncelle.Location = new System.Drawing.Point(802, 250);
            this.txtUrunModelGuncelle.Name = "txtUrunModelGuncelle";
            this.txtUrunModelGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtUrunModelGuncelle.TabIndex = 42;
            // 
            // txtUrunMarkaGuncelle
            // 
            this.txtUrunMarkaGuncelle.Location = new System.Drawing.Point(802, 214);
            this.txtUrunMarkaGuncelle.Name = "txtUrunMarkaGuncelle";
            this.txtUrunMarkaGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtUrunMarkaGuncelle.TabIndex = 43;
            // 
            // txtUrunAdıGuncelle
            // 
            this.txtUrunAdıGuncelle.Location = new System.Drawing.Point(802, 186);
            this.txtUrunAdıGuncelle.Name = "txtUrunAdıGuncelle";
            this.txtUrunAdıGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAdıGuncelle.TabIndex = 44;
            // 
            // txtUrunAcıklamasıGuncelle
            // 
            this.txtUrunAcıklamasıGuncelle.Location = new System.Drawing.Point(802, 365);
            this.txtUrunAcıklamasıGuncelle.Name = "txtUrunAcıklamasıGuncelle";
            this.txtUrunAcıklamasıGuncelle.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAcıklamasıGuncelle.TabIndex = 45;
            this.txtUrunAcıklamasıGuncelle.Click += new System.EventHandler(this.btnUrunSil_Click);
            this.txtUrunAcıklamasıGuncelle.TextChanged += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Blue;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuncelle.Location = new System.Drawing.Point(894, 393);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(124, 36);
            this.btnGuncelle.TabIndex = 46;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Visible = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(647, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(274, 17);
            this.label16.TabIndex = 47;
            this.label16.Text = "Guncellemek istediğiniz ürünün adını girin:";
            // 
            // btnAra2
            // 
            this.btnAra2.BackColor = System.Drawing.Color.Blue;
            this.btnAra2.Location = new System.Drawing.Point(941, 132);
            this.btnAra2.Name = "btnAra2";
            this.btnAra2.Size = new System.Drawing.Size(77, 30);
            this.btnAra2.TabIndex = 48;
            this.btnAra2.Text = "ARA";
            this.btnAra2.UseVisualStyleBackColor = false;
            this.btnAra2.Click += new System.EventHandler(this.btnAra2_Click);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(650, 143);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(135, 17);
            this.lblAra.TabIndex = 49;
            this.lblAra.Text = " Aranacak Urun Adi:";
            // 
            // txtAranacakUrun2
            // 
            this.txtAranacakUrun2.Location = new System.Drawing.Point(802, 140);
            this.txtAranacakUrun2.Name = "txtAranacakUrun2";
            this.txtAranacakUrun2.Size = new System.Drawing.Size(100, 22);
            this.txtAranacakUrun2.TabIndex = 50;
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1030, 441);
            this.Controls.Add(this.txtAranacakUrun2);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.btnAra2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtUrunAcıklamasıGuncelle);
            this.Controls.Add(this.txtUrunAdıGuncelle);
            this.Controls.Add(this.txtUrunMarkaGuncelle);
            this.Controls.Add(this.txtUrunModelGuncelle);
            this.Controls.Add(this.txtUrunMiktariGuncelle);
            this.Controls.Add(this.txtUrunFiyatiGuncelle);
            this.Controls.Add(this.txtUrunMaliyetiGuncelle);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbbxKategorier1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.txtSilinecekUrun);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunAra);
            this.Controls.Add(this.txtArananUrunAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUrunAcıklamasi);
            this.Controls.Add(this.txtUrunAciklamasi);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtMaliyet);
            this.Controls.Add(this.txtUrunMiktari);
            this.Controls.Add(this.lblSatışFiyati);
            this.Controls.Add(this.lblMaliyet);
            this.Controls.Add(this.lblUrunMiktari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtEklenecekUrunAdi);
            this.Controls.Add(this.cmbbxKategoriler);
            this.Controls.Add(this.btnUrunEkle);
            this.Name = "frmUrunEkle";
            this.Text = "frmUrunEkle";
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.ComboBox cmbbxKategoriler;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtEklenecekUrunAdi;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUrunMiktari;
        private System.Windows.Forms.Label lblMaliyet;
        private System.Windows.Forms.Label lblSatışFiyati;
        private System.Windows.Forms.TextBox txtUrunMiktari;
        private System.Windows.Forms.TextBox txtMaliyet;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtUrunAciklamasi;
        private System.Windows.Forms.Label lblUrunAcıklamasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArananUrunAdi;
        private System.Windows.Forms.Button btnUrunAra;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.TextBox txtSilinecekUrun;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbbxKategorier1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUrunMaliyetiGuncelle;
        private System.Windows.Forms.TextBox txtUrunFiyatiGuncelle;
        private System.Windows.Forms.TextBox txtUrunMiktariGuncelle;
        private System.Windows.Forms.TextBox txtUrunModelGuncelle;
        private System.Windows.Forms.TextBox txtUrunMarkaGuncelle;
        private System.Windows.Forms.TextBox txtUrunAdıGuncelle;
        private System.Windows.Forms.TextBox txtUrunAcıklamasıGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAra2;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.TextBox txtAranacakUrun2;
    }
}