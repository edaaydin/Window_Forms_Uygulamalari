namespace BİlgiYarismasi
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
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            lblSoru = new Label();
            lblD = new Label();
            lblY = new Label();
            lblSoruNo = new Label();
            lblDogru = new Label();
            lblYanlis = new Label();
            btnSonraki = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(31, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(482, 172);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Location = new Point(31, 190);
            btnA.Name = "btnA";
            btnA.Size = new Size(226, 47);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(263, 190);
            btnB.Name = "btnB";
            btnB.Size = new Size(250, 47);
            btnB.TabIndex = 1;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(31, 243);
            btnC.Name = "btnC";
            btnC.Size = new Size(226, 43);
            btnC.TabIndex = 1;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(263, 243);
            btnD.Name = "btnD";
            btnD.Size = new Size(250, 43);
            btnD.TabIndex = 1;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(549, 19);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(70, 20);
            lblSoru.TabIndex = 2;
            lblSoru.Text = "Soru No :";
            // 
            // lblD
            // 
            lblD.AutoSize = true;
            lblD.Location = new Point(561, 55);
            lblD.Name = "lblD";
            lblD.Size = new Size(58, 20);
            lblD.TabIndex = 2;
            lblD.Text = "Doğru :";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(566, 90);
            lblY.Name = "lblY";
            lblY.Size = new Size(53, 20);
            lblY.TabIndex = 2;
            lblY.Text = "Yanlis :";
            // 
            // lblSoruNo
            // 
            lblSoruNo.AutoSize = true;
            lblSoruNo.Location = new Point(646, 19);
            lblSoruNo.Name = "lblSoruNo";
            lblSoruNo.Size = new Size(17, 20);
            lblSoruNo.TabIndex = 2;
            lblSoruNo.Text = "0";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(646, 55);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(17, 20);
            lblDogru.TabIndex = 2;
            lblDogru.Text = "0";
            // 
            // lblYanlis
            // 
            lblYanlis.AutoSize = true;
            lblYanlis.Location = new Point(646, 90);
            lblYanlis.Name = "lblYanlis";
            lblYanlis.Size = new Size(17, 20);
            lblYanlis.TabIndex = 2;
            lblYanlis.Text = "0";
            // 
            // btnSonraki
            // 
            btnSonraki.Location = new Point(566, 124);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(124, 36);
            btnSonraki.TabIndex = 1;
            btnSonraki.Text = "Sonraki";
            btnSonraki.UseVisualStyleBackColor = true;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 335);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 388);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(780, 424);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblYanlis);
            Controls.Add(lblDogru);
            Controls.Add(lblSoruNo);
            Controls.Add(lblY);
            Controls.Add(lblD);
            Controls.Add(lblSoru);
            Controls.Add(btnSonraki);
            Controls.Add(btnB);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Label lblSoru;
        private Label lblD;
        private Label lblY;
        private Label lblSoruNo;
        private Label lblDogru;
        private Label lblYanlis;
        private Button btnSonraki;
        private Label label1;
        private Label label2;
    }
}
