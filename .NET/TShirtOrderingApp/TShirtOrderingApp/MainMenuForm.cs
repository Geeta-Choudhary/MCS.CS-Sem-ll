using System;
using System.Windows.Forms;

namespace TShirtOrderingApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }

        private void btnCalculatorForm_Click(object sender, EventArgs e)
        {
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.Show();
        }
    }
}
