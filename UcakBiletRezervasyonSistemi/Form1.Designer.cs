namespace UcakBiletRezervasyonSistemi
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
            grpUcusBilgileri = new GroupBox();
            mtxtSaat = new MaskedTextBox();
            dtTarih = new DateTimePicker();
            cbNereye = new ComboBox();
            cbNereden = new ComboBox();
            lblTarih = new Label();
            lblSaat = new Label();
            lblNereye = new Label();
            lblNereden = new Label();
            grpYolcuBilgileri = new GroupBox();
            btbKaydet = new Button();
            mtxtTelNo = new MaskedTextBox();
            mtxtTc = new MaskedTextBox();
            txtAdSoyad = new TextBox();
            lblTc = new Label();
            lblTelNo = new Label();
            lblAdSoyad = new Label();
            Rezervasyon_Bilgileri = new ListBox();
            panel1 = new Panel();
            lblBaslik = new Label();
            grpUcusBilgileri.SuspendLayout();
            grpYolcuBilgileri.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grpUcusBilgileri
            // 
            grpUcusBilgileri.Controls.Add(mtxtSaat);
            grpUcusBilgileri.Controls.Add(dtTarih);
            grpUcusBilgileri.Controls.Add(cbNereye);
            grpUcusBilgileri.Controls.Add(cbNereden);
            grpUcusBilgileri.Controls.Add(lblTarih);
            grpUcusBilgileri.Controls.Add(lblSaat);
            grpUcusBilgileri.Controls.Add(lblNereye);
            grpUcusBilgileri.Controls.Add(lblNereden);
            grpUcusBilgileri.Location = new Point(66, 136);
            grpUcusBilgileri.Name = "grpUcusBilgileri";
            grpUcusBilgileri.Size = new Size(456, 311);
            grpUcusBilgileri.TabIndex = 0;
            grpUcusBilgileri.TabStop = false;
            grpUcusBilgileri.Text = "Uçuş Bilgileri";
            // 
            // mtxtSaat
            // 
            mtxtSaat.Location = new Point(110, 217);
            mtxtSaat.Mask = "00:00";
            mtxtSaat.Name = "mtxtSaat";
            mtxtSaat.Size = new Size(275, 34);
            mtxtSaat.TabIndex = 4;
            mtxtSaat.ValidatingType = typeof(DateTime);
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(110, 168);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(275, 34);
            dtTarih.TabIndex = 3;
            // 
            // cbNereye
            // 
            cbNereye.FormattingEnabled = true;
            cbNereye.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana", "Elazığ", "Samsun" });
            cbNereye.Location = new Point(110, 110);
            cbNereye.Name = "cbNereye";
            cbNereye.Size = new Size(275, 36);
            cbNereye.TabIndex = 2;
            // 
            // cbNereden
            // 
            cbNereden.FormattingEnabled = true;
            cbNereden.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana", "Elazığ", "Samsun" });
            cbNereden.Location = new Point(110, 53);
            cbNereden.Name = "cbNereden";
            cbNereden.Size = new Size(275, 36);
            cbNereden.TabIndex = 2;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(34, 174);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(53, 28);
            lblTarih.TabIndex = 1;
            lblTarih.Text = "Tarih";
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Location = new Point(34, 223);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(50, 28);
            lblSaat.TabIndex = 1;
            lblSaat.Text = "Saat";
            // 
            // lblNereye
            // 
            lblNereye.AutoSize = true;
            lblNereye.Location = new Point(13, 118);
            lblNereye.Name = "lblNereye";
            lblNereye.Size = new Size(74, 28);
            lblNereye.TabIndex = 1;
            lblNereye.Text = "Nereye";
            // 
            // lblNereden
            // 
            lblNereden.AutoSize = true;
            lblNereden.Location = new Point(0, 61);
            lblNereden.Name = "lblNereden";
            lblNereden.Size = new Size(87, 28);
            lblNereden.TabIndex = 0;
            lblNereden.Text = "Nereden";
            // 
            // grpYolcuBilgileri
            // 
            grpYolcuBilgileri.Controls.Add(btbKaydet);
            grpYolcuBilgileri.Controls.Add(mtxtTelNo);
            grpYolcuBilgileri.Controls.Add(mtxtTc);
            grpYolcuBilgileri.Controls.Add(txtAdSoyad);
            grpYolcuBilgileri.Controls.Add(lblTc);
            grpYolcuBilgileri.Controls.Add(lblTelNo);
            grpYolcuBilgileri.Controls.Add(lblAdSoyad);
            grpYolcuBilgileri.Location = new Point(564, 136);
            grpYolcuBilgileri.Name = "grpYolcuBilgileri";
            grpYolcuBilgileri.Size = new Size(425, 311);
            grpYolcuBilgileri.TabIndex = 1;
            grpYolcuBilgileri.TabStop = false;
            grpYolcuBilgileri.Text = "Yolcu Bİlgileri";
            // 
            // btbKaydet
            // 
            btbKaydet.BackColor = SystemColors.ActiveCaption;
            btbKaydet.Location = new Point(249, 212);
            btbKaydet.Name = "btbKaydet";
            btbKaydet.Size = new Size(122, 37);
            btbKaydet.TabIndex = 3;
            btbKaydet.Text = "Kaydet";
            btbKaydet.UseVisualStyleBackColor = false;
            btbKaydet.Click += btbKaydet_Click;
            // 
            // mtxtTelNo
            // 
            mtxtTelNo.Location = new Point(249, 157);
            mtxtTelNo.Mask = "(999) 000-0000";
            mtxtTelNo.Name = "mtxtTelNo";
            mtxtTelNo.Size = new Size(125, 34);
            mtxtTelNo.TabIndex = 2;
            // 
            // mtxtTc
            // 
            mtxtTc.Location = new Point(249, 102);
            mtxtTc.Mask = "00000000000";
            mtxtTc.Name = "mtxtTc";
            mtxtTc.Size = new Size(125, 34);
            mtxtTc.TabIndex = 2;
            mtxtTc.ValidatingType = typeof(int);
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(249, 51);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 34);
            txtAdSoyad.TabIndex = 1;
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Location = new Point(160, 108);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(33, 28);
            lblTc.TabIndex = 0;
            lblTc.Text = "TC";
            // 
            // lblTelNo
            // 
            lblTelNo.AutoSize = true;
            lblTelNo.Location = new Point(45, 163);
            lblTelNo.Name = "lblTelNo";
            lblTelNo.Size = new Size(162, 28);
            lblTelNo.TabIndex = 0;
            lblTelNo.Text = "Telefon Numarası";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(45, 51);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(148, 28);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Yolcu Ad Soyad";
            // 
            // Rezervasyon_Bilgileri
            // 
            Rezervasyon_Bilgileri.FormattingEnabled = true;
            Rezervasyon_Bilgileri.HorizontalScrollbar = true;
            Rezervasyon_Bilgileri.ItemHeight = 28;
            Rezervasyon_Bilgileri.Location = new Point(66, 472);
            Rezervasyon_Bilgileri.Name = "Rezervasyon_Bilgileri";
            Rezervasyon_Bilgileri.Size = new Size(923, 116);
            Rezervasyon_Bilgileri.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(lblBaslik);
            panel1.Location = new Point(66, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 91);
            panel1.TabIndex = 3;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Location = new Point(354, 32);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(166, 28);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Yıldız Hava Yolları";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(panel1);
            Controls.Add(Rezervasyon_Bilgileri);
            Controls.Add(grpYolcuBilgileri);
            Controls.Add(grpUcusBilgileri);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Uçak Bilet Rezervason Sistemi";
            grpUcusBilgileri.ResumeLayout(false);
            grpUcusBilgileri.PerformLayout();
            grpYolcuBilgileri.ResumeLayout(false);
            grpYolcuBilgileri.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpUcusBilgileri;
        private ComboBox cbNereye;
        private ComboBox cbNereden;
        private Label lblTarih;
        private Label lblNereye;
        private Label lblNereden;
        private GroupBox grpYolcuBilgileri;
        private DateTimePicker dtTarih;
        private MaskedTextBox mtxtSaat;
        private Label lblSaat;
        private Label lblTc;
        private Label lblTelNo;
        private Label lblAdSoyad;
        private TextBox txtAdSoyad;
        private MaskedTextBox mtxtTelNo;
        private MaskedTextBox mtxtTc;
        private Button btbKaydet;
        private ListBox Rezervasyon_Bilgileri;
        private Panel panel1;
        private Label lblBaslik;
    }
}
