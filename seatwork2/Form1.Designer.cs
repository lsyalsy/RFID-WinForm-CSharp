namespace seatwork2
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonRegister = new Button();
            labelMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 110);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "用户名：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 174);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "密码：";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(261, 107);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(200, 27);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(261, 171);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(200, 27);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(261, 220);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(94, 29);
            buttonRegister.TabIndex = 4;
            buttonRegister.Text = "注册";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(367, 220);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "登录";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(261, 270);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 20);
            labelMessage.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 404);
            Controls.Add(labelMessage);
            Controls.Add(buttonRegister);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "登录/注册";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonRegister;
        private Label labelMessage;
    }
}
