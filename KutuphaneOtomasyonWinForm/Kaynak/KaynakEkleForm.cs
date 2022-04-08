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
    public partial class KaynakEkleForm : Form
    {
        public KaynakEkleForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void kaynakEkleKaydetBtn_Click(object sender, EventArgs e)
        {
            KaynaklarTab kaynaklarTab = new KaynaklarTab();
            kaynaklarTab.kaynak_Ad = kaynakAdEkletxt.Text;
            kaynaklarTab.kaynak_Yazar = kaynakYazarEkletxt.Text;
            kaynaklarTab.kaynak_Yayinci = kaynakYayinciEkletxt.Text;
            kaynaklarTab.kaynak_SayfaSayisi = Convert.ToInt32(kaynakSayfaSayisiEkle.Value);
            kaynaklarTab.kaynak_BasimTarihi = kaynakTarihEkle.Value;

            db.KaynaklarTab.Add(kaynaklarTab);
            db.SaveChanges();

            var kliste = db.KaynaklarTab.ToList();
            dataGridKaynakEkleView.DataSource = kliste.ToList();
        }
    }
}
