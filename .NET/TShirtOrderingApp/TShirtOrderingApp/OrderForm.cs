using System;
using System.Windows.Forms;

namespace TShirtOrderingApp
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal pricePerShirt = 0;

            if (rbSmall.Checked)
                pricePerShirt = 125;
            else if (rbMedium.Checked)
                pricePerShirt = 175;
            else if (rbLarge.Checked)
                pricePerShirt = 250;
            else
            {
                MessageBox.Show("Please select a T-shirt size.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalPrice = quantity * pricePerShirt;

            string promoCode = txtPromoCode.Text.Trim();
            if (!string.IsNullOrEmpty(promoCode))
            {
                if (promoCode.Equals("TRUEBLUE", StringComparison.OrdinalIgnoreCase))
                {
                    totalPrice *= 0.90m; // Apply 10% discount
                }
                else
                {
                    MessageBox.Show("Invalid promo code.", "Promo Code Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            decimal gst = totalPrice * 0.09m;
            totalPrice += gst;

            lblFinalPrice.Text = $"Final Price: Rs. {totalPrice:F2}";
        }
    }
}
