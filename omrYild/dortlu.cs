using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace omrYild
{
    public partial class dortlu : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=omer.accdb");
        DataTable dt = new DataTable();
        public dortlu()
        {
            InitializeComponent();
        }
        private void normal_Load(object sender, EventArgs e)
        {
            koltuklar();
            yolcudoldur();
            bilgidoldur();
            bilgiler();
            yolculargrid.Columns[0].HeaderText = "Durum";
            yolculargrid.Columns[1].HeaderText = "Koltuk";
            yolculargrid.Columns[2].HeaderText = "Adı Soyadı";
            yolculargrid.Columns[3].HeaderText = "Nereden";
            yolculargrid.Columns[4].HeaderText = "Nereye";
            yolculargrid.Columns[5].HeaderText = "Cinsiyet";
            yolculargrid.Columns[6].HeaderText = "Ödeme";
            yolculargrid.Columns[7].HeaderText = "Ücret";
            yolculargrid.Columns[0].Width = 95;
            yolculargrid.Columns[1].Width = 55;
            yolculargrid.Columns[2].Width = 125;
            yolculargrid.Columns[3].Width = 90;
            yolculargrid.Columns[4].Width = 100;
            yolculargrid.Columns[5].Width = 65;
            yolculargrid.Columns[6].Width = 115;
            yolculargrid.Columns[7].Width = 55;
            yolculargrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            yolculargrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(243, 247, 248);
            yolculargrid.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9);
            yolculargrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(243, 247, 248);
            yolculargrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            yolculargrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            yolculargrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            yolculargrid.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void koltuklar()
        {
            foreach (Button btn in pnlOtobus.Controls.OfType<Button>())
            {
                btn.BackColor = Color.FromArgb(243, 247, 248);
                btn.Width = 35;
                btn.Height = 34;
                btn.BackgroundImage = new Bitmap("images/bos.jpg");
            }
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT yolcuCinsiyeti,yolcuKoltukNo FROM yolcu WHERE seferid=@seferid";
            kmt.Parameters.AddWithValue("@seferid", txtSeferidsi.Text);
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                string cinsiyet = yukle["yolcuCinsiyeti"].ToString();
                string KoltukNo = yukle["yolcuKoltukNo"].ToString();

                if (cinsiyet == "Bay")
                {
                    Controls.Find("btn" + KoltukNo, true)[0].BackgroundImage = new Bitmap("images/erkek.jpg");
                }
                else if (cinsiyet == "Bayan")
                {
                    Controls.Find("btn" + KoltukNo, true)[0].BackgroundImage = new Bitmap("images/kadin.jpg");
                }
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void btnListe_Click(object sender, EventArgs e)
        {
            liste lst = new liste();
            lst.txtSeferidsi.Text = txtSeferidsi.Text;
            lst.txtPlaka.Text     = lblPlaka.Text;
            lst.txtSeferSayi.Text = txtSeferSayi.Text.ToString();
            lst.ShowDialog();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            temizlik();
            Hide(); 
        }
        Button secilen;
        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            secilen = (Button)sender;
            txtKoltukNo.Text = secilen.Text.ToString();
            biletkayit blkayit = new biletkayit();
            blkayit.txtGuzergah.Text  = txtGuzergah.Text;
            blkayit.txtSeferidsi.Text = txtSeferidsi.Text;
            blkayit.txtsaat.Text      = txtsaat.Text;
            blkayit.txtTarih.Text     = txtTarih.Text;
            blkayit.txtKoltukNo.Text  = txtKoltukNo.Text;
            blkayit.txtKoltuk.Text    = txtKoltuk.Text;
            blkayit.txtPlaka.Text     = txtPlaka.Text.ToString();
            blkayit.txtSeferSayi.Text = txtSeferSayi.Text.ToString();
            blkayit.Show();
            temizlik();
            Hide();
        }
        public void yolcudoldur()
        {
            dt.Clear();
            OleDbDataAdapter dap = new OleDbDataAdapter("SELECT satisTip,yolcuKoltukNo,yolcuAdSoyadi,yolculukNereden,yolculukNereye,yolcuCinsiyeti,odemeSekli,ucret FROM yolcu WHERE seferid=@id ORDER BY yolcuKoltukNo ASC", baglan);
            dap.SelectCommand.Parameters.AddWithValue("@id", txtSeferidsi.Text);
            dap.Fill(dt);
            yolculargrid.DataSource = dt;
        }
        private void bilgidoldur()
        {
            txtGuzergah.Clear();
            txtsaat.Clear();
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT guzergahi,hareketSaati,koltukTuru,otobusPlakasi,seferSayi FROM sefer WHERE id=@id";
            kmt.Parameters.AddWithValue("@id", txtSeferidsi.Text);
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                txtGuzergah.Text  = yukle["guzergahi"].ToString();
                txtsaat.Text      = yukle["hareketSaati"].ToString();
                txtKoltuk.Text    = yukle["koltukTuru"].ToString();
                string guzergah   = yukle["otobusPlakasi"].ToString() + " " + lblGuzergah.Text;
                lblGuzergah.Text  = guzergah;
                txtSeferSayi.Text = yukle["seferSayi"].ToString();
                txtPlaka.Text     = yukle["otobusPlakasi"].ToString();
                lblPlaka.Text     = yukle["otobusPlakasi"].ToString();
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void bilgiler()
        {
            OleDbCommand tpl = new OleDbCommand();
            OleDbDataReader toplam;
            baglan.Open();
            tpl.Connection = baglan;
            tpl.CommandText = "SELECT COUNT(yolcuKoltukNo) AS doluKoltuk FROM yolcu WHERE seferid=@seferid";
            tpl.Parameters.AddWithValue("@seferid", txtSeferidsi.Text);
            toplam = tpl.ExecuteReader();
            while (toplam.Read())
            {
                lblTYolcu.Text = toplam["doluKoltuk"].ToString();
                int tplm = Convert.ToInt32(toplam["doluKoltuk"]);
                int bos = 46 - tplm;
                lblBKoltuk.Text = bos.ToString();
            }
            baglan.Close();
            toplam.Dispose();
            OleDbCommand rzv = new OleDbCommand();
            OleDbDataReader rezerve;
            baglan.Open();
            rzv.Connection = baglan;
            rzv.CommandText = "SELECT COUNT(yolcuKoltukNo) AS rezerveKoltuk FROM yolcu WHERE seferid=@seferid AND satisTip=@satisTip";
            rzv.Parameters.AddWithValue("@seferid", txtSeferidsi.Text);
            rzv.Parameters.AddWithValue("@satisTip", "Rezervasyon");
            rezerve = rzv.ExecuteReader();
            while (rezerve.Read())
            {
                lblRzv.Text = rezerve["rezerveKoltuk"].ToString();
            }
            baglan.Close();
            rezerve.Dispose();
            OleDbCommand nkt = new OleDbCommand();
            OleDbDataReader nakit;
            baglan.Open();
            nkt.Connection = baglan;
            nkt.CommandText = "SELECT SUM(Ucret) AS nakit FROM yolcu WHERE seferid=@seferid AND odemeSekli=@odemeSekli";
            nkt.Parameters.AddWithValue("@seferid", txtSeferidsi.Text);
            nkt.Parameters.AddWithValue("@odemeSekli", "Nakit");
            nakit = nkt.ExecuteReader();
            while (nakit.Read())
            {
                lblNakit.Text = nakit["nakit"].ToString();
            }
            baglan.Close();
            nakit.Dispose();
            OleDbCommand krdk = new OleDbCommand();
            OleDbDataReader kredik;
            baglan.Open();
            krdk.Connection = baglan;
            krdk.CommandText = "SELECT SUM(Ucret) AS krdkrt FROM yolcu WHERE seferid=@seferid AND odemeSekli=@odemeSekli";
            krdk.Parameters.AddWithValue("@seferid", txtSeferidsi.Text);
            krdk.Parameters.AddWithValue("@odemeSekli", "Kredi Kartı");
            kredik = krdk.ExecuteReader();
            while (kredik.Read())
            {
                lblKrediKarti.Text = kredik["krdkrt"].ToString();
                if (lblKrediKarti.Text.Equals(""))
                {
                    lblKrediKarti.Text = "0";
                }
                if (lblNakit.Text.Equals(""))
                {
                    lblNakit.Text = "0";
                }
                int nakittop = Convert.ToInt32(lblNakit.Text);
                int krdktop = Convert.ToInt32(lblKrediKarti.Text);
                lblToplam.Text = (nakittop + krdktop).ToString();
            }
            baglan.Close();
            kredik.Dispose();
        }
        private void temizlik()
        {
            foreach (TextBox txtbx in Controls.OfType<TextBox>())
            {
                txtbx.Clear();
            }
        }
        private void yolculargrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            biletguncelle bltguncel = new biletguncelle();
            bltguncel.txtSeferidsi.Text = txtSeferidsi.Text;
            bltguncel.txtKoltukNo.Text  = yolculargrid.CurrentRow.Cells[1].Value.ToString();
            bltguncel.txtGuzergah.Text  = txtGuzergah.Text;
            bltguncel.txtKoltuk.Text    = txtKoltuk.Text.ToString();
            bltguncel.txtPlaka.Text     = txtPlaka.Text.ToString();
            bltguncel.txtSeferSayi.Text = txtSeferSayi.Text;
            bltguncel.Show();
            Hide();
        }

        private void yolculargrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
