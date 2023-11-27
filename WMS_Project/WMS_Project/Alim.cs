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
    public partial class Alim : UserControl
    {
        public Alim()
        {
            InitializeComponent();
            
        }
        SqlConnection baglanti = new SqlConnection("Data Source =DESKTOP-F2SN8FC; Initial Catalog =WMS; Integrated Security =true");
        SqlConnection connection = new SqlConnection("Data Source =DESKTOP-F2SN8FC; Initial Catalog =WMS; Integrated Security =TRUE");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        SqlCommandBuilder builder;
        DataTable tbl = new DataTable();
        DataSet dataSetds = new DataSet();



        private void btnListeleme_Click(object sender, EventArgs e)
        {
            string getir = "Select * from AlimFaturaHareketi";
            SqlCommand komut = new SqlCommand(getir, baglanti);
            SqlDataAdapter dradapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dradapter.Fill(dt);
            dtListele.DataSource = dt;
            baglanti.Close();
        }

        public void hesapla()
        {
            int araToplam = 0;
            int kdv = 0;
            int netToplam = 0;

            for (int i = 0; i < dtListele.Rows.Count - 1; i++)
            {
                var miktar = Convert.ToInt32(dtListele[3, i].Value.ToString() == "" ? 0 : dtListele[3, i].Value);
                var birimFiyat = Convert.ToInt32(dtListele[5, i].Value.ToString() == "" ? 0 : dtListele[5, i].Value);

                araToplam += miktar * birimFiyat;
                kdv += Convert.ToInt32(dtListele.Rows[i].Cells[6].Value.ToString() == "" ? 0 : dtListele.Rows[i].Cells[6].Value);
                netToplam += Convert.ToInt32(dtListele.Rows[i].Cells[7].Value.ToString() == "" ? 0 : dtListele.Rows[i].Cells[7].Value);
            }
            txtAraToplam.Text = araToplam.ToString();
            textBox5.Text = kdv.ToString();
            textBox4.Text = netToplam.ToString();
        }
        private void dtListele_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 5 || e.ColumnIndex == 6)//Miktar, BirimFiyat, Kdv      
            {
                //eğer miktar birimfiyat boş gelir ise
                if (dtListele[3, e.RowIndex].Value.ToString() == "" || dtListele[5, e.RowIndex].Value.ToString() == "")
                {
                    //kdv ile net tutar 0 gelir.
                    dtListele[6, e.RowIndex].Value = 0;
                    dtListele[7, e.RowIndex].Value = 0;
                }
                else//boş değil ise datagridwiev üzerinde işlemler yaoılır
                {
                    var miktar = Convert.ToInt32(dtListele[3, e.RowIndex].Value.ToString() == "" ? 0 : dtListele[3, e.RowIndex].Value);
                    var birimFiyat = Convert.ToInt32(dtListele[5, e.RowIndex].Value.ToString() == "" ? 0 : dtListele[5, e.RowIndex].Value);
                    var kdv = Convert.ToInt32(dtListele[6, e.RowIndex].Value.ToString() == "" ? 0 : dtListele[6, e.RowIndex].Value); 
                    //net tutar hesaplanılır.
                    dtListele[7, e.RowIndex].Value = miktar * birimFiyat + kdv;
                }
                hesapla();
                return;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           //datagridview içine yazılan bilgiler sqle kayıt edilir.
            builder = new SqlCommandBuilder(da);
            da.Update(dataSetds, "AlimFaturaHareketi");
            MessageBox.Show("Girmiş olduğunuz bilgiler başarıyla kaydedildi.");

        }

        void Listele()
        {
            //Alım fatura verileri listelenir
            baglanti.Open();
            da = new SqlDataAdapter("select * from AlimFaturaHareketi", baglanti);
            da.Fill(dataSetds, "AlimFaturaHareketi");
            dtListele.DataSource = dataSetds.Tables["AlimFaturaHareketi"];
        }
        private void Alim_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
