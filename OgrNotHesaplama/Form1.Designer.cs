namespace OgrNotHesaplama
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
            lblAd = new Label();
            lblSinav1 = new Label();
            lblSoyad = new Label();
            lblSinav2 = new Label();
            lblProje = new Label();
            txtxAd = new TextBox();
            txtSoyad = new TextBox();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txtpro = new TextBox();
            btnHesapla = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(36, 30);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(39, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Adı :";
            // 
            // lblSinav1
            // 
            lblSinav1.AutoSize = true;
            lblSinav1.Location = new Point(12, 154);
            lblSinav1.Name = "lblSinav1";
            lblSinav1.Size = new Size(63, 20);
            lblSinav1.TabIndex = 0;
            lblSinav1.Text = "Sınav 1 :";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(14, 92);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(61, 20);
            lblSoyad.TabIndex = 0;
            lblSoyad.Text = "Soyadı :";
            // 
            // lblSinav2
            // 
            lblSinav2.AutoSize = true;
            lblSinav2.Location = new Point(176, 153);
            lblSinav2.Name = "lblSinav2";
            lblSinav2.Size = new Size(63, 20);
            lblSinav2.TabIndex = 0;
            lblSinav2.Text = "Sınav 2 :";
            // 
            // lblProje
            // 
            lblProje.AutoSize = true;
            lblProje.Location = new Point(346, 150);
            lblProje.Name = "lblProje";
            lblProje.Size = new Size(43, 20);
            lblProje.TabIndex = 0;
            lblProje.Text = "Proje";
            // 
            // txtxAd
            // 
            txtxAd.Location = new Point(103, 30);
            txtxAd.Name = "txtxAd";
            txtxAd.Size = new Size(125, 27);
            txtxAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(103, 85);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 1;
            // 
            // txt1
            // 
            txt1.Location = new Point(81, 147);
            txt1.Name = "txt1";
            txt1.Size = new Size(65, 27);
            txt1.TabIndex = 1;
            // 
            // txt2
            // 
            txt2.Location = new Point(245, 147);
            txt2.Name = "txt2";
            txt2.Size = new Size(65, 27);
            txt2.TabIndex = 1;
            // 
            // txtpro
            // 
            txtpro.Location = new Point(395, 146);
            txtpro.Name = "txtpro";
            txtpro.Size = new Size(65, 27);
            txtpro.TabIndex = 1;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(103, 210);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(284, 39);
            btnHesapla.TabIndex = 2;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(19, 274);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(441, 104);
            listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 443);
            Controls.Add(listBox1);
            Controls.Add(btnHesapla);
            Controls.Add(txtpro);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(txtSoyad);
            Controls.Add(txtxAd);
            Controls.Add(lblSoyad);
            Controls.Add(lblProje);
            Controls.Add(lblSinav2);
            Controls.Add(lblSinav1);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Öğrenci Not Hesaplama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSinav1;
        private Label lblSoyad;
        private Label lblSinav2;
        private Label lblProje;
        private TextBox txtxAd;
        private TextBox txtSoyad;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txtpro;
        private Button btnHesapla;
        private ListBox listBox1;
    }
}
