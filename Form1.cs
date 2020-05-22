using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gulyaev_AG_6
{
    public partial class Form1 : Form
    {
        double operand1 = 0, operand2 = 0;
        string result;
        char operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_digit_Click(object sender, EventArgs e)
        {
            label1.Text += (sender as Button).Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button_operation_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(label1.Text);
            operation = (sender as Button).Text[0];
            label1.Text = "";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            operand2 = Convert.ToDouble(label1.Text);
            switch (operation)
            {
                case '+':
                    result = Convert.ToString(operand1 + operand2);
                    break;
                case '-':
                    result = Convert.ToString(operand1 - operand2);
                    break;
                case '×':
                    result = Convert.ToString(operand1 * operand2);
                    break;
                case '/':
                    if (operand2 != 0) result = Convert.ToString(operand1 / operand2);
                    else result = "error";
                    break;
            }
            label1.Text = result;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    button_operation_Click(button1, e); break;
                case Keys.Multiply:
                    button_operation_Click(button3, e); break;
                case Keys.Divide:
                    button_operation_Click(button4, e); break;
                case Keys.Subtract:
                    button_operation_Click(button2, e); break;
                case Keys.NumPad0:
                    button_digit_Click(button00, e); break;
                case Keys.NumPad1:
                    button_digit_Click(button01, e); break;
                case Keys.NumPad2:
                    button_digit_Click(button02, e); break;
                case Keys.NumPad3:
                    button_digit_Click(button03, e); break;
                case Keys.NumPad4:
                    button_digit_Click(button04, e); break;
                case Keys.NumPad5:
                    button_digit_Click(button05, e); break;
                case Keys.NumPad6:
                    button_digit_Click(button06, e); break;
                case Keys.NumPad7:
                    button_digit_Click(button07, e); break;
                case Keys.NumPad8:
                    button_digit_Click(button08, e); break;
                case Keys.NumPad9:
                    button_digit_Click(button09, e); break;
                case Keys.Decimal:
                    button_digit_Click(button10, e); break;
                case Keys.Delete:
                    button_clear_Click(button6, e); break;
                case Keys.Enter:
                    button_equal_Click(button5, e); break;
            }
        }
    }
}
