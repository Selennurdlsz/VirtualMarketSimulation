using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace VeriYapısıProje2Ödev1
{
    public partial class frmUrunEkle : Form
    {
        AnaSayfa a = new AnaSayfa();
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            int i = 1;
            switch (cmbbxKategoriler.SelectedIndex)
            {
                case 0:
                    İkiliAramaAgaci aramaAgaci = new İkiliAramaAgaci();
                    aramaAgaci.Ekle("Dizüstü Bilgisayar");
                    aramaAgaci.Ekle(txtEklenecekUrunAdi.ToString());  
                    UrunBilgileriArray ub = new UrunBilgileriArray();
                    ub.UrunAdi = txtEklenecekUrunAdi.ToString();
                    ub.Marka = txtMarka.ToString();
                    ub.Model = Convert.ToInt32(txtModel.Text);
                    ub.Fiyat = Convert.ToInt32(txtSatisFiyati.Text);
                    ub.UrunMaliyeti = Convert.ToInt32(txtMaliyet.Text);
                    ub.UrunMiktari = Convert.ToInt32(txtUrunMiktari.Text);
                    ub.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    ub.ekle(ub);
                    MessageBox.Show("Ürününüz eklendi.");
                    UrunBilgileriArray u = new UrunBilgileriArray();
                    u.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    i++;
                   // u.hashEkle(u.UrunAciklamasi, i);

                    break;

                case 1:
                    İkiliAramaAgaci aramaAgaci1 = new İkiliAramaAgaci();
                    aramaAgaci1.Ekle("Buzdolabı");
                    aramaAgaci1.Ekle(txtEklenecekUrunAdi.ToString());
                    UrunBilgileriArray ub1 = new UrunBilgileriArray();
                    ub1.UrunAdi = txtEklenecekUrunAdi.ToString();
                    ub1.Marka = txtMarka.ToString();
                    ub1.Model = Convert.ToInt32(txtModel.Text);
                    ub1.Fiyat = Convert.ToInt32(txtSatisFiyati.Text);
                    ub1.UrunMaliyeti = Convert.ToInt32(txtMaliyet.Text);
                    ub1.UrunMiktari = Convert.ToInt32(txtUrunMiktari.Text);
                    ub1.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    ub1.ekle(ub1);
                    MessageBox.Show("Ürününüz eklendi.");
                    UrunBilgileriArray u1 = new UrunBilgileriArray();
                    u1.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    i++;
                    // u.hashEkle(u.UrunAciklamasi, i);
                    break;
                case 2:
                    İkiliAramaAgaci aramaAgaci2 = new İkiliAramaAgaci();
                    aramaAgaci2.Ekle("Pantolon");
                    aramaAgaci2.Ekle(txtEklenecekUrunAdi.ToString());
                    UrunBilgileriArray ub2 = new UrunBilgileriArray();
                    ub2.UrunAdi = txtEklenecekUrunAdi.ToString();
                    ub2.Marka = txtMarka.ToString();
                    ub2.Model = Convert.ToInt32(txtModel.Text);
                    ub2.Fiyat = Convert.ToInt32(txtSatisFiyati.Text);
                    ub2.UrunMaliyeti = Convert.ToInt32(txtMaliyet.Text);
                    ub2.UrunMiktari = Convert.ToInt32(txtUrunMiktari.Text);
                    ub2.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    ub2.ekle(ub2);
                    MessageBox.Show("Ürününüz eklendi.");
                    UrunBilgileriArray u2 = new UrunBilgileriArray();
                    u2.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    i++;
                    // u.hashEkle(u.UrunAciklamasi, i);
                    break;
                case 3:
                    İkiliAramaAgaci aramaAgaci3 = new İkiliAramaAgaci();
                    aramaAgaci3.Ekle("Defter");
                    aramaAgaci3.Ekle(txtEklenecekUrunAdi.ToString());
                    UrunBilgileriArray ub3 = new UrunBilgileriArray();
                    ub3.UrunAdi = txtEklenecekUrunAdi.ToString();
                    ub3.Marka = txtMarka.ToString();
                    ub3.Model = Convert.ToInt32(txtModel.Text);
                    ub3.Fiyat = Convert.ToInt32(txtSatisFiyati.Text);
                    ub3.UrunMaliyeti = Convert.ToInt32(txtMaliyet.Text);
                    ub3.UrunMiktari = Convert.ToInt32(txtUrunMiktari.Text);
                    ub3.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    ub3.ekle(ub3);
                    MessageBox.Show("Ürününüz eklendi.");
                    UrunBilgileriArray u3 = new UrunBilgileriArray();
                    u3.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    i++;
                    // u.hashEkle(u.UrunAciklamasi, i);

                    break;
                case 4:
                    İkiliAramaAgaci aramaAgaci4 = new İkiliAramaAgaci();
                    aramaAgaci4.Ekle("Masa");
                    aramaAgaci4.Ekle(txtEklenecekUrunAdi.ToString());
                    UrunBilgileriArray ub4 = new UrunBilgileriArray();
                    ub4.UrunAdi = txtEklenecekUrunAdi.ToString();
                    ub4.Marka = txtMarka.ToString();
                    ub4.Model = Convert.ToInt32(txtModel.Text);
                    ub4.Fiyat = Convert.ToInt32(txtSatisFiyati.Text);
                    ub4.UrunMaliyeti = Convert.ToInt32(txtMaliyet.Text);
                    ub4.UrunMiktari = Convert.ToInt32(txtUrunMiktari.Text);
                    ub4.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    ub4.ekle(ub4);
                    MessageBox.Show("Ürününüz eklendi.");
                    UrunBilgileriArray u4 = new UrunBilgileriArray();
                    u4.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    i++;
                    // u.hashEkle(u.UrunAciklamasi, i);
                    break;
                case 5:

                    İkiliAramaAgaci aramaAgaci5 = new İkiliAramaAgaci();
                    aramaAgaci5.Ekle("Bitkiler");
                    aramaAgaci5.Ekle(txtEklenecekUrunAdi.ToString());
                    UrunBilgileriArray ub5 = new UrunBilgileriArray();
                    ub5.UrunAdi = txtEklenecekUrunAdi.ToString();
                    ub5.Marka = txtMarka.ToString();
                    ub5.Model = Convert.ToInt32(txtModel.Text);
                    ub5.Fiyat = Convert.ToInt32(txtSatisFiyati.Text);
                    ub5.UrunMaliyeti = Convert.ToInt32(txtMaliyet.Text);
                    ub5.UrunMiktari = Convert.ToInt32(txtUrunMiktari.Text);
                    ub5.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    ub5.ekle(ub5);
                    MessageBox.Show("Ürününüz eklendi.");
                    UrunBilgileriArray u5 = new UrunBilgileriArray();
                    u5.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    i++;
                    // u.hashEkle(u.UrunAciklamasi, i);
                    break;
                case 6:
                    İkiliAramaAgaci aramaAgaci6 = new İkiliAramaAgaci();
                    aramaAgaci6.Ekle("Picanol");
                    aramaAgaci6.Ekle(txtEklenecekUrunAdi.ToString());
                    UrunBilgileriArray ub6 = new UrunBilgileriArray();
                    ub6.UrunAdi = txtEklenecekUrunAdi.ToString();
                    ub6.Marka = txtMarka.ToString();
                    ub6.Model = Convert.ToInt32(txtModel.Text);
                    ub6.Fiyat = Convert.ToInt32(txtSatisFiyati.Text);
                    ub6.UrunMaliyeti = Convert.ToInt32(txtMaliyet.Text);
                    ub6.UrunMiktari = Convert.ToInt32(txtUrunMiktari.Text);
                    ub6.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    ub6.ekle(ub6);
                    MessageBox.Show("Ürününüz eklendi.");
                    UrunBilgileriArray u6 = new UrunBilgileriArray();
                    u6.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    i++;
                    // u.hashEkle(u.UrunAciklamasi, i);
                    break;
                case 7:
                    İkiliAramaAgaci aramaAgaci7 = new İkiliAramaAgaci();
                    aramaAgaci7.Ekle("Bakliyat");
                    aramaAgaci7.Ekle(txtEklenecekUrunAdi.ToString());
                    UrunBilgileriArray ub7 = new UrunBilgileriArray();
                    ub7.UrunAdi = txtEklenecekUrunAdi.ToString();
                    ub7.Marka = txtMarka.ToString();
                    ub7.Model = Convert.ToInt32(txtModel.Text);
                    ub7.Fiyat = Convert.ToInt32(txtSatisFiyati.Text);
                    ub7.UrunMaliyeti = Convert.ToInt32(txtMaliyet.Text);
                    ub7.UrunMiktari = Convert.ToInt32(txtUrunMiktari.Text);
                    ub7.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    ub7.ekle(ub7);
                    MessageBox.Show("Ürününüz eklendi.");
                    UrunBilgileriArray u7 = new UrunBilgileriArray();
                    u7.UrunAciklamasi = txtUrunAciklamasi.ToString();
                    i++;
                    // u.hashEkle(u.UrunAciklamasi, i);
                    break;

            }
        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            
            UrunBilgileriArray ub = new UrunBilgileriArray();
            ub.UrunAdi = txtEklenecekUrunAdi.ToString();
            ub.Marka = txtMarka.ToString();
            ub.Model = Convert.ToInt32(txtModel.Text);
            ub.Fiyat = Convert.ToInt32(txtSatisFiyati.Text);
            ub.UrunMaliyeti = Convert.ToInt32(txtMaliyet.Text);
            ub.UrunMiktari = Convert.ToInt32(txtUrunMiktari.Text);
            ub.UrunAciklamasi = txtUrunAciklamasi.ToString();
            ub.ekle(ub);
            int j = 0;
            j = ub.UrunSayisi;
            string Aranacak = txtArananUrunAdi.ToString();
            bool Durum = false;
            for (int i = 0; i < j; i++)
            {
                if (ub.UrunAdi.ToUpper() == Aranacak.ToUpper())
                {
                    Durum = true;
                    break;
                }
            }
            if (Durum == true)
            {
               
                MessageBox.Show("Aradığınız urun listede mevcut.");
               
            }
              
            else
                MessageBox.Show("Aradığınız urun listede mevcut değil.");


        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            UrunBilgileriArray ub = new UrunBilgileriArray();
            ub.UrunAdi = txtEklenecekUrunAdi.ToString();
            ub.Marka = txtMarka.ToString();
            ub.Model = Convert.ToInt32(txtModel.Text);
            ub.Fiyat = Convert.ToInt32(txtSatisFiyati.Text);
            ub.UrunMaliyeti = Convert.ToInt32(txtMaliyet.Text);
            ub.UrunMiktari = Convert.ToInt32(txtUrunMiktari.Text);
            ub.UrunAciklamasi = txtUrunAciklamasi.ToString();
            ub.ekle(ub);
            int j = 0;
            j = ub.UrunSayisi;
            string Silinecek =txtSilinecekUrun.ToString();
            bool Durum = false;
            for (int i = 0; i < j; i++)
            {
                if (ub.UrunAdi.ToUpper() == Silinecek.ToUpper())
                {
                    Durum = true;
                    break;
                }
            }
            if (Durum == true)
            {
                ub.UrunSil(ub);
                MessageBox.Show("Urununuz silindi.");

            }

            else
                MessageBox.Show("Aradığınız urun listede mevcut değil.");

        }

        private void btnAra2_Click(object sender, EventArgs e)
        {
            btnGuncelle.Visible = true;
            UrunBilgileriArray ub = new UrunBilgileriArray();
            ub.UrunAdi = txtEklenecekUrunAdi.ToString();
            ub.Marka = txtMarka.ToString();
            ub.Model = Convert.ToInt32(txtModel.Text);
            ub.Fiyat = Convert.ToInt32(txtSatisFiyati.Text);
            ub.UrunMaliyeti = Convert.ToInt32(txtMaliyet.Text);
            ub.UrunMiktari = Convert.ToInt32(txtUrunMiktari.Text);
            ub.UrunAciklamasi = txtUrunAciklamasi.ToString();
            ub.ekle(ub);
            int j = 0;
            j = ub.UrunSayisi;
            string Aranacak2 = txtAranacakUrun2.ToString();
            bool Durum = false;
            for (int i = 0; i < j; i++)
            {
                if (ub.UrunAdi.ToUpper() == Aranacak2.ToUpper())
                {
                    Durum = true;
                    break;
                }
                if (Durum == true)
                {
 
                    MessageBox.Show("Urununuz bulundu.");

                }
                else
                    MessageBox.Show("Aradığınız urun listede mevcut değil.");
            }
          

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UrunBilgileriArray ub1 = new UrunBilgileriArray();
            ub1.UrunAdi = txtUrunAdıGuncelle.ToString();
            ub1.Marka = txtUrunMarkaGuncelle.ToString();
            ub1.Model = Convert.ToInt32(txtUrunModelGuncelle.Text);
            ub1.Fiyat = Convert.ToInt32(txtUrunFiyatiGuncelle.Text);
            ub1.UrunMaliyeti = Convert.ToInt32(txtUrunMaliyetiGuncelle.Text);
            ub1.UrunMiktari = Convert.ToInt32(txtUrunMiktariGuncelle.Text);
            ub1.UrunAciklamasi = txtUrunAcıklamasıGuncelle.ToString();
            ub1.ekle(ub1);
            UrunBilgileriArray u = new UrunBilgileriArray();
            u.UrunAciklamasi = txtUrunAcıklamasıGuncelle.ToString();
            // u.hashEkle(u.UrunAciklamasi, i);
            MessageBox.Show("Urununuz güncellendi.");
        }
    }
}
