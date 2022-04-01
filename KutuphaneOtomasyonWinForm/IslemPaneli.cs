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

        }
    }
}
