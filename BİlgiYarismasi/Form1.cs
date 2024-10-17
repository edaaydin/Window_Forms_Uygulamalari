namespace BİlgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;

            soruNo++;
            lblSoruNo.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label1.Text = "1923";
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Hangi il Ege bölgesinde bulunmaz ?";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label1.Text = "Balıkesir";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Son kuşlar hangi yazara aittir ?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreya";
                btnC.Text = "Attila İlhan";
                btnD.Text = "Reşat Nuri";
                label1.Text = "Sait Faik";
                btnSonraki.Text = "Sonuçlar";
            }
            if (soruNo == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show($"Doğru Sayısı : {dogru} \nYanlış Sayısı : {yanlis}");
            }
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnSonraki.Enabled = true;

            label2.Text = btnA.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
            }
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label2.Text = btnB.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label2.Text = btnC.Text;

            if (label1.Text == label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
            }
        }
        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label2.Text = btnD.Text;

            if (label1.Text == label2.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
            }
        }
    }
}


