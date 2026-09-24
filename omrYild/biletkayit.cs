using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace omrYild
{
    public partial class biletkayit : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=omer.accdb");
        DataTable dt = new DataTable();
        public biletkayit()
        {
            InitializeComponent();
        }
        private void biletkayit_Load(object sender, EventArgs e)
        {
            combobos();
        }
        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (!txtKoltukNo.Text.Equals(txtKontrol.Text))
            {
                if (!cmbNereden.Text.Equals("Seçiniz") && !cmbNereye.Text.Equals("Seçiniz") && !cmbSatisTip.Text.Equals("Seçiniz") && txtAdSoyad.Text != "" && txtTelefon.Text != "")
                {
                    if (rdBay.Checked != false || rdBayan.Checked != false)
                    {
                        try
                        {
                            string Cinsiyet ="";
                            if (rdBay.Checked.Equals(true))
                            {
                                Cinsiyet = "Bay";
                            }
                            else if (rdBayan.Checked.Equals(true))
                            {
                                Cinsiyet = "Bayan";
                            }
                            int bedel=0;
                            if (cmbSatisTip.Text.Equals("Rezervasyon"))
                            {
                                bedel = 0;
                            }
                            else if (!cmbSatisTip.Text.Equals("Rezervasyon"))
                            {
                                bedel = Convert.ToInt32(txtUcret.Text);
                            }
                            if (cmbOdemeSekli.Text.Equals("") || cmbOdemeSekli.Text.Equals("Seçiniz"))
                            {
                                cmbOdemeSekli.Text = "Ödeme Yapılmadı";
                            }
                            baglan.Open();
                            OleDbCommand kmt = new OleDbCommand();
                            kmt.Connection = baglan;
                            kmt.CommandText = "INSERT INTO yolcu (yolcuAdSoyadi,yolcuTeli,yolcuCinsiyeti,yolculukTarihi,yolculukSaati,yolcuKoltukNo,yolculukNereden,yolculukNereye,satisTip,odemeSekli,ucret,seferSayi,otobusPlakasi,seferid) VALUES (@yolcuAdSoyadi,@yolcuTeli,@yolcuCinsiyeti,@yolculukTarihi,@yolculukSaati,@yolcuKoltukNo,@yolculukNereden,@yolculukNereye,@satisTip,@odemeSekli,@ucret,@seferSayi,@otobusPlakasi,@seferid)";
                            kmt.Parameters.AddWithValue("@yolcuAdSoyadi", txtAdSoyad.Text);
                            kmt.Parameters.AddWithValue("@yolcuTeli", txtTelefon.Text);
                            kmt.Parameters.AddWithValue("@yolcuCinsiyeti", Cinsiyet);
                            kmt.Parameters.AddWithValue("@yolculukTarihi", Convert.ToDateTime(txtTarih.Text));
                            kmt.Parameters.AddWithValue("@yolculukSaati", txtsaat.Text);
                            kmt.Parameters.AddWithValue("@yolcuKoltukNo", txtKoltukNo.Text);
                            kmt.Parameters.AddWithValue("@yolculukNereden", cmbNereden.Text);
                            kmt.Parameters.AddWithValue("@yolculukNereye", cmbNereye.Text);
                            kmt.Parameters.AddWithValue("@satisTip", cmbSatisTip.Text);
                            kmt.Parameters.AddWithValue("@odemeSekli", cmbOdemeSekli.Text);
                            kmt.Parameters.AddWithValue("@ucret", bedel.ToString());
                            kmt.Parameters.AddWithValue("@seferSayi", txtSeferSayi.Text.ToString());
                            kmt.Parameters.AddWithValue("@otobusPlakasi", txtPlaka.Text.ToString());
                            kmt.Parameters.AddWithValue("@seferid", txtSeferidsi.Text);
                            kmt.ExecuteNonQuery();
                            baglan.Close();
                            MessageBox.Show("Başarıyla Kayıt Yapıldı !", "İşlem Gerçekleşti !.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            combobos();
                            yonlendir();
                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cinsiyet Seçilmemiş !", "Uyarı !.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Seçim Yapılmamış Alanlar Var !", "Uyarı !.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Koltukta Yolcu Tanımlı !", "Uyarı !.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combobos();
                yonlendir();
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            yonlendir();
        }
        private void yonlendir()
        {
            if (txtKoltuk.Text.Equals("2+1"))
            {
                uclu uc = new uclu();
                uc.txtSeferidsi.Text = txtSeferidsi.Text;
                uc.txtTarih.Text = Convert.ToDateTime(txtTarih.Text).ToShortDateString();
                uc.Show();
                temizlik();
                Hide();
            }
            else if (txtKoltuk.Text.Equals("2+2"))
            {
                dortlu dort = new dortlu();
                dort.txtSeferidsi.Text = txtSeferidsi.Text;
                dort.txtTarih.Text = Convert.ToDateTime(txtTarih.Text).ToShortDateString();
                dort.Show();
                temizlik();
                Hide();
            }
        }
        private void kontroldoldur()
        {
            txtKontrol.Text = "";
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT yolcuKoltukNo FROM yolcu WHERE yolcuKoltukNo=@yolcuKoltukNo AND seferid=@seferid";
            kmt.Parameters.AddWithValue("@yolcuKoltukNo", txtKoltukNo.Text);
            kmt.Parameters.AddWithValue("@seferid", txtSeferidsi.Text);
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                txtKontrol.Text = yukle["yolcuKoltukNo"].ToString();
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void neredendoldur()
        {
            cmbNereden.Items.Clear();
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            kmt.CommandText = "SELECT Nereden FROM nereden ORDER BY Nereden ASC";
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                cmbNereden.Items.Add(yukle["Nereden"]);
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void nereyedoldur()
        {
            cmbNereye.Items.Clear();
            OleDbCommand kmt = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            kmt.Connection = baglan;
            if (txtGuzergah.Text.Equals("Samsun - İzmir - Ankara"))
            {
                kmt.CommandText = "SELECT Nereye FROM ankara ORDER BY Nereye ASC";
            }
            else if (txtGuzergah.Text.Equals("Samsun - Gümüşhane - Erzurum"))
            {
                kmt.CommandText = "SELECT Nereye FROM erzurum ORDER BY Nereye ASC";
            }
            else if (txtGuzergah.Text.Equals("Samsun - Isparta - Antalya"))
            {
                kmt.CommandText = "SELECT Nereye FROM antalya ORDER BY Nereye ASC";
            }
            else if (txtGuzergah.Text.Equals("Samsun - Konya - Adıyaman"))
            {
                kmt.CommandText = "SELECT Nereye FROM adiyaman ORDER BY Nereye ASC";
            }
            else if (txtGuzergah.Text.Equals("Samsun - Trabzon - Hatay"))
            {
                kmt.CommandText = "SELECT Nereye FROM hatay ORDER BY Nereye ASC";
            }
            else if (txtGuzergah.Text.Equals("Samsun - Balıkesir -  İstanbul"))
            {
                kmt.CommandText = "SELECT Nereye FROM istanbul ORDER BY Nereye ASC";
            }
            else if (txtGuzergah.Text.Equals("Samsuna Geliş"))
            {
                kmt.CommandText = "SELECT Nereye FROM samsun ORDER BY Nereye ASC";
            }
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                cmbNereye.Items.Add(yukle["Nereye"]);
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void cmbNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOdemeSekli.Visible = false;
            lblodeme.Visible = false;
            lblUcret.Visible = false;
            txtUcret.Visible = false;
            pcTl.Visible = false;
            cmbSatisTip.Text = "";
            cmbSatisTip.SelectedText = "Seçiniz";
        }
        private void cmbSatisTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            kontroldoldur();
            cmbOdemeSekli.Visible = false;
            lblodeme.Visible = false;
            lblUcret.Visible = true;
            txtUcret.Visible = true;
            pcTl.Visible = true;
            ucret();
            if (!cmbSatisTip.Text.Equals("Rezervasyon"))
            {
                cmbOdemeSekli.Visible = true;
                lblodeme.Visible = true;
            }
        }
        private void combobos()
        {
            txtAdSoyad.Text = "";
            txtTelefon.Text = "";
            txtUcret.Text = "";
            cmbOdemeSekli.Text = "";
            cmbNereden.Text = "";
            cmbNereye.Text = "";
            cmbSatisTip.Text = "";
            rdBay.Checked = false;
            rdBayan.Checked = false;
            cmbOdemeSekli.Visible = false;
            lblodeme.Visible = false;
            lblUcret.Visible = false;
            txtUcret.Visible = false;
            pcTl.Visible = false;
            cmbNereden.SelectedText = "Seçiniz";
            cmbNereye.SelectedText = "Seçiniz";
            cmbSatisTip.SelectedText = "Seçiniz";
            cmbOdemeSekli.Text = "Seçiniz";
            neredendoldur();
            nereyedoldur();
        }
        private void ucret()
        {
            if (txtGuzergah.Text.Equals("Samsun - İzmir - Ankara"))
            {
                string neresi = cmbNereye.Text;
                txtUcret.Clear();
                OleDbCommand ucr = new OleDbCommand();
                OleDbDataReader getir;
                baglan.Open();
                ucr.Connection = baglan;
                ucr.CommandText = "SELECT Ucret FROM ankara WHERE Nereye = @neresi";
                ucr.Parameters.AddWithValue("@neresi", neresi);
                getir = ucr.ExecuteReader();
                while (getir.Read())
                {
                    txtUcret.Text = getir["Ucret"].ToString();
                }
                baglan.Close();
                getir.Dispose();
            }
            else if (txtGuzergah.Text.Equals("Samsun - Gümüşhane - Erzurum"))
            {
                string neresi = cmbNereye.Text;
                txtUcret.Clear();
                OleDbCommand ucr = new OleDbCommand();
                OleDbDataReader getir;
                baglan.Open();
                ucr.Connection = baglan;
                ucr.CommandText = "SELECT Ucret FROM erzurum WHERE Nereye = @neresi";
                ucr.Parameters.AddWithValue("@neresi", neresi);
                getir = ucr.ExecuteReader();
                while (getir.Read())
                {
                    txtUcret.Text = getir["Ucret"].ToString();
                }
                baglan.Close();
                getir.Dispose();
            }
            else if (txtGuzergah.Text.Equals("Samsun - Isparta - Antalya"))
            {
                string neresi = cmbNereye.Text;
                txtUcret.Clear();
                OleDbCommand ucr = new OleDbCommand();
                OleDbDataReader getir;
                baglan.Open();
                ucr.Connection = baglan;
                ucr.CommandText = "SELECT Ucret FROM antalya WHERE Nereye = @neresi";
                ucr.Parameters.AddWithValue("@neresi", neresi);
                getir = ucr.ExecuteReader();
                while (getir.Read())
                {
                    txtUcret.Text = getir["Ucret"].ToString();
                }
                baglan.Close();
                getir.Dispose();
            }
            else if (txtGuzergah.Text.Equals("Samsun - Konya - Adıyaman"))
            {
                string neresi = cmbNereye.Text;
                txtUcret.Clear();
                OleDbCommand ucr = new OleDbCommand();
                OleDbDataReader getir;
                baglan.Open();
                ucr.Connection = baglan;
                ucr.CommandText = "SELECT Ucret FROM adiyaman WHERE Nereye = @neresi";
                ucr.Parameters.AddWithValue("@neresi", neresi);
                getir = ucr.ExecuteReader();
                while (getir.Read())
                {
                    txtUcret.Text = getir["Ucret"].ToString();
                }
                baglan.Close();
                getir.Dispose();
            }
            else if (txtGuzergah.Text.Equals("Samsun - Trabzon - Hatay"))
            {
                string neresi = cmbNereye.Text;
                txtUcret.Clear();
                OleDbCommand ucr = new OleDbCommand();
                OleDbDataReader getir;
                baglan.Open();
                ucr.Connection = baglan;
                ucr.CommandText = "SELECT Ucret FROM hatay WHERE Nereye = @neresi";
                ucr.Parameters.AddWithValue("@neresi", neresi);
                getir = ucr.ExecuteReader();
                while (getir.Read())
                {
                    txtUcret.Text = getir["Ucret"].ToString();
                }
                baglan.Close();
                getir.Dispose();
            }
            else if (txtGuzergah.Text.Equals("Samsun - Balıkesir -  İstanbul"))
            {
                string neresi = cmbNereye.Text;
                txtUcret.Clear();
                OleDbCommand ucr = new OleDbCommand();
                OleDbDataReader getir;
                baglan.Open();
                ucr.Connection = baglan;
                ucr.CommandText = "SELECT Ucret FROM istanbul WHERE Nereye = @neresi";
                ucr.Parameters.AddWithValue("@neresi", neresi);
                getir = ucr.ExecuteReader();
                while (getir.Read())
                {
                    txtUcret.Text = getir["Ucret"].ToString();
                }
                baglan.Close();
                getir.Dispose();
            }
            else if (txtGuzergah.Text.Equals("Samsuna Geliş"))
            {
                string neresi = cmbNereye.Text;
                txtUcret.Clear();
                OleDbCommand ucr = new OleDbCommand();
                OleDbDataReader getir;
                baglan.Open();
                ucr.Connection = baglan;
                ucr.CommandText = "SELECT Ucret FROM samsun WHERE Nereye = @neresi";
                ucr.Parameters.AddWithValue("@neresi", neresi);
                getir = ucr.ExecuteReader();
                while (getir.Read())
                {
                    txtUcret.Text = getir["Ucret"].ToString();
                }
                baglan.Close();
                getir.Dispose();
            }
        }
        private void temizlik()
        {
            foreach (TextBox txtbx in Controls.OfType<TextBox>())
            {
                txtbx.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUcret_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
