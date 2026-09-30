namespace CashierApplication
{
    partial class Frmlogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userLabel = new Label();
            userBox = new TextBox();
            PassBox = new TextBox();
            passLabel = new Label();
            loginButton = new Button();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(27, 29);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(60, 15);
            userLabel.TabIndex = 0;
            userLabel.Text = "Username";
            // 
            // userBox
            // 
            userBox.Location = new Point(27, 56);
            userBox.Name = "userBox";
            userBox.Size = new Size(147, 23);
            userBox.TabIndex = 1;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(27, 119);
            PassBox.Name = "PassBox";
            PassBox.Size = new Size(147, 23);
            PassBox.TabIndex = 3;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new Point(27, 92);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(57, 15);
            passLabel.TabIndex = 2;
            passLabel.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(57, 164);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(89, 41);
            loginButton.TabIndex = 4;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += this.loginButton_Click;
            // 
            // Frmlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(197, 226);
            Controls.Add(loginButton);
            Controls.Add(PassBox);
            Controls.Add(passLabel);
            Controls.Add(userBox);
            Controls.Add(userLabel);
            Name = "Frmlogin";
            Text = "Frmlogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userLabel;
        private TextBox userBox;
        private TextBox PassBox;
        private Label passLabel;
        private Button loginButton;
    }
}