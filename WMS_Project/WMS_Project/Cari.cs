using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WMS_Project
{
    public partial class Cari : UserControl
    {
        public Cari()
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
            dtListemele.DataSource = dataset.Tables[0];
           

        }

        private void Kayitsayisiyaz()
        {
            int kayitsayisi = dtListemele.Rows.Count - 1;
            lblToplam.Text = Convert.ToString(kayitsayisi);
        }


        private void btnListeleme_Click(object sender, EventArgs e)
        {
            string getir = "Select * from Cari";
            SqlCommand komut = new SqlCommand(getir, baglanti);
            SqlDataAdapter dradapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dradapter.Fill(dt);
            dtListemele.DataSource = dt;
            baglanti.Close();
            Kayitsayisiyaz();

        }


        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            

             if (String.IsNullOrEmpty(txtKod.Text) || string.IsNullOrEmpty(txtUnvan.Text) || string.IsNullOrEmpty(txtBakiye.Text) || string.IsNullOrEmpty(txtIl.Text)
            || string.IsNullOrEmpty(txtIlce.Text) || string.IsNullOrEmpty(txtPostaKodu.Text) || string.IsNullOrEmpty(txtUlke.Text) || string.IsNullOrEmpty(txtAdres.Text)
            || string.IsNullOrEmpty(txtTelefon.Text))
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
                cmd.CommandText = "Select * from Cari where Kod ='" + txtKod.Text + "'";


                dr = cmd.ExecuteReader();
                //Eğer girilen kullanıcı adı veritabanında var ise uyarı ekranı alırız
                if (dr.Read())
                {
                    MessageBox.Show("Girilen Cari Kodu Sisteme Kayıtlıdır. Lütfen Yeni Bir Kod Giriniz ", "Uyarı Ekranı");
                    return;

                }
                connection.Close();
                connection.Close();

                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into Cari (Kod,Unvan,Unvan2,Bakiye,Il,Ilce,PostaKodu,Ulke,Adres,Telefon) values (@Kod,@Unvan,@Unvan2,@Bakiye,@Il,@Ilce,@PostaKodu,@Ulke,@Adres,@Telefon)", baglanti);
                komut.Parameters.AddWithValue("@Kod", txtKod.Text);
                komut.Parameters.AddWithValue("@Unvan", txtUnvan.Text);
                komut.Parameters.AddWithValue("@Unvan2", txtUnvan2.Text);
                komut.Parameters.AddWithValue("@Bakiye", txtBakiye.Text);
                komut.Parameters.AddWithValue("@Il", txtIl.Text);
                komut.Parameters.AddWithValue("@Ilce", txtIlce.Text);
                komut.Parameters.AddWithValue("@PostaKodu", txtPostaKodu.Text);
                komut.Parameters.AddWithValue("@Ulke", txtUlke.Text);
                komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(" Müşteri kaydınız başarıyla oluşturulmuştur.", "Kayıt Ekranı");

            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKod.Clear();
            txtUnvan.Clear();
            txtUnvan2.Clear();
            txtBakiye.Clear();
            txtIl.Clear();
            txtIlce.Clear();
            txtPostaKodu.Clear();
            txtUlke.Clear();
            txtAdres.Clear();
            txtTelefon.Clear();
           
        }


        private void dtListemele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKod.Text = dtListemele.CurrentRow.Cells["Kod"].Value.ToString();
            txtUnvan.Text = dtListemele.CurrentRow.Cells["Unvan"].Value.ToString();
            txtUnvan2.Text = dtListemele.CurrentRow.Cells["Unvan2"].Value.ToString();
            txtBakiye.Text = dtListemele.CurrentRow.Cells["Bakiye"].Value.ToString();
            txtIl.Text = dtListemele.CurrentRow.Cells["Il"].Value.ToString();
            txtIlce.Text = dtListemele.CurrentRow.Cells["Ilce"].Value.ToString();
            txtPostaKodu.Text = dtListemele.CurrentRow.Cells["PostaKodu"].Value.ToString();
            txtUlke.Text = dtListemele.CurrentRow.Cells["Ulke"].Value.ToString();
            txtAdres.Text = dtListemele.CurrentRow.Cells["Adres"].Value.ToString();
            txtTelefon.Text = dtListemele.CurrentRow.Cells["Telefon"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Cari set Unvan=@Unvan,Unvan2=@Unvan2,Bakiye=@Bakiye,Il=@Il,Ilce=@Ilce,PostaKodu=@PostaKodu,Ulke=@Ulke,Adres=@Adres,Telefon=@Telefon where  Kod=@Kod ",baglanti);
            komut.Parameters.AddWithValue("@Kod", txtKod.Text);
            komut.Parameters.AddWithValue("@Unvan", txtUnvan.Text);
            komut.Parameters.AddWithValue("@Unvan2", txtUnvan2.Text);
            komut.Parameters.AddWithValue("@Bakiye", Double.Parse( txtBakiye.Text));
            komut.Parameters.AddWithValue("@Il", txtIl.Text);
            komut.Parameters.AddWithValue("@Ilce", txtIlce.Text);
            komut.Parameters.AddWithValue("@PostaKodu", txtPostaKodu.Text);
            komut.Parameters.AddWithValue("@Ulke", txtUlke.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * from Cari");
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Güncellendi.", "Güncelleme Ekranı");
            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Seçilen Kaydı Silmek İstediğinize Emin Misiniz ? ", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(" delete from Cari where Kod= '" + dtListemele.CurrentRow.Cells["Kod"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydınız Silindi");
            }

            if (secim == DialogResult.No)
            {
                MessageBox.Show("Kaydınız Silinemedi!");
            }
           
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Cari where Kod like '%" + txtArama.Text + "%'", baglanti);
            adapter.Fill(tablo);
            dtListemele.DataSource = tablo;
            baglanti.Close() ;
        }



        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);

            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txtBakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);

            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txtPostaKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)
                  && !char.IsSeparator(e.KeyChar);

            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void Cari_Load(object sender, EventArgs e)
        {

        }

        private void lblRafSayisi_Click(object sender, EventArgs e)
        {

        }

        private void dtListemele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

  