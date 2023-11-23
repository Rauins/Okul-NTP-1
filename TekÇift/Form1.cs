namespace TekÇift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = Convert.ToInt32(textBox1.Text);
            if (sayi1 % 2 == 0 && sayi1 != 0 )
            {
                MessageBox.Show("Sayı Çifttir");
            }
            else if (sayi1 % 2 == 1 ) 
            {
                MessageBox.Show("Sayı Tektir");
            }
            else
            {
                MessageBox.Show("Sayı 0'dır");
            }
        }
    }
}