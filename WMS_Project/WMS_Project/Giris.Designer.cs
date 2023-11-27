namespace WMS_Project
{
    partial class Giris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSifreUnuttum = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chkGoster = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGiris.Location = new System.Drawing.Point(195, 335);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 27);
            this.btnGiris.TabIndex = 13;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(46, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = " ";
            // 
            // lblSifreUnuttum
            // 
            this.lblSifreUnuttum.AutoSize = true;
            this.lblSifreUnuttum.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblSifreUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreUnuttum.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSifreUnuttum.Location = new System.Drawing.Point(178, 375);
            this.lblSifreUnuttum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifreUnuttum.Name = "lblSifreUnuttum";
            this.lblSifreUnuttum.Size = new System.Drawing.Size(133, 15);
            this.lblSifreUnuttum.TabIndex = 14;
            this.lblSifreUnuttum.Text = "Şifreni mi unuttun ?";
            this.lblSifreUnuttum.Click += new System.EventHandler(this.lblSifreUnuttum_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(175, 246);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(141, 21);
            this.txtKullaniciAdi.TabIndex = 11;
            this.txtKullaniciAdi.Text = "ozge";
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(175, 293);
            this.txtSifre.MaxLength = 8;
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(141, 21);
            this.txtSifre.TabIndex = 12;
            this.txtSifre.Text = "1";
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 217);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(46, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şifre";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // chkGoster
            // 
            this.chkGoster.AutoSize = true;
            this.chkGoster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkGoster.Location = new System.Drawing.Point(322, 295);
            this.chkGoster.Name = "chkGoster";
            this.chkGoster.Size = new System.Drawing.Size(68, 19);
            this.chkGoster.TabIndex = 15;
            this.chkGoster.Text = "Göster";
            this.chkGoster.UseVisualStyleBackColor = true;
            this.chkGoster.CheckedChanged += new System.EventHandler(this.chkGoster_CheckedChanged);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(398, 413);
            this.Controls.Add(this.chkGoster);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblSifreUnuttum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAST WMS";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSifreUnuttum;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox chkGoster;
    }
}

