using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.Kullanici
{
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        public void Listele()
        {
            var kullanicilar = db.KullanicilarTab.ToList();
            dataGridKullaniciEkleView.DataSource = kullanicilar.ToList();
        }

        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void kullaniciEkleKaydetBtn_Click(object sender, EventArgs e)
        {
            KullanicilarTab kullanicilarTab = new KullanicilarTab();


            kullanicilarTab.kullanici_Ad = kullaniciAdEkletxt.Text;
            kullanicilarTab.kullanici_Soyad = kullaniciSoyadEkletxt.Text;

            if (radioErkek.Checked == true)
            {
                kullanicilarTab.kullanici_Cinsiyet = "E";
            }
            else if(radioKadin.Checked == true)
            {
                kullanicilarTab.kullanici_Cinsiyet = "K";
            }
            else
            {
                MessageBox.Show("Cinsiyet boş geçilemez...");
            }

            kullanicilarTab.kullanici_TC = kullaniciTCEkletxt.Text;
            kullanicilarTab.kullanici_Tel = kullaniciTelEkletxt.Text;
            kullanicilarTab.kullanici_Mail = kullaniciMailEkletxt.Text;
            kullanicilarTab.kullanici_Ceza = Convert.ToDouble(kullaniciCezaEkletxt.Text);

            db.KullanicilarTab.Add(kullanicilarTab);
            db.SaveChanges();
            Listele();
        }

    }
}
