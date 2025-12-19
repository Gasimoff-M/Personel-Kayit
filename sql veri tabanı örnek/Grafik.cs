using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.SqlClient;

namespace sql_veri_tabanı_örnek
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MAHAMMAD;Initial Catalog=İlkVeriTabanim;Persist Security Info=True;User ID=sa;Password=5485;Encrypt=True;Trust Server Certificate=True");

        private void Grafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand grfk1 = new SqlCommand("Select PerSehir,count(*) From Personel_1 Group by PerSehir",baglanti);
            SqlDataReader dr1 = grfk1.ExecuteReader();
            while (dr1.Read())
            {
                
            }
        }
    }

}
