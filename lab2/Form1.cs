using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
           
            int x, y, z;

            if (!int.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("Будь ласка, введіть правильне значення для X.");
            }
            else if (!int.TryParse(textBox2.Text, out y))
            {
                MessageBox.Show("Будь ласка, введіть правильне значення для Y.");
            }
            else if (!int.TryParse(textBox3.Text, out z))
            {
                MessageBox.Show("Будь ласка, введіть правильне значення для Z.");
            }
            else
            {
                double res1 = Math.Pow(x - 1, 1.0 / 3);
                double res2 = Math.Pow(y + res1, 1.0 / 4);
                double res3 = 2 * (Math.Abs(x + z));

                double res = Math.Log10(x) * (res2 / res3);

                MessageBox.Show("Результат: " + Math.Round(res, 4));
            }

        }

      
    }
}
