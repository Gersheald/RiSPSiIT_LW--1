using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiSPSiIT_LW__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            if (a > 0)
            {

                b = a * a * a;
                textBox2.Text = Convert.ToString(b);

            }
            else
                textBox2.Text = "Введите положительное число";
       
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double a, c;
            a = Convert.ToDouble(textBox1.Text);
            if (a > 0)
            {
                c = 6 * (a * a);
                textBox3.Text = Convert.ToString(c);                      
            }
            else
                textBox3.Text = "Введите положительное число";
        }
    }
}
