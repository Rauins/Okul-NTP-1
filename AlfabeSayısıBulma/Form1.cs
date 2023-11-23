namespace AlfabeSayısıBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string harf = comboBox1.Text;
            switch (harf)
            {
                case "A":
                    label2.Text = "A Alfabenin 1. Harfidir.";
                    break;
                case "B":
                    label2.Text = "B Alfabenin 2. Harfidir. ";
                    break;
                case "C":
                    label2.Text = "C Alfabenin 3. Harfidir. ";
                    break;
                case "Ç":
                    label2.Text = "Ç Alfabenin 4. Harfidir. ";
                    break;
                case "D":
                    label2.Text = "D Alfabenin 5. Harfidir. ";
                    break;
                case "E":
                    label2.Text = "E Alfabenin 6. Harfidir. ";
                    break;
                case "F":
                    label2.Text = "F Alfabenin 7. Harfidir. ";
                    break;
                case "G":
                    label2.Text = "G Alfabenin 8. Harfidir. ";
                    break;
                case "Ğ":
                    label2.Text = "Ğ Alfabenin 9. Harfidir. ";
                    break;
                case "H":
                    label2.Text = "H Alfabenin 10. Harfidir. ";
                    break;
                case "I":
                    label2.Text = "I Alfabenin 12. Harfidir. ";
                    break;
                case "İ":
                    label2.Text = "İ Alfabenin 11. Harfidir. ";
                    break;
                case "J":
                    label2.Text = "J Alfabenin 13. Harfidir. ";
                    break;
                case "K":
                    label2.Text = "K Alfabenin 14. Harfidir. ";
                    break;
                case "L":
                    label2.Text = "L Alfabenin 15. Harfidir. ";
                    break;
                case "M":
                    label2.Text = "M Alfabenin 16. Harfidir. ";
                    break;
                case "N":
                    label2.Text = "N Alfabenin 17. Harfidir. ";
                    break;
                case "O":
                    label2.Text = "O Alfabenin 18. Harfidir. ";
                    break;
                case "Ö":
                    label2.Text = "Ö Alfabenin 19. Harfidir. ";
                    break;
                case "P":
                    label2.Text = "P Alfabenin 20. Harfidir. ";
                    break;
                case "R":
                    label2.Text = "R Alfabenin 21. Harfidir. ";
                    break;
                case "S":
                    label2.Text = "S Alfabenin 22. Harfidir. ";
                    break;
                case "Ş":
                    label2.Text = "Ş Alfabenin 23. Harfidir. ";
                    break;
                case "T":
                    label2.Text = "T Alfabenin 24. Harfidir. ";
                    break;
                case "U":
                    label2.Text = "U Alfabenin 25. Harfidir. ";
                    break;
                case "Ü":
                    label2.Text = "Ü Alfabenin 26. Harfidir. ";
                    break;
                case "V":
                    label2.Text = "V Alfabenin 27. Harfidir. ";
                    break;
                case "Y":
                    label2.Text = "Y Alfabenin 28. Harfidir. ";
                    break;
                case "Z":
                    label2.Text = "Z Alfabenin 29. Harfidir. ";
                    break;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}