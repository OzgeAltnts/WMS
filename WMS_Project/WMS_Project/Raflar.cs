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
    public partial class Raflar : UserControl
    {
        public Raflar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source =DESKTOP-F2SN8FC; Initial Catalog =WMS; Integrated Security =true");


        public void verilerigoster(string veriler)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(veriler, baglanti);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            dtListeleme.DataSource = dataset.Tables[0];

        }

        private void Kayitsayisiyaz()
        {
            int kayitsayisi = dtListeleme.Rows.Count -1;
            lblToplam.Text= Convert.ToString(kayitsayisi);
        }

        private void Raflar_Load(object sender, EventArgs e)
        {

        }

        private void btnListeleme_Click(object sender, EventArgs e)
        {
            string getir = "Select * from UrunAdres";
            SqlCommand komut = new SqlCommand(getir, baglanti);
            SqlDataAdapter dradapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dradapter.Fill(dt);
            dtListeleme.DataSource = dt;
            baglanti.Close();
            Kayitsayisiyaz();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtKoridor.Text) || string.IsNullOrEmpty(txtRaf.Text) || string.IsNullOrEmpty(txtKat.Text) || string.IsNullOrEmpty(txtKoliAdi.Text))
            {

                MessageBox.Show("Boş Alanları Doldurunuz", "Eksik İşlem Ekranı");
                return;
            }

            else
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into UrunAdres (Koridor,Raf,Kat,KoliAdi) values (@Koridor,@Raf,@Kat,@KoliAdi)", baglanti);
                komut.Parameters.AddWithValue("@Koridor", txtKoridor.Text);
                komut.Parameters.AddWithValue("@Raf", txtRaf.Text);
                komut.Parameters.AddWithValue("@Kat", txtKat.Text);
                komut.Parameters.AddWithValue("@KoliAdi", txtKoliAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(" Ürün Adresi kaydınız başarıyla oluşturulmuştur.", "Kayıt Ekranı");

            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Seçilen Kaydı Silmek İstediğinize Emin Misiniz ? ", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(" delete from UrunAdres where Koridor= '" + dtListeleme.CurrentRow.Cells["Koridor"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydınız Silindi");
            }

            if (secim == DialogResult.No)
            {
                MessageBox.Show("Kaydınız Silinemedi!");
            }
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update UrunAdres set Raf=@Raf,Kat=@Kat,KoliAdi=@KoliAdi where Koridor=@Koridor ", baglanti);
            komut.Parameters.AddWithValue("@Koridor", txtKoridor.Text);
            komut.Parameters.AddWithValue("@Raf", txtRaf.Text);
            komut.Parameters.AddWithValue("@Kat", txtKat.Text);
            komut.Parameters.AddWithValue("@KoliAdi", txtKoliAdi.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * from UrunAdres");
            baglanti.Close();
            MessageBox.Show("Urün Adres Kaydı Güncellendi.", "Güncelleme Ekranı");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void dtListeleme_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKoridor.Text = dtListeleme.CurrentRow.Cells["Koridor"].Value.ToString();
            txtRaf.Text = dtListeleme.CurrentRow.Cells["Raf"].Value.ToString();
            txtKat.Text = dtListeleme.CurrentRow.Cells["Kat"].Value.ToString();
            txtKoliAdi.Text = dtListeleme.CurrentRow.Cells["KoliAdi"].Value.ToString();
            Kayitsayisiyaz();

        }
    }
}
