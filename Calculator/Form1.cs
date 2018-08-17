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
    public partial class Form1 : Form
    {
        public Form1()
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
                throw new Exception("Cannot divide by 0");
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

        }

        private void two_Click(object sender, EventArgs e)
        {

        }

        private void one_Click_1(object sender, EventArgs e)
        {
        }

        private void four_Click(object sender, EventArgs e)
        {

        }

        private void five_Click(object sender, EventArgs e)
        {

        }

        private void six_Click(object sender, EventArgs e)
        {

        }

        private void seven_Click(object sender, EventArgs e)
        {

        }

        private void eight_Click(object sender, EventArgs e)
        {

        }

        private void nine_Click(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {

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
            double a = int.Parse(textBox1.Text);
            double b = int.Parse(textBox3.Text);
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
    }
}
