using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, sayi4;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            sayi3 = 0;
            sayi4 = 1;
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (radioButton1.Checked)
                {
                    sayi3 = sayi3 + i;
                }
                
            }
            
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (radioButton2.Checked)
                {
                    sayi4 = sayi4 * i;
                }
                
            }
            if (radioButton1.Checked)
            {
                MessageBox.Show("İşlemin sonucu : " + sayi3);
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("İşlemin sonucu : " + sayi4);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
