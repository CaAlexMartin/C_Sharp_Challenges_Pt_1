using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_Simple_Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

            protected void subtractButton_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(numberTextBox1.Text);
            int secondNumber = int.Parse(numberTextBox2.Text);

            int result = firstNumber - secondNumber;

            resultLabel.Text = result.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(numberTextBox1.Text);
            int secondNumber = int.Parse(numberTextBox2.Text);

            int result = firstNumber * secondNumber;

            resultLabel.Text = result.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double firstNumber = int.Parse(numberTextBox1.Text);
            double secondNumber = int.Parse(numberTextBox2.Text);

            double result = firstNumber / secondNumber;

            resultLabel.Text = result.ToString();
        }

        protected void plusButton_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(numberTextBox1.Text);
            int secondNumber = int.Parse(numberTextBox2.Text);

            int result = firstNumber + secondNumber;

            resultLabel.Text = result.ToString();
        }
    }
}