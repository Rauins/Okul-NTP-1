using static System.Windows.Forms.DataFormats;

namespace SesSeviyesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int ses = trackBar1.Value;
            if (ses == 0)
            {
                label1.Text = "Ses Yok"; label1.ForeColor = Color.Black;
            }
            if (ses > 0 && ses <= 10)
            {
                label1.Text = "Normal Ses Seviyesi"; label1.ForeColor = Color.Green;
            }
            if (ses >= 11)
            {
                label1.Text = "Y�ksek Ses Seviyesi"; label1.ForeColor = Color.Red;
            }
        }
    }
}