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
    public partial class Stok : UserControl
    {
        public Stok()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source =DESKTOP-F2SN8FC; Initial Catalog =WMS; Integrated Security =true");
        SqlConnection connection = new SqlConnection("Data Source =DESKTOP-F2SN8FC; Initial Catalog =WMS; Integrated Security =TRUE");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        public void verilerigoster(string veriler)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(veriler, baglanti);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            dtListele.DataSource = dataset.Tables[0];

        }

        private void Kayitsayisiyaz()
        {
            int kayitsayisi = dtListele.Rows.Count - 1;
            lblToplam.Text = Convert.ToString(kayitsayisi);
        }

        private void btnBarkodOlustur_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw brc = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            barkod.Image = brc.Draw(txtBarkod.Text, 75);
        }

        private void btnListeleme_Click(object sender, EventArgs e)
        {
            string getir = "Select * from Stok";
            SqlCommand komut = new SqlCommand(getir, baglanti);
            SqlDataAdapter dradapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dradapter.Fill(dt);
            dtListele.DataSource = dt;
            baglanti.Close();
            Kayitsayisiyaz();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUrunKodu.Clear();
            txtUrunAdi.Clear();
            txtUrunAdi2.Clear();
            txtDovizCinsi.Clear();
            txtFiyat.Clear();
            txtMarka.Clear();
            txtBirim.Clear();
            txtSkt.Clear();
            txtBarkod.Clear();
            barkod.Enabled = false;
        }

        private void dtListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunKodu.Text = dtListele.CurrentRow.Cells["UrunKodu"].Value.ToString();
            txtUrunAdi.Text = dtListele.CurrentRow.Cells["UrunAdi"].Value.ToString();
            txtUrunAdi2.Text = dtListele.CurrentRow.Cells["UrunAdi2"].Value.ToString();
            txtDovizCinsi.Text = dtListele.CurrentRow.Cells["DovizCinsi"].Value.ToString();
            txtFiyat.Text = dtListele.CurrentRow.Cells["SatisFiyati"].Value.ToString();
            txtMarka.Text = dtListele.CurrentRow.Cells["Marka"].Value.ToString();
            txtBirim.Text = dtListele.CurrentRow.Cells["Birim"].Value.ToString();
            txtSkt.Text = dtListele.CurrentRow.Cells["Skt"].Value.ToString();
            txtBarkod.Text = dtListele.CurrentRow.Cells["Barkod"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Stok set UrunAdi=@UrunAdi,UrunAdi2=@UrunAdi2,DovizCinsi=@DovizCinsi,SatisFiyati=@SatisFiyati,Marka=@Marka,Birim=@Birim,Skt=@Skt,Barkod=@Barkod where UrunKodu=@UrunKodu ", baglanti);
            komut.Parameters.AddWithValue("@UrunKodu", txtUrunKodu.Text);
            komut.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@UrunAdi2", txtUrunAdi2.Text);
            komut.Parameters.AddWithValue("@DovizCinsi", txtDovizCinsi.Text);
            komut.Parameters.AddWithValue("@SatisFiyati", Double.Parse(txtFiyat.Text));
            komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
            komut.Parameters.AddWithValue("@Birim", txtBirim.Text);
            komut.Parameters.AddWithValue("@Skt", txtSkt.Text);
            komut.Parameters.AddWithValue("@Barkod", txtBarkod.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * from Stok");
            baglanti.Close();
            MessageBox.Show("Stok Kaydı Güncellendi.", "Güncelleme Ekranı");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Seçilen Kaydı Silmek İstediğinize Emin Misiniz ? " , "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(" delete from Stok where UrunKodu= '" + dtListele.CurrentRow.Cells["UrunKodu"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydınız Silindi");
            }

            if (secim == DialogResult.No)
            {
                MessageBox.Show("Kaydınız Silinemedi!");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUrunKodu.Text) || string.IsNullOrEmpty(txtUrunKodu.Text) || string.IsNullOrEmpty(txtUrunKodu.Text) || string.IsNullOrEmpty(txtFiyat.Text)
           || string.IsNullOrEmpty(txtMarka.Text) || string.IsNullOrEmpty(txtBirim.Text) || string.IsNullOrEmpty(txtSkt.Text) || string.IsNullOrEmpty(txtBarkod.Text))
            {

                MessageBox.Show("Boş Alanları Doldurunuz", "Eksik İşlem Ekranı");
                return;
            }

            else
            {

                cmd = new SqlCommand();
                connection.Open();//bağlantı açılır
                cmd.Connection = connection;
                //kullanıcı adının kayıtlı olup olmadığını kontrol eder
                cmd.CommandText = "Select * from Stok where UrunKodu ='" + txtUrunKodu.Text + "'";


                dr = cmd.ExecuteReader();
                //Eğer girilen kullanıcı adı veritabanında var ise uyarı ekranı alırız
                if (dr.Read())
                {
                    MessageBox.Show("Girilen Ürün Kodu Sisteme Kayıtlıdır. Lütfen Yeni Bir Ürün Kod Giriniz ", "Uyarı Ekranı");
                    return;

                }

                connection.Close();

                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into Stok (UrunKodu,UrunAdi,UrunAdi2,DovizCinsi,SatisFiyati,Marka,Birim,Skt,Barkod) values (@UrunKodu,@UrunAdi,@UrunAdi2,@DovizCinsi,@SatisFiyati,@Marka,@Birim,@Skt,@Barkod)", baglanti);
                komut.Parameters.AddWithValue("@UrunKodu", txtUrunKodu.Text);
                komut.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@UrunAdi2", txtUrunAdi2.Text);
                komut.Parameters.AddWithValue("@DovizCinsi", txtDovizCinsi.Text);
                komut.Parameters.AddWithValue("@SatisFiyati",txtFiyat.Text);
                komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
                komut.Parameters.AddWithValue("@Birim", txtBirim.Text);
                komut.Parameters.AddWithValue("@Skt", txtSkt.Text);
                komut.Parameters.AddWithValue("@Barkod", txtBarkod.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(" Müşteri kaydınız başarıyla oluşturulmuştur.", "Kayıt Ekranı");

            }
        }

        private void Stok_Load(object sender, EventArgs e)
        {

        }
    }
}
