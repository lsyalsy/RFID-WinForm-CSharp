using System;
using System.Drawing;
using System.Windows.Forms;
using CalcLibrary;

namespace seatwork2
{
    public partial class CalculatorForm : Form
    {
        private Calc _calculator;
        private double _result = 0;
        private string _operation = "";
        private bool _isNewOperation = true;

        public CalculatorForm()
        {
            InitializeComponent();
            _calculator = new Calc();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (_isNewOperation)
            {
                textBoxDisplay.Text = button.Text;
                _isNewOperation = false;
            }
            else
            {
                textBoxDisplay.Text += button.Text;
            }
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (double.TryParse(textBoxDisplay.Text, out double value))
            {
                _operation = button.Text;
                _result = value;
                _isNewOperation = true;
            }
            else
            {
                textBoxDisplay.Text = "错误";
                _isNewOperation = true;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxDisplay.Text, out double currentValue))
            {
                textBoxDisplay.Text = "错误";
                _isNewOperation = true;
                return;
            }

            try
            {
                switch (_operation)
                {
                    case "+":
                        _result = _calculator.Add(_result, currentValue);
                        break;
                    case "-":
                        _result = _calculator.Subtract(_result, currentValue);
                        break;
                    case "*":
                        _result = _calculator.Multiply(_result, currentValue);
                        break;
                    case "/":
                        _result = _calculator.Divide(_result, currentValue);
                        break;
                    default:
                        textBoxDisplay.Text = currentValue.ToString();
                        _isNewOperation = true;
                        return;
                }
                textBoxDisplay.Text = _result.ToString();
                _isNewOperation = true;
            }
            catch (DivideByZeroException)
            {
                textBoxDisplay.Text = "错误：除零";
                _isNewOperation = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";
            _result = 0;
            _operation = "";
            _isNewOperation = true;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 1)
                textBoxDisplay.Text = textBoxDisplay.Text.Substring(0, textBoxDisplay.Text.Length - 1);
            else
                textBoxDisplay.Text = "0";
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (!textBoxDisplay.Text.Contains("."))
                textBoxDisplay.Text += ".";
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "0")
            {
                if (textBoxDisplay.Text.StartsWith("-"))
                    textBoxDisplay.Text = textBoxDisplay.Text.Substring(1);
                else
                    textBoxDisplay.Text = "-" + textBoxDisplay.Text;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
