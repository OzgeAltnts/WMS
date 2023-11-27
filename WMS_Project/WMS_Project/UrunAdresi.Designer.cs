namespace WMS_Project
{
    partial class UrunAdresi
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
            this.dtListele = new System.Windows.Forms.DataGridView();
            this.btnListeleme = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.cmboxmlkodu = new System.Windows.Forms.ComboBox();
            this.cmboxmladi = new System.Windows.Forms.ComboBox();
            this.lblMalKodu = new System.Windows.Forms.Label();
            this.lblMalAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dtListele
            // 
            this.dtListele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListele.Location = new System.Drawing.Point(76, 113);
            this.dtListele.Name = "dtListele";
            this.dtListele.Size = new System.Drawing.Size(647, 211);
            this.dtListele.TabIndex = 0;
            this.dtListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListele_CellContentClick);
            // 
            // btnListeleme
            // 
            this.btnListeleme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeleme.Location = new System.Drawing.Point(632, 69);
            this.btnListeleme.Name = "btnListeleme";
            this.btnListeleme.Size = new System.Drawing.Size(75, 23);
            this.btnListeleme.TabIndex = 28;
            this.btnListeleme.Text = "LİSTELE";
            this.btnListeleme.UseVisualStyleBackColor = false;
            this.btnListeleme.Click += new System.EventHandler(this.btnListeleme_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToplam.Location = new System.Drawing.Point(607, 327);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(22, 13);
            this.lblToplam.TabIndex = 37;
            this.lblToplam.Text = "-----";
            // 
            // cmboxmlkodu
            // 
            this.cmboxmlkodu.FormattingEnabled = true;
            this.cmboxmlkodu.Location = new System.Drawing.Point(185, 71);
            this.cmboxmlkodu.Name = "cmboxmlkodu";
            this.cmboxmlkodu.Size = new System.Drawing.Size(148, 21);
            this.cmboxmlkodu.TabIndex = 38;
            // 
            // cmboxmladi
            // 
            this.cmboxmladi.FormattingEnabled = true;
            this.cmboxmladi.Location = new System.Drawing.Point(431, 71);
            this.cmboxmladi.Name = "cmboxmladi";
            this.cmboxmladi.Size = new System.Drawing.Size(148, 21);
            this.cmboxmladi.TabIndex = 39;
            // 
            // lblMalKodu
            // 
            this.lblMalKodu.AutoSize = true;
            this.lblMalKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMalKodu.Location = new System.Drawing.Point(117, 74);
            this.lblMalKodu.Name = "lblMalKodu";
            this.lblMalKodu.Size = new System.Drawing.Size(68, 15);
            this.lblMalKodu.TabIndex = 40;
            this.lblMalKodu.Text = "Mal Kodu";
            // 
            // lblMalAdi
            // 
            this.lblMalAdi.AutoSize = true;
            this.lblMalAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMalAdi.Location = new System.Drawing.Point(370, 74);
            this.lblMalAdi.Name = "lblMalAdi";
            this.lblMalAdi.Size = new System.Drawing.Size(55, 15);
            this.lblMalAdi.TabIndex = 41;
            this.lblMalAdi.Text = "Mal Adı";
            // 
            // UrunAdresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMalAdi);
            this.Controls.Add(this.lblMalKodu);
            this.Controls.Add(this.cmboxmladi);
            this.Controls.Add(this.cmboxmlkodu);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnListeleme);
            this.Controls.Add(this.dtListele);
            this.Name = "UrunAdresi";
            this.Size = new System.Drawing.Size(800, 361);
            this.Load += new System.EventHandler(this.UrunAdresi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListele;
        private System.Windows.Forms.Button btnListeleme;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.ComboBox cmboxmlkodu;
        private System.Windows.Forms.ComboBox cmboxmladi;
        private System.Windows.Forms.Label lblMalKodu;
        private System.Windows.Forms.Label lblMalAdi;
    }
}
