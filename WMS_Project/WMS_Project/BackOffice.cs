using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS_Project
{
    public partial class BackOffice : Form
    {
        public BackOffice()
        {
            InitializeComponent();
        }

        private void add_UControls(UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill;
            pnlmain.Controls.Clear();
            pnlmain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            foreach (var pnl in Menu.Controls.OfType<Panel>())
           
                pnl.BackColor = Color.WhiteSmoke;
            

            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnCari":
                    add_UControls(new Cari());
                    pnlCari.BackColor = Color.WhiteSmoke;
                    break;

                case "btnStok":
                    add_UControls(new Stok());
                    pnlStok.BackColor = Color.WhiteSmoke;
                    break;

                case "btnAlim":
                    add_UControls(new Alim());
                    pnlAlim.BackColor = Color.WhiteSmoke;
                    break;

                case "btnSatis":
                    add_UControls(new Satis());
                    pnlSatis.BackColor = Color.WhiteSmoke;
                    break;

                case "btnAyarlar":
                    add_UControls(new Ayarlar());
                    pnlAyarlar.BackColor = Color.WhiteSmoke;
                    break;

                case "btnYardim":
                    add_UControls(new Yardim());
                    pnlYardim.BackColor = Color.WhiteSmoke;
                    break;
            }
        }
        private void btnCari_Click(object sender, EventArgs e)
        {
            //BackOffice frm2 = new BackOffice();
            //frm2.TopLevel = false;
            //panel1.Controls.Add(frm2); // panel1 içerisinde formu ekledik
        }

        private void BackOffice_Load(object sender, EventArgs e)
        {

        }

        private void BackOffice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Giris form = new Giris();
            form.Show();
        }
    }
}
