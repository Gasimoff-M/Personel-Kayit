

namespace sql_veri_tabanı_örnek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            mskMaas = new MaskedTextBox();
            cmbSehir = new ComboBox();
            txtMeslek = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtİd = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnGrafikler = new Button();
            btnİstatistik = new Button();
            btnTemizle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnKaydet = new Button();
            btnListele = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(mskMaas);
            groupBox1.Controls.Add(cmbSehir);
            groupBox1.Controls.Add(txtMeslek);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(txtİd);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Cambria", 12F);
            groupBox1.Location = new Point(16, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(484, 366);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Kayıt";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(286, 239);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 27);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Bekar";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(191, 239);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(64, 27);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Evli";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // mskMaas
            // 
            mskMaas.Location = new Point(192, 203);
            mskMaas.Mask = "0000";
            mskMaas.Name = "mskMaas";
            mskMaas.Size = new Size(198, 31);
            mskMaas.TabIndex = 11;
            mskMaas.ValidatingType = typeof(int);
            // 
            // cmbSehir
            // 
            cmbSehir.FormattingEnabled = true;
            cmbSehir.Location = new Point(191, 165);
            cmbSehir.Name = "cmbSehir";
            cmbSehir.Size = new Size(199, 31);
            cmbSehir.TabIndex = 10;
            // 
            // txtMeslek
            // 
            txtMeslek.Location = new Point(191, 273);
            txtMeslek.Name = "txtMeslek";
            txtMeslek.Size = new Size(199, 31);
            txtMeslek.TabIndex = 12;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(191, 129);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(199, 31);
            txtSoyad.TabIndex = 9;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(191, 92);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(199, 31);
            txtAd.TabIndex = 8;
            // 
            // txtİd
            // 
            txtİd.Location = new Point(191, 55);
            txtİd.Name = "txtİd";
            txtİd.Size = new Size(199, 31);
            txtİd.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(102, 276);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 23);
            label7.TabIndex = 6;
            label7.Text = "Meslek :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 240);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 5;
            label6.Text = "Durum :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 206);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 4;
            label5.Text = "Maaş :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 168);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 3;
            label4.Text = "Şehir :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 132);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 2;
            label3.Text = "Soyad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 1;
            label2.Text = "Ad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 0;
            label1.Text = "Personel İD :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGrafikler);
            groupBox2.Controls.Add(btnİstatistik);
            groupBox2.Controls.Add(btnTemizle);
            groupBox2.Controls.Add(btnGuncelle);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(btnKaydet);
            groupBox2.Controls.Add(btnListele);
            groupBox2.Font = new Font("Cambria", 12F);
            groupBox2.Location = new Point(509, 14);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(390, 366);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "İşlemler";
            // 
            // btnGrafikler
            // 
            btnGrafikler.Location = new Point(99, 299);
            btnGrafikler.Name = "btnGrafikler";
            btnGrafikler.Size = new Size(188, 39);
            btnGrafikler.TabIndex = 6;
            btnGrafikler.Text = "Grafikler";
            btnGrafikler.UseVisualStyleBackColor = true;
            btnGrafikler.Click += btnGrafikler_Click;
            // 
            // btnİstatistik
            // 
            btnİstatistik.Location = new Point(99, 254);
            btnİstatistik.Name = "btnİstatistik";
            btnİstatistik.Size = new Size(188, 39);
            btnİstatistik.TabIndex = 5;
            btnİstatistik.Text = "İstatistik";
            btnİstatistik.UseVisualStyleBackColor = true;
            btnİstatistik.Click += btnİstatistik_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(99, 209);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(188, 39);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(99, 164);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(188, 39);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(99, 119);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(188, 39);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(99, 74);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(188, 39);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(99, 29);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(188, 39);
            btnListele.TabIndex = 0;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(16, 386);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1148, 222);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1142, 192);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(906, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1034, 361);
            label8.Name = "label8";
            label8.Size = new Size(62, 23);
            label8.TabIndex = 4;
            label8.Text = "label8";
            label8.Visible = false;
            label8.TextChanged += label8_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1176, 616);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private MaskedTextBox mskMaas;
        private ComboBox cmbSehir;
        private TextBox txtMeslek;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtİd;
        private Button btnGrafikler;
        private Button btnİstatistik;
        private Button btnTemizle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnKaydet;
        private Button btnListele;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label8;
    }
}
