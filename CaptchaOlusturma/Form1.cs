namespace CaptchaOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            String[] sembol2 = { "+", "-", "*", "/", "#" };
            int sembol3;

            Random r = new Random();
            int s1, s2, s3;
            s1 = r.Next(0, sembol1.Length);
            s2 = r.Next(0, sembol2.Length);
            s3 = r.Next(0, 10);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString();
        }
    }
}
