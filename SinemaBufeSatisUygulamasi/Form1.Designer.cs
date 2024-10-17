namespace SinemaBufeSatisUygulamasi
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
            gbUrunMik = new GroupBox();
            txtSu = new TextBox();
            txtCay = new TextBox();
            txtBilet = new TextBox();
            txtMisir = new TextBox();
            lblSu = new Label();
            lblCay = new Label();
            lblBilet = new Label();
            lblMisir = new Label();
            gbFiyatListesi = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbKasa = new GroupBox();
            btnHesapla = new Button();
            lblKasa0 = new Label();
            lblKasa = new Label();
            lbl00 = new Label();
            lblToplam = new Label();
            panel1 = new Panel();
            lblBaslik = new Label();
            btnTemizle = new Button();
            gbUrunMik.SuspendLayout();
            gbFiyatListesi.SuspendLayout();
            gbKasa.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gbUrunMik
            // 
            gbUrunMik.BackColor = Color.RosyBrown;
            gbUrunMik.Controls.Add(txtSu);
            gbUrunMik.Controls.Add(txtCay);
            gbUrunMik.Controls.Add(txtBilet);
            gbUrunMik.Controls.Add(txtMisir);
            gbUrunMik.Controls.Add(lblSu);
            gbUrunMik.Controls.Add(lblCay);
            gbUrunMik.Controls.Add(lblBilet);
            gbUrunMik.Controls.Add(lblMisir);
            gbUrunMik.Location = new Point(43, 231);
            gbUrunMik.Name = "gbUrunMik";
            gbUrunMik.Size = new Size(265, 267);
            gbUrunMik.TabIndex = 0;
            gbUrunMik.TabStop = false;
            gbUrunMik.Text = "Ürün Miktar";
            // 
            // txtSu
            // 
            txtSu.Location = new Point(89, 99);
            txtSu.Name = "txtSu";
            txtSu.Size = new Size(125, 27);
            txtSu.TabIndex = 1;
            // 
            // txtCay
            // 
            txtCay.Location = new Point(89, 140);
            txtCay.Name = "txtCay";
            txtCay.Size = new Size(125, 27);
            txtCay.TabIndex = 1;
            // 
            // txtBilet
            // 
            txtBilet.Location = new Point(89, 179);
            txtBilet.Name = "txtBilet";
            txtBilet.Size = new Size(125, 27);
            txtBilet.TabIndex = 1;
            // 
            // txtMisir
            // 
            txtMisir.Location = new Point(89, 52);
            txtMisir.Name = "txtMisir";
            txtMisir.Size = new Size(125, 27);
            txtMisir.TabIndex = 1;
            // 
            // lblSu
            // 
            lblSu.AutoSize = true;
            lblSu.Location = new Point(41, 101);
            lblSu.Name = "lblSu";
            lblSu.Size = new Size(25, 20);
            lblSu.TabIndex = 0;
            lblSu.Text = "Su";
            // 
            // lblCay
            // 
            lblCay.AutoSize = true;
            lblCay.Location = new Point(33, 147);
            lblCay.Name = "lblCay";
            lblCay.Size = new Size(33, 20);
            lblCay.TabIndex = 0;
            lblCay.Text = "Çay";
            // 
            // lblBilet
            // 
            lblBilet.AutoSize = true;
            lblBilet.Location = new Point(27, 186);
            lblBilet.Name = "lblBilet";
            lblBilet.Size = new Size(39, 20);
            lblBilet.TabIndex = 0;
            lblBilet.Text = "Bilet";
            // 
            // lblMisir
            // 
            lblMisir.AutoSize = true;
            lblMisir.Location = new Point(25, 59);
            lblMisir.Name = "lblMisir";
            lblMisir.Size = new Size(41, 20);
            lblMisir.TabIndex = 0;
            lblMisir.Text = "Mısır";
            // 
            // gbFiyatListesi
            // 
            gbFiyatListesi.BackColor = Color.RosyBrown;
            gbFiyatListesi.Controls.Add(label4);
            gbFiyatListesi.Controls.Add(label3);
            gbFiyatListesi.Controls.Add(label2);
            gbFiyatListesi.Controls.Add(label1);
            gbFiyatListesi.Location = new Point(413, 231);
            gbFiyatListesi.Name = "gbFiyatListesi";
            gbFiyatListesi.Size = new Size(274, 267);
            gbFiyatListesi.TabIndex = 1;
            gbFiyatListesi.TabStop = false;
            gbFiyatListesi.Text = "Fiyat Listesi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 164);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 0;
            label4.Text = "Bilet : 8 TL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 127);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 0;
            label3.Text = "Çay : 2 TL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 88);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 0;
            label2.Text = "Su : 1 TL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 52);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Mısır : 4 TL";
            // 
            // gbKasa
            // 
            gbKasa.BackColor = Color.RosyBrown;
            gbKasa.Controls.Add(btnTemizle);
            gbKasa.Controls.Add(btnHesapla);
            gbKasa.Controls.Add(lblKasa0);
            gbKasa.Controls.Add(lblKasa);
            gbKasa.Controls.Add(lbl00);
            gbKasa.Controls.Add(lblToplam);
            gbKasa.Location = new Point(795, 231);
            gbKasa.Name = "gbKasa";
            gbKasa.Size = new Size(277, 267);
            gbKasa.TabIndex = 2;
            gbKasa.TabStop = false;
            gbKasa.Text = "Kasa";
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(58, 138);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(145, 29);
            btnHesapla.TabIndex = 2;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // lblKasa0
            // 
            lblKasa0.AutoSize = true;
            lblKasa0.Location = new Point(143, 221);
            lblKasa0.Name = "lblKasa0";
            lblKasa0.Size = new Size(44, 20);
            lblKasa0.TabIndex = 1;
            lblKasa0.Text = "00 TL";
            // 
            // lblKasa
            // 
            lblKasa.AutoSize = true;
            lblKasa.Location = new Point(96, 221);
            lblKasa.Name = "lblKasa";
            lblKasa.Size = new Size(40, 20);
            lblKasa.TabIndex = 0;
            lblKasa.Text = "Kasa";
            // 
            // lbl00
            // 
            lbl00.AutoSize = true;
            lbl00.Location = new Point(142, 99);
            lbl00.Name = "lbl00";
            lbl00.Size = new Size(44, 20);
            lbl00.TabIndex = 1;
            lbl00.Text = "00 TL";
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(77, 99);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(59, 20);
            lblToplam.TabIndex = 0;
            lblToplam.Text = "Toplam";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(lblBaslik);
            panel1.Location = new Point(189, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 54);
            panel1.TabIndex = 3;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Location = new Point(272, 17);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(170, 20);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Sinema Büfe Satış Paneli";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(92, 189);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(94, 29);
            btnTemizle.TabIndex = 3;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 701);
            Controls.Add(panel1);
            Controls.Add(gbKasa);
            Controls.Add(gbFiyatListesi);
            Controls.Add(gbUrunMik);
            Name = "Form1";
            Text = "Sinema Büfe Satış Uygulaması";
            gbUrunMik.ResumeLayout(false);
            gbUrunMik.PerformLayout();
            gbFiyatListesi.ResumeLayout(false);
            gbFiyatListesi.PerformLayout();
            gbKasa.ResumeLayout(false);
            gbKasa.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbUrunMik;
        private TextBox txtSu;
        private TextBox txtCay;
        private TextBox txtBilet;
        private TextBox txtMisir;
        private Label lblSu;
        private Label lblCay;
        private Label lblBilet;
        private Label lblMisir;
        private GroupBox gbFiyatListesi;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gbKasa;
        private Button btnHesapla;
        private Label lbl00;
        private Label lblToplam;
        private Panel panel1;
        private Label lblBaslik;
        private Label lblKasa0;
        private Label lblKasa;
        private Button btnTemizle;
    }
}
