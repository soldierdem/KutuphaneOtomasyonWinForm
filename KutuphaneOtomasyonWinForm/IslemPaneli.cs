using KutuphaneOtomasyonWinForm.Kaynak;
using KutuphaneOtomasyonWinForm.Kitap;
using KutuphaneOtomasyonWinForm.Kullanici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm
{
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }

        int buttonClickCount = 0;
        int buttonClickCount2 = 0;
        int buttonClickCount3 = 0;
        int buttonClickCount4 = 0;
        int buttonClickCount5 = 0;
        int buttonClickCount6 = 0;




        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            //Kullanici butonları başlangıçta kapalıdır.(ekle-güncelle-sil)
            ekleKullaniciBtn.Visible = false;
            guncelleKullaniciBtn.Visible = false;
            silKullaniciBtn.Visible = false;
            //dataGridViewKullanicilar.Visible = false;

            //Kitap butonları başlangıçta kapalıdır.(ekle-güncelle-sil)
            ekleKaynakBtn.Visible = false;
            guncelleKaynakBtn.Visible = false;
            silKaynakBtn.Visible = false;
        }


        private void kullanicilarBtn_Click(object sender, EventArgs e)
        {

            if (ekleKullaniciBtn.Visible == false)
            {
                ekleKullaniciBtn.Visible = true;
                guncelleKullaniciBtn.Visible = true;
                silKullaniciBtn.Visible = true;
            }
            else
            {
                ekleKullaniciBtn.Visible = false;
                guncelleKullaniciBtn.Visible = false;
                silKullaniciBtn.Visible = false;
            }


            if (buttonClickCount == 0)
            {
                buttonClickCount += 1;

                KullaniciListeleForm kullaniciListeForm = new KullaniciListeleForm();
                kullaniciListeForm.MdiParent = this;
                kullaniciListeForm.Show();
            }


            //dataGridViewKullanicilar.Visible = true;

            //var kullanicilar = db.KullanicilarTab.ToList();
            //dataGridViewKullanicilar.DataSource = kullanicilar.ToList();
        }

        private void ekleKullaniciBtn_Click(object sender, EventArgs e)
        {

            if (buttonClickCount2 == 0)
            {
                buttonClickCount2 += 1;

                KullaniciEkleForm kullaniciEkleForm = new KullaniciEkleForm();
                kullaniciEkleForm.MdiParent = this;
                kullaniciEkleForm.Show();
            }
        }

        private void guncelleKullaniciBtn_Click(object sender, EventArgs e)
        {
            if(buttonClickCount3 == 0)
            {
                buttonClickCount3 += 1;

                KullaniciGuncelleForm kullaniciGuncelleForm = new KullaniciGuncelleForm();
                kullaniciGuncelleForm.MdiParent = this;
                kullaniciGuncelleForm.Show();
            }
        }

        private void silKullaniciBtn_Click(object sender, EventArgs e)
        {
            if (buttonClickCount4 == 0)
            {
                buttonClickCount4 += 1;

                KullaniciSilForm kullaniciSilForm = new KullaniciSilForm();
                kullaniciSilForm.MdiParent = this;
                kullaniciSilForm.Show();
            }
        }

        private void kaynaklarBtn_Click(object sender, EventArgs e)
        {
            if (ekleKaynakBtn.Visible == false)
            {
                ekleKaynakBtn.Visible = true;
                guncelleKaynakBtn.Visible = true;
                silKaynakBtn.Visible = true;
            }
            else
            {
                ekleKaynakBtn.Visible = false;
                guncelleKaynakBtn.Visible = false;
                silKaynakBtn.Visible = false;
            }

            if (buttonClickCount5 == 0)
            {
                buttonClickCount5 += 1;

                KaynakListeleForm kaynakListeleForm = new KaynakListeleForm();
                kaynakListeleForm.MdiParent = this;
                kaynakListeleForm.Show();
            }
        }

        private void ekleKaynakBtn_Click(object sender, EventArgs e)
        {
            if (buttonClickCount6 == 0)
            {
                buttonClickCount6 += 1;

                KaynakEkleForm kaynakEkleForm = new KaynakEkleForm();
                kaynakEkleForm.MdiParent = this;
                kaynakEkleForm.Show();
            }
        }

        private void guncelleKaynakBtn_Click(object sender, EventArgs e)
        {
            KaynakGuncelleForm kaynakGuncelleForm = new KaynakGuncelleForm();
            kaynakGuncelleForm.MdiParent = this;
            kaynakGuncelleForm.Show();
        }

        private void silKaynakBtn_Click(object sender, EventArgs e)
        {
            KaynakSilForm kaynakSilForm = new KaynakSilForm();
            kaynakSilForm.MdiParent = this;
            kaynakSilForm.Show();
        }

        
    }
}
