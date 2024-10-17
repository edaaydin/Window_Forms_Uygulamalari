namespace DigitalSaatUygulamasi
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
            label1Saniye = new Label();
            label2Dakika = new Label();
            label3Saat = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1Saniye
            // 
            label1Saniye.Font = new Font("Segoe UI", 19.8000011F);
            label1Saniye.Location = new Point(425, 188);
            label1Saniye.Name = "label1Saniye";
            label1Saniye.Size = new Size(78, 40);
            label1Saniye.TabIndex = 0;
            label1Saniye.Text = "0";
            // 
            // label2Dakika
            // 
            label2Dakika.Font = new Font("Segoe UI", 19.8000011F);
            label2Dakika.Location = new Point(296, 188);
            label2Dakika.Name = "label2Dakika";
            label2Dakika.Size = new Size(92, 40);
            label2Dakika.TabIndex = 1;
            label2Dakika.Text = "0";
            // 
            // label3Saat
            // 
            label3Saat.Font = new Font("Segoe UI", 19.8000011F);
            label3Saat.Location = new Point(141, 188);
            label3Saat.Name = "label3Saat";
            label3Saat.Size = new Size(95, 40);
            label3Saat.TabIndex = 2;
            label3Saat.Text = "0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label3Saat);
            Controls.Add(label2Dakika);
            Controls.Add(label1Saniye);
            Name = "Form1";
            Text = "Dijital Saat Uygulaması";
            ResumeLayout(false);
        }

        #endregion

        private Label label1Saniye;
        private Label label2Dakika;
        private Label label3Saat;
        private System.Windows.Forms.Timer timer1;
    }
}
