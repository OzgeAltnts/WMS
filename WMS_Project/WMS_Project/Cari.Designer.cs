namespace WMS_Project
{
    partial class Cari
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
            this.txtKod = new System.Windows.Forms.TextBox();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtPostaKodu = new System.Windows.Forms.TextBox();
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.txtIl = new System.Windows.Forms.TextBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.txtUnvan2 = new System.Windows.Forms.TextBox();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.lblKod = new System.Windows.Forms.Label();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.lblUnvan2 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblIl = new System.Windows.Forms.Label();
            this.lblIlce = new System.Windows.Forms.Label();
            this.lblPostaKodu = new System.Windows.Forms.Label();
            this.lblUlke = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtListemele = new System.Windows.Forms.DataGridView();
            this.wMSData = new WMS_Project.WMSData();
            this.btnListeleme = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblRafSayisi = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtListemele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(82, 4);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(100, 20);
            this.txtKod.TabIndex = 0;
            this.txtKod.Text = "DP";
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(522, 30);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(100, 20);
            this.txtUlke.TabIndex = 7;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(522, 56);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 40);
            this.txtAdres.TabIndex = 8;
            // 
            // txtPostaKodu
            // 
            this.txtPostaKodu.Location = new System.Drawing.Point(522, 4);
            this.txtPostaKodu.Name = "txtPostaKodu";
            this.txtPostaKodu.Size = new System.Drawing.Size(100, 20);
            this.txtPostaKodu.TabIndex = 6;
            this.txtPostaKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostaKodu_KeyPress);
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(295, 56);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(100, 20);
            this.txtIlce.TabIndex = 5;
            // 
            // txtIl
            // 
            this.txtIl.Location = new System.Drawing.Point(295, 30);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(100, 20);
            this.txtIl.TabIndex = 4;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(295, 4);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtBakiye.TabIndex = 3;
            this.txtBakiye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBakiye_KeyPress);
            // 
            // txtUnvan2
            // 
            this.txtUnvan2.Location = new System.Drawing.Point(82, 56);
            this.txtUnvan2.Name = "txtUnvan2";
            this.txtUnvan2.Size = new System.Drawing.Size(100, 20);
            this.txtUnvan2.TabIndex = 2;
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(82, 30);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(100, 20);
            this.txtUnvan.TabIndex = 1;
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(21, 11);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(53, 13);
            this.lblKod.TabIndex = 10;
            this.lblKod.Text = "Cari Kodu";
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Location = new System.Drawing.Point(21, 37);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(39, 13);
            this.lblUnvan.TabIndex = 11;
            this.lblUnvan.Text = "Ünvan";
            // 
            // lblUnvan2
            // 
            this.lblUnvan2.AutoSize = true;
            this.lblUnvan2.Location = new System.Drawing.Point(21, 63);
            this.lblUnvan2.Name = "lblUnvan2";
            this.lblUnvan2.Size = new System.Drawing.Size(45, 13);
            this.lblUnvan2.TabIndex = 12;
            this.lblUnvan2.Text = "Ünvan2";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(244, 11);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(39, 13);
            this.lblBakiye.TabIndex = 13;
            this.lblBakiye.Text = "Bakiye";
            // 
            // lblIl
            // 
            this.lblIl.AutoSize = true;
            this.lblIl.Location = new System.Drawing.Point(244, 37);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(12, 13);
            this.lblIl.TabIndex = 14;
            this.lblIl.Text = "İl";
            // 
            // lblIlce
            // 
            this.lblIlce.AutoSize = true;
            this.lblIlce.Location = new System.Drawing.Point(244, 63);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(24, 13);
            this.lblIlce.TabIndex = 15;
            this.lblIlce.Text = "İlçe";
            // 
            // lblPostaKodu
            // 
            this.lblPostaKodu.AutoSize = true;
            this.lblPostaKodu.Location = new System.Drawing.Point(454, 11);
            this.lblPostaKodu.Name = "lblPostaKodu";
            this.lblPostaKodu.Size = new System.Drawing.Size(62, 13);
            this.lblPostaKodu.TabIndex = 16;
            this.lblPostaKodu.Text = "Posta Kodu";
            // 
            // lblUlke
            // 
            this.lblUlke.AutoSize = true;
            this.lblUlke.Location = new System.Drawing.Point(454, 37);
            this.lblUlke.Name = "lblUlke";
            this.lblUlke.Size = new System.Drawing.Size(29, 13);
            this.lblUlke.TabIndex = 17;
            this.lblUlke.Text = "Ülke";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(454, 63);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 18;
            this.lblAdres.Text = "Adres";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(650, 11);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 19;
            this.lblTelefon.Text = "Telefon";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(273, 117);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // dtListemele
            // 
            this.dtListemele.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtListemele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListemele.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtListemele.Location = new System.Drawing.Point(0, 165);
            this.dtListemele.Name = "dtListemele";
            this.dtListemele.Size = new System.Drawing.Size(800, 196);
            this.dtListemele.TabIndex = 21;
            this.dtListemele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListemele_CellContentClick);
            this.dtListemele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListemele_CellDoubleClick);
            // 
            // wMSData
            // 
            this.wMSData.DataSetName = "WMSData";
            this.wMSData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnListeleme
            // 
            this.btnListeleme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeleme.Location = new System.Drawing.Point(3, 136);
            this.btnListeleme.Name = "btnListeleme";
            this.btnListeleme.Size = new System.Drawing.Size(75, 23);
            this.btnListeleme.TabIndex = 22;
            this.btnListeleme.Text = "LİSTELE";
            this.btnListeleme.UseVisualStyleBackColor = false;
            this.btnListeleme.Click += new System.EventHandler(this.btnListeleme_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(468, 117);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 23;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(692, 50);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(100, 20);
            this.txtArama.TabIndex = 10;
            this.txtArama.Text = "DP";
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(80, 136);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 26;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(698, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cari Kod Arama";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(371, 117);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(81, 23);
            this.btnGuncelle.TabIndex = 28;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(692, 4);
            this.txtTelefon.MaxLength = 10;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 29;
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // lblRafSayisi
            // 
            this.lblRafSayisi.AutoSize = true;
            this.lblRafSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRafSayisi.Location = new System.Drawing.Point(689, 149);
            this.lblRafSayisi.Name = "lblRafSayisi";
            this.lblRafSayisi.Size = new System.Drawing.Size(89, 13);
            this.lblRafSayisi.TabIndex = 36;
            this.lblRafSayisi.Text = "Toplam Cari Kayıt";
            this.lblRafSayisi.Click += new System.EventHandler(this.lblRafSayisi_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToplam.Location = new System.Drawing.Point(775, 149);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(25, 13);
            this.lblToplam.TabIndex = 37;
            this.lblToplam.Text = "___";
            // 
            // Cari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblRafSayisi);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.btnListeleme);
            this.Controls.Add(this.dtListemele);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblUlke);
            this.Controls.Add(this.lblPostaKodu);
            this.Controls.Add(this.lblIlce);
            this.Controls.Add(this.lblIl);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.lblUnvan2);
            this.Controls.Add(this.lblUnvan);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.txtUnvan);
            this.Controls.Add(this.txtUnvan2);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.txtIl);
            this.Controls.Add(this.txtIlce);
            this.Controls.Add(this.txtPostaKodu);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtUlke);
            this.Controls.Add(this.txtKod);
            this.Name = "Cari";
            this.Size = new System.Drawing.Size(800, 361);
            this.Load += new System.EventHandler(this.Cari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtListemele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtPostaKodu;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox txtUnvan2;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.Label lblUnvan2;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblIl;
        private System.Windows.Forms.Label lblIlce;
        private System.Windows.Forms.Label lblPostaKodu;
        private System.Windows.Forms.Label lblUlke;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dtListemele;
        private WMSData wMSData;
        private System.Windows.Forms.Button btnListeleme;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblRafSayisi;
        private System.Windows.Forms.Label lblToplam;
    }
}
