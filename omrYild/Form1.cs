
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using System.Data.OleDb;

namespace omrYild
{
    public partial class Form1 : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=omer.accdb");
      
DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            combobos();
            sefergrid.Columns[0].HeaderText = "Tarih";
            sefergrid.Columns[1].HeaderText = "Saat";
            sefergrid.Columns[2].HeaderText = "Güzergah";
            sefergrid.Columns[3].HeaderText = "Koltuk";
            sefergrid.Columns[4].HeaderText = "Plaka";
            sefergrid.Columns[5].HeaderText = "Şoför";
            sefergrid.Columns[6].HeaderText = "Sefer";
            sefergrid.Columns[0].Width = 90;
            sefergrid.Columns[1].Width = 65;
            sefergrid.Columns[2].Width = 290;
            sefergrid.Columns[3].Width = 65;
            sefergrid.Columns[4].Width = 110;
            sefergrid.Columns[5].Width = 130;
            sefergrid.Columns[6].Width = 65;
            sefergrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            sefergrid.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            sefergrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(243, 247, 248);
            sefergrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            sefergrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sefergrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sefergrid.RowHeadersDefaultCellStyle.Alignment    = DataGridViewContentAlignment.MiddleCenter;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            combobos();
        }
       
        private void combobos()
        {
            txtSeferAra.Text = "";
            seferTarihi.Text = "";
            sefersorgu();
            sefersayisi();
        }
        public void sefersorgu()
        {
            dt.Clear();
            OleDbDataAdapter dap = new OleDbDataAdapter("SELECT hareketTarihi,hareketSaati,guzergahi,koltukTuru,otobusPlakasi,soforAdSoyadi,seferSayi FROM sefer WHERE hareketTarihi=@hareketTarihi ORDER BY hareketSaati ASC", baglan);
            dap.SelectCommand.Parameters.AddWithValue("@hareketTarihi", seferTarihi.Value.ToShortDateString());
            dap.Fill(dt);
            sefergrid.DataSource = dt;
        }
        private void seferTarihi_ValueChanged(object sender, EventArgs e)
        {
            txtSeferAra.Text = "";
            sefersorgu();
            sefersayisi();
        }
        private void sefersayisi()
        {
            lblToplam.Text ="";
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT COUNT(id) AS sefersayisi FROM sefer WHERE hareketTarihi=@hareketTarihi";
            kmt.Parameters.AddWithValue("@hareketTarihi", seferTarihi.Value.ToShortDateString());
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                lblToplam.Text = yukle["sefersayisi"].ToString();
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void sefergrid_DoubleClick(object sender, EventArgs e)
        {
            string saat     = sefergrid.CurrentRow.Cells[1].Value.ToString();
            string guzegah  = sefergrid.CurrentRow.Cells[2].Value.ToString();
            txtSeferid.Text = "";
            txtKoltuk.Text  = "";
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT id, koltukTuru,hareketTarihi FROM sefer WHERE hareketTarihi=@hareketTarihi AND hareketSaati=@hareketSaati AND guzergahi=@guzergahi";
            kmt.Parameters.AddWithValue("@hareketTarihi", seferTarihi.Value.ToShortDateString());
            kmt.Parameters.AddWithValue("@hareketSaati", saat);
            kmt.Parameters.AddWithValue("@guzergahi", guzegah);
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                txtSeferid.Text = yukle["id"].ToString();
                txtKoltuk.Text  = yukle["koltukTuru"].ToString();
                txtTarih.Text   = yukle["hareketTarihi"].ToString();
            }
            baglan.Close();
            yukle.Dispose();

            if (txtKoltuk.Text.Equals("2+1"))
            {
                uclu uc = new uclu();
                uc.txtSeferidsi.Text = txtSeferid.Text;
                uc.txtTarih.Text = Convert.ToDateTime(txtTarih.Text).ToShortDateString();
                uc.Show();
                temizlik();
                Hide();
            }
            else if (txtKoltuk.Text.Equals("2+2"))
            {
                dortlu dort = new dortlu();
                dort.txtSeferidsi.Text = txtSeferid.Text;
                dort.txtTarih.Text = Convert.ToDateTime(txtTarih.Text).ToShortDateString();
                dort.Show();
                temizlik();
                Hide();
            }
        }
        private void pcbxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void pcbxexit_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Ayarlar Kaydedilecek ve Programdan Çıkılacak.. ", "Çıkmak İstiyormusunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void temizlik()
        {
            foreach (TextBox txtbx in Controls.OfType<TextBox>())
            {
                txtbx.Clear();
            }
        }

        private void txtSeferAra_TextChanged(object sender, EventArgs e)
        {
            if (txtSeferAra.Text.Equals(""))
            {
                dt.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT hareketTarihi,hareketSaati,guzergahi,koltukTuru,otobusPlakasi,soforAdSoyadi,seferSayi FROM sefer ORDER BY hareketSaati ASC", baglan);
                adtr.Fill(dt);
                sefergrid.DataSource = dt;
            }
            else
            {
                dt.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT hareketTarihi,hareketSaati,guzergahi,koltukTuru,otobusPlakasi,soforAdSoyadi,seferSayi FROM sefer WHERE hareketTarihi=@hareketTarihi AND guzergahi LIKE '%" + txtSeferAra.Text + "%'", baglan);
                adtr.SelectCommand.Parameters.AddWithValue("@hareketTarihi", seferTarihi.Value.ToShortDateString());
                adtr.Fill(dt);
                sefergrid.DataSource = dt;
                int dtsayi = 0;
                dtsayi = sefergrid.RowCount - 1;
                lblToplam.Text = dtsayi.ToString();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            yenisefer ysefer = new yenisefer();
            ysefer.Show();
            Hide();
        }

        private void sefergrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string saat = sefergrid.CurrentRow.Cells[1].Value.ToString();
            string guzegah = sefergrid.CurrentRow.Cells[2].Value.ToString();
            txtSeferid.Text = "";
            txtKoltuk.Text = "";
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT id, koltukTuru,hareketTarihi FROM sefer WHERE hareketTarihi=@hareketTarihi AND hareketSaati=@hareketSaati AND guzergahi=@guzergahi";
            kmt.Parameters.AddWithValue("@hareketTarihi", seferTarihi.Value.ToShortDateString());
            kmt.Parameters.AddWithValue("@hareketSaati", saat);
            kmt.Parameters.AddWithValue("@guzergahi", guzegah);
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                txtSeferid.Text = yukle["id"].ToString();
                txtKoltuk.Text = yukle["koltukTuru"].ToString();
                txtTarih.Text = yukle["hareketTarihi"].ToString();
            }
            baglan.Close();
            yukle.Dispose();

            if (txtKoltuk.Text.Equals("2+1"))
            {
                uclu uc = new uclu();
                uc.txtSeferidsi.Text = txtSeferid.Text;
                uc.txtTarih.Text = Convert.ToDateTime(txtTarih.Text).ToShortDateString();
                uc.Show();
                temizlik();
                Hide();
            }
            else if (txtKoltuk.Text.Equals("2+2"))
            {
                dortlu dort = new dortlu();
                dort.txtSeferidsi.Text = txtSeferid.Text;
                dort.txtTarih.Text = Convert.ToDateTime(txtTarih.Text).ToShortDateString();
                dort.Show();
                temizlik();
                Hide();
            }
        }

        private void seferbox_Enter(object sender, EventArgs e)
        {

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenisefer ysefer = new yenisefer();
            ysefer.Show();
            Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Ayarlar Kaydedilecek ve Programdan Çıkılacak.. ", "Çıkmak İstiyormusunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string saat = sefergrid.CurrentRow.Cells[1].Value.ToString();
            string guzegah = sefergrid.CurrentRow.Cells[2].Value.ToString();
            txtSeferid.Text = "";
            txtKoltuk.Text = "";
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT id, koltukTuru,hareketTarihi FROM sefer WHERE hareketTarihi=@hareketTarihi AND hareketSaati=@hareketSaati AND guzergahi=@guzergahi";
            kmt.Parameters.AddWithValue("@hareketTarihi", seferTarihi.Value.ToShortDateString());
            kmt.Parameters.AddWithValue("@hareketSaati", saat);
            kmt.Parameters.AddWithValue("@guzergahi", guzegah);
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                txtSeferid.Text = yukle["id"].ToString();
                txtKoltuk.Text = yukle["koltukTuru"].ToString();
                txtTarih.Text = yukle["hareketTarihi"].ToString();
            }
            baglan.Close();
            yukle.Dispose();

            if (txtKoltuk.Text.Equals("2+1"))
            {
                uclu uc = new uclu();
                uc.txtSeferidsi.Text = txtSeferid.Text;
                uc.txtTarih.Text = Convert.ToDateTime(txtTarih.Text).ToShortDateString();
                uc.Show();
                temizlik();
                Hide();
            }
            else if (txtKoltuk.Text.Equals("2+2"))
            {
                dortlu dort = new dortlu();
                dort.txtSeferidsi.Text = txtSeferid.Text;
                dort.txtTarih.Text = Convert.ToDateTime(txtTarih.Text).ToShortDateString();
                dort.Show();
                temizlik();
                Hide();
            }
        }

        private void seferGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
