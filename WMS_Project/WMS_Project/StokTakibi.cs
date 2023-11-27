using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS_Project
{
    public partial class StokTakibi : UserControl
    {
        public StokTakibi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source =DESKTOP-F2SN8FC; Initial Catalog =WMS; Integrated Security =true");
        SqlConnection connection = new SqlConnection("Data Source =DESKTOP-F2SN8FC; Initial Catalog =WMS; Integrated Security =TRUE");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        private void ToplamMiktar()
        {
            double toplam = 0;
            for (int i = 0; i < dtListele.Rows.Count; i++)
            {
                toplam += Convert.ToDouble(dtListele.Rows[i].Cells[5].Value);
            }
            lblToplam.Text = "Toplam Miktar : " + toplam;
        }

        private void dtListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListeleme_Click(object sender, EventArgs e)
        {
            SqlCommand komut = cmd = new SqlCommand(string.Format(@"
            SELECT 
                Urun.MalKodu,StokTakip.EvrakNo,StokTakip.[Giris/Cikis],StokTakip.EvrakTip,StokTakip.Tarih, Urun.Miktar
            FROM Urun
            LEFT JOIN UrunAdres ON UrunAdres.UrunAdresId=Urun.UrunAdresId
            LEFT JOIN StokTakip ON StokTakip.StokTakipId=StokTakip.StokTakipId
            WHERE MalKodu='{0}'", cmboxmlkodu.Text), connection);
            SqlDataAdapter dradapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dradapter.Fill(dt);
            dtListele.DataSource = dt;
            baglanti.Close();
            ToplamMiktar();
        }

        private void StokTakibi_Load(object sender, EventArgs e)
        {
            //ürün tablosundan veri çekip comboBox içerisine koyuyoruz.
            cmboxmlkodu.Items.Clear();
            cmd = new SqlCommand(string.Format(@"select * from Urun", cmboxmlkodu.Text), connection);
            da = new SqlDataAdapter(cmd);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            cmboxmlkodu.DisplayMember = "MalKodu";
            cmboxmlkodu.ValueMember = "UrunId";
            cmboxmlkodu.DataSource = tablo;

            cmboxmaladi.DisplayMember = "MalAdi";
            cmboxmaladi.ValueMember = "UrunId";
            cmboxmaladi.DataSource = tablo;
        }
    }
}
