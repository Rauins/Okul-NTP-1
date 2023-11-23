namespace Karesinial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = sayi1 * sayi1;
            MessageBox.Show("Girdiðiniz sayýnýn karesi : " + sayi2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}