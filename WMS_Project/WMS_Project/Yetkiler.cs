using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS_Project
{
    public partial class Yetkiler : UserControl
    {
        public Yetkiler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source =DESKTOP-F2SN8FC; Initial Catalog =WMS; Integrated Security =true");
        SqlConnection connection = new SqlConnection("Data Source =DESKTOP-F2SN8FC; Initial Catalog =WMS; Integrated Security =TRUE");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        private void Yetkiler_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from KullaniciKayit", connection);
             da = new SqlDataAdapter(cmd);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            cmboxkullanici.DisplayMember = "AdSoyad";
            cmboxkullanici.ValueMember = "Id";
            cmboxkullanici.DataSource = tablo;
        }

      

        private void btnListeleme_Click(object sender, EventArgs e)
        {
            string KullaniciId = cmboxkullanici.SelectedValue.ToString();

            string getir = @"
            SELECT Menu.MenuId, Menu.MenuAdi, Yetki.YetkiId,
            ISNULL(Kaydetme, 0) as Kaydetme, ISNULL(Silme,0) AS Silme, ISNULL(Guncelleme,0) AS Guncelleme 
            FROM Menu
            LEFT JOIN Yetki ON Menu.MenuId=Yetki.MenuId AND Yetki.KullaniciKayitId=" + KullaniciId;
            SqlCommand komut = new SqlCommand(getir, baglanti);
            SqlDataAdapter dradapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dradapter.Fill(dt);
            dtListele.DataSource = dt;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;

            baglanti.Open();
            for (counter = 0; counter < dtListele.RowCount; counter++)
            {
                var rows = dtListele.Rows[counter];


                if (rows.Cells["YetkiId"].Value!= null && rows.Cells["YetkiId"].Value.ToString() !="")
                {
                   
                    SqlCommand komut = new SqlCommand("Update Yetki set Kaydetme=@Kaydetme, Silme=@Silme, Guncelleme=@Guncelleme where  YetkiId=@YetkiId ", baglanti);
                    komut.Parameters.AddWithValue("@YetkiId", rows.Cells["YetkiId"].Value);
                    komut.Parameters.AddWithValue("@Kaydetme", rows.Cells["Kaydetme"].Value);
                    komut.Parameters.AddWithValue("@Silme", rows.Cells["Silme"].Value);
                    komut.Parameters.AddWithValue("@Guncelleme", rows.Cells["Guncelleme"].Value);
                    komut.ExecuteNonQuery();
                                    
                }
                else
                {
                    SqlCommand komut = new SqlCommand(@"
                    Insert into Yetki (MenuId,KullaniciKayitId,Kaydetme,Silme,Guncelleme) 
                    values 
                    (@MenuId,@KullaniciKayitId,@Kaydetme)", baglanti);
                    komut.Parameters.AddWithValue("@MenuId", rows.Cells["MenuId"].Value);
                    komut.Parameters.AddWithValue("@KullaniciKayitId", cmboxkullanici.SelectedValue.ToString());
                    komut.Parameters.AddWithValue("@Kaydetme", rows.Cells["Kaydetme"].Value);
                    komut.Parameters.AddWithValue("@Silme", rows.Cells["Silme"].Value);
                    komut.Parameters.AddWithValue("@Guncelleme", rows.Cells["Guncelleme"].Value);
                    komut.ExecuteNonQuery();

                }


            }

            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi.", "Güncelleme Ekranı");
            btnListeleme_Click(null, null);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
