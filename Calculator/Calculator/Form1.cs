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
    public partial class Calculator : Form
    {
        string intput=string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result=0.0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            intput += 1;
            this.textBox1.Text += intput;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            intput += 2;
            this.textBox1.Text += intput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            intput += 3;
            this.textBox1.Text += intput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            intput += 4;
            this.textBox1.Text += intput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            intput += 5;
            this.textBox1.Text += intput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            intput += 6;
            this.textBox1.Text += intput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            intput += 7;
            this.textBox1.Text += intput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            intput += 8;
            this.textBox1.Text += intput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            intput += 9;
            this.textBox1.Text += intput;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operand1 = intput;
            operation = '-';
            intput = string.Empty;
        }

        private void button12mul_Click(object sender, EventArgs e)
        {
            operand1 = intput;
            operation = '*';
            intput = string.Empty;
        }

        private void button13div_Click(object sender, EventArgs e)
        {
            operand1 = intput;
            operation = '/';
            intput = string.Empty;
        }

        private void button14plus_Click(object sender, EventArgs e)
        {
            operand1 = intput;
            operation = '+';
            intput = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            operand2 = intput;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }

            }
        }
    }
}
