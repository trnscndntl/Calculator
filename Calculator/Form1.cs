using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class comma : Form
    {
        public comma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            znak.Text = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            znak.Text = "*";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Min(double a, double b)
        {
            return a - b;
        }

        public static double Umn(double a, double b)
        {
            return a * b;
        }

        public static double Pod(double a, double b)
        {
            if (b == 0)
            {
                MessageBox.Show("You cannot divide by 0");
            }
            else
            {
                return a / b;
            }
        }
        public static double Kor(double a)
        {
            return Math.Sqrt(a);
        }

        public static double Step(double a, double b)
        {
            return Math.Pow(a, b);
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (znak.Text == "")
            {
                textBox1.Text += "3";
            }
            else
            {
                textBox3.Text += "3";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (znak.Text == "")
            {
                textBox1.Text += "2";
            }
            else
            {
                textBox3.Text += "2";
            }
        }

        private void one_Click_1(object sender, EventArgs e)
        {
            if (znak.Text == "")
            {
                textBox1.Text += "1";
            }
            else
            {
                textBox3.Text += "1";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (znak.Text == "")
            {
                textBox1.Text += "4";
            }
            else
            {
                textBox3.Text += "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (znak.Text == "")
            {
                textBox1.Text += "5";
            }
            else
            {
                textBox3.Text += "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (znak.Text == "")
            {
                textBox1.Text += "6";
            }
            else
            {
                textBox3.Text += "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (znak.Text == "")
            {
                textBox1.Text += "7";
            }
            else
            {
                textBox3.Text += "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (znak.Text == "")
            {
                textBox1.Text += "8";
            }
            else
            {
                textBox3.Text += "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (znak.Text == "")
            {
                textBox1.Text += "9";
            }
            else
            {
                textBox3.Text += "9";
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (znak.Text == "")
            {
                textBox1.Text += "0";
            }
            else
            {
                textBox3.Text += "0";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            znak.Text = "";
        }
        private void equals_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox3.Text);
            switch (znak.Text)
            {
                case "+": textBox2.Text = Sum(a, b).ToString();
                    break;
                case "-": textBox2.Text = Min(a, b).ToString();
                    break;
                case "*": textBox2.Text = Umn(a, b).ToString();
                    break;
                case "/": textBox2.Text = Pod(a, b).ToString();
                    break;
                case "^": textBox2.Text = Step(a, b).ToString();
                    break;
                case "√": textBox2.Text = Kor(a).ToString();
                    break;
                default: break;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            znak.Text = "-";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            znak.Text = "/";
        }

        private void sqr_Click(object sender, EventArgs e)
        {
            znak.Text = "^";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void sqrt_Click(object sender, EventArgs e)
        {
            znak.Text = "√";
        }
        private void znak_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (znak.Text == "")
            {
                textBox1.Text += ".";
            }
            else
            {
                textBox3.Text += ".";
            }
        }
    }
}
