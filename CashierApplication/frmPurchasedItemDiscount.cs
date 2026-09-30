using System;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class Form1 : Form
    {

        public double currentprice;

        public Form1()
        {
            InitializeComponent();

            calcuButton.Click += Calcubutton_Click;
            paymentButton.Click += submit_Click;
        }

 
        public void Calcubutton_Click(object sender, EventArgs e)
        {

            double itemPrice = 0.0;
            int itemQuantity = 1;
            double itemDiscountPercent = 0.0;

            double.TryParse(priceBox.Text, out itemPrice);
            int.TryParse(quantityBox.Text, out itemQuantity);
            double.TryParse(discountBox.Text, out itemDiscountPercent);

            double totalPrice = itemPrice * itemQuantity;
            double discounted = totalPrice * (1.0 - (itemDiscountPercent / 100.0));

            currentprice = discounted;

            try
            {
                priceBox.PlaceholderText = discounted.ToString("F2");
            }
            catch
            {
                
            }

            discountedPrice.Text = "Discounted Price: " + discounted.ToString("C");
        }

        
        public void submit_Click(object sender, EventArgs e)
        {
            double paymentAmount = 0.0;
            double.TryParse(paymentBox.Text, out paymentAmount);

            double changeAmount = paymentAmount - currentprice;
            change.Text = "Change: " + changeAmount.ToString("C");
        }
    }
}
