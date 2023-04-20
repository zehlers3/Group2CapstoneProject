namespace WinFormsApp1
{
    partial class LoginPage
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
            usernameTxt = new TextBox();
            loginError = new Label();
            label2 = new Label();
            passwordTxt = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(231, 64);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(188, 23);
            usernameTxt.TabIndex = 0;
            // 
            // loginError
            // 
            loginError.AutoSize = true;
            loginError.Location = new Point(165, 67);
            loginError.Name = "loginError";
            loginError.Size = new Size(60, 15);
            loginError.TabIndex = 1;
            loginError.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 116);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(231, 113);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(188, 23);
            passwordTxt.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(279, 163);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 265);
            Controls.Add(button1);
            Controls.Add(passwordTxt);
            Controls.Add(label2);
            Controls.Add(loginError);
            Controls.Add(usernameTxt);
            Name = "LoginPage";
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTxt;
        private Label loginError;
        private Label label2;
        private TextBox passwordTxt;
        private Button button1;
        private Label label3;
    }
}