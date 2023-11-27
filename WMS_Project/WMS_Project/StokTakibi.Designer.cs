namespace WMS_Project
{
    partial class StokTakibi
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
            this.cmboxmlkodu = new System.Windows.Forms.ComboBox();
            this.cmboxmaladi = new System.Windows.Forms.ComboBox();
            this.lblMalKodu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListeleme = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dtListele
            // 
            this.dtListele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListele.Location = new System.Drawing.Point(86, 115);
            this.dtListele.Name = "dtListele";
            this.dtListele.Size = new System.Drawing.Size(647, 211);
            this.dtListele.TabIndex = 1;
            this.dtListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListele_CellContentClick);
            // 
            // cmboxmlkodu
            // 
            this.cmboxmlkodu.FormattingEnabled = true;
            this.cmboxmlkodu.Location = new System.Drawing.Point(204, 72);
            this.cmboxmlkodu.Name = "cmboxmlkodu";
            this.cmboxmlkodu.Size = new System.Drawing.Size(148, 21);
            this.cmboxmlkodu.TabIndex = 39;
            // 
            // cmboxmaladi
            // 
            this.cmboxmaladi.FormattingEnabled = true;
            this.cmboxmaladi.Location = new System.Drawing.Point(440, 72);
            this.cmboxmaladi.Name = "cmboxmaladi";
            this.cmboxmaladi.Size = new System.Drawing.Size(148, 21);
            this.cmboxmaladi.TabIndex = 40;
            // 
            // lblMalKodu
            // 
            this.lblMalKodu.AutoSize = true;
            this.lblMalKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMalKodu.Location = new System.Drawing.Point(130, 78);
            this.lblMalKodu.Name = "lblMalKodu";
            this.lblMalKodu.Size = new System.Drawing.Size(68, 15);
            this.lblMalKodu.TabIndex = 41;
            this.lblMalKodu.Text = "Mal Kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(366, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mal Adı";
            // 
            // btnListeleme
            // 
            this.btnListeleme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeleme.Location = new System.Drawing.Point(627, 72);
            this.btnListeleme.Name = "btnListeleme";
            this.btnListeleme.Size = new System.Drawing.Size(75, 23);
            this.btnListeleme.TabIndex = 43;
            this.btnListeleme.Text = "LİSTELE";
            this.btnListeleme.UseVisualStyleBackColor = false;
            this.btnListeleme.Click += new System.EventHandler(this.btnListeleme_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToplam.Location = new System.Drawing.Point(582, 329);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(98, 13);
            this.lblToplam.TabIndex = 44;
            this.lblToplam.Text = "Mevcut Stok Adedi";
            // 
            // StokTakibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnListeleme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMalKodu);
            this.Controls.Add(this.cmboxmaladi);
            this.Controls.Add(this.cmboxmlkodu);
            this.Controls.Add(this.dtListele);
            this.Name = "StokTakibi";
            this.Size = new System.Drawing.Size(800, 361);
            this.Load += new System.EventHandler(this.StokTakibi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListele;
        private System.Windows.Forms.ComboBox cmboxmlkodu;
        private System.Windows.Forms.ComboBox cmboxmaladi;
        private System.Windows.Forms.Label lblMalKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListeleme;
        private System.Windows.Forms.Label lblToplam;
    }
}
