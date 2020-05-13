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

namespace BankaTest
{
    public partial class Faiz : Form2
    {
    
    public Faiz()
        {
            InitializeComponent();
        }

        //Hesapla butonuna bastığımızda gerekli işlenmleri yapabilmesi için
        private void BtnHesaplaFaiz_Click(object sender, EventArgs e)
        {
            //Süre'yi ay olarak tanımladık
            double AnaPara, FaizOrani, Sure, Faiz, NetFaiz, Vergi;

            AnaPara = Convert.ToDouble(TxtAnapara.Text);
            FaizOrani = Convert.ToDouble(TxtFaizOrani.Text);
            Sure = Convert.ToDouble(TxtSure.Text);

            try
            {
                TxtFaiz.Text = (double.Parse(TxtAnapara.Text) * double.Parse(TxtFaizOrani.Text) * double.Parse(TxtSure.Text) / 1200).ToString();
            }
            catch (Exception)
            {

            }
            Faiz = 0;
            Vergi = Faiz * 0.15;

            NetFaiz = Faiz - Vergi;

            LblFaiz.Text = Convert.ToString(Faiz);

            LblVergi.Text = Convert.ToString(Vergi);

            LblNetFaiz.Text = Convert.ToString(NetFaiz);
        }
    }
    
}
