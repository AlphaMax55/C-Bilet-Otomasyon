using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace omrYild
{
    public partial class biletguncelle : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=omer.accdb");
        DataTable dt = new DataTable();
        public biletguncelle()
        {
            InitializeComponent();
        }
        private void biletguncelle_Load(object sender, EventArgs e)
        {
            cmbdoldur();
        }
        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (txtKontrol.Text.Equals("") || txtKontrol.Text.Equals(txtKoltukNo.Text))
            {
                if (!cmbSatisTip.Text.Equals("Seçiniz"))
                {
                    try
                    {
                        string Cinsiyet = "";
                        if (rdBay.Checked.Equals(true))
                        {
                            Cinsiyet = "Bay";
                        }
                        else if (rdBayan.Checked.Equals(true))
                        {
                            Cinsiyet = "Bayan";
                        }
                        int bedel = 0;
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
                        kmt.CommandText = "UPDATE yolcu SET yolcuAdSoyadi=@yolcuAdSoyadi,yolcuTeli=@yolcuTeli,yolcuCinsiyeti=@yolcuCinsiyeti,yolculukTarihi=@yolculukTarihi,yolculukSaati=@yolculukSaati,yolcuKoltukNo=@yolcuKoltukNo,yolculukNereden=@yolculukNereden,yolculukNereye=@yolculukNereye,satisTip=@satisTip,odemeSekli=@odemeSekli,ucret=@ucret,seferSayi=@seferSayi,otobusPlakasi=@otobusPlakasi WHERE id=@id";
                        kmt.Parameters.AddWithValue("@yolcuAdSoyadi", txtAdSoyad.Text);
                        kmt.Parameters.AddWithValue("@yolcuTeli", txtTelefon.Text);
                        kmt.Parameters.AddWithValue("@yolcuCinsiyeti", Cinsiyet);
                        kmt.Parameters.AddWithValue("@yolculukTarihi", Convert.ToDateTime(txtTarih.Text));
                        kmt.Parameters.AddWithValue("@yolculukSaati", txtsaat.Text);
                        kmt.Parameters.AddWithValue("@yolcuKoltukNo", txtSecilenKoltuk.Text);
                        kmt.Parameters.AddWithValue("@yolculukNereden", cmbNereden.Text);
                        kmt.Parameters.AddWithValue("@yolculukNereye", cmbNereye.Text);
                        kmt.Parameters.AddWithValue("@satisTip", cmbSatisTip.Text);
                        kmt.Parameters.AddWithValue("@odemeSekli", cmbOdemeSekli.Text);
                        kmt.Parameters.AddWithValue("@ucret", bedel.ToString());
                        kmt.Parameters.AddWithValue("@seferSayi", txtSeferSayi.Text.ToString());
                        kmt.Parameters.AddWithValue("@otobusPlakasi", txtPlaka.Text.ToString());
                        kmt.Parameters.AddWithValue("@id", txtYolcuid.Text);
                        kmt.ExecuteNonQuery();
                        baglan.Close();
                        MessageBox.Show("Başarıyla Güncelleme Yapıldı !", "İşlem Gerçekleşti !.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        yonlendir();
                    }
                    catch
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Satış Tpi Seçilmemiş !", "Uyarı !.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Koltukta Yolcu Tanımlı !", "Uyarı !.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yonlendir();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Yolcuyu Silmek İstiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                baglan.Open();
                OleDbCommand kmt = new OleDbCommand();
                kmt.Connection = baglan;
                kmt.CommandText = "DELETE FROM yolcu WHERE id=@id";
                kmt.Parameters.AddWithValue("@id", txtYolcuid.Text);
                kmt.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Silme İşlemi Tamamlandı!.");
                yonlendir();
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            yonlendir();
        }
        private void cmbkoltukUc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtKoltuk.Text.Equals("2+1"))
            {
                txtSecilenKoltuk.Text = cmbkoltukUc.Text;
                kontroldoldur();
            }
        }
        private void cmbkoltukDort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtKoltuk.Text.Equals("2+2"))
            {
                txtSecilenKoltuk.Text = cmbkoltukDort.Text;
                kontroldoldur();
            }
        }
        private void koltukdoldur()
        {
            for (int i = 1; i < 38; i++)
            {
                cmbkoltukUc.Items.Add(i);
            }
            for (int j = 1; j < 47; j++)
            {
                cmbkoltukDort.Items.Add(j);
            }
        }
        private void bilgidoldur()
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader yukle;
            baglan.Open();
            cmd.Connection = baglan;
            cmd.CommandText = "SELECT * FROM yolcu WHERE seferid=@seferid AND yolcuKoltukNo=@yolcuKoltukNo";
            cmd.Parameters.AddWithValue("@seferid", txtSeferidsi.Text);
            cmd.Parameters.AddWithValue("@yolcuKoltukNo", txtKoltukNo.Text.ToString());
            yukle = cmd.ExecuteReader();
            while (yukle.Read())
            {
                txtYolcuid.Text       = yukle["id"].ToString();
                txtAdSoyad.Text       = yukle["yolcuAdSoyadi"].ToString();
                txtTelefon.Text       = yukle["yolcuTeli"].ToString();
                cmbNereden.Text       = yukle["yolculukNereden"].ToString();
                cmbNereye.Text        = yukle["yolculukNereye"].ToString();
                cmbSatisTip.Text      = yukle["satisTip"].ToString();
                txtUcret.Text         = yukle["Ucret"].ToString();
                cmbOdemeSekli.Text    = yukle["odemeSekli"].ToString();
                txtSecilenKoltuk.Text = yukle["yolcuKoltukNo"].ToString();
                txtTarih.Text         = Convert.ToDateTime(yukle["yolculukTarihi"]).ToShortDateString();
                txtsaat.Text          = yukle["yolculukSaati"].ToString();
                string cins           = yukle["yolcuCinsiyeti"].ToString();
                if (cins.Equals("Bay"))
                {
                    rdBay.Checked = true;
                }
                else
                {
                    rdBayan.Checked = true;
                }
                if (txtKoltuk.Text.Equals("2+1"))
                {
                    cmbkoltukDort.Visible = false;
                    cmbkoltukUc.Text      = yukle["yolcuKoltukNo"].ToString();
                }
                else if (txtKoltuk.Text.Equals("2+2"))
                {
                    cmbkoltukUc.Visible = false;
                    cmbkoltukDort.Text  = yukle["yolcuKoltukNo"].ToString();
                }
            }
            baglan.Close();
            yukle.Dispose();
        }
        private void yonlendir()
        {
            if (txtKoltuk.Text.Equals("2+1"))
            {
                uclu uc = new uclu();
                uc.txtSeferidsi.Text = txtSeferidsi.Text;
                uc.txtTarih.Text = Convert.ToDateTime(txtTarih.Text).ToShortDateString();
                uc.yolcudoldur();
                temizlik();
                uc.Show();
                Hide();
            }
            else if (txtKoltuk.Text.Equals("2+2"))
            {
                dortlu dort = new dortlu();
                dort.txtSeferidsi.Text = txtSeferidsi.Text;
                dort.txtTarih.Text = Convert.ToDateTime(txtTarih.Text).ToShortDateString();
                dort.yolcudoldur();
                temizlik();
                dort.Show();
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
            kmt.Parameters.AddWithValue("@yolcuKoltukNo", txtSecilenKoltuk.Text);
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
            yukle = kmt.ExecuteReader();
            while (yukle.Read())
            {
                cmbNereye.Items.Add(yukle["Nereye"]);
            }
            baglan.Close();
            yukle.Dispose();
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
        }
        private void cmbdoldur()
        {
            bilgidoldur();
            nereyedoldur();
            neredendoldur();
            koltukdoldur();
            if (txtUcret.Text.Equals("0"))
            {
                ucret();
            }
        }
        private void temizlik()
        {
            foreach (TextBox txtbx in Controls.OfType<TextBox>())
            {
                txtbx.Clear();
            }
            foreach (ComboBox cmbx in Controls.OfType<ComboBox>())
            {
                cmbx.Text="";
            }
            foreach (RadioButton rdb in Controls.OfType<RadioButton>())
            {
                rdb.Checked = false;
            }

        }
        private void cmbNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucret();
            cmbOdemeSekli.Visible = false;
            lblodeme.Visible = false;
            lblUcret.Visible = false;
            txtUcret.Visible = false;
            pcTl.Visible = false;
            cmbSatisTip.Text = "";
            cmbSatisTip.Text = "Seçiniz";
        }
        private void cmbSatisTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUcret.Visible = true;
            txtUcret.Visible = true;
            pcTl.Visible = true;
            if (!cmbSatisTip.Text.Equals("Rezervasyon"))
            {
                cmbOdemeSekli.Visible = true;
                lblodeme.Visible = true;
            }
        }
    }
}
