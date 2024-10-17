namespace AlisverisIndirimHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int kitapAdet;
            double toplam;

            kitapAdet = Convert.ToInt32(txtKitapAdet.Text);

            if (kitapAdet >= 0 && kitapAdet <= 20)
            {
                toplam = (kitapAdet * 8) - (kitapAdet * 8 * 0.20);
                lbl00.Text = toplam.ToString() + "TL";
            }
            if (kitapAdet >= 21 && kitapAdet <= 40)
            {
                toplam = (kitapAdet * 8) - (kitapAdet * 8 * 0.40);
                lbl00.Text = toplam.ToString() + "TL";
            }
            if (kitapAdet >= 41)
            {
                toplam = (kitapAdet * 8) - (kitapAdet * 8 * 0.50);
                lbl00.Text = toplam.ToString() + "TL";
            }

        }
    }
}
