namespace TarihBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt32(DateTime.Now.DayOfWeek);
            switch (gun)
            {
                case 1:
                    MessageBox.Show("Pazartesi");
                    break;
                case 2:
                    MessageBox.Show("Sal�");
                    break;
                case 3:
                    MessageBox.Show("�ar�amba");
                    break;
                case 4:
                    MessageBox.Show("Per�embe");
                    break;
                case 5:
                    MessageBox.Show("Cuma");
                    break;
                case 6:
                    MessageBox.Show("Cumartesi");
                    break;
                case 0:
                    MessageBox.Show("Pazar");
                    break;
                default:
                    MessageBox.Show("Hata Olu�tu");
                    break;
            }
        }
    }
}