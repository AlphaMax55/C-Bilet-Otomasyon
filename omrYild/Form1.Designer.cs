namespace omrYild
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sefergrid = new System.Windows.Forms.DataGridView();
            this.seferbox = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeferAra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.seferTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtSeferid = new System.Windows.Forms.TextBox();
            this.txtKoltuk = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.pcbxexit = new System.Windows.Forms.PictureBox();
            this.pcbxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sefergrid)).BeginInit();
            this.seferbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sefergrid
            // 
            this.sefergrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sefergrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sefergrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sefergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sefergrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.sefergrid.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.sefergrid.Location = new System.Drawing.Point(4, 224);
            this.sefergrid.MultiSelect = false;
            this.sefergrid.Name = "sefergrid";
            this.sefergrid.ReadOnly = true;
            this.sefergrid.RowHeadersVisible = false;
            this.sefergrid.Size = new System.Drawing.Size(818, 333);
            this.sefergrid.TabIndex = 2;
            this.sefergrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sefergrid_CellContentClick);
            this.sefergrid.DoubleClick += new System.EventHandler(this.sefergrid_DoubleClick);
            // 
            // seferbox
            // 
            this.seferbox.BackColor = System.Drawing.Color.LightGray;
            this.seferbox.Controls.Add(this.pictureBox5);
            this.seferbox.Controls.Add(this.pictureBox3);
            this.seferbox.Controls.Add(this.pictureBox2);
            this.seferbox.Controls.Add(this.label3);
            this.seferbox.Controls.Add(this.txtSeferAra);
            this.seferbox.Controls.Add(this.pictureBox1);
            this.seferbox.Controls.Add(this.lblToplam);
            this.seferbox.Controls.Add(this.label2);
            this.seferbox.Controls.Add(this.btnTemizle);
            this.seferbox.Controls.Add(this.label1);
            this.seferbox.Controls.Add(this.seferTarihi);
            this.seferbox.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seferbox.ForeColor = System.Drawing.Color.Red;
            this.seferbox.Location = new System.Drawing.Point(4, 32);
            this.seferbox.Name = "seferbox";
            this.seferbox.Size = new System.Drawing.Size(818, 192);
            this.seferbox.TabIndex = 0;
            this.seferbox.TabStop = false;
            this.seferbox.Enter += new System.EventHandler(this.seferbox_Enter);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(155, 77);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(608, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(160, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sefer:";
            // 
            // txtSeferAra
            // 
            this.txtSeferAra.BackColor = System.Drawing.Color.PeachPuff;
            this.txtSeferAra.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeferAra.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSeferAra.Location = new System.Drawing.Point(102, 142);
            this.txtSeferAra.Name = "txtSeferAra";
            this.txtSeferAra.Size = new System.Drawing.Size(162, 25);
            this.txtSeferAra.TabIndex = 12;
            this.txtSeferAra.TextChanged += new System.EventHandler(this.txtSeferAra_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(405, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.Firebrick;
            this.lblToplam.Location = new System.Drawing.Point(487, 129);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(43, 25);
            this.lblToplam.TabIndex = 9;
            this.lblToplam.Text = "Top";
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(558, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adet Sefer Mevcut";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTemizle
            // 
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTemizle.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.Location = new System.Drawing.Point(270, 116);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(84, 38);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tarih:";
            // 
            // seferTarihi
            // 
            this.seferTarihi.Font = new System.Drawing.Font("Bell MT", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seferTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.seferTarihi.Location = new System.Drawing.Point(102, 102);
            this.seferTarihi.Name = "seferTarihi";
            this.seferTarihi.Size = new System.Drawing.Size(162, 27);
            this.seferTarihi.TabIndex = 4;
            this.seferTarihi.ValueChanged += new System.EventHandler(this.seferTarihi_ValueChanged);
            // 
            // txtSeferid
            // 
            this.txtSeferid.Location = new System.Drawing.Point(855, 51);
            this.txtSeferid.Name = "txtSeferid";
            this.txtSeferid.Size = new System.Drawing.Size(48, 20);
            this.txtSeferid.TabIndex = 3;
            // 
            // txtKoltuk
            // 
            this.txtKoltuk.Location = new System.Drawing.Point(855, 88);
            this.txtKoltuk.Name = "txtKoltuk";
            this.txtKoltuk.Size = new System.Drawing.Size(48, 20);
            this.txtKoltuk.TabIndex = 4;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(855, 121);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(48, 20);
            this.txtTarih.TabIndex = 5;
            // 
            // pcbxexit
            // 
            this.pcbxexit.Image = ((System.Drawing.Image)(resources.GetObject("pcbxexit.Image")));
            this.pcbxexit.Location = new System.Drawing.Point(786, 10);
            this.pcbxexit.Name = "pcbxexit";
            this.pcbxexit.Size = new System.Drawing.Size(18, 16);
            this.pcbxexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxexit.TabIndex = 11;
            this.pcbxexit.TabStop = false;
            this.pcbxexit.Click += new System.EventHandler(this.pcbxexit_Click);
            // 
            // pcbxMinimize
            // 
            this.pcbxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pcbxMinimize.Image")));
            this.pcbxMinimize.Location = new System.Drawing.Point(761, 10);
            this.pcbxMinimize.Name = "pcbxMinimize";
            this.pcbxMinimize.Size = new System.Drawing.Size(19, 16);
            this.pcbxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxMinimize.TabIndex = 12;
            this.pcbxMinimize.TabStop = false;
            this.pcbxMinimize.Click += new System.EventHandler(this.pcbxMinimize_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 27);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(67, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(62, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.sToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.aToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.aToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.aToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.yeniToolStripMenuItem.Text = "Yeni Sefer ";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sToolStripMenuItem.Text = "Yeni Bilet";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.çıkışToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(826, 560);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pcbxMinimize);
            this.Controls.Add(this.pcbxexit);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtKoltuk);
            this.Controls.Add(this.txtSeferid);
            this.Controls.Add(this.seferbox);
            this.Controls.Add(this.sefergrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sefergrid)).EndInit();
            this.seferbox.ResumeLayout(false);
            this.seferbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox seferbox;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker seferTarihi;
        public System.Windows.Forms.DataGridView sefergrid;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtKoltuk;
        public System.Windows.Forms.TextBox txtSeferid;
        public System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbxexit;
        private System.Windows.Forms.PictureBox pcbxMinimize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeferAra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

