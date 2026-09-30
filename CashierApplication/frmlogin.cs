using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
            loginButton.Click += loginButton_Click;
        }
        public void loginButton_Click(object sender, EventArgs e)
        {
            string username = userBox.Text;
            string password = PassBox.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            if (username == "cashier" && password == "pass123")
            {
                DialogResult diaresult = MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var mainForm = new frmcashier();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
