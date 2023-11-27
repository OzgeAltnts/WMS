namespace WMS_Project
{
    partial class KullaniciKayit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciKayit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.prgsbarGüvenlik = new System.Windows.Forms.ProgressBar();
            this.cmboxGrup = new System.Windows.Forms.ComboBox();
            this.lblSifreTekrar = new System.Windows.Forms.Label();
            this.txtSifteTekrar = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblGrup = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 215);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(290, 304);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(150, 20);
            this.txtMail.TabIndex = 36;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(182, 309);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(49, 15);
            this.lblMail.TabIndex = 33;
            this.lblMail.Text = "E-mail";
            // 
            // prgsbarGüvenlik
            // 
            this.prgsbarGüvenlik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prgsbarGüvenlik.Location = new System.Drawing.Point(451, 352);
            this.prgsbarGüvenlik.Maximum = 3;
            this.prgsbarGüvenlik.Name = "prgsbarGüvenlik";
            this.prgsbarGüvenlik.Size = new System.Drawing.Size(25, 10);
            this.prgsbarGüvenlik.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgsbarGüvenlik.TabIndex = 32;
            this.prgsbarGüvenlik.Visible = false;
            // 
            // cmboxGrup
            // 
            this.cmboxGrup.FormattingEnabled = true;
            this.cmboxGrup.ItemHeight = 13;
            this.cmboxGrup.Location = new System.Drawing.Point(290, 327);
            this.cmboxGrup.Name = "cmboxGrup";
            this.cmboxGrup.Size = new System.Drawing.Size(150, 21);
            this.cmboxGrup.TabIndex = 37;
            this.cmboxGrup.SelectedIndexChanged += new System.EventHandler(this.cmboxGrup_SelectedIndexChanged);
            // 
            // lblSifreTekrar
            // 
            this.lblSifreTekrar.AutoSize = true;
            this.lblSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreTekrar.Location = new System.Drawing.Point(182, 383);
            this.lblSifreTekrar.Name = "lblSifreTekrar";
            this.lblSifreTekrar.Size = new System.Drawing.Size(82, 15);
            this.lblSifreTekrar.TabIndex = 31;
            this.lblSifreTekrar.Text = "Şifre Tekrar";
            // 
            // txtSifteTekrar
            // 
            this.txtSifteTekrar.Location = new System.Drawing.Point(290, 378);
            this.txtSifteTekrar.MaxLength = 8;
            this.txtSifteTekrar.Name = "txtSifteTekrar";
            this.txtSifteTekrar.PasswordChar = '*';
            this.txtSifteTekrar.Size = new System.Drawing.Size(150, 20);
            this.txtSifteTekrar.TabIndex = 39;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(290, 352);
            this.txtSifre.MaxLength = 8;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(150, 20);
            this.txtSifre.TabIndex = 38;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(290, 280);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(150, 20);
            this.txtKullaniciAd.TabIndex = 35;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(290, 254);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(150, 20);
            this.txtAd.TabIndex = 34;
            // 
            // btnKayıt
            // 
            this.btnKayıt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKayıt.Location = new System.Drawing.Point(328, 404);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnKayıt.Size = new System.Drawing.Size(75, 23);
            this.btnKayıt.TabIndex = 40;
            this.btnKayıt.Text = "EKLE";
            this.btnKayıt.UseVisualStyleBackColor = false;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(182, 357);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(37, 15);
            this.lblSifre.TabIndex = 30;
            this.lblSifre.Text = "Şifre";
            // 
            // lblGrup
            // 
            this.lblGrup.AutoSize = true;
            this.lblGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGrup.Location = new System.Drawing.Point(182, 333);
            this.lblGrup.Name = "lblGrup";
            this.lblGrup.Size = new System.Drawing.Size(38, 15);
            this.lblGrup.TabIndex = 29;
            this.lblGrup.Text = "Grup";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(180, 285);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(87, 15);
            this.lblKullanici.TabIndex = 28;
            this.lblKullanici.Text = "Kullanıcı Adı";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(182, 259);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(66, 15);
            this.lblAd.TabIndex = 27;
            this.lblAd.Text = "Ad Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 43;
            // 
            // KullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.prgsbarGüvenlik);
            this.Controls.Add(this.cmboxGrup);
            this.Controls.Add(this.lblSifreTekrar);
            this.Controls.Add(this.txtSifteTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblGrup);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KullaniciKayit";
            this.Size = new System.Drawing.Size(655, 450);
            this.Load += new System.EventHandler(this.KullaniciKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.ProgressBar prgsbarGüvenlik;
        private System.Windows.Forms.ComboBox cmboxGrup;
        private System.Windows.Forms.Label lblSifreTekrar;
        private System.Windows.Forms.TextBox txtSifteTekrar;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblGrup;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
