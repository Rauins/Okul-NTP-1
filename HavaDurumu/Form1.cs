namespace HavaDurumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            if(sayi < 10 )
            {
                MessageBox.Show("Hava so�uk");
            }
            else if (sayi < 25 )
            {
                MessageBox.Show("Hava hafif s�cak");
            }
            else 
            {
                MessageBox.Show("Hava s�cak");
            }
        }
    }
}