namespace WMS_Project
{
    partial class SiparisToplama
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
            this.lblMalKodu = new System.Windows.Forms.Label();
            this.txtMalKodu = new System.Windows.Forms.TextBox();
            this.txtEvrakNo = new System.Windows.Forms.TextBox();
            this.lblEvrakNo = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecilenMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKalanMiktar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnListeleme = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtListeleme)).BeginInit();
            this.SuspendLayout();
            // 
            // dtListeleme
            // 
            this.dtListeleme.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtListeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListeleme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtListeleme.Location = new System.Drawing.Point(0, 165);
            this.dtListeleme.Name = "dtListeleme";
            this.dtListeleme.Size = new System.Drawing.Size(800, 196);
            this.dtListeleme.TabIndex = 23;
            this.dtListeleme.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListeleme_CellDoubleClick);
            // 
            // lblMalKodu
            // 
            this.lblMalKodu.AutoSize = true;
            this.lblMalKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMalKodu.Location = new System.Drawing.Point(25, 21);
            this.lblMalKodu.Name = "lblMalKodu";
            this.lblMalKodu.Size = new System.Drawing.Size(63, 16);
            this.lblMalKodu.TabIndex = 58;
            this.lblMalKodu.Text = "Mal Kodu";
            // 
            // txtMalKodu
            // 
            this.txtMalKodu.Location = new System.Drawing.Point(134, 20);
            this.txtMalKodu.Multiline = true;
            this.txtMalKodu.Name = "txtMalKodu";
            this.txtMalKodu.Size = new System.Drawing.Size(128, 20);
            this.txtMalKodu.TabIndex = 57;
            this.txtMalKodu.Text = "2145";
            // 
            // txtEvrakNo
            // 
            this.txtEvrakNo.Location = new System.Drawing.Point(134, 59);
            this.txtEvrakNo.Multiline = true;
            this.txtEvrakNo.Name = "txtEvrakNo";
            this.txtEvrakNo.Size = new System.Drawing.Size(128, 20);
            this.txtEvrakNo.TabIndex = 62;
            this.txtEvrakNo.Text = "25";
            // 
            // lblEvrakNo
            // 
            this.lblEvrakNo.AutoSize = true;
            this.lblEvrakNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEvrakNo.Location = new System.Drawing.Point(25, 63);
            this.lblEvrakNo.Name = "lblEvrakNo";
            this.lblEvrakNo.Size = new System.Drawing.Size(103, 16);
            this.lblEvrakNo.TabIndex = 61;
            this.lblEvrakNo.Text = "Evrak Numarası";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(407, 18);
            this.txtMiktar.Multiline = true;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(128, 20);
            this.txtMiktar.TabIndex = 64;
            this.txtMiktar.Text = "25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(303, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Miktar";
            // 
            // txtSecilenMiktar
            // 
            this.txtSecilenMiktar.Location = new System.Drawing.Point(407, 59);
            this.txtSecilenMiktar.Multiline = true;
            this.txtSecilenMiktar.Name = "txtSecilenMiktar";
            this.txtSecilenMiktar.Size = new System.Drawing.Size(128, 20);
            this.txtSecilenMiktar.TabIndex = 66;
            this.txtSecilenMiktar.Text = "25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(303, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Seçilen Miktar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtKalanMiktar
            // 
            this.txtKalanMiktar.Location = new System.Drawing.Point(407, 100);
            this.txtKalanMiktar.Multiline = true;
            this.txtKalanMiktar.Name = "txtKalanMiktar";
            this.txtKalanMiktar.Size = new System.Drawing.Size(128, 20);
            this.txtKalanMiktar.TabIndex = 68;
            this.txtKalanMiktar.Text = "25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(303, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "Kalan Miktar";
            // 
            // btnListeleme
            // 
            this.btnListeleme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeleme.Location = new System.Drawing.Point(626, 63);
            this.btnListeleme.Name = "btnListeleme";
            this.btnListeleme.Size = new System.Drawing.Size(75, 23);
            this.btnListeleme.TabIndex = 69;
            this.btnListeleme.Text = "LİSTELE";
            this.btnListeleme.UseVisualStyleBackColor = false;
            this.btnListeleme.Click += new System.EventHandler(this.btnListeleme_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(626, 24);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 70;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(626, 101);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 71;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(134, 101);
            this.txtTarih.Multiline = true;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(128, 20);
            this.txtTarih.TabIndex = 73;
            this.txtTarih.Text = "25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Tarih";
            // 
            // SiparisToplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListeleme);
            this.Controls.Add(this.txtKalanMiktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSecilenMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEvrakNo);
            this.Controls.Add(this.lblEvrakNo);
            this.Controls.Add(this.lblMalKodu);
            this.Controls.Add(this.txtMalKodu);
            this.Controls.Add(this.dtListeleme);
            this.Name = "SiparisToplama";
            this.Size = new System.Drawing.Size(800, 361);
            this.Load += new System.EventHandler(this.SiparisToplama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtListeleme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListeleme;
        private System.Windows.Forms.Label lblMalKodu;
        private System.Windows.Forms.TextBox txtMalKodu;
        private System.Windows.Forms.TextBox txtEvrakNo;
        private System.Windows.Forms.Label lblEvrakNo;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecilenMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKalanMiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnListeleme;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label5;
    }
}
