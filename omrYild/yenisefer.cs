using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace omrYild
{
    public partial class yenisefer : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=omer.accdb");
        DataTable dt = new DataTable();
        public yenisefer()
        {
            InitializeComponent();
        }
        private void yenisefer_Load(object sender, EventArgs e)
        {
            combobos();
            sefergrid.Columns[0].HeaderText = "Sefer";
            sefergrid.Columns[1].HeaderText = "Tarih";
            sefergrid.Columns[2].HeaderText = "Saat";
            sefergrid.Columns[3].HeaderText = "Güzergah";
            sefergrid.Columns[4].HeaderText = "Koltuk";
            sefergrid.Columns[5].HeaderText = "Plaka";
            sefergrid.Columns[6].HeaderText = "Şoför";
            sefergrid.Columns[0].Width = 70;
            sefergrid.Columns[1].Width = 90;
            sefergrid.Columns[2].Width = 80;
            sefergrid.Columns[3].Width = 220;
            sefergrid.Columns[4].Width = 70;
            sefergrid.Columns[5].Width = 107;
            sefergrid.Columns[6].Width = 160;
            sefergrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            sefergrid.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            sefergrid.DefaultCellStyle.SelectionBackColor = Color.Azure;
            sefergrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            sefergrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sefergrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sefergrid.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!cmbOtobus.Text.Equals("Seçiniz") && !cmbGuzegah.Text.Equals("Seçiniz") && !cmbKoltuk.Text.Equals("Seçiniz") && !cmbSaat.Text.Equals("Seçiniz") && !cmbDakika.Text.Equals("Seçiniz") && txtSeferSayi.Text != "" && txtPeron.Text != "")
            {
                try
                {
                    string saat = cmbSaat.Text + " : " + cmbDakika.Text;
                    baglan.Open();
                    OleDbCommand kmt = new OleDbCommand();
                    kmt.Connection = baglan;
                    kmt.CommandText = "INSERT INTO sefer (hareketTarihi,hareketSaati,hareketSaat,hareketDakika,seferSayi,peron,otobusPlakasi,guzergahi,soforAdSoyadi,koltukTuru) VALUES (@hareketTarihi,@hareketSaati,@hareketSaat,@hareketDakika,@seferSayi,@peron,@otobusPlakasi,@guzegahi,@soforAdSoyadi,@koltukTuru)";
                    kmt.Parameters.AddWithValue("@hareketTarihi", Convert.ToDateTime(seferTarihi.Text));
                    kmt.Parameters.AddWithValue("@hareketSaati", saat);
                    kmt.Parameters.AddWithValue("@hareketSaat", cmbSaat.Text);
                    kmt.Parameters.AddWithValue("@hareketDakika", cmbDakika.Text);
                    kmt.Parameters.AddWithValue("@SeferSayisi", txtSeferSayi.Text);
                    kmt.Parameters.AddWithValue("@peron", txtPeron.Text);
                    kmt.Parameters.AddWithValue("@otobusPlakasi", cmbOtobus.Text);
                    kmt.Parameters.AddWithValue("@guzergahi", cmbGuzegah.Text);
                    kmt.Parameters.AddWithValue("@soforAdSoyadi", cmbSofor.Text);
                    kmt.Parameters.AddWithValue("@koltukTuru", cmbKoltuk.Text);
                    kmt.ExecuteNonQuery();
                    baglan.Close();
                    combobos();
                    Form1 frm1 = new Form1();
                    int sefid = 1;
                    baglan.Open();
                    OleDbCommand sk = new OleDbCommand();
                    sk.Connection = baglan;
                    sk.CommandText = "UPDATE sonkayit SET sonKayit=@sonKayit WHERE id=@id";
                    sk.Parameters.AddWithValue("@sonKayit", txtSeferSayi.Text.ToString());
                    sk.Parameters.AddWithValue("@id", sefid.ToString());
                    sk.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Başarıyla Kayıt Yapıldı !", "İşlem Gerçekleşti !.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    frm1.Show();
                    temizlik();
                    Hide();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapılmamış Alanlar Var !", "Uyarı !.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            seferTarihi.Text = "";
            combobos();
        }
        private void btnYeniKapat_Click(object sender, EventArgs e)
        {
            temizlik();
            Form1 frm1 = new Form1();
            frm1.Show();
            Hide();
        }
        private void saatdoldur()
        {
            string sifir = "0";
            for (int i = 1; i < 25; i++)
            {
                if (i.ToString().Length >= 2)
                {
                    cmbSaat.Items.Add(i);
                }
                else if (i.ToString().Length < 2)
                {
                    cmbSaat.Items.Add(sifir + i);
                }
            }
        }
        private void dakikadoldur()
        {
            string sifir = "0";
            for (int i = 0; i < 60; i++)
            {
                if (i.ToString().Length >= 2)
                {
                    cmbDakika.Items.Add(i);
                }
                else if (i.ToString().Length < 2)
                {
                    cmbDakika.Items.Add(sifir + i);
                }
            }
        }
        private void koltuktipdoldur()
        {
            cmbKoltuk.Items.Clear();
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT koltukTuru FROM koltukturu ORDER BY koltukTuru ASC";
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                cmbKoltuk.Items.Add(yukle["koltukTuru"]);
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void guzergahdoldur()
        {
            cmbGuzegah.Items.Clear();
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT guzergah FROM guzergah ORDER BY guzergah ASC";
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                cmbGuzegah.Items.Add(yukle["guzergah"]);
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void otobusdoldur()
        {
            cmbOtobus.Items.Clear();
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT plakasi FROM otobus ORDER BY plakasi ASC";
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                cmbOtobus.Items.Add(yukle["plakasi"]);
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void sofordoldur()
        {
            cmbSofor.Items.Clear();
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT soforAdSoyadi FROM sofor ORDER BY soforAdSoyadi ASC";
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                cmbSofor.Items.Add(yukle["soforAdSoyadi"]);
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void combodoldur()
        {
            koltuktipdoldur();
            saatdoldur();
            dakikadoldur();
            guzergahdoldur();
            otobusdoldur();
            sofordoldur();
        }
        private void combobos()
        {
            cmbSaat.Text = "";
            cmbDakika.Text = "";
            cmbGuzegah.Text = "";
            cmbKoltuk.Text = "";
            cmbOtobus.Text = "";
            cmbSofor.Text = "";
            seferTarihi.Text = "";
            cmbSaat.SelectedText = "Seçiniz";
            cmbDakika.SelectedText = "Seçiniz";
            cmbGuzegah.SelectedText = "Seçiniz";
            cmbKoltuk.SelectedText = "Seçiniz";
            cmbOtobus.SelectedText = "Seçiniz";
            cmbSofor.SelectedText = "Seçiniz";
            combodoldur();
            sefersorgu();
            sefersayiyaz();
        }
        private void sefersayiyaz()
        {
            txtSeferSayi.Clear();
            int id = 1;
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT sonKayit FROM sonkayit WHERE id=@id";
            kmt.Parameters.AddWithValue("@id", id.ToString());
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                int son = yukle.GetInt32(0);
                son = son + 1;
                txtSeferSayi.Text = son.ToString();
            }
            baglan.Close();
            yukle.Dispose();
        }
        public void sefersorgu()
        {
            dt.Clear();
            OleDbDataAdapter dap = new OleDbDataAdapter("SELECT seferSayi,hareketTarihi,hareketSaati,guzergahi,koltukTuru,otobusPlakasi,soforAdSoyadi FROM sefer WHERE hareketTarihi=@hareketTarihi ORDER BY hareketSaati ASC", baglan);
            dap.SelectCommand.Parameters.AddWithValue("@hareketTarihi", seferTarihi.Value.ToShortDateString());
            dap.Fill(dt);
            sefergrid.DataSource = dt;
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            temizlik();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            temizlik();
            Form1 frm1 = new Form1();
            frm1.Show();
            Hide();
        }
        private void sefergrid_DoubleClick(object sender, EventArgs e)
        {
            seferguncelle sguncelle = new seferguncelle();
            sguncelle.gunceltxtSeferSayi.Text  = sefergrid.CurrentRow.Cells[0].Value.ToString();
            sguncelle.guncelseferTarihi.Text   = sefergrid.CurrentRow.Cells[1].Value.ToString();
            sguncelle.guncelcmbGuzergah.Text   = sefergrid.CurrentRow.Cells[3].Value.ToString();
            sguncelle.guncelcmbKoltuk.Text     = sefergrid.CurrentRow.Cells[4].Value.ToString();
            sguncelle.guncelcmbOtobus.Text     = sefergrid.CurrentRow.Cells[5].Value.ToString();
            sguncelle.guncelcmbSofor.Text      = sefergrid.CurrentRow.Cells[6].Value.ToString();
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT peron,id,hareketSaat,hareketDakika,hareketTarihi FROM sefer WHERE hareketTarihi = @Tarih AND guzergahi=@guzergahi AND seferSayi=@seferSayi";
            kmt.Parameters.AddWithValue("@Tarih", sguncelle.guncelseferTarihi.Value.ToShortDateString());
            kmt.Parameters.AddWithValue("@guzergahi", sguncelle.guncelcmbGuzergah.Text);
            kmt.Parameters.AddWithValue("@seferSayi", sefergrid.CurrentRow.Cells[0].Value.ToString());
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                string peron = yukle.GetString(0).ToString();
                string id    = yukle.GetInt32(1).ToString();
                sguncelle.gunceltxtPeron.Text = yukle["peron"].ToString();
                sguncelle.txtSeferid.Text     = yukle["id"].ToString();
                sguncelle.guncelseferTarihi.Text = Convert.ToDateTime(seferTarihi.Text).ToShortDateString();
                sguncelle.guncelcmbSaat.Text = yukle["hareketSaat"].ToString();
                sguncelle.guncelcmbDakika.Text = yukle["hareketDakika"].ToString();
                sguncelle.Show();
                Hide();
            }
            baglan.Close();
            yukle.Dispose();

        }
        private void temizlik()
        {
            foreach (TextBox txtbx in Controls.OfType<TextBox>())
            {
                txtbx.Clear();
            }
        }
        private void seferTarihi_ValueChanged(object sender, EventArgs e)
        {
            sefersorgu();
        }

        private void sefergrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            seferguncelle sguncelle = new seferguncelle();
            sguncelle.gunceltxtSeferSayi.Text = sefergrid.CurrentRow.Cells[0].Value.ToString();
            sguncelle.guncelseferTarihi.Text = sefergrid.CurrentRow.Cells[1].Value.ToString();
            sguncelle.guncelcmbGuzergah.Text = sefergrid.CurrentRow.Cells[3].Value.ToString();
            sguncelle.guncelcmbKoltuk.Text = sefergrid.CurrentRow.Cells[4].Value.ToString();
            sguncelle.guncelcmbOtobus.Text = sefergrid.CurrentRow.Cells[5].Value.ToString();
            sguncelle.guncelcmbSofor.Text = sefergrid.CurrentRow.Cells[6].Value.ToString();
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT peron,id,hareketSaat,hareketDakika,hareketTarihi FROM sefer WHERE hareketTarihi = @Tarih AND guzergahi=@guzergahi AND seferSayi=@seferSayi";
            kmt.Parameters.AddWithValue("@Tarih", sguncelle.guncelseferTarihi.Value.ToShortDateString());
            kmt.Parameters.AddWithValue("@guzergahi", sguncelle.guncelcmbGuzergah.Text);
            kmt.Parameters.AddWithValue("@seferSayi", sefergrid.CurrentRow.Cells[0].Value.ToString());
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                string peron = yukle.GetString(0).ToString();
                string id = yukle.GetInt32(1).ToString();
                sguncelle.gunceltxtPeron.Text = yukle["peron"].ToString();
                sguncelle.txtSeferid.Text = yukle["id"].ToString();
                sguncelle.guncelseferTarihi.Text = Convert.ToDateTime(seferTarihi.Text).ToShortDateString();
                sguncelle.guncelcmbSaat.Text = yukle["hareketSaat"].ToString();
                sguncelle.guncelcmbDakika.Text = yukle["hareketDakika"].ToString();
                sguncelle.Show();
                Hide();
            }
            baglan.Close();
            yukle.Dispose();
        }

        private void YeniSeferTanimla_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
