namespace DigitalSaatUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat = 0, dakika = 0, saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label1Saniye.Text = saniye.ToString();

            if (saniye == 60)
            {
                dakika++;
                label2Dakika.Text = dakika.ToString();
                saniye = 0;

                if (dakika == 60)
                {
                    saat = saat + 1;
                    label3Saat.Text = saniye.ToString();
                    dakika = 0;
                }
            }
        }
    }
}
