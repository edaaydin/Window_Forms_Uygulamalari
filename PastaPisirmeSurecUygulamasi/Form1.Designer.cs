namespace PastaPisirmeSurecUygulamasi
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            lblKaristirma = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar3 = new ProgressBar();
            lblHarmanlama = new Label();
            progressBar2 = new ProgressBar();
            lblCirpma = new Label();
            progressBar4 = new ProgressBar();
            lblPisiyor = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 61);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 48);
            progressBar1.TabIndex = 0;
            // 
            // lblKaristirma
            // 
            lblKaristirma.AutoSize = true;
            lblKaristirma.Location = new Point(12, 25);
            lblKaristirma.Name = "lblKaristirma";
            lblKaristirma.Size = new Size(197, 20);
            lblKaristirma.TabIndex = 1;
            lblKaristirma.Text = "Un ve Yumurta Karıştırılıyor...\r\n";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(12, 283);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(776, 48);
            progressBar3.TabIndex = 0;
            // 
            // lblHarmanlama
            // 
            lblHarmanlama.AutoSize = true;
            lblHarmanlama.Location = new Point(12, 247);
            lblHarmanlama.Name = "lblHarmanlama";
            lblHarmanlama.Size = new Size(260, 20);
            lblHarmanlama.TabIndex = 1;
            lblHarmanlama.Text = "Malzemeler Ekleniyor ve karıştırılıyor...";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(12, 176);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(776, 48);
            progressBar2.TabIndex = 0;
            // 
            // lblCirpma
            // 
            lblCirpma.AutoSize = true;
            lblCirpma.Location = new Point(12, 140);
            lblCirpma.Name = "lblCirpma";
            lblCirpma.Size = new Size(170, 20);
            lblCirpma.TabIndex = 1;
            lblCirpma.Text = "Çırpma İşlemi Yapılıyor...";
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(12, 390);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(776, 48);
            progressBar4.TabIndex = 0;
            // 
            // lblPisiyor
            // 
            lblPisiyor.AutoSize = true;
            lblPisiyor.Location = new Point(12, 354);
            lblPisiyor.Name = "lblPisiyor";
            lblPisiyor.Size = new Size(116, 20);
            lblPisiyor.TabIndex = 1;
            lblPisiyor.Text = "Pasta Pişiriliyor...";
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Interval = 1000;
            timer4.Tick += timer4_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 468);
            Controls.Add(lblPisiyor);
            Controls.Add(lblCirpma);
            Controls.Add(lblHarmanlama);
            Controls.Add(lblKaristirma);
            Controls.Add(progressBar4);
            Controls.Add(progressBar2);
            Controls.Add(progressBar3);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Pasta Pişirme Süreç Uygulaması";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lblKaristirma;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar3;
        private Label lblHarmanlama;
        private ProgressBar progressBar2;
        private Label lblCirpma;
        private ProgressBar progressBar4;
        private Label lblPisiyor;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}
