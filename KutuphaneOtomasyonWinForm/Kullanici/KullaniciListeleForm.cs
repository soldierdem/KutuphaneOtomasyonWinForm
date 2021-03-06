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
    public partial class KullaniciListeleForm : Form
    {
        public KullaniciListeleForm()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
            var kullanicilar = db.KullanicilarTab.ToList();
            dataGridKullanicilarView.DataSource = kullanicilar.ToList();
        }

        private void KullaniciListeForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
