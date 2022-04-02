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
    public partial class KullaniciGuncelleForm : Form
    {
        public KullaniciGuncelleForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        public void Listele()
        {
            var kullanicilar = db.KullanicilarTab.ToList();
            dataGridGuncelleView.DataSource = kullanicilar.ToList();
        }

        private void KullaniciGuncelleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridGuncelleView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kullaniciAdEkletxt.Text = dataGridGuncelleView.CurrentRow.Cells[1].Value.ToString();
            //ad 1. kolonda oyüzden cell değerini 1 yazdık
            kullaniciSoyadEkletxt.Text = dataGridGuncelleView.CurrentRow.Cells[2].Value.ToString();

            if (dataGridGuncelleView.CurrentRow.Cells[3].Value.ToString().Equals("E"))
            {
                radioErkek.Checked = true;
            }
            else if (dataGridGuncelleView.CurrentRow.Cells[3].Value.ToString().Equals("K"))
            {
                radioKadin.Checked = true;
            }

            kullaniciTCEkletxt.Text = dataGridGuncelleView.CurrentRow.Cells[4].Value.ToString();
            kullaniciTelEkletxt.Text = dataGridGuncelleView.CurrentRow.Cells[5].Value.ToString();
            kullaniciMailEkletxt.Text = dataGridGuncelleView.CurrentRow.Cells[6].Value.ToString();
           
        /*  if(dataGridGuncelleView.CurrentRow.Cells[7].Value.ToString() == null)
            {
                kullaniciCezaEkletxt.Text = "0";
            }
            else
            {
                kullaniciCezaEkletxt.Text = dataGridGuncelleView.CurrentRow.Cells[7].Value.ToString();
            }
        */
        }

        private void kullaniciEkleGuncelleBtn_Click(object sender, EventArgs e)
        {
            int secilenID = Convert.ToInt32(dataGridGuncelleView.CurrentRow.Cells[0].Value);
            var kullanici = db.KullanicilarTab.Where(x=>x.kullanici_ID == secilenID).FirstOrDefault();


            kullanici.kullanici_Ad = kullaniciAdEkletxt.Text;
            kullanici.kullanici_Soyad = kullaniciSoyadEkletxt.Text;

            if (radioErkek.Checked == true)
            {
                kullanici.kullanici_Cinsiyet = "E";
            }
            else if (radioKadin.Checked == true)
            {
                kullanici.kullanici_Cinsiyet = "K";
            }
            /*else
            {
                MessageBox.Show("Cinsiyet boş geçilemez...");
            }*/

            kullanici.kullanici_TC = kullaniciTCEkletxt.Text;
            kullanici.kullanici_Tel = kullaniciTelEkletxt.Text;
            kullanici.kullanici_Mail = kullaniciMailEkletxt.Text;
            kullanici.kullanici_Ceza = Convert.ToDouble(kullaniciCezaEkletxt.Text);

            db.SaveChanges();
            Listele();
        }
    }
}
