namespace WMS_Project
{
    partial class MalKabul
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
            this.txtMalAdi = new System.Windows.Forms.TextBox();
            this.lblEvrakNo = new System.Windows.Forms.Label();
            this.btnListeleme = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtMalKodu = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtEvrakTip = new System.Windows.Forms.TextBox();
            this.lblgGC = new System.Windows.Forms.Label();
            this.lblEvrakTip = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMalAdi = new System.Windows.Forms.Label();
            this.lblMalKodu = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtGC = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtEvrakNo = new System.Windows.Forms.TextBox();
            this.BtnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtListeleme)).BeginInit();
            this.SuspendLayout();
            // 
            // dtListeleme
            // 
            this.dtListeleme.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtListeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListeleme.Location = new System.Drawing.Point(0, 165);
            this.dtListeleme.Name = "dtListeleme";
            this.dtListeleme.Size = new System.Drawing.Size(800, 196);
            this.dtListeleme.TabIndex = 22;
            this.dtListeleme.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListeleme_CellDoubleClick);
            // 
            // txtMalAdi
            // 
            this.txtMalAdi.Location = new System.Drawing.Point(147, 55);
            this.txtMalAdi.Multiline = true;
            this.txtMalAdi.Name = "txtMalAdi";
            this.txtMalAdi.Size = new System.Drawing.Size(128, 20);
            this.txtMalAdi.TabIndex = 23;
            this.txtMalAdi.Text = "etek";
            // 
            // lblEvrakNo
            // 
            this.lblEvrakNo.AutoSize = true;
            this.lblEvrakNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEvrakNo.Location = new System.Drawing.Point(38, 96);
            this.lblEvrakNo.Name = "lblEvrakNo";
            this.lblEvrakNo.Size = new System.Drawing.Size(103, 16);
            this.lblEvrakNo.TabIndex = 24;
            this.lblEvrakNo.Text = "Evrak Numarası";
            // 
            // btnListeleme
            // 
            this.btnListeleme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeleme.Location = new System.Drawing.Point(641, 27);
            this.btnListeleme.Name = "btnListeleme";
            this.btnListeleme.Size = new System.Drawing.Size(75, 23);
            this.btnListeleme.TabIndex = 44;
            this.btnListeleme.Text = "LİSTELE";
            this.btnListeleme.UseVisualStyleBackColor = false;
            this.btnListeleme.Click += new System.EventHandler(this.btnListeleme_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(641, 79);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 45;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtMalKodu
            // 
            this.txtMalKodu.Location = new System.Drawing.Point(146, 16);
            this.txtMalKodu.Multiline = true;
            this.txtMalKodu.Name = "txtMalKodu";
            this.txtMalKodu.Size = new System.Drawing.Size(128, 20);
            this.txtMalKodu.TabIndex = 48;
            this.txtMalKodu.Text = "2145";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(435, 92);
            this.txtTarih.Multiline = true;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(128, 20);
            this.txtTarih.TabIndex = 49;
            this.txtTarih.Text = "02-02-2022";
            // 
            // txtEvrakTip
            // 
            this.txtEvrakTip.Location = new System.Drawing.Point(435, 52);
            this.txtEvrakTip.Multiline = true;
            this.txtEvrakTip.Name = "txtEvrakTip";
            this.txtEvrakTip.Size = new System.Drawing.Size(128, 20);
            this.txtEvrakTip.TabIndex = 50;
            this.txtEvrakTip.Text = "gk";
            // 
            // lblgGC
            // 
            this.lblgGC.AutoSize = true;
            this.lblgGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgGC.Location = new System.Drawing.Point(326, 17);
            this.lblgGC.Name = "lblgGC";
            this.lblgGC.Size = new System.Drawing.Size(73, 16);
            this.lblgGC.TabIndex = 51;
            this.lblgGC.Text = "Giriş / Çıkış";
            // 
            // lblEvrakTip
            // 
            this.lblEvrakTip.AutoSize = true;
            this.lblEvrakTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEvrakTip.Location = new System.Drawing.Point(326, 56);
            this.lblEvrakTip.Name = "lblEvrakTip";
            this.lblEvrakTip.Size = new System.Drawing.Size(68, 16);
            this.lblEvrakTip.TabIndex = 52;
            this.lblEvrakTip.Text = "Evrak Tipi";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Location = new System.Drawing.Point(326, 131);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(43, 16);
            this.lblMiktar.TabIndex = 53;
            this.lblMiktar.Text = "Miktar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(280, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 54;
            // 
            // lblMalAdi
            // 
            this.lblMalAdi.AutoSize = true;
            this.lblMalAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMalAdi.Location = new System.Drawing.Point(38, 59);
            this.lblMalAdi.Name = "lblMalAdi";
            this.lblMalAdi.Size = new System.Drawing.Size(52, 16);
            this.lblMalAdi.TabIndex = 55;
            this.lblMalAdi.Text = "Mal Adı";
            // 
            // lblMalKodu
            // 
            this.lblMalKodu.AutoSize = true;
            this.lblMalKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMalKodu.Location = new System.Drawing.Point(38, 19);
            this.lblMalKodu.Name = "lblMalKodu";
            this.lblMalKodu.Size = new System.Drawing.Size(63, 16);
            this.lblMalKodu.TabIndex = 56;
            this.lblMalKodu.Text = "Mal Kodu";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(326, 96);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 16);
            this.lblTarih.TabIndex = 57;
            this.lblTarih.Text = "Tarih";
            // 
            // txtGC
            // 
            this.txtGC.Location = new System.Drawing.Point(435, 14);
            this.txtGC.Multiline = true;
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(128, 20);
            this.txtGC.TabIndex = 58;
            this.txtGC.Text = "g";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(435, 130);
            this.txtMiktar.Multiline = true;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(128, 20);
            this.txtMiktar.TabIndex = 59;
            this.txtMiktar.Text = "25";
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.Location = new System.Drawing.Point(147, 92);
            this.txtEvrakNo.Multiline = true;
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Size = new System.Drawing.Size(128, 20);
            this.txtEvrakNo.TabIndex = 60;
            this.txtEvrakNo.Text = "8574";
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(641, 131);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 61;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // MalKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.txtEvrakNo);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtGC);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblMalKodu);
            this.Controls.Add(this.lblMalAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblEvrakTip);
            this.Controls.Add(this.lblgGC);
            this.Controls.Add(this.txtEvrakTip);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtMalKodu);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListeleme);
            this.Controls.Add(this.lblEvrakNo);
            this.Controls.Add(this.txtMalAdi);
            this.Controls.Add(this.dtListeleme);
            this.Name = "MalKabul";
            this.Size = new System.Drawing.Size(800, 361);
            ((System.ComponentModel.ISupportInitialize)(this.dtListeleme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListeleme;
        private System.Windows.Forms.TextBox txtMalAdi;
        private System.Windows.Forms.Label lblEvrakNo;
        private System.Windows.Forms.Button btnListeleme;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtMalKodu;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtEvrakTip;
        private System.Windows.Forms.Label lblgGC;
        private System.Windows.Forms.Label lblEvrakTip;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMalAdi;
        private System.Windows.Forms.Label lblMalKodu;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtGC;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtEvrakNo;
        private System.Windows.Forms.Button BtnSil;
    }
}
