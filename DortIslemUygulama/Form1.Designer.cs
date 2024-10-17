namespace DortIslemUygulama
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
            lblSayi1 = new Label();
            lblSayi2 = new Label();
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            SuspendLayout();
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(153, 171);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(125, 36);
            btnHesapla.TabIndex = 0;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // lblSayi1
            // 
            lblSayi1.AutoSize = true;
            lblSayi1.Location = new Point(62, 74);
            lblSayi1.Name = "lblSayi1";
            lblSayi1.Size = new Size(55, 20);
            lblSayi1.TabIndex = 1;
            lblSayi1.Text = "Sayı 1 :";
            // 
            // lblSayi2
            // 
            lblSayi2.AutoSize = true;
            lblSayi2.Location = new Point(62, 128);
            lblSayi2.Name = "lblSayi2";
            lblSayi2.Size = new Size(55, 20);
            lblSayi2.TabIndex = 2;
            lblSayi2.Text = "Sayı 2 :";
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(153, 67);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(125, 27);
            txtSayi1.TabIndex = 3;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(153, 121);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(125, 27);
            txtSayi2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(412, 300);
            Controls.Add(txtSayi2);
            Controls.Add(txtSayi1);
            Controls.Add(lblSayi2);
            Controls.Add(lblSayi1);
            Controls.Add(btnHesapla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHesapla;
        private Label lblSayi1;
        private Label lblSayi2;
        private TextBox txtSayi1;
        private TextBox txtSayi2;
    }
}
