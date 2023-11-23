namespace İndirimliÜrün
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.10; //Yüzde 10 indirim
            label3.Text = indirimliFiyat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.25; //Yüzde 25 indirim
            label3.Text = indirimliFiyat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.50; //Yüzde 50 indirim
            label3.Text = indirimliFiyat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.75; //Yüzde 75 indirim
            label3.Text = indirimliFiyat.ToString();
        }
    }
}