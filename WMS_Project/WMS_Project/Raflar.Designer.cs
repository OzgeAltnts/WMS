namespace WMS_Project
{
    partial class Raflar
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
            this.dtListeleme = new System.Windows.Forms.DataGridView();
            this.btnListeleme = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblKoliAdi = new System.Windows.Forms.Label();
            this.lblKat = new System.Windows.Forms.Label();
            this.lblRaf = new System.Windows.Forms.Label();
            this.lblKoridor = new System.Windows.Forms.Label();
            this.txtKoridor = new System.Windows.Forms.TextBox();
            this.txtRaf = new System.Windows.Forms.TextBox();
            this.txtKat = new System.Windows.Forms.TextBox();
            this.txtKoliAdi = new System.Windows.Forms.TextBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblRafSayisi = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtListeleme)).BeginInit();
            this.SuspendLayout();
            // 
            // dtListeleme
            // 
            this.dtListeleme.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtListeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListeleme.Location = new System.Drawing.Point(61, 230);
            this.dtListeleme.Name = "dtListeleme";
            this.dtListeleme.Size = new System.Drawing.Size(535, 220);
            this.dtListeleme.TabIndex = 0;
            this.dtListeleme.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListeleme_CellDoubleClick);
            // 
            // btnListeleme
            // 
            this.btnListeleme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeleme.Location = new System.Drawing.Point(80, 204);
            this.btnListeleme.Name = "btnListeleme";
            this.btnListeleme.Size = new System.Drawing.Size(75, 23);
            this.btnListeleme.TabIndex = 23;
            this.btnListeleme.Text = "LİSTELE";
            this.btnListeleme.UseVisualStyleBackColor = false;
            this.btnListeleme.Click += new System.EventHandler(this.btnListeleme_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(210, 159);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblKoliAdi
            // 
            this.lblKoliAdi.AutoSize = true;
            this.lblKoliAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoliAdi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKoliAdi.Location = new System.Drawing.Point(377, 70);
            this.lblKoliAdi.Name = "lblKoliAdi";
            this.lblKoliAdi.Size = new System.Drawing.Size(56, 15);
            this.lblKoliAdi.TabIndex = 32;
            this.lblKoliAdi.Text = "Koli Adı";
            // 
            // lblKat
            // 
            this.lblKat.AutoSize = true;
            this.lblKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKat.Location = new System.Drawing.Point(377, 46);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(28, 15);
            this.lblKat.TabIndex = 31;
            this.lblKat.Text = "Kat";
            // 
            // lblRaf
            // 
            this.lblRaf.AutoSize = true;
            this.lblRaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRaf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRaf.Location = new System.Drawing.Point(87, 80);
            this.lblRaf.Name = "lblRaf";
            this.lblRaf.Size = new System.Drawing.Size(29, 15);
            this.lblRaf.TabIndex = 30;
            this.lblRaf.Text = "Raf";
            // 
            // lblKoridor
            // 
            this.lblKoridor.AutoSize = true;
            this.lblKoridor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoridor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKoridor.Location = new System.Drawing.Point(87, 47);
            this.lblKoridor.Name = "lblKoridor";
            this.lblKoridor.Size = new System.Drawing.Size(54, 15);
            this.lblKoridor.TabIndex = 29;
            this.lblKoridor.Text = "Koridor";
            // 
            // txtKoridor
            // 
            this.txtKoridor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKoridor.Location = new System.Drawing.Point(157, 44);
            this.txtKoridor.Name = "txtKoridor";
            this.txtKoridor.Size = new System.Drawing.Size(100, 21);
            this.txtKoridor.TabIndex = 25;
            // 
            // txtRaf
            // 
            this.txtRaf.Location = new System.Drawing.Point(157, 75);
            this.txtRaf.Name = "txtRaf";
            this.txtRaf.Size = new System.Drawing.Size(100, 20);
            this.txtRaf.TabIndex = 26;
            // 
            // txtKat
            // 
            this.txtKat.Location = new System.Drawing.Point(450, 42);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(100, 20);
            this.txtKat.TabIndex = 27;
            // 
            // txtKoliAdi
            // 
            this.txtKoliAdi.Location = new System.Drawing.Point(450, 68);
            this.txtKoliAdi.Name = "txtKoliAdi";
            this.txtKoliAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKoliAdi.TabIndex = 28;
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(412, 159);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 33;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(311, 159);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(81, 23);
            this.btnGuncelle.TabIndex = 34;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblRafSayisi
            // 
            this.lblRafSayisi.AutoSize = true;
            this.lblRafSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRafSayisi.Location = new System.Drawing.Point(477, 214);
            this.lblRafSayisi.Name = "lblRafSayisi";
            this.lblRafSayisi.Size = new System.Drawing.Size(100, 13);
            this.lblRafSayisi.TabIndex = 35;
            this.lblRafSayisi.Text = "Toplam Ürün Adresi";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToplam.Location = new System.Drawing.Point(577, 214);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(25, 13);
            this.lblToplam.TabIndex = 36;
            this.lblToplam.Text = "___";
            // 
            // Raflar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblRafSayisi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.lblKoliAdi);
            this.Controls.Add(this.lblKat);
            this.Controls.Add(this.lblRaf);
            this.Controls.Add(this.lblKoridor);
            this.Controls.Add(this.txtKoridor);
            this.Controls.Add(this.txtRaf);
            this.Controls.Add(this.txtKat);
            this.Controls.Add(this.txtKoliAdi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListeleme);
            this.Controls.Add(this.dtListeleme);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Raflar";
            this.Size = new System.Drawing.Size(655, 450);
            this.Load += new System.EventHandler(this.Raflar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtListeleme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListeleme;
        private System.Windows.Forms.Button btnListeleme;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblKoliAdi;
        private System.Windows.Forms.Label lblKat;
        private System.Windows.Forms.Label lblRaf;
        private System.Windows.Forms.Label lblKoridor;
        private System.Windows.Forms.TextBox txtKoridor;
        private System.Windows.Forms.TextBox txtRaf;
        private System.Windows.Forms.TextBox txtKat;
        private System.Windows.Forms.TextBox txtKoliAdi;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblRafSayisi;
        private System.Windows.Forms.Label lblToplam;
    }
}
