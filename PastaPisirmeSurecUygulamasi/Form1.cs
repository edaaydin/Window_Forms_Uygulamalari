namespace PastaPisirmeSurecUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

            if (progressBar1.Value % 20 == 10)
            {
                lblKaristirma.BackColor = Color.White;
            }
            if (progressBar1.Value % 20 == 0)
            {
                lblKaristirma.BackColor = Color.Red;
            }

            if (progressBar1.Value == 100)
            {
                //MessageBox.Show("Kar��t�rma i�lemi tamamlanm��t�r");
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;

            if (progressBar2.Value % 10 == 0)
            {
                lblCirpma.BackColor = Color.Red;
            }
            if (progressBar2.Value % 10 == 5)
            {
                lblCirpma.BackColor = Color.White;
            }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 20;

            if (progressBar3.Value % 40 == 0)
            {
                lblHarmanlama.BackColor = Color.White;
            }
            if (progressBar3.Value % 40 == 20)
            {
                lblHarmanlama.BackColor = Color.Red;
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 1;

            if (progressBar4.Value % 2 == 0)
            {
                lblPisiyor.BackColor = Color.Red;
            }
            if (progressBar4.Value % 2 == 1)
            {
                lblPisiyor.BackColor = Color.White;
            }
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("��leminiz ba�ar�yla ger�ekle�mi�tir.");
            }
        }
    }
}
