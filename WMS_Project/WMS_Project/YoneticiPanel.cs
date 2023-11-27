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
    public partial class YoneticiPanel : Form
    {
        public YoneticiPanel()
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

        private void pnlMenu_Click(object sender, EventArgs e)
        {
            foreach (var pnl in Menu.Controls.OfType<Panel>())

                pnl.BackColor = Color.WhiteSmoke;


            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnKullanici":
                    add_UControls(new KullaniciKayit());
                    pnlKullanici.BackColor = Color.WhiteSmoke;
                    break;

                case "btnyetkiler":
                    add_UControls(new Yetkiler());
                    pnlYetkiler.BackColor = Color.WhiteSmoke;
                    break;

                case "btnRaflar":
                    add_UControls(new Raflar());
                    pnlRaflar.BackColor = Color.WhiteSmoke;
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

        private void YoneticiPanel_Load(object sender, EventArgs e)
        {

        }

        private void YoneticiPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Giris form = new Giris();
            form.Show();
        }
    }
}
