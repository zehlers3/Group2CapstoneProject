namespace Group2CapstoneProj
{
    partial class CatagoriesForm
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
            label1 = new Label();
            button1 = new Button();
            searchTxt = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 60);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Catagories";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(724, 12);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(134, 23);
            searchTxt.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(643, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(206, 110);
            button3.Name = "button3";
            button3.Size = new Size(112, 55);
            button3.TabIndex = 4;
            button3.Text = "Fruits";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(406, 110);
            button4.Name = "button4";
            button4.Size = new Size(112, 55);
            button4.TabIndex = 5;
            button4.Text = "Vegetables";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(606, 110);
            button5.Name = "button5";
            button5.Size = new Size(112, 55);
            button5.TabIndex = 6;
            button5.Text = "Meats";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(206, 197);
            button6.Name = "button6";
            button6.Size = new Size(112, 55);
            button6.TabIndex = 7;
            button6.Text = "Cheeses";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(406, 197);
            button7.Name = "button7";
            button7.Size = new Size(112, 55);
            button7.TabIndex = 8;
            button7.Text = "Bread";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(606, 197);
            button8.Name = "button8";
            button8.Size = new Size(112, 55);
            button8.TabIndex = 9;
            button8.Text = "Misc";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(773, 300);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 10;
            button9.Text = "View Cart";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // CatagoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 450);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(searchTxt);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "CatagoriesForm";
            Text = "CatagoriesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox searchTxt;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}