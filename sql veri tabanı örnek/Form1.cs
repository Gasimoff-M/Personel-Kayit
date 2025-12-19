
using Microsoft.Data.SqlClient;

using System.Data;


namespace sql_veri_tabanı_örnek
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MAHAMMAD;Initial Catalog=İlkVeriTabanim;Persist Security Info=True;User ID=sa;Password=5485;Encrypt=True;Trust Server Certificate=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Personel_1", baglanti);
            adtr.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Personel_1 (PerAd ,PerSoyad ,PerSehir ,PerMaas ,PerMeslek , PerDurum) values (@p1 ,@p2 ,@p3 ,@p4 ,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();


            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Personel_1", baglanti);
            adtr.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label8.Text = "False";
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = " ";
            txtSoyad.Text = " ";
            txtMeslek.Text = " ";
            cmbSehir.Text = " ";
            mskMaas.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtAd.Focus();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtİd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();


        }

        private void label8_TextChanged(object sender, EventArgs e)
        {

            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("Delete From Personel_1 Where Perİd=@k1 ", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtİd.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Personel Silindi");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand guncelle = new SqlCommand("Update Personel_1 Set PerAd=@a1 ,PerSoyad=@a2 ,PerSehir=@a3 ,PerMaas=@a4 , PerDurum=@a5 ,PerMeslek=@a6 Where Perİd=@a7", baglanti);
            guncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            guncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@a3", cmbSehir.Text);
            guncelle.Parameters.AddWithValue("@a4", mskMaas.Text);
            guncelle.Parameters.AddWithValue("@a5", label8.Text);
            guncelle.Parameters.AddWithValue("@a6", txtMeslek.Text);
            guncelle.Parameters.AddWithValue("@a7", txtİd.Text);
            guncelle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Personel Güncellendi");

        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            istatistik istsk = new istatistik();
            istsk.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            Grafik gr = new Grafik();
            gr.Show();
        }
    }
}
