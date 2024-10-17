namespace SinemaBufeSatisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Global alandýr !

        int kasaTutar = 0;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt32(txtMisir.Text);
            su = Convert.ToInt32(txtSu.Text);
            cay = Convert.ToInt32(txtCay.Text);
            bilet = Convert.ToInt32(txtBilet.Text);

            toplam = misir * 4 + su * 1 + cay * 2 + bilet * 8;
            lbl00.Text = toplam.ToString() + "TL";

            kasaTutar = kasaTutar + toplam;
            lblKasa0.Text = kasaTutar.ToString() + "TL";

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBilet.Text = "";
            txtCay.Text = "";
            txtMisir.Text = "";
            txtSu.Text = "";
            txtMisir.Focus(); // Odak noktasi
        }
    }
}
