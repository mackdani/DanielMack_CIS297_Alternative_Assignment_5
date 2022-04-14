using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsForm
{
    /// </summary>
    /// <Student>Daniel Mack</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    public partial class CalculatorForm1 : Form
    {
        public CalculatorForm1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 1.	Return a string without the Whitespaces
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string Textinput = textBox1.Text;
            Result_TextBox.Text = Textinput.Replace(" ", "");
        }
        /// <summary>
        /// 2.	Reverse a string
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            char[] charArray = textBox1.Text.ToCharArray();
            Array.Reverse(charArray);
            string result;
            result = new string(charArray);
            Result_TextBox.Text = result;
        }
        /// <summary>
        /// 3.	3) Display the quotient and the remainder
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            int firstnum = int.Parse(textBox1.Text);
            int secondnum = int.Parse(textBox2.Text);
            int remainder;
            double quotient = Math.DivRem(firstnum, secondnum, out remainder);
            Result_TextBox.Text = $"Quotient:{quotient}                         Remainder:{remainder}";
        }
        /// </summary>
        /// 4) Find the logarithm of a specified number to base 10
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            double firstnum = double.Parse(textBox1.Text);
            double Log = Math.Log10(firstnum);
            Result_TextBox.Text = $"Log({firstnum}) to the base 10 is {Log}";
        }
        /// </summary>
        /// 5) Find the logarithm of a specified number to a specified base
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            double firstnum = double.Parse(textBox1.Text);
            double secondnum = double.Parse(textBox2.Text);
            double LogBase = Math.Log(firstnum, secondnum);
            Result_TextBox.Text = $"Log({firstnum}) to the base {secondnum} is {LogBase}";
        }
        /// </summary>
        /// 6) Display the minimum and maximum of the two numbers
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(textBox1.Text);
            double num2 = Double.Parse(textBox2.Text);

            double min1 = Math.Min(num1, num2);
            double max1 = Math.Max(num1, num2);

            Result_TextBox.Text = $"Minimum: {min1}    &    Maximum: { max1 }";
        }
        /// </summary>
        /// 7) Find the specified number to the specified power
        /// </summary>
        private void button7_Click(object sender, EventArgs e)
        {
            double firstnum = double.Parse(textBox1.Text);
            double secondnum = double.Parse(textBox2.Text);
            double Result = Math.Pow(firstnum, secondnum);
            Result_TextBox.Text = $"{firstnum} to the power {secondnum} is {Result}";
        }
        /// </summary>
        /// 8) Find the roots of a quadratic equation
        /// </summary>
            private void button8_Click(object sender, EventArgs e)
        {
            double discrim;
            double X_1;
            double X_2;
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            discrim = (b * b) - (4 * a * c);
            if (discrim == 0)
            {
                X_1 = -b / (2 * a);
                X_2 = X_1;
                Result_TextBox.Text = $"Root X1 = {X_1}  &  Root X2 = {X_2}";
            }
            else if (discrim > 0)
            {
                X_1 = (-b + Math.Sqrt(discrim)) / (2 * a);
                X_2 = (-b - Math.Sqrt(discrim)) / (2 * a);
                Result_TextBox.Text = $"Root X1 = {X_1}  &  Root X2 = {X_2}";
            }
        }
        /// </summary>
        /// 9) Find the square root of the given number
        /// </summary>
        private void button9_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            Result_TextBox.Text = Math.Sqrt(number).ToString();
        }
        /// <summary>
        /// 10) Exit
        /// </summary>
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            Result_TextBox.Text = "";
        }
    }
}
