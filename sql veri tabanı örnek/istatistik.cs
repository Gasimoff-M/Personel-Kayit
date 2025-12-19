using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace sql_veri_tabanı_örnek
{
    public partial class istatistik : Form
    {
        public istatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MAHAMMAD;Initial Catalog=İlkVeriTabanim;Persist Security Info=True;User ID=sa;Password=5485;Encrypt=True;Trust Server Certificate=True");

        private void istatistik_Load(object sender, EventArgs e)
        {
            // Toplam Personel Sayısı
            baglanti.Open();
            SqlCommand istatistik1 = new SqlCommand("Select Count(*) From Personel_1", baglanti);
            SqlDataReader dr1 =istatistik1.ExecuteReader();
            while (dr1.Read())
            {
                lblTopPer.Text = dr1[0].ToString();
            }
            baglanti.Close();

            // Evli Personel Sayısı
            baglanti.Open();
            SqlCommand istatistik2 = new SqlCommand("Select Count(*) From Personel_1 Where PerDurum=1", baglanti);
            SqlDataReader dr2 = istatistik2.ExecuteReader();
            while(dr2.Read())
            {
                lblEvli.Text = dr2[0].ToString();
            }
            baglanti.Close();

            // Bekar Personel Sayısı    
            baglanti.Open();
            SqlCommand istatistik3 = new SqlCommand("Select Count(*) From Personel_1 Where PerDurum=0", baglanti);
            SqlDataReader dr3 = istatistik3.ExecuteReader();
            while(dr3.Read())
            {
                lblBekar.Text = dr3[0].ToString();

            }
            baglanti.Close();

            // Şehir Sayısı 
            baglanti.Open();

            SqlCommand istatistik4 = new SqlCommand("Select Count(Distinct PerSehir) From Personel_1", baglanti);
            var dr4 = istatistik4.ExecuteReader();
            while (dr4.Read())
            {
                lblSehir.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //Toplam Maaş
            baglanti.Open();
            SqlCommand istatistik5 = new SqlCommand("Select Sum(PerMaas) From Personel_1 ", baglanti);
            SqlDataReader dr5 = istatistik5.ExecuteReader();
            while(dr5.Read())
            {
                lblTopMaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            // Ortalama Maaaş
            baglanti.Open();
            SqlCommand istatistik6 = new SqlCommand("Select Avg(PerMaas) from Personel_1 ", baglanti);
            SqlDataReader dr6 = istatistik6.ExecuteReader();
            while(dr6.Read())
            {
                lblOrtMaas.Text = dr6[0].ToString();
            }

            baglanti.Close();
        }
    }


}
