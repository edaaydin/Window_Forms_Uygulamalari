namespace UcakBiletRezervasyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbKaydet_Click(object sender, EventArgs e)
        {
            Rezervasyon_Bilgileri.Items.Add($"Nereden : {cbNereden.Text} Nereye : {cbNereye.Text} Tarih : {dtTarih.Text} Saat : {mtxtSaat.Text}");

            Rezervasyon_Bilgileri.Items.Add($"Ad Soyad : {txtAdSoyad.Text} TC No : {mtxtTc.Text} Telefon Numarasý : {mtxtTelNo.Text}");

            MessageBox.Show("Kayýt Ýþleminiz Tamamlanmýþtýr :)");
        }
    }
}
