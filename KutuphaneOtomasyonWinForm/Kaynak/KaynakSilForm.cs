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
    public partial class KaynakSilForm : Form
    {
        public KaynakSilForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public void Listele()
        {
            var kaynaklarTab = db.KaynaklarTab;
            dataGridKaynakSilView.DataSource = kaynaklarTab.ToList();
        }

        private void KaynakSilForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void kaynakSilKaydetBtn_Click(object sender, EventArgs e)
        {
            int secilenID = Convert.ToInt32(dataGridKaynakSilView.CurrentRow.Cells[0].Value);
            var silinenKaynak = db.KaynaklarTab.Where(x => x.kaynak_ID == secilenID).FirstOrDefault();
            db.KaynaklarTab.Remove(silinenKaynak);
            db.SaveChanges();

            Listele();

        }
    }
}
