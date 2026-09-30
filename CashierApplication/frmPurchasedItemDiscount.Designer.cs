namespace CashierApplication
{
    partial class Form1
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
            item = new Label();
            itemBox = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            discountBox = new TextBox();
            discount = new Label();
            priceBox = new TextBox();
            price = new Label();
            quantity = new Label();
            quantityBox = new TextBox();
            calcuButton = new Button();
            discountedPrice = new Label();
            change = new Label();
            paymentBox = new TextBox();
            label1 = new Label();
            paymentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // item
            // 
            item.AutoSize = true;
            item.Location = new Point(12, 32);
            item.Name = "item";
            item.Size = new Size(36, 15);
            item.TabIndex = 0;
            item.Text = "Items";
            // 
            // itemBox
            // 
            itemBox.Location = new Point(12, 50);
            itemBox.Name = "itemBox";
            itemBox.Size = new Size(156, 23);
            itemBox.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // discountBox
            // 
            discountBox.Location = new Point(174, 50);
            discountBox.Name = "discountBox";
            discountBox.Size = new Size(100, 23);
            discountBox.TabIndex = 3;
            // 
            // discount
            // 
            discount.AutoSize = true;
            discount.Location = new Point(174, 32);
            discount.Name = "discount";
            discount.Size = new Size(72, 15);
            discount.TabIndex = 2;
            discount.Text = "Discount(%)";
            // 
            // priceBox
            // 
            priceBox.Location = new Point(12, 96);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(100, 23);
            priceBox.TabIndex = 5;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(12, 78);
            price.Name = "price";
            price.Size = new Size(33, 15);
            price.TabIndex = 4;
            price.Text = "Price";
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.Location = new Point(130, 99);
            quantity.Name = "quantity";
            quantity.Size = new Size(53, 15);
            quantity.TabIndex = 6;
            quantity.Text = "Quantity";
            // 
            // quantityBox
            // 
            quantityBox.Location = new Point(189, 96);
            quantityBox.Name = "quantityBox";
            quantityBox.Size = new Size(84, 23);
            quantityBox.TabIndex = 7;
            // 
            // calcuButton
            // 
            calcuButton.Location = new Point(105, 135);
            calcuButton.Name = "calcuButton";
            calcuButton.Size = new Size(97, 41);
            calcuButton.TabIndex = 8;
            calcuButton.Text = "Compute";
            calcuButton.UseVisualStyleBackColor = true;
            // 
            // discountedPrice
            // 
            discountedPrice.AutoSize = true;
            discountedPrice.Location = new Point(34, 196);
            discountedPrice.Name = "discountedPrice";
            discountedPrice.Size = new Size(0, 15);
            discountedPrice.TabIndex = 9;
            // 
            // change
            // 
            change.AutoSize = true;
            change.Location = new Point(34, 330);
            change.Name = "change";
            change.Size = new Size(0, 15);
            change.TabIndex = 10;
            // 
            // paymentBox
            // 
            paymentBox.Location = new Point(115, 239);
            paymentBox.Name = "paymentBox";
            paymentBox.Size = new Size(103, 23);
            paymentBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 242);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 11;
            label1.Text = "Payment Recieve";
            // 
            // paymentButton
            // 
            paymentButton.Location = new Point(105, 268);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(97, 41);
            paymentButton.TabIndex = 13;
            paymentButton.Text = "Submit";
            paymentButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 406);
            Controls.Add(paymentButton);
            Controls.Add(paymentBox);
            Controls.Add(label1);
            Controls.Add(change);
            Controls.Add(discountedPrice);
            Controls.Add(calcuButton);
            Controls.Add(quantityBox);
            Controls.Add(quantity);
            Controls.Add(priceBox);
            Controls.Add(price);
            Controls.Add(discountBox);
            Controls.Add(discount);
            Controls.Add(itemBox);
            Controls.Add(item);
            Name = "Form1";
            Text = "Cashier Application";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label item;
        private TextBox itemBox;
        private FileSystemWatcher fileSystemWatcher1;
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
    }
}
