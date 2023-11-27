namespace WMS_Project
{
    partial class Yetkiler
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
            this.cmboxkullanici = new System.Windows.Forms.ComboBox();
            this.btnListeleme = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtListele)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtListele
            // 
            this.dtListele.AllowUserToAddRows = false;
            this.dtListele.AllowUserToDeleteRows = false;
            this.dtListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListele.Location = new System.Drawing.Point(0, 0);
            this.dtListele.Name = "dtListele";
            this.dtListele.Size = new System.Drawing.Size(655, 391);
            this.dtListele.TabIndex = 0;
            // 
            // cmboxkullanici
            // 
            this.cmboxkullanici.FormattingEnabled = true;
            this.cmboxkullanici.Location = new System.Drawing.Point(18, 18);
            this.cmboxkullanici.Name = "cmboxkullanici";
            this.cmboxkullanici.Size = new System.Drawing.Size(121, 21);
            this.cmboxkullanici.TabIndex = 2;
            // 
            // btnListeleme
            // 
            this.btnListeleme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeleme.Location = new System.Drawing.Point(155, 18);
            this.btnListeleme.Name = "btnListeleme";
            this.btnListeleme.Size = new System.Drawing.Size(75, 23);
            this.btnListeleme.TabIndex = 44;
            this.btnListeleme.Text = "LİSTELE";
            this.btnListeleme.UseVisualStyleBackColor = false;
            this.btnListeleme.Click += new System.EventHandler(this.btnListeleme_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmboxkullanici);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnListeleme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 59);
            this.panel1.TabIndex = 45;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(246, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtListele);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 391);
            this.panel2.TabIndex = 46;
            // 
            // Yetkiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Yetkiler";
            this.Size = new System.Drawing.Size(655, 450);
            this.Load += new System.EventHandler(this.Yetkiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtListele)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListele;
        private System.Windows.Forms.ComboBox cmboxkullanici;
        private System.Windows.Forms.Button btnListeleme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}
