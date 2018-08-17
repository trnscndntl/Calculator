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

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Min(double a, double b)
        {
            return a - b;
        }
        public double Umn(double a, double b)
        {
            return a * b;
        }
        public double Pod(double a, double b)
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
        public double Kor(double a)
        {
            double result;
            result = Math.Sqrt(a);
            return result;
        }
        public double Kvadr(double a)
        {
            double result;
            result = Math.Pow(a, 2);
            return result;
        }


    }
}
