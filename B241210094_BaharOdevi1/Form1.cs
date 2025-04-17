/*******************************************************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**				BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					2024-2025 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖÐRENCÝ ADI............: Yaren Naz KAHYAOÐLU
**				ÖÐRENCÝ NUMARASI.......: B241210094
**              DERSÝN ALINDIÐI GRUP...: 1.Öðretim C grubu
******************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace B241210094_BaharOdevi1
{
    public partial class Form1 : Form
    {
        Menu m = new Menu(); //menu nesnesini oluþturuyorum

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //combobox içine gelecek kategorileri yazýyorum
            comboBox1.Items.Add("Meyve");
            comboBox1.Items.Add("Salata");
            comboBox1.Items.Add("Tatlý");
            comboBox1.Items.Add("Ýçecek");
            comboBox1.SelectedIndex = 0; //varsayýlan eleman seçili olmasý için
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // eðer boþ ise giriþ kontrolleri yapýyorum
                if (string.IsNullOrWhiteSpace(txtAdi.Text) ||
                    string.IsNullOrWhiteSpace(txtCins.Text) ||
                    string.IsNullOrWhiteSpace(txtFiyat.Text) ||
                    string.IsNullOrWhiteSpace(txtKdv.Text) ||
                    string.IsNullOrWhiteSpace(txtKalori.Text))
                {
                    MessageBox.Show("Lütfen tüm alanlarý doldurunuz!");
                    return;
                }
                //kullanýcýdan alýnan deðerli deðiþkenlere atýyorum
                string adi = txtAdi.Text;
                string cins = txtCins.Text;
                double fiyat = Convert.ToDouble(txtFiyat.Text);
                double kdvOrani = Convert.ToDouble(txtKdv.Text);
                int kalori = Convert.ToInt32(txtKalori.Text);

                // KDVli fiyat hesaplamak için
                double kdvliFiyat = fiyat * (1 + kdvOrani / 100);


                // fiyat ve kalori kontrolü için(negatiflik)
                if (fiyat <= 0 || kalori <= 0)
                {
                    MessageBox.Show("Fiyat ve kalori pozitif deðer olmalýdýr!");
                    return;
                }
                // kullanýcýnýn seçtiði yiyecek kategori göre uygun sýnýfý oluþturmak ve menüye eklemek için
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Meyve":
                        m.Ekle(new Meyve(adi, cins, kdvliFiyat, kdvOrani, kalori));
                        break;
                    case "Tatlý":
                        m.Ekle(new Meyve(adi, cins, kdvliFiyat, kdvOrani, kalori));
                        break;
                    case "Ýçecek":
                        m.Ekle(new Meyve(adi, cins, kdvliFiyat, kdvOrani, kalori));
                        break;
                    case "Salata":
                        m.Ekle(new Meyve(adi, cins, kdvliFiyat, kdvOrani, kalori));
                        break;
                }

                Listele();

                // alanlarý temizlemek için
                txtAdi.Clear();
                txtCins.Clear();
                txtFiyat.Clear();
                txtKdv.Clear();
                txtKalori.Clear();
                txtAdi.Focus();
            }
            //try catch methodu ile hata olmamasý için koydum.
            catch (FormatException)
            {
                MessageBox.Show("Geçersiz sayý formatý! Lütfen doðru formatta girin.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluþtu: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e) //silme butonu için event atadým
        {
            if (listBox1.SelectedIndex != -1) //eðer seçilmiþse sil
            {
                m.Sil(listBox1.SelectedIndex);
                Listele();
            }
            else
            {
                MessageBox.Show("Menüden silinecek öðe seçiniz!");
            }
        }

        private void Listele()
        {
            listBox1.Items.Clear(); //listeyi temizle
            double toplamFiyat = 0;
            int toplamKalori = 0;

            foreach (var item in m.MenuYazdir())
            {
                listBox1.Items.Add(item.Yazdir());
                toplamFiyat += item.fiyat; //yiyeceklerin fiyatlarýný toplamak için

                // kalorileri hesaplamak için
                if (item is Yiyecek yiyecek)
                {
                    if (yiyecek is Meyve meyve) toplamKalori += meyve.kalori;
                    else if (yiyecek is Salata salata) toplamKalori += salata.kalori;
                    else if (yiyecek is Tatli tatli) toplamKalori += tatli.kalori;
                    else if (yiyecek is Icecek icecek) toplamKalori += icecek.kalori;
                }
            }
            //toplam kalori ve fiyatý yazdýrmak için
            lblFiyatToplam.Text = $"Toplam Fiyat (KDV Dahil): {toplamFiyat:C2}";
            lblKaloriToplam.Text = $"Toplam Kalori: {toplamKalori} kcal";

            //uyarý mesajlarý
            if (toplamFiyat > 500)
            {
                MessageBox.Show($"Uyarý: Fiyat limiti aþýldý!\nToplam Fiyat: {toplamFiyat:C2} (Max: 500)");
            }
            if (toplamKalori > 1000)
            {
                MessageBox.Show($"Uyarý: Kalori limiti aþýldý!\nToplam Kalori: {toplamKalori} (Max: 1000)");
            }
        }
        //listelediðimiz menü bilgilerini yazdýrmak için butona event atýyorum
        private void btnMenuGoster_Click(object sender, EventArgs e)
        {
            if (m.MenuYazdir().Count == 0)
            {
                MessageBox.Show("Menü þu an boþ!", "Menü Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string menuMetni = "Menü:\n\n";
            double toplamFiyat = 0;
            int toplamKalori = 0;

            foreach (var item in m.MenuYazdir())
            {
                menuMetni += item.Yazdir() + "\n";
                toplamFiyat += item.fiyat;

                // kalori bilgisi için kontrol
                if (item is Yiyecek yiyecek)
                {
                    if (yiyecek is Meyve meyve) toplamKalori += meyve.kalori;
                    else if (yiyecek is Salata salata) toplamKalori += salata.kalori;
                    else if (yiyecek is Tatli tatli) toplamKalori += tatli.kalori;
                    else if (yiyecek is Icecek icecek) toplamKalori += icecek.kalori;
                }
            }

            // toplam bilgilerini eklemek için
            menuMetni += "\n-------------------------------\n";
            menuMetni += $"Toplam Tutar: {toplamFiyat:C2}\n";
            menuMetni += $"Toplam Kalori: {toplamKalori} kcal";

            MessageBox.Show(menuMetni, "Menü Ýçeriði", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    //yiyecek sýnýfýný tanýmlýyorum parametleri ekliyorum
    class Yiyecek
    {
        public string adi;
        public string cins;
        public double fiyat;
        public double kdvOrani;

        public Yiyecek(string a, string c, double f, double kdv)
        {
            adi = a;
            cins = c;
            fiyat = f;
            kdvOrani = kdv;
        }
        //bilgileri listboxa yazdýrmak için fonksiyon
        public virtual string Yazdir()
        {
            return $"{adi,-9} {cins,-9} {fiyat,6:C2} {kdvOrani,2}% KDV";
        }
    }
    //yiyecek sýnýfýndan türetilmiþ alt sýnýflarý tanýmlýyorum
    class Meyve : Yiyecek
    {
        public int kalori;
        public Meyve(string a, string c, double f, double kdv, int k) : base(a, c, f, kdv)
        {
            kalori = k;
        }

        public override string Yazdir()
        {
            return base.Yazdir() + $" {kalori,5} kcal";
        }
    }

    class Salata : Yiyecek
    {
        public int kalori;
        public Salata(string a, string c, double f, double kdv, int k) : base(a, c, f, kdv)
        {
            kalori = k;
        }

        public override string Yazdir()
        {
            return base.Yazdir() + $" {kalori,5} kcal";
        }
    }

    class Tatli : Yiyecek
    {
        public int kalori;
        public Tatli(string a, string c, double f, double kdv, int k) : base(a, c, f, kdv)
        {
            kalori = k;
        }

        public override string Yazdir()
        {
            return base.Yazdir() + $" {kalori,5} kcal";
        }
    }

    class Icecek : Yiyecek
    {
        public int kalori;
        public Icecek(string a, string c, double f, double kdv, int k) : base(a, c, f, kdv)
        {
            kalori = k;
        }

        public override string Yazdir()
        {
            return base.Yazdir() + $" {kalori,5} kcal";
        }
    }
    // menü sýnýfý yiyecekleri liste halinde tutar
    class Menu
    {
        private List<Yiyecek> liste = new List<Yiyecek>();
        // menüye yeni bir yiyecek ekler.
        public void Ekle(Yiyecek y)
        {
            liste.Add(y);
        }

        public void Sil(int index)
        {
            if (index >= 0 && index < liste.Count)
                liste.RemoveAt(index);
        }
        //menüdekileri listeye döndürür.
        public List<Yiyecek> MenuYazdir()
        {
            return liste;
        }
    }
}