using System;
using System.Drawing;
using System.Windows.Forms;

namespace seatwork2
{
    public partial class Form1 : Form
    {
        private UserManager _userManager;

        public Form1()
        {
            InitializeComponent();
            _userManager = new UserManager();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                labelMessage.Text = "用户名和密码不能为空";
                labelMessage.ForeColor = Color.Red;
                return;
            }

            if (username.Length < 3 || username.Length > 20)
            {
                labelMessage.Text = "用户名长度应为3-20个字符";
                labelMessage.ForeColor = Color.Red;
                return;
            }

            if (password.Length < 6 || password.Length > 20)
            {
                labelMessage.Text = "密码长度应为6-20个字符";
                labelMessage.ForeColor = Color.Red;
                return;
            }

            if (username.Contains(",") || password.Contains(","))
            {
                labelMessage.Text = "用户名和密码不能包含逗号";
                labelMessage.ForeColor = Color.Red;
                return;
            }

            bool success = _userManager.Register(username, password);
            if (success)
            {
                labelMessage.Text = "注册成功，请登录";
                labelMessage.ForeColor = Color.Green;
                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }
            else
            {
                labelMessage.Text = "用户名已存在";
                labelMessage.ForeColor = Color.Red;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                labelMessage.Text = "用户名和密码不能为空";
                labelMessage.ForeColor = Color.Red;
                return;
            }

            bool success = _userManager.Login(username, password);
            if (success)
            {
                labelMessage.Text = "登录成功";
                labelMessage.ForeColor = Color.Green;
                
                CalculatorForm calculatorForm = new CalculatorForm();
                calculatorForm.FormClosed += (s, args) => Application.Exit();
                calculatorForm.Show();
                this.Hide();
            }
            else
            {
                labelMessage.Text = "用户名或密码错误";
                labelMessage.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
