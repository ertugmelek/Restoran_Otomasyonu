using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YemekBurada
{
    public partial class FrmYemekBurada : Form
    {
        //MEnü adını ve fiyatını tutucak bir dictionary oluşturuyorum
        public Dictionary<string, double> Menuler;
        public FrmYemekBurada()
        {
            InitializeComponent();
            Menuler = new Dictionary<string, double>();
        }
        string[] dosyalar = Directory.GetFiles(@"C:\Users\CASPER\Desktop\Restorantotomasyonu\Resimler\", "*.jpg");
        //Resimleri slayt gösterisi şeklinde gösteriyorum
        private void tmrSure_Tick(object sender, EventArgs e)
        {
            ResimGoruntule();
        }
        void ResimGoruntule()
        {
            Random r = new Random();
            picYemek.ImageLocation = dosyalar[r.Next(0, dosyalar.Length)];
        }
        //resim geçişleri için timerı başlatıyorum ve combobox değerlerini doldurup ilk değer ataması yapıyorum
        private void FrmYemekBurada_Load(object sender, EventArgs e)
        {
            tmrSure.Enabled = true;
            tmrSure.Interval = 1000;
            DataTable tblYemek = new DataTable();
            ComboBoxYemekDoldur(tblYemek);
            DataTable tblIcecek = new DataTable();
            ComboBoxIcecekDoldur(tblIcecek);
            rdbTam.Checked = true;
            cmbMenu.SelectedIndex = cmbIcecek.SelectedIndex = 0;
        }
        //yemekleri comboboxa dolduruyorum
        void ComboBoxYemekDoldur(DataTable tblYemek)
        {
            tblYemek.Columns.Add("Ad");
            tblYemek.Columns.Add("Fiyat");
            tblYemek.Rows.Add("Et Menü", 25);
            tblYemek.Rows.Add("Tavuk Menü", 17);
            tblYemek.Rows.Add("Vejeteryan Menü", 12);
            cmbMenu.DisplayMember = "Ad";  //comboboxda görüntülenecek değer
            cmbMenu.ValueMember = "Fiyat"; //comboboxda görüntülenen elemanın değeri
            cmbMenu.DataSource = tblYemek; //combobox veri kaynağını set'liyoruz
        }
        //içecekleri comboboxa dolduruyorum
        void ComboBoxIcecekDoldur(DataTable tblIcecek)
        {
            tblIcecek.Columns.Add("Ad");
            tblIcecek.Columns.Add("Fiyat");
            tblIcecek.Rows.Add("Kola", 2);
            tblIcecek.Rows.Add("Fanta", 2);
            tblIcecek.Rows.Add("Ayran", 1.5);
            tblIcecek.Rows.Add("Soda", 1);
            cmbIcecek.DisplayMember = "Ad";
            cmbIcecek.ValueMember = "Fiyat";
            cmbIcecek.DataSource = tblIcecek;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListboxaSiparisEkle();
        }
        //listboxda verilen siparişeri gösteriyorum
        void ListboxaSiparisEkle()
        {
            List<Ekstralar> ekst = new List<Ekstralar>();
            if (chbPatates.Checked)
            {
                ekst.Add(new Patates(2));
            }
            if (chbSalatalık.Checked)
            {
                ekst.Add(new Salatalik(0.5F));
            }
            if (chbTursu.Checked)
            {
                ekst.Add(new Tursu(2));
            }
            if (chbDomates.Checked)
            {
                ekst.Add(new Domates(0.5F));
            }
            if (chbBarbeku.Checked)
            {
                ekst.Add(new Barbeku(1));
            }
            if (chbHardal.Checked)
            {
                ekst.Add(new Hardal(1));
            }
            if (chbKozdePatlican.Checked)
            {
                ekst.Add(new KozdePatlican(2));
            }
            float toplam = 0;
            foreach (Ekstralar item in ekst)
            {
                toplam += item.Fiyat;
            }
            toplam += float.Parse(cmbMenu.SelectedValue.ToString());
            toplam += float.Parse(cmbIcecek.SelectedValue.ToString());
            toplam *= float.Parse(nmrcAdet.Value.ToString());
            string ekstrasecilenler = "";
            for (int i = 0; i < ekst.Count; i++)
            {
                ekstrasecilenler += ekst[i].Ad + ",";
            }

            if (!ekstrasecilenler.Equals(""))
                ekstrasecilenler = "(" + ekstrasecilenler.Substring(0, ekstrasecilenler.Length - 1) + " ekstralarıyla). -->Fiyat: " + toplam;
            else
                ekstrasecilenler = ".  --->Fiyat: " + toplam;
            lstSiparisler.Items.Add(cmbMenu.Text + " ile " + cmbIcecek.Text + (rdbTam.Checked ? " Tam" : " Yarım") + " boyunda" + ekstrasecilenler);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            ToplamFiyatHesapla();
        }
        //Siparişin tutarını hesaplayıp textbox a yazdırıyorum
        void ToplamFiyatHesapla()
        {
            List<Ekstralar> ekst = new List<Ekstralar>();
            if (chbPatates.Checked)
            {
                ekst.Add(new Patates(2));
            }
            if (chbSalatalık.Checked)
            {
                ekst.Add(new Salatalik(0.5F));
            }
            if (chbTursu.Checked)
            {
                ekst.Add(new Tursu(2));
            }
            if (chbDomates.Checked)
            {
                ekst.Add(new Domates(0.5F));
            }
            if (chbBarbeku.Checked)
            {
                ekst.Add(new Barbeku(1));
            }
            if (chbHardal.Checked)
            {
                ekst.Add(new Hardal(1));
            }
            if (chbKozdePatlican.Checked)
            {
                ekst.Add(new KozdePatlican(2));
            }
            float toplam = 0;
            foreach (Ekstralar item in ekst)
            {
                toplam += item.Fiyat;
            }
            toplam += float.Parse(cmbMenu.SelectedValue.ToString());
            toplam += float.Parse(cmbIcecek.SelectedValue.ToString());
            toplam *= float.Parse(nmrcAdet.Value.ToString());
            txtTutar.Text = toplam.ToString();
        }
        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            SiparisTamamla();
        }
        //Siparişi tamamlayıp mesaj gösteren kısmı yazıyorum
        void SiparisTamamla()
        {
            double toplam = 0;
            for (int i = 0; i < lstSiparisler.Items.Count; i++)
            {
                toplam += float.Parse(lstSiparisler.Items[i].ToString().Split('>')[1].Split(':')[1]);
            }
            MessageBox.Show(lstSiparisler.Items.Count + " tane siparişiniz hazır.\nToplam hesabınız : " + toplam + "\nAfiyet olsun :)");

        }
    }
}
