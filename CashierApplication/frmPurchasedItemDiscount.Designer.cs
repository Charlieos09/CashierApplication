namespace CashierApplication
{
    partial class frmcashier
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.item = new Label();
            this.itemBox = new TextBox();
            this.discountBox = new TextBox();
            this.discount = new Label();
            this.priceBox = new TextBox();
            this.price = new Label();
            this.quantity = new Label();
            this.quantityBox = new TextBox();
            this.calcuButton = new Button();
            this.discountedPrice = new Label();
            this.change = new Label();
            this.paymentBox = new TextBox();
            this.label1 = new Label();
            this.paymentButton = new Button();
            this.fileSystemWatcher1 = new FileSystemWatcher();
            this.menu = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // item
            // 
            this.item.AutoSize = true;
            this.item.Location = new Point(12, 32);
            this.item.Name = "item";
            this.item.Size = new Size(36, 15);
            this.item.TabIndex = 0;
            this.item.Text = "Items";
            // 
            // itemBox
            // 
            this.itemBox.Location = new Point(12, 50);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new Size(156, 23);
            this.itemBox.TabIndex = 1;
            // 
            // discountBox
            // 
            this.discountBox.Location = new Point(174, 50);
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new Size(100, 23);
            this.discountBox.TabIndex = 3;
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Location = new Point(174, 32);
            this.discount.Name = "discount";
            this.discount.Size = new Size(72, 15);
            this.discount.TabIndex = 2;
            this.discount.Text = "Discount(%)";
            // 
            // priceBox
            // 
            this.priceBox.Location = new Point(12, 96);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new Size(100, 23);
            this.priceBox.TabIndex = 5;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new Point(12, 78);
            this.price.Name = "price";
            this.price.Size = new Size(33, 15);
            this.price.TabIndex = 4;
            this.price.Text = "Price";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new Point(130, 99);
            this.quantity.Name = "quantity";
            this.quantity.Size = new Size(53, 15);
            this.quantity.TabIndex = 6;
            this.quantity.Text = "Quantity";
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new Point(189, 96);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new Size(84, 23);
            this.quantityBox.TabIndex = 7;
            // 
            // calcuButton
            // 
            this.calcuButton.Location = new Point(105, 135);
            this.calcuButton.Name = "calcuButton";
            this.calcuButton.Size = new Size(97, 41);
            this.calcuButton.TabIndex = 8;
            this.calcuButton.Text = "Compute";
            this.calcuButton.UseVisualStyleBackColor = true;
            // 
            // discountedPrice
            // 
            this.discountedPrice.AutoSize = true;
            this.discountedPrice.Location = new Point(34, 196);
            this.discountedPrice.Name = "discountedPrice";
            this.discountedPrice.Size = new Size(0, 15);
            this.discountedPrice.TabIndex = 9;
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Location = new Point(34, 330);
            this.change.Name = "change";
            this.change.Size = new Size(0, 15);
            this.change.TabIndex = 10;
            // 
            // paymentBox
            // 
            this.paymentBox.Location = new Point(115, 239);
            this.paymentBox.Name = "paymentBox";
            this.paymentBox.Size = new Size(103, 23);
            this.paymentBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new Size(97, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Payment Receive";
            // 
            // paymentButton
            // 
            this.paymentButton.Location = new Point(105, 268);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new Size(97, 41);
            this.paymentButton.TabIndex = 13;
            this.paymentButton.Text = "Submit";
            this.paymentButton.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            this.menu.Location = new Point(0, 0);
            this.menu.Name = "menustrip";
            this.menu.Size = new Size(311, 24);
            this.menu.TabIndex = 14;
            this.menu.Text = "menu";
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem();
            exitMenuItem.Text = "Exit";
            exitMenuItem.Click += this.menustrip_exit_Click;
            this.menu.Items.Add(exitMenuItem);
            ToolStripMenuItem logoutitem = new ToolStripMenuItem();
            logoutitem.Text = "Logout";
            logoutitem.Click += this.logout_Click;
            this.menu.Items.Add(logoutitem);
            // 
            // frmcashier
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(311, 406);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.paymentBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.change);
            this.Controls.Add(this.discountedPrice);
            this.Controls.Add(this.calcuButton);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.price);
            this.Controls.Add(this.discountBox);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.item);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frmcashier";
            this.Text = "Cashier Application";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label item;
        private TextBox itemBox;
        private Label change;
        private Label discountedPrice;
        private Button calcuButton;
        private TextBox quantityBox;
        private Label quantity;
        private TextBox priceBox;
        private Label price;
        private TextBox discountBox;
        private Label discount;
        private TextBox paymentBox;
        private Label label1;
        private Button paymentButton;
        private FileSystemWatcher fileSystemWatcher1;

        private MenuStrip menu;
        
    }
}
