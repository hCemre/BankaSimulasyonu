/*****************************************************************
 **              SAKARYA ÜNİVERSİTESİ
 **        BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 **         BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
 **           NESNEYE DAYALI PROGRAMLAMA DERSİ
 **               2019-2020 BAHAR DÖNEMİ
 **
 **         ÖĞRENCİ NUMARASI: B191200035
 **         ÖĞRENCİ ADI: HAKİME CEMRE ÖNER
 ****************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BankaTest
{
    partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti= new SqlConnection ("Data Source=HASAR-1;Initial Catalog=DbBankaTest;Integrated Security=True");
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKISILER (Ad,Soyad,TC,Telefon,HesapNo,Sifre) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTc.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", MskHesapNo.Text);
            komut.Parameters.AddWithValue("@p6", TxtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi");
        }

        private void BtnHesapNo_Click(object sender, EventArgs e)
        {
            //Rastgele hesap numarası getirmesi için random sınıfından rastgele bir nesne türettim
            Random rastgele = new Random();
            int sayi = rastgele.Next(100000,1000000);
           MskHesapNo.Text = sayi.ToString();
           //Eğer atanan hesap numarası veritabanında varsa sayının değiştirilmesini sağlar
            try
            {
                MskHesapNo.Text= sayi.ToString();
            }
            catch
            {
                MessageBox.Show("Bu Hesap Numarası Sistemde Mevcut");
            }
            finally
            {
                Random random = new Random();
                int yenisayi = random.Next(100000,1000000);
                MskHesapNo.Text = sayi.ToString();
            }

        }

        private void MskHesapNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        { 

        }
        
    }
}
