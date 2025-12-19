namespace sql_veri_tabanı_örnek
{
    partial class istatistik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblTopPer = new Label();
            lblEvli = new Label();
            lblBekar = new Label();
            lblSehir = new Label();
            lblTopMaas = new Label();
            lblOrtMaas = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 54);
            label1.Name = "label1";
            label1.Size = new Size(202, 23);
            label1.TabIndex = 0;
            label1.Text = "Toplam Personel Sayı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 98);
            label2.Name = "label2";
            label2.Size = new Size(171, 23);
            label2.TabIndex = 1;
            label2.Text = "Evli Personel Sayı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 141);
            label3.Name = "label3";
            label3.Size = new Size(188, 23);
            label3.TabIndex = 2;
            label3.Text = "Bekar Personel Sayı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 184);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 3;
            label4.Text = "Şehir Sayi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 224);
            label5.Name = "label5";
            label5.Size = new Size(132, 23);
            label5.TabIndex = 4;
            label5.Text = "Toplam Maaş :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(106, 268);
            label6.Name = "label6";
            label6.Size = new Size(148, 23);
            label6.TabIndex = 5;
            label6.Text = "Ortalama Maaş :";
            // 
            // lblTopPer
            // 
            lblTopPer.AutoSize = true;
            lblTopPer.Location = new Point(257, 56);
            lblTopPer.Name = "lblTopPer";
            lblTopPer.Size = new Size(21, 23);
            lblTopPer.TabIndex = 6;
            lblTopPer.Text = "0";
            // 
            // lblEvli
            // 
            lblEvli.AutoSize = true;
            lblEvli.Location = new Point(257, 100);
            lblEvli.Name = "lblEvli";
            lblEvli.Size = new Size(21, 23);
            lblEvli.TabIndex = 7;
            lblEvli.Text = "0";
            // 
            // lblBekar
            // 
            lblBekar.AutoSize = true;
            lblBekar.Location = new Point(257, 143);
            lblBekar.Name = "lblBekar";
            lblBekar.Size = new Size(21, 23);
            lblBekar.TabIndex = 8;
            lblBekar.Text = "0";
            // 
            // lblSehir
            // 
            lblSehir.AutoSize = true;
            lblSehir.Location = new Point(257, 186);
            lblSehir.Name = "lblSehir";
            lblSehir.Size = new Size(21, 23);
            lblSehir.TabIndex = 9;
            lblSehir.Text = "0";
            // 
            // lblTopMaas
            // 
            lblTopMaas.AutoSize = true;
            lblTopMaas.Location = new Point(257, 226);
            lblTopMaas.Name = "lblTopMaas";
            lblTopMaas.Size = new Size(21, 23);
            lblTopMaas.TabIndex = 10;
            lblTopMaas.Text = "0";
            // 
            // lblOrtMaas
            // 
            lblOrtMaas.AutoSize = true;
            lblOrtMaas.Location = new Point(257, 270);
            lblOrtMaas.Name = "lblOrtMaas";
            lblOrtMaas.Size = new Size(21, 23);
            lblOrtMaas.TabIndex = 11;
            lblOrtMaas.Text = "0";
            // 
            // istatistik
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(525, 352);
            Controls.Add(lblOrtMaas);
            Controls.Add(lblTopMaas);
            Controls.Add(lblSehir);
            Controls.Add(lblBekar);
            Controls.Add(lblEvli);
            Controls.Add(lblTopPer);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "istatistik";
            Text = "istatistik";
            Load += istatistik_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblTopPer;
        private Label lblEvli;
        private Label lblBekar;
        private Label lblSehir;
        private Label lblTopMaas;
        private Label lblOrtMaas;
    }
}