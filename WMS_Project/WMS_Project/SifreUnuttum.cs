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
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Xml;


namespace WMS_Project
{
    public partial class SifreUnuttum : Form
    {

        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public SifreUnuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source =DESKTOP-F2SN8FC; Initial Catalog =WMS; Integrated Security =true");
            com = new SqlCommand();
            con.Open();//bağlantı açılır
            com.Connection = con;

            com.CommandText = "Select * From KullaniciKayit where KullaniciAdi ='" + textBox1.Text + "'And Email= '" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            while (dr.Read())
            {

                try
                {
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String tarih = DateTime.Now.ToLongDateString();
                    String mailadresi = ("ozgeealtintass@gmail.com"); //Gönderici mail adresi tanımlandı
                    String sifre = ("ozge+1220"); //Gönderici şifre tanımlandı  
                    String smtpsrvr = "gmail.smtp.com"; //Mail türü tanımlandı
                    String kime = (dr["Email"].ToString()); //Alıcının mail adresi veri tabanından çekilir.
                    String konu = ("Şifre Hatırlatma Maili");
                    //Gönderilecek olan mesaj
                    String yaz = ("Sayın, " + dr["KullaniciAdi"].ToString() + "\n" + "Bizden " + tarih + " Tarihinde Şifre Hatırlatma Talebinde " +
                        "Bulundunuz" + "\n" + "Parolanız : " + dr["Sifre"].ToString() + "\n" + "İyi Çalışmalar. ");

                    smtpserver.Credentials = new NetworkCredential(mailadresi, sifre);
                    smtpserver.Port = 587;//gmail olduğu için port numarası
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;//güvenlik bağlantısını açmak için
                    smtpserver.DeliveryMethod = SmtpDeliveryMethod.Network;

                    mail.From = new MailAddress(mailadresi);//mailin kimden kime gideceği
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yaz;

                    smtpserver.Send(mail);//maili gönder

                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Girmiş Olduğunuz Bilgiler Uyuşuyor. Şifreniz Mail Adresinize Gönderilmiştir");
                    this.Hide();
                }

                catch (Exception Hata)
                {
                    MessageBox.Show(Hata.Message, "Mail Gönderme Hatası!");
                }
            }
           
        }
    }
}
