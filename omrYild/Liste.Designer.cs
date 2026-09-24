namespace omrYild
{
    partial class liste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(liste));
            this.txtSeferidsi = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtSeferSayi = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSeferidsi
            // 
            this.txtSeferidsi.Location = new System.Drawing.Point(904, 12);
            this.txtSeferidsi.Name = "txtSeferidsi";
            this.txtSeferidsi.Size = new System.Drawing.Size(24, 20);
            this.txtSeferidsi.TabIndex = 1;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(904, 38);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(24, 20);
            this.txtPlaka.TabIndex = 18;
            // 
            // txtSeferSayi
            // 
            this.txtSeferSayi.Location = new System.Drawing.Point(904, 64);
            this.txtSeferSayi.Name = "txtSeferSayi";
            this.txtSeferSayi.Size = new System.Drawing.Size(24, 20);
            this.txtSeferSayi.TabIndex = 20;
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKapat.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.Crimson;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKapat.Location = new System.Drawing.Point(393, 527);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(96, 48);
            this.btnKapat.TabIndex = 75;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(882, 578);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.txtSeferSayi);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtSeferidsi);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "liste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste";
            this.Load += new System.EventHandler(this.liste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewer;
        public System.Windows.Forms.TextBox txtSeferidsi;
        public System.Windows.Forms.TextBox txtPlaka;
        public System.Windows.Forms.TextBox txtSeferSayi;
        private System.Windows.Forms.Button btnKapat;
    }
}