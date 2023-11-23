namespace Vki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo, boy, vki;
            kilo = Convert.ToDouble(textBox1.Text);
            boy = Convert.ToDouble(textBox2.Text);
            vki = kilo / boy * boy;
            MessageBox.Show("Vücut Kitle Endeksiniz : " + vki);
        }
    }
}