using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        private double firstNumber; 
        private string operation;   

        public Form1()
        {
          
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "+";
            txtDisplay.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            firstNumber = 0;
            operation = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(txtDisplay.Text);
            double result = 0;

            switch (operation)
            {
                case "+": result = firstNumber + secondNumber; break;
                case "-": result = firstNumber - secondNumber; break;
                case "*": result = firstNumber * secondNumber; break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        MessageBox.Show("Ошибка: Деление на ноль!");
                    break;
                case "^": result = Math.Pow(firstNumber, secondNumber); break;
            }

            txtDisplay.Text = result.ToString();
        }

        private void txtdisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "-";
            txtDisplay.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "*";
            txtDisplay.Clear();
        }

        private void btntoshare_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "/";
            txtDisplay.Clear();
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(txtDisplay.Text);

            if (number >= 0)
                txtDisplay.Text = Math.Sqrt(number).ToString();
            else
                MessageBox.Show("Ошибка: Нельзя вычислить корень из отрицательного числа!");
        }

        private void btnpower_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtDisplay.Text);
            operation = "^";
            txtDisplay.Clear();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
