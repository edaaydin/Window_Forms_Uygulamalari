namespace LoginPaneliOlusturma
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
            lblTc = new Label();
            maskedTextBox1 = new MaskedTextBox();
            lblSifre = new Label();
            maskedTextBox2 = new MaskedTextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnGiris = new Button();
            chkbSifremiUnuttum = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Location = new Point(42, 141);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(127, 20);
            lblTc.TabIndex = 0;
            lblTc.Text = "TC Kimlik Numara";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(175, 134);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(183, 27);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(130, 184);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(39, 20);
            lblSifre.TabIndex = 2;
            lblSifre.Text = "Şifre";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(175, 177);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.PasswordChar = '*';
            maskedTextBox2.Size = new Size(183, 27);
            maskedTextBox2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(42, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 67);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 25);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Giriş Paneli\r\n";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(42, 263);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 40);
            panel2.TabIndex = 5;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(264, 217);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(94, 29);
            btnGiris.TabIndex = 6;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            // 
            // chkbSifremiUnuttum
            // 
            chkbSifremiUnuttum.AutoSize = true;
            chkbSifremiUnuttum.Location = new Point(372, 180);
            chkbSifremiUnuttum.Name = "chkbSifremiUnuttum";
            chkbSifremiUnuttum.Size = new Size(139, 24);
            chkbSifremiUnuttum.TabIndex = 7;
            chkbSifremiUnuttum.Text = "Şifremi Unuttum";
            chkbSifremiUnuttum.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 333);
            Controls.Add(chkbSifremiUnuttum);
            Controls.Add(btnGiris);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(maskedTextBox2);
            Controls.Add(lblSifre);
            Controls.Add(maskedTextBox1);
            Controls.Add(lblTc);
            Name = "Form1";
            Text = "Login Paneli";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTc;
        private MaskedTextBox maskedTextBox1;
        private Label lblSifre;
        private MaskedTextBox maskedTextBox2;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnGiris;
        private CheckBox chkbSifremiUnuttum;
    }
}
