using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace omrYild
{
    public partial class seferguncelle : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=omer.accdb");
        DataTable dt = new DataTable();
        public seferguncelle()
        {
            InitializeComponent();
        }
        private void seferguncelle_Load(object sender, EventArgs e)
        {
            guncelcombodoldur();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (!guncelcmbOtobus.Text.Equals("") && !guncelcmbGuzergah.Text.Equals("") && !guncelcmbKoltuk.Text.Equals("") && !guncelcmbSaat.Text.Equals("") && !guncelcmbDakika.Text.Equals("") && gunceltxtSeferSayi.Text != "" && gunceltxtPeron.Text != "")
            {
                try
                {
                    string saat = guncelcmbSaat.Text + " : " + guncelcmbDakika.Text;
                    baglan.Open();
                    OleDbCommand kmt = new OleDbCommand();
                    kmt.Connection = baglan;
                    kmt.CommandText = "UPDATE sefer SET hareketTarihi=@hareketTarihi,hareketSaati=@hareketSaati,hareketSaat=@hareketSaat,hareketDakika=@hareketDakika,seferSayi=@SeferSayisi,peron=@peron,otobusPlakasi=@otobusPlakasi,guzergahi=@guzergahi,soforAdSoyadi=@soforAdSoyadi,koltukTuru=@koltukTuru WHERE id=@id";
                    kmt.Parameters.AddWithValue("@hareketTarihi", Convert.ToDateTime(guncelseferTarihi.Text));
                    kmt.Parameters.AddWithValue("@hareketSaati", saat);
                    kmt.Parameters.AddWithValue("@hareketSaat", guncelcmbSaat.Text);
                    kmt.Parameters.AddWithValue("@hareketDakika", guncelcmbDakika.Text);
                    kmt.Parameters.AddWithValue("@SeferSayisi", gunceltxtSeferSayi.Text.ToString());
                    kmt.Parameters.AddWithValue("@peron", gunceltxtPeron.Text);
                    kmt.Parameters.AddWithValue("@otobusPlakasi", guncelcmbOtobus.Text);
                    kmt.Parameters.AddWithValue("@guzergahi", guncelcmbGuzergah.Text);
                    kmt.Parameters.AddWithValue("@soforAdSoyadi", guncelcmbSofor.Text);
                    kmt.Parameters.AddWithValue("@koltukTuru", guncelcmbKoltuk.Text);
                    kmt.Parameters.AddWithValue("@id", txtSeferid.Text);
                    kmt.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Başarıyla Güncellendi !", "İşlem Tamam !.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    yonlendir();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın !", "Uyarı !.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            yonlendir();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Seferi Silmek İstiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                baglan.Open();
                OleDbCommand kmt = new OleDbCommand();
                kmt.Connection = baglan;
                kmt.CommandText = "DELETE FROM sefer WHERE id=@id";
                kmt.Parameters.AddWithValue("@id", txtSeferid.Text);
                kmt.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Silme İşlemi Tamamlandı!.");
                yonlendir();
            }
        }
        private void guncelsaatdoldur()
        {
            guncelcmbSaat.Items.Clear();
            string sifir = "0";
            for (int i = 1; i < 25; i++)
            {
                if (i.ToString().Length >= 2)
                {
                    guncelcmbSaat.Items.Add(i);
                }
                else if (i.ToString().Length < 2)
                {
                    guncelcmbSaat.Items.Add(sifir + i);
                }
            }
        }
        private void gunceldakikadoldur()
        {
            guncelcmbDakika.Items.Clear();
            string sifir = "0";
            for (int i = 0; i < 60; i++)
            {
                if (i.ToString().Length >= 2)
                {
                    guncelcmbDakika.Items.Add(i);
                }
                else if (i.ToString().Length < 2)
                {
                    guncelcmbDakika.Items.Add(sifir + i);
                }
            }
        }
        private void guncelkoltuktipdoldur()
        {
            guncelcmbKoltuk.Items.Clear();
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT koltukTuru FROM koltukturu ORDER BY koltukTuru ASC";
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                guncelcmbKoltuk.Items.Add(yukle["koltukTuru"]);
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void guncelguzergahdoldur()
        {
            guncelcmbGuzergah.Items.Clear();
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT guzergah FROM guzergah ORDER BY guzergah ASC";
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                guncelcmbGuzergah.Items.Add(yukle["guzergah"]);
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void guncelotobusdoldur()
        {
            guncelcmbOtobus.Items.Clear();
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT plakasi FROM otobus ORDER BY plakasi ASC";
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                guncelcmbOtobus.Items.Add(yukle["plakasi"]);
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void guncelsofordoldur()
        {
            guncelcmbSofor.Items.Clear();
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT soforAdSoyadi FROM sofor ORDER BY soforAdSoyadi ASC";
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                guncelcmbSofor.Items.Add(yukle["soforAdSoyadi"]);
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void guncelcombodoldur()
        {
            guncelkoltuktipdoldur();
            guncelsaatdoldur();
            gunceldakikadoldur();
            guncelguzergahdoldur();
            guncelotobusdoldur();
            guncelsofordoldur();
        }
        private void temizlik()
        {
            foreach (TextBox txtbx in Controls.OfType<TextBox>())
            {
                txtbx.Clear();
            }
            guncelcmbDakika.Text = "";
            guncelcmbSaat.Text = "";
        }
        private void yonlendir()
        {
            temizlik();
            yenisefer ysefer = new yenisefer();
            ysefer.Show();
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
