using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS_Project
{
    public partial class Depo : Form
    {
        public Depo()
        {
            InitializeComponent();
        }

        private void add_UControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMenu.Controls.Clear();
            pnlMenu.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnUrunAdresi_Click(object sender, EventArgs e)
        {
            foreach (var pnl in Menu.Controls.OfType<Panel>())

                pnl.BackColor = Color.WhiteSmoke;

            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnUrunAdresi":
                    add_UControls(new UrunAdresi());
                    pnlUrunAdresi.BackColor = Color.WhiteSmoke;
                    break;

                case "btnStokTakibi":
                    add_UControls(new StokTakibi());
                    pnlStokTakibi.BackColor = Color.WhiteSmoke;
                    break;

                case "btnSiparisToplama":
                    add_UControls(new SiparisToplama());
                    pnlSiparisToplama.BackColor = Color.WhiteSmoke;
                    break;

                case "btnMalKabul":
                    add_UControls(new MalKabul());
                    pnlMalKabul.BackColor = Color.WhiteSmoke;
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

        private void Depo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Giris form = new Giris();
            form.Show();
        }

        private void Depo_Load(object sender, EventArgs e)
        {

        }
    }
}
