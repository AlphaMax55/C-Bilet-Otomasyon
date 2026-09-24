namespace omrYild
{
    partial class biletkayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(biletkayit));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.cmbSatisTip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdBay = new System.Windows.Forms.RadioButton();
            this.rdBayan = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsaat = new System.Windows.Forms.TextBox();
            this.txtGuzergah = new System.Windows.Forms.TextBox();
            this.txtSeferidsi = new System.Windows.Forms.TextBox();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.txtKontrol = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.lblUcret = new System.Windows.Forms.Label();
            this.lblodeme = new System.Windows.Forms.Label();
            this.cmbOdemeSekli = new System.Windows.Forms.ComboBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtKoltuk = new System.Windows.Forms.TextBox();
            this.pcTl = new System.Windows.Forms.PictureBox();
            this.txtSeferSayi = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcTl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Adı Soyadı :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtAdSoyad.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.txtAdSoyad.ForeColor = System.Drawing.Color.Olive;
            this.txtAdSoyad.Location = new System.Drawing.Point(152, 47);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(154, 29);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tel No:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtTelefon.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.txtTelefon.ForeColor = System.Drawing.Color.Olive;
            this.txtTelefon.Location = new System.Drawing.Point(152, 80);
            this.txtTelefon.Mask = "(###)### ## ##";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(154, 29);
            this.txtTelefon.TabIndex = 1;
            // 
            // cmbNereden
            // 
            this.cmbNereden.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbNereden.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbNereden.ForeColor = System.Drawing.Color.Olive;
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Location = new System.Drawing.Point(152, 111);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(154, 26);
            this.cmbNereden.TabIndex = 2;
            // 
            // cmbNereye
            // 
            this.cmbNereye.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbNereye.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbNereye.ForeColor = System.Drawing.Color.Olive;
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Location = new System.Drawing.Point(152, 145);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(154, 26);
            this.cmbNereye.TabIndex = 3;
            this.cmbNereye.SelectedIndexChanged += new System.EventHandler(this.cmbNereye_SelectedIndexChanged);
            // 
            // cmbSatisTip
            // 
            this.cmbSatisTip.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbSatisTip.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbSatisTip.ForeColor = System.Drawing.Color.Olive;
            this.cmbSatisTip.FormattingEnabled = true;
            this.cmbSatisTip.Items.AddRange(new object[] {
            "Rezervasyon",
            "Bilet Satış"});
            this.cmbSatisTip.Location = new System.Drawing.Point(152, 177);
            this.cmbSatisTip.Name = "cmbSatisTip";
            this.cmbSatisTip.Size = new System.Drawing.Size(154, 26);
            this.cmbSatisTip.TabIndex = 4;
            this.cmbSatisTip.SelectedIndexChanged += new System.EventHandler(this.cmbSatisTip_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nereye:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nereden:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Satış Tip:";
            // 
            // rdBay
            // 
            this.rdBay.AutoSize = true;
            this.rdBay.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold);
            this.rdBay.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.rdBay.Location = new System.Drawing.Point(152, 290);
            this.rdBay.Name = "rdBay";
            this.rdBay.Size = new System.Drawing.Size(56, 25);
            this.rdBay.TabIndex = 5;
            this.rdBay.TabStop = true;
            this.rdBay.Text = "Bay";
            this.rdBay.UseVisualStyleBackColor = true;
            // 
            // rdBayan
            // 
            this.rdBayan.AutoSize = true;
            this.rdBayan.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold);
            this.rdBayan.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.rdBayan.Location = new System.Drawing.Point(226, 290);
            this.rdBayan.Name = "rdBayan";
            this.rdBayan.Size = new System.Drawing.Size(73, 25);
            this.rdBayan.TabIndex = 6;
            this.rdBayan.TabStop = true;
            this.rdBayan.Text = "Bayan";
            this.rdBayan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(12, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cinsiyet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(129, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bilet Satış";
            // 
            // txtsaat
            // 
            this.txtsaat.Location = new System.Drawing.Point(367, 100);
            this.txtsaat.Name = "txtsaat";
            this.txtsaat.Size = new System.Drawing.Size(80, 20);
            this.txtsaat.TabIndex = 12;
            // 
            // txtGuzergah
            // 
            this.txtGuzergah.Location = new System.Drawing.Point(367, 74);
            this.txtGuzergah.Name = "txtGuzergah";
            this.txtGuzergah.Size = new System.Drawing.Size(80, 20);
            this.txtGuzergah.TabIndex = 10;
            // 
            // txtSeferidsi
            // 
            this.txtSeferidsi.Location = new System.Drawing.Point(367, 48);
            this.txtSeferidsi.Name = "txtSeferidsi";
            this.txtSeferidsi.Size = new System.Drawing.Size(80, 20);
            this.txtSeferidsi.TabIndex = 9;
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Location = new System.Drawing.Point(367, 128);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(80, 20);
            this.txtKoltukNo.TabIndex = 22;
            // 
            // txtKontrol
            // 
            this.txtKontrol.Location = new System.Drawing.Point(367, 194);
            this.txtKontrol.Name = "txtKontrol";
            this.txtKontrol.Size = new System.Drawing.Size(80, 20);
            this.txtKontrol.TabIndex = 23;
            // 
            // txtUcret
            // 
            this.txtUcret.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtUcret.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.txtUcret.ForeColor = System.Drawing.Color.Olive;
            this.txtUcret.Location = new System.Drawing.Point(152, 209);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.ReadOnly = true;
            this.txtUcret.Size = new System.Drawing.Size(73, 29);
            this.txtUcret.TabIndex = 24;
            this.txtUcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUcret.TextChanged += new System.EventHandler(this.txtUcret_TextChanged);
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblUcret.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUcret.Location = new System.Drawing.Point(12, 217);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(57, 21);
            this.lblUcret.TabIndex = 25;
            this.lblUcret.Text = "Ücret:";
            // 
            // lblodeme
            // 
            this.lblodeme.AutoSize = true;
            this.lblodeme.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblodeme.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblodeme.Location = new System.Drawing.Point(12, 253);
            this.lblodeme.Name = "lblodeme";
            this.lblodeme.Size = new System.Drawing.Size(110, 21);
            this.lblodeme.TabIndex = 27;
            this.lblodeme.Text = "Ödeme Şekli:";
            // 
            // cmbOdemeSekli
            // 
            this.cmbOdemeSekli.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbOdemeSekli.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbOdemeSekli.ForeColor = System.Drawing.Color.Olive;
            this.cmbOdemeSekli.FormattingEnabled = true;
            this.cmbOdemeSekli.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Nakit"});
            this.cmbOdemeSekli.Location = new System.Drawing.Point(152, 248);
            this.cmbOdemeSekli.Name = "cmbOdemeSekli";
            this.cmbOdemeSekli.Size = new System.Drawing.Size(154, 26);
            this.cmbOdemeSekli.TabIndex = 26;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(367, 158);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(80, 20);
            this.txtTarih.TabIndex = 29;
            // 
            // txtKoltuk
            // 
            this.txtKoltuk.Location = new System.Drawing.Point(367, 226);
            this.txtKoltuk.Name = "txtKoltuk";
            this.txtKoltuk.Size = new System.Drawing.Size(80, 20);
            this.txtKoltuk.TabIndex = 30;
            // 
            // pcTl
            // 
            this.pcTl.Image = ((System.Drawing.Image)(resources.GetObject("pcTl.Image")));
            this.pcTl.Location = new System.Drawing.Point(245, 217);
            this.pcTl.Name = "pcTl";
            this.pcTl.Size = new System.Drawing.Size(10, 14);
            this.pcTl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcTl.TabIndex = 66;
            this.pcTl.TabStop = false;
            // 
            // txtSeferSayi
            // 
            this.txtSeferSayi.Location = new System.Drawing.Point(367, 301);
            this.txtSeferSayi.Name = "txtSeferSayi";
            this.txtSeferSayi.Size = new System.Drawing.Size(80, 20);
            this.txtSeferSayi.TabIndex = 70;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(367, 261);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(80, 20);
            this.txtPlaka.TabIndex = 69;
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKapat.Font = new System.Drawing.Font("Bell MT", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.Crimson;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKapat.Location = new System.Drawing.Point(175, 330);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(91, 48);
            this.btnKapat.TabIndex = 72;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKayit.Font = new System.Drawing.Font("Bell MT", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnKayit.ForeColor = System.Drawing.Color.Crimson;
            this.btnKayit.Image = ((System.Drawing.Image)(resources.GetObject("btnKayit.Image")));
            this.btnKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayit.Location = new System.Drawing.Point(69, 330);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(90, 48);
            this.btnKayit.TabIndex = 71;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // biletkayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(349, 391);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtSeferSayi);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.pcTl);
            this.Controls.Add(this.txtKoltuk);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.lblodeme);
            this.Controls.Add(this.cmbOdemeSekli);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.txtKontrol);
            this.Controls.Add(this.txtKoltukNo);
            this.Controls.Add(this.txtsaat);
            this.Controls.Add(this.txtGuzergah);
            this.Controls.Add(this.txtSeferidsi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdBayan);
            this.Controls.Add(this.rdBay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSatisTip);
            this.Controls.Add(this.cmbNereye);
            this.Controls.Add(this.cmbNereden);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "biletkayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "biletkayit";
            this.Load += new System.EventHandler(this.biletkayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcTl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.ComboBox cmbNereden;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.ComboBox cmbSatisTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdBay;
        private System.Windows.Forms.RadioButton rdBayan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtsaat;
        public System.Windows.Forms.TextBox txtGuzergah;
        public System.Windows.Forms.TextBox txtSeferidsi;
        public System.Windows.Forms.TextBox txtKoltukNo;
        public System.Windows.Forms.TextBox txtKontrol;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label lblodeme;
        private System.Windows.Forms.ComboBox cmbOdemeSekli;
        public System.Windows.Forms.TextBox txtTarih;
        public System.Windows.Forms.TextBox txtKoltuk;
        private System.Windows.Forms.PictureBox pcTl;
        public System.Windows.Forms.TextBox txtSeferSayi;
        public System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKayit;
    }
}