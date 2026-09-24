using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace omrYild
{
    public partial class liste : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=omer.accdb");
        DataTable dt = new DataTable();
        public liste()
        {
            InitializeComponent();
        }
        private void liste_Load(object sender, EventArgs e)
        {
            dt.Clear();
            OleDbDataAdapter dta = new OleDbDataAdapter("SELECT Distinct yolcuAdSoyadi,yolcuCinsiyeti,yolcuKoltukNo,yolculukNereden,yolculukNereye,Ucret,odemeSekli,otobusPlakasi,seferSayi FROM  yolcu WHERE seferid=@seferid ORDER BY yolcuKoltukNo ASC", baglan);
            dta.SelectCommand.Parameters.AddWithValue("@seferid", txtSeferidsi.Text);
            dta.Fill(dt);
            yolcuListesi yoliste = new yolcuListesi();
            yoliste.SetDataSource(dt);
            ReportViewer.ReportSource= yoliste;
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
