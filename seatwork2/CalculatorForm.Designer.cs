namespace seatwork2
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            textBoxDisplay = new TextBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonDivide = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            buttonMultiply = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonSubtract = new Button();
            button0 = new Button();
            buttonDecimal = new Button();
            buttonEquals = new Button();
            buttonAdd = new Button();
            buttonClear = new Button();
            buttonBackspace = new Button();
            buttonSign = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDisplay.Location = new Point(12, 12);
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.ReadOnly = true;
            textBoxDisplay.Size = new Size(330, 46);
            textBoxDisplay.TabIndex = 0;
            textBoxDisplay.Text = "0";
            textBoxDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(12, 70);
            button7.Name = "button7";
            button7.Size = new Size(75, 50);
            button7.TabIndex = 1;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonNumber_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(97, 70);
            button8.Name = "button8";
            button8.Size = new Size(75, 50);
            button8.TabIndex = 2;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonNumber_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(182, 70);
            button9.Name = "button9";
            button9.Size = new Size(75, 50);
            button9.TabIndex = 3;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonNumber_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDivide.Location = new Point(267, 70);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(75, 50);
            buttonDivide.TabIndex = 4;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonOperation_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 130);
            button4.Name = "button4";
            button4.Size = new Size(75, 50);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonNumber_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(97, 130);
            button5.Name = "button5";
            button5.Size = new Size(75, 50);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonNumber_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(182, 130);
            button6.Name = "button6";
            button6.Size = new Size(75, 50);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonNumber_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMultiply.Location = new Point(267, 130);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(75, 50);
            buttonMultiply.TabIndex = 8;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonOperation_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 190);
            button1.Name = "button1";
            button1.Size = new Size(75, 50);
            button1.TabIndex = 9;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonNumber_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(97, 190);
            button2.Name = "button2";
            button2.Size = new Size(75, 50);
            button2.TabIndex = 10;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonNumber_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(182, 190);
            button3.Name = "button3";
            button3.Size = new Size(75, 50);
            button3.TabIndex = 11;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonNumber_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubtract.Location = new Point(267, 190);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(75, 50);
            buttonSubtract.TabIndex = 12;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += buttonOperation_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button0.Location = new Point(12, 250);
            button0.Name = "button0";
            button0.Size = new Size(75, 50);
            button0.TabIndex = 13;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += buttonNumber_Click;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDecimal.Location = new Point(97, 250);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(75, 50);
            buttonDecimal.TabIndex = 14;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = true;
            buttonDecimal.Click += buttonDecimal_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEquals.Location = new Point(182, 250);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(75, 50);
            buttonEquals.TabIndex = 15;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(267, 250);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 50);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonOperation_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(12, 310);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 50);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonBackspace
            // 
            buttonBackspace.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBackspace.Location = new Point(97, 310);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(75, 50);
            buttonBackspace.TabIndex = 18;
            buttonBackspace.Text = "←";
            buttonBackspace.UseVisualStyleBackColor = true;
            buttonBackspace.Click += buttonBackspace_Click;
            // 
            // buttonSign
            // 
            buttonSign.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSign.Location = new Point(182, 310);
            buttonSign.Name = "buttonSign";
            buttonSign.Size = new Size(75, 50);
            buttonSign.TabIndex = 19;
            buttonSign.Text = "±";
            buttonSign.UseVisualStyleBackColor = true;
            buttonSign.Click += buttonSign_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(267, 310);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 50);
            buttonExit.TabIndex = 20;
            buttonExit.Text = "退出";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 372);
            Controls.Add(buttonExit);
            Controls.Add(buttonSign);
            Controls.Add(buttonBackspace);
            Controls.Add(buttonClear);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEquals);
            Controls.Add(buttonDecimal);
            Controls.Add(button0);
            Controls.Add(buttonSubtract);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonMultiply);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonDivide);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(textBoxDisplay);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "计算器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDisplay;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonDivide;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonMultiply;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonSubtract;
        private Button button0;
        private Button buttonDecimal;
        private Button buttonEquals;
        private Button buttonAdd;
        private Button buttonClear;
        private Button buttonBackspace;
        private Button buttonSign;
        private Button buttonExit;
    }
}
