namespace LambaKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool secim;
            secim = checkBox1.Checked; //Checked özelliði True veya False deðerleri alýr.
            label2.Text = secim.ToString();
        }
    }
}