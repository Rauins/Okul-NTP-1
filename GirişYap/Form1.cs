namespace GirişYap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad;
            ad = textBox1.Text;
            if (ad == "ali")
            {
                MessageBox.Show("Kullanıcı adı doğru.");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı yanlış.");
            }
        }
    }
}