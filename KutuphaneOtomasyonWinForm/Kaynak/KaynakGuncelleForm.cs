using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.Kaynak
{
    public partial class KaynakGuncelleForm : Form
    {
        public KaynakGuncelleForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void Listele()
        {
            var kaynaklar = db.KaynaklarTab.ToList();
            dataGridKaynakGuncelleView.DataSource = kaynaklar.ToList();
        }

        private void KaynakGuncelleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridKaynakGuncelleView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kaynakAdGuncelletxt.Text = dataGridKaynakGuncelleView.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
