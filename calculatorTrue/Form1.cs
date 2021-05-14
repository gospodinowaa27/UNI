using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorTrue
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if(!textBox1.Text.Contains(","))
                 textBox1.Text = textBox1.Text + button.Text;
            }else
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                buttonE.PerformClick();
                        operation = button.Text;
                        label.Text = result + " " + operation;
                        isOperationPerformed = true;
                


            }
            else
            {
                operation = button.Text;
                result = Double.Parse(textBox1.Text);
                label.Text = result + " " + operation;
                isOperationPerformed = true;
            }
        }
            private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(textBox1.Text);
            label.Text = "";
        }
    }
}
