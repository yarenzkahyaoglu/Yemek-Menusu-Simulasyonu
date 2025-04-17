/*******************************************************************************************************************
**					SAKARYA �N�VERS�TES�
**				B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**				    B�LG�SAYAR M�HEND�SL��� B�L�M�
**				   NESNEYE DAYALI PROGRAMLAMA DERS�
**					2024-2025 BAHAR D�NEM�
**	
**				�DEV NUMARASI..........: 1
**				��RENC� ADI............: Yaren Naz KAHYAO�LU
**				��RENC� NUMARASI.......: B241210094
**              DERS�N ALINDI�I GRUP...: 1.��retim C grubu
******************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace B241210094_BaharOdevi1
{
    public partial class Form1 : Form
    {
        Menu m = new Menu(); //menu nesnesini olu�turuyorum

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //combobox i�ine gelecek kategorileri yaz�yorum
            comboBox1.Items.Add("Meyve");
            comboBox1.Items.Add("Salata");
            comboBox1.Items.Add("Tatl�");
            comboBox1.Items.Add("��ecek");
            comboBox1.SelectedIndex = 0; //varsay�lan eleman se�ili olmas� i�in
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // e�er bo� ise giri� kontrolleri yap�yorum
                if (string.IsNullOrWhiteSpace(txtAdi.Text) ||
                    string.IsNullOrWhiteSpace(txtCins.Text) ||
                    string.IsNullOrWhiteSpace(txtFiyat.Text) ||
                    string.IsNullOrWhiteSpace(txtKdv.Text) ||
                    string.IsNullOrWhiteSpace(txtKalori.Text))
                {
                    MessageBox.Show("L�tfen t�m alanlar� doldurunuz!");
                    return;
                }
                //kullan�c�dan al�nan de�erli de�i�kenlere at�yorum
                string adi = txtAdi.Text;
                string cins = txtCins.Text;
                double fiyat = Convert.ToDouble(txtFiyat.Text);
                double kdvOrani = Convert.ToDouble(txtKdv.Text);
                int kalori = Convert.ToInt32(txtKalori.Text);

                // KDVli fiyat hesaplamak i�in
                double kdvliFiyat = fiyat * (1 + kdvOrani / 100);


                // fiyat ve kalori kontrol� i�in(negatiflik)
                if (fiyat <= 0 || kalori <= 0)
                {
                    MessageBox.Show("Fiyat ve kalori pozitif de�er olmal�d�r!");
                    return;
                }
                // kullan�c�n�n se�ti�i yiyecek kategori g�re uygun s�n�f� olu�turmak ve men�ye eklemek i�in
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Meyve":
                        m.Ekle(new Meyve(adi, cins, kdvliFiyat, kdvOrani, kalori));
                        break;
                    case "Tatl�":
                        m.Ekle(new Meyve(adi, cins, kdvliFiyat, kdvOrani, kalori));
                        break;
                    case "��ecek":
                        m.Ekle(new Meyve(adi, cins, kdvliFiyat, kdvOrani, kalori));
                        break;
                    case "Salata":
                        m.Ekle(new Meyve(adi, cins, kdvliFiyat, kdvOrani, kalori));
                        break;
                }

                Listele();

                // alanlar� temizlemek i�in
                txtAdi.Clear();
                txtCins.Clear();
                txtFiyat.Clear();
                txtKdv.Clear();
                txtKalori.Clear();
                txtAdi.Focus();
            }
            //try catch methodu ile hata olmamas� i�in koydum.
            catch (FormatException)
            {
                MessageBox.Show("Ge�ersiz say� format�! L�tfen do�ru formatta girin.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata olu�tu: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e) //silme butonu i�in event atad�m
        {
            if (listBox1.SelectedIndex != -1) //e�er se�ilmi�se sil
            {
                m.Sil(listBox1.SelectedIndex);
                Listele();
            }
            else
            {
                MessageBox.Show("Men�den silinecek ��e se�iniz!");
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
                toplamFiyat += item.fiyat; //yiyeceklerin fiyatlar�n� toplamak i�in

                // kalorileri hesaplamak i�in
                if (item is Yiyecek yiyecek)
                {
                    if (yiyecek is Meyve meyve) toplamKalori += meyve.kalori;
                    else if (yiyecek is Salata salata) toplamKalori += salata.kalori;
                    else if (yiyecek is Tatli tatli) toplamKalori += tatli.kalori;
                    else if (yiyecek is Icecek icecek) toplamKalori += icecek.kalori;
                }
            }
            //toplam kalori ve fiyat� yazd�rmak i�in
            lblFiyatToplam.Text = $"Toplam Fiyat (KDV Dahil): {toplamFiyat:C2}";
            lblKaloriToplam.Text = $"Toplam Kalori: {toplamKalori} kcal";

            //uyar� mesajlar�
            if (toplamFiyat > 500)
            {
                MessageBox.Show($"Uyar�: Fiyat limiti a��ld�!\nToplam Fiyat: {toplamFiyat:C2} (Max: 500)");
            }
            if (toplamKalori > 1000)
            {
                MessageBox.Show($"Uyar�: Kalori limiti a��ld�!\nToplam Kalori: {toplamKalori} (Max: 1000)");
            }
        }
        //listeledi�imiz men� bilgilerini yazd�rmak i�in butona event at�yorum
        private void btnMenuGoster_Click(object sender, EventArgs e)
        {
            if (m.MenuYazdir().Count == 0)
            {
                MessageBox.Show("Men� �u an bo�!", "Men� Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string menuMetni = "Men�:\n\n";
            double toplamFiyat = 0;
            int toplamKalori = 0;

            foreach (var item in m.MenuYazdir())
            {
                menuMetni += item.Yazdir() + "\n";
                toplamFiyat += item.fiyat;

                // kalori bilgisi i�in kontrol
                if (item is Yiyecek yiyecek)
                {
                    if (yiyecek is Meyve meyve) toplamKalori += meyve.kalori;
                    else if (yiyecek is Salata salata) toplamKalori += salata.kalori;
                    else if (yiyecek is Tatli tatli) toplamKalori += tatli.kalori;
                    else if (yiyecek is Icecek icecek) toplamKalori += icecek.kalori;
                }
            }

            // toplam bilgilerini eklemek i�in
            menuMetni += "\n-------------------------------\n";
            menuMetni += $"Toplam Tutar: {toplamFiyat:C2}\n";
            menuMetni += $"Toplam Kalori: {toplamKalori} kcal";

            MessageBox.Show(menuMetni, "Men� ��eri�i", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    //yiyecek s�n�f�n� tan�ml�yorum parametleri ekliyorum
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
        //bilgileri listboxa yazd�rmak i�in fonksiyon
        public virtual string Yazdir()
        {
            return $"{adi,-9} {cins,-9} {fiyat,6:C2} {kdvOrani,2}% KDV";
        }
    }
    //yiyecek s�n�f�ndan t�retilmi� alt s�n�flar� tan�ml�yorum
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
    // men� s�n�f� yiyecekleri liste halinde tutar
    class Menu
    {
        private List<Yiyecek> liste = new List<Yiyecek>();
        // men�ye yeni bir yiyecek ekler.
        public void Ekle(Yiyecek y)
        {
            liste.Add(y);
        }

        public void Sil(int index)
        {
            if (index >= 0 && index < liste.Count)
                liste.RemoveAt(index);
        }
        //men�dekileri listeye d�nd�r�r.
        public List<Yiyecek> MenuYazdir()
        {
            return liste;
        }
    }
}