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
    public partial class KullaniciGiriş : Form
    {
        public KullaniciGiriş()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MAHAMMAD;Initial Catalog=İlkVeriTabanim;Persist Security Info=True;User ID=sa;Password=5485;Encrypt=True;Trust Server Certificate=True");
     
        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand giris = new SqlCommand("Select * From KullaniciGiris where KullaniciAd = @p1 and Sifre = @p2", baglanti);
            giris.Parameters.AddWithValue("@p1",textBox1.Text);
            giris.Parameters.AddWithValue("@p2", textBox2.Text);

            SqlDataReader dr1 = giris.ExecuteReader();  

            if (dr1.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Ad ve ya Şifre !!!");
            }

            baglanti.Close();
        }


    }
}
