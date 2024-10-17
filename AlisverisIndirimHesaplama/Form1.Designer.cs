namespace AlisverisIndirimHesaplama
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
            btnHesapla = new Button();
            lblKitapAdet = new Label();
            lblTutar = new Label();
            txtKitapAdet = new TextBox();
            lbl00 = new Label();
            SuspendLayout();
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(126, 135);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(125, 40);
            btnHesapla.TabIndex = 0;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // lblKitapAdet
            // 
            lblKitapAdet.AutoSize = true;
            lblKitapAdet.Location = new Point(33, 34);
            lblKitapAdet.Name = "lblKitapAdet";
            lblKitapAdet.Size = new Size(87, 20);
            lblKitapAdet.TabIndex = 1;
            lblKitapAdet.Text = "Kitap Adet :";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(70, 94);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(50, 20);
            lblTutar.TabIndex = 1;
            lblTutar.Text = "Tutar :";
            // 
            // txtKitapAdet
            // 
            txtKitapAdet.Location = new Point(126, 27);
            txtKitapAdet.Name = "txtKitapAdet";
            txtKitapAdet.Size = new Size(125, 27);
            txtKitapAdet.TabIndex = 2;
            // 
            // lbl00
            // 
            lbl00.AutoSize = true;
            lbl00.Location = new Point(126, 94);
            lbl00.Name = "lbl00";
            lbl00.Size = new Size(44, 20);
            lbl00.TabIndex = 3;
            lbl00.Text = "00 TL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(432, 333);
            Controls.Add(lbl00);
            Controls.Add(txtKitapAdet);
            Controls.Add(lblTutar);
            Controls.Add(lblKitapAdet);
            Controls.Add(btnHesapla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHesapla;
        private Label lblKitapAdet;
        private Label lblTutar;
        private TextBox txtKitapAdet;
        private Label lbl00;
    }
}
