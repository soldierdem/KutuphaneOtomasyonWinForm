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
    public partial class Form1 : Form
    {
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void personelGirisBtn_Click(object sender, EventArgs e)
        {
            string gelenAd = personelAdGiristxt.Text;
            string gelenSifre = personelSifreGiristxt.Text;

            var personel = db.PersonellerTab.Where(
            sutun => sutun.personel_Ad.Equals(gelenAd) && sutun.personel_Sifre.Equals(gelenSifre)).FirstOrDefault();

            if(personel != null)
            {
                MessageBox.Show("Başarılı Giriş");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }

            /*
            if (gelenAd.Equals("admin") && gelenSifre.Equals("123"))
            {
                MessageBox.Show("Başarılı Giriş");
            }
            else 
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
            */
        }
    }
}
