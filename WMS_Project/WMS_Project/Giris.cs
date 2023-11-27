using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WMS_Project
{
    public partial class Giris : Form       
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public Giris()
        {
            InitializeComponent();
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Kullanıcı adına sayı girilmesini engeller
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);

            //Boşluk engeller
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Şifreye harf girilmesi engeller
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);

            //Boşluk engeller
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
            //Enter tuşuna basılınca giriş butony aftif edilir
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGiris_Click(null, null);
            }
        }

        private void lblSifreUnuttum_Click(object sender, EventArgs e)
        {
            this.Hide();
            SifreUnuttum frm = new SifreUnuttum();
            //YeniKayit frm = new YeniKayit();
            frm.Show();
        }

        private void chkGoster_CheckedChanged(object sender, EventArgs e)
        {
            //Şifre gösterme ve gizleme özelliği verir

            txtSifre.UseSystemPasswordChar= chkGoster.CheckState == CheckState.Checked? true : false;
        }

        private void btnGiris_Click(object sender, EventArgs e)

        {
            //kullanıcı adı veya şifrenin boş geçilmesini engeller
            if (String.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {

                MessageBox.Show("Boş Geçilemez");
                return;
            }

            //sql bağlantısı kurulur
            con = new SqlConnection("Data Source =DESKTOP-F2SN8FC; Initial Catalog =WMS; Integrated Security =true");
            com = new SqlCommand();
            con.Open();//bağlantı açılır
            com.Connection = con;

            //KullaniciKayit tablosundan girilen veriler birbirini tutuyormu diye sorgu yapıyoruz
            com.CommandText = @"
            Select * From KullaniciKayit 
            where KullaniciAdi ='" + txtKullaniciAdi.Text + "' And Sifre= '" + txtSifre.Text + "'";


            dr = com.ExecuteReader();

            if (dr.Read())
            {
                int kullaniciGrup = Convert.ToInt32(dr["Grup"]);
                //Eğer kullanıcının Grubu 1 ise Depo ekranını göster.
                if (kullaniciGrup == 1)
                {
                    Depo form = new Depo();
                    form.Show();
                }
                //Eğer kullanıcının Grubu 2 ise BackOffice ekranını göster.
                else if (kullaniciGrup == 2)
                {
                   BackOffice form = new BackOffice();
                    form.Show();
                }
                //Eğer kullanıcının Grubu 3 ise Yönetici Paneli ekranını göster.
                else if (kullaniciGrup == 3)
                {
                    YoneticiPanel form = new YoneticiPanel();
                    form.Show();
                }
                //Şartların hiçbiri değil ise mesaj ekranını yazdır
                else
                {
                    MessageBox.Show("Kullanıcıya grup ataması yapılmamış.");
                    return;
                }
                //Giriş sayfasını gizle
                this.Hide();

            }
            //Girilen bilgiler yanlışsa uyarı mesajı verir
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
            }
            con.Close();
            //Bağlantı Kapatılır
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }