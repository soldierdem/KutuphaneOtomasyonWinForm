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

        int buttonClickCount4 = 0;


        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            ekleKullaniciBtn.Visible = false;
            guncelleKullaniciBtn.Visible = false;
            silKullaniciBtn.Visible = false;
            //dataGridViewKullanicilar.Visible = false;        
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

                KullaniciListeForm kullaniciListeForm = new KullaniciListeForm();
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
    }
}
