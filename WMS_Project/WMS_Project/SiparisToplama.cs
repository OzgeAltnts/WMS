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
    public partial class SiparisToplama : UserControl
    {
        public SiparisToplama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source =DESKTOP-F2SN8FC; Initial Catalog =WMS; Integrated Security =true");
        SqlConnection connection = new SqlConnection("Data Source =DESKTOP-F2SN8FC; Initial Catalog =WMS; Integrated Security =TRUE");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(@"
            Insert into SiparisHareket 
            (MalKodu,EvrakNo,Tarih,Miktar,SecilenMiktar,KalanMiktar) 
            values 
            (@MalKodu,@EvrakNo,@Tarih,@Miktar,@SecilenMiktar,@KalanMiktar)", baglanti);
            komut.Parameters.Clear();
            komut.Parameters.AddWithValue("@MalKodu", txtMalKodu.Text);
            komut.Parameters.AddWithValue("@EvrakNo", txtEvrakNo.Text);
            komut.Parameters.AddWithValue("@Tarih", txtTarih.Text);
            komut.Parameters.AddWithValue("@Miktar", txtMiktar.Text);
            komut.Parameters.AddWithValue("@SecilenMiktar", txtSecilenMiktar.Text);
            komut.Parameters.AddWithValue("@KalanMiktar", txtKalanMiktar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(" İşleminiz başarıyla oluşturulmuştur.", "Kayıt Ekranı");
        }

        private void btnListeleme_Click(object sender, EventArgs e)
        {

            string getir = "select SiparisHareketId,MalKodu,EvrakNo,Tarih,Miktar,SecilenMiktar,KalanMiktar from SiparisHareket";
            SqlCommand komut = new SqlCommand(getir, baglanti);
            SqlDataAdapter dradapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dradapter.Fill(dt);
            dtListeleme.DataSource = dt;
            baglanti.Close();

            //SqlCommand komut = cmd = new SqlCommand(string.Format(@"
            //SELECT 
            //    Urun.MalKodu,UrunAdres.Koridor, UrunAdres.Raf, UrunAdres.Kat, UrunAdres.KoliAdi AS [Koli Adı], Urun.Miktar 
            //FROM Urun
            //LEFT JOIN UrunAdres ON UrunAdres.UrunAdresId=Urun.UrunAdresId
            //WHERE MalKodu='{0}'", txtMalKodu.Text), connection);
            //SqlDataAdapter dradapter = new SqlDataAdapter(komut);
            //DataTable dt = new DataTable();
            //dradapter.Fill(dt);
            //dtListeleme.DataSource = dt;
            //baglanti.Close();

        }

        private void dtListeleme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtMalKodu.Text = dtListeleme.CurrentRow.Cells["MalKodu"].Value.ToString();
            //tx.Text = dtListeleme.CurrentRow.Cells["MalAdi"].Value.ToString();
            //txtEvrakNo.Text = dtListeleme.CurrentRow.Cells["EvrakNo"].Value.ToString();
            //txtGC.Text = dtListeleme.CurrentRow.Cells["[Giris/Cikis]"].Value.ToString();
            //txtEvrakTip.Text = dtListeleme.CurrentRow.Cells["EvrakTip"].Value.ToString();
            //txtTarih.Text = dtListeleme.CurrentRow.Cells["Tarih"].Value.ToString();
            //txtEvrakNo.Text = dtListeleme.CurrentRow.Cells["Miktar"].Value.ToString();
        }

        private void SiparisToplama_Load(object sender, EventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Seçilen Kaydı Silmek İstediğinize Emin Misiniz ? ", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(" delete from SiparisHareket where MalKodu= '" + dtListeleme.CurrentRow.Cells["MalKodu"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydınız Silindi");
            }

            if (secim == DialogResult.No)
            {
                MessageBox.Show("Kaydınız Silinemedi!");
            }
        }
    }
}
