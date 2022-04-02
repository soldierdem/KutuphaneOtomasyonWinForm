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
    public partial class KullaniciSilForm : Form
    {
        public KullaniciSilForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        public void Listele()
        {
            var kullanicilar = db.KullanicilarTab.ToList();
            dataGridSilView.DataSource = kullanicilar.ToList();
        }

        private void KullaniciSilForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void kullaniciSilKaydetBtn_Click(object sender, EventArgs e)
        {
            int secilenID = Convert.ToInt32(dataGridSilView.CurrentRow.Cells[0].Value);
            var kullanici = db.KullanicilarTab.Where(x => x.kullanici_ID == secilenID).FirstOrDefault();
            db.KullanicilarTab.Remove(kullanici);
            db.SaveChanges();
            Listele();
        }

        
    }
}
