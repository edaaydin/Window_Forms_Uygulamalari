namespace OgrNotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2, proje;
            double ortalama;

            ad = txtxAd.Text;
            soyad = txtSoyad.Text;

            s1 = Convert.ToInt32(txt1.Text);
            s2 = Convert.ToInt32(txt2.Text);
            proje = Convert.ToInt32(txtpro.Text);

            ortalama = (s1 + s2 + proje) / 3;

            listBox1.Items.Add($"Adý : {ad} Soyadý : {soyad} Ortalama : {ortalama}");

        }
    }
}
