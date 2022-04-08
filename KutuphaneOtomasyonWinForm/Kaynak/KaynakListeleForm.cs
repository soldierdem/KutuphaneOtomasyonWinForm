using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.Kitap
{
    public partial class KaynakListeleForm : Form
    {
        public KaynakListeleForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        public void Listele()
        {
            var kaynaklar = db.KaynaklarTab.ToList();
            dataGridKaynaklarView.DataSource = kaynaklar.ToList();
        }

        private void KaynakListeleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
