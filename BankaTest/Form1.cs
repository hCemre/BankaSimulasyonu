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
  
     partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=HASAR-1;Initial Catalog=DbBankaTest;Integrated Security=True");
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void LnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           //Kayıt ol'a tıklandığında form3'e yönlendirmek için
            Form3 frm = new Form3();
            frm.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From TBLKISILER where hesapno=@p1 and sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", MskHesapNo.Text);
            komut.Parameters.AddWithValue("@p2",TxtSifre.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
                {
                    Form2 fr = new Form2();
                    fr.hesap = MskHesapNo.Text;
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Hesap Bilgileri");
                }
            baglanti.Close();
        }


     }
}
