namespace ListboxIcindekielemaniBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                // Her öðeyi tek tek kontrol etmeliyiz
                if (listBox1.Items[i].ToString().Contains(textBox1.Text))
                {
                    listBox1.SetSelected(i, true);
                    if (textBox1.Text == " ")
                    {
                        listBox1.SetSelected(i, false);
                    }
                }
                else
                {
                    listBox1.SetSelected(i, false);
                }
            }
        }
    }
}
