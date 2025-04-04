using System;
using System.Data;
using System.Windows.Forms;

namespace TShirtOrderingApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        // Handle button clicks
        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                textBox.Text += button.Text;
            }
        }

        // Handle '=' button click for evaluating the expression
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(textBox.Text, null);
                textBox.Text = result.ToString();
            }
            catch (Exception)
            {
                textBox.Text = "Error";
            }
        }

        // Handle Clear button click
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }
    }
}
