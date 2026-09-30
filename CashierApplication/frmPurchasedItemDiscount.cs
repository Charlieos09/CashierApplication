using System;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmcashier : Form
    {

        public double currentprice;

        public frmcashier()
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


            priceBox.PlaceholderText = discounted.ToString("F2");
            discountedPrice.Text = "Discounted Price: " + discounted.ToString("C");
        }


        public void submit_Click(object sender, EventArgs e)
        {
            double paymentAmount = 0.0;
            double.TryParse(paymentBox.Text, out paymentAmount);

            double changeAmount = paymentAmount - currentprice;
            change.Text = "Change: " + changeAmount.ToString("C");
        }
        public void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmlogin loginForm = new Frmlogin();
            loginForm.Show();
        }

        public void menustrip_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
