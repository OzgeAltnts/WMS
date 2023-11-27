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
    public partial class KullaniciKayit : UserControl
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        //sql bağlantısını yapıyoruz
        SqlConnection connection = new SqlConnection("Data Source =DESKTOP-F2SN8FC; Initial Catalog =WMS; Integrated Security =TRUE");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        private void KullaniciKayit_Load(object sender, EventArgs e)
        {
            //Grup tablosundan veri çekip comboBox içerisine koyuyoruz.
            cmd = new SqlCommand("select * from Grup", connection);
            da = new SqlDataAdapter(cmd);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            cmboxGrup.DisplayMember = "GrupAdi";
            cmboxGrup.ValueMember = "Id";
            cmboxGrup.DataSource = tablo;

        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            try
            {
                //alanların boş olup olmadığını kontrol eder doğruysa messageBoks çalışır
                if (String.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtKullaniciAd.Text) || string.IsNullOrEmpty(cmboxGrup.Text)
                    || string.IsNullOrEmpty(txtSifre.Text) || string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtSifteTekrar.Text))
                {
                    MessageBox.Show("Boş Alanları Doldurunuz", "Eksik İşlem Ekranı");
                }
                //Girilen iki şifre birbiriyle aynı değise messageBox çalışır
                else if (txtSifre.Text != txtSifteTekrar.Text)
                {
                    MessageBox.Show("Şifre Tekrarı Hatalı", "Parola Kayıt Ekranı");
                }

                else
                {
                    cmd = new SqlCommand();
                    connection.Open();//bağlantı açılır
                    cmd.Connection = connection;
                    //kullanıcı adının kayıtlı olup olmadığını kontrol eder
                    cmd.CommandText = "Select * From KullaniciKayit where KullaniciAdi ='" + txtKullaniciAd.Text + "'";


                    dr = cmd.ExecuteReader();
                    //Eğer girilen kullanıcı adı veritabanında var ise uyarı ekranı alırız
                    if (dr.Read())
                    {
                        MessageBox.Show("Kullanıcı Mevcut", "Uyarı Ekranı");
                        return;

                    }

                    dr.Close();

                    //Kayıt sorgusu oluşturulur ve textlere yazılan veriler sql de kaydolur.
                    //oluşturulan parametreleri textboxtan çekip KullaniciKayıt tablomuza arat
                    cmd = new SqlCommand(@"
                    Insert into KullaniciKayit
                    (AdSoyad,KullaniciAdi,Email,Grup,Sifre,SifreTekrar) 
                    values 
                    (@AdSoyad,@KullaniciAdi,@Email,@Grup,@Sifre,@SifreTekrar)", connection);

                    //oluşturulan parametreleri textboxtan çekip KullaniciKayıt tablomuza arat
                    cmd.Parameters.AddWithValue("@AdSoyad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAd.Text);
                    cmd.Parameters.AddWithValue("@Email", txtMail.Text);
                    cmd.Parameters.AddWithValue("@Grup", cmboxGrup.SelectedValue);
                    cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                    cmd.Parameters.AddWithValue("@SifreTekrar", txtSifteTekrar.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close(); //bağlantı kapanır ve yeni kişi oluşturulur

                    MessageBox.Show("Kaydınız başarıyla oluşturulmuştur.", "Kayıt Ekranı");

                    //kişi oluşturulunca textlerin içini temizler.
                    txtAd.Clear();
                    txtKullaniciAd.Clear();
                    cmboxGrup.Text = "";
                    txtSifre.Clear();
                    txtMail.Clear();
                    txtSifteTekrar.Clear();

                }
            }
            catch (Exception) //hata yakalarsa gelecek olan mesaj
            {
                MessageBox.Show("Hatalı Giriş Yaptınız", "HataEKranı");
            }
            finally
            {
                connection.Close(); //bağlantı kapatılır
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            prgsbarGüvenlik.Visible = true;

            //Şifre güvenliği için progressBar kullanıyoruz girilen karakter sayısına göre
            int karaktersayisi = txtSifre.Text.Length;
            //1 ve 2 karakterse şifre zayif
            if (karaktersayisi > 0 && karaktersayisi < 3)
            {
                prgsbarGüvenlik.Value = 1;//uzunluk
                prgsbarGüvenlik.ForeColor = Color.DarkRed;//arka plan rengi
                label2.Text = "Şifre Zayıf";

            }
            //3,4,5 karakterse şifre orta
            else if (karaktersayisi >= 3 && karaktersayisi < 6)
            {
                prgsbarGüvenlik.Value = 2;
                prgsbarGüvenlik.ForeColor = Color.Yellow;
                label2.Text = "Şifre Orta";
            }
            //6,7,8 karakterse şifre güçlü
            else if (karaktersayisi >= 6 && karaktersayisi <= 8)
            {
                prgsbarGüvenlik.Value = 3;
                prgsbarGüvenlik.ForeColor = Color.DarkGreen;
                label2.Text = "Şifre Güçlü";
            }
            //hiçbiri değil 0 ise hiçbir işlem yapmaz
            else
            {
                prgsbarGüvenlik.Value = 0;
                label2.Text = "";
                prgsbarGüvenlik.Visible = false;
            }

        }

        private void cmboxGrup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }

