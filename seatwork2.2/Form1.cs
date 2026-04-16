using System;
using System.Drawing;
using System.Windows.Forms;
using MouseHookLib;

namespace seatwork2._2
{
    public partial class Form1 : Form
    {
        private MouseHook? _mouseHook;
        private bool _isMonitoring = false;

        public Form1()
        {
            InitializeComponent();
            _mouseHook = new MouseHook();
            _mouseHook.MouseMove += MouseHook_MouseMove;
        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            if (_isMonitoring)
            {
                StopMonitoring();
            }
            else
            {
                StartMonitoring();
            }
        }

        private void StartMonitoring()
        {
            if (_mouseHook != null)
            {
                _mouseHook.Start();
                _isMonitoring = true;
                buttonToggle.Text = "停止监视";
                buttonToggle.BackColor = Color.LightCoral;
                
                Point currentPosition = _mouseHook.GetCursorPosition();
                UpdatePositionDisplay(currentPosition.X, currentPosition.Y);
            }
        }

        private void StopMonitoring()
        {
            if (_mouseHook != null)
            {
                _mouseHook.Stop();
                _isMonitoring = false;
                buttonToggle.Text = "开始监视";
                buttonToggle.BackColor = SystemColors.Control;
            }
        }

        private void MouseHook_MouseMove(object? sender, MouseHookLib.MouseEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdatePositionDisplay(e.X, e.Y)));
            }
            else
            {
                UpdatePositionDisplay(e.X, e.Y);
            }
        }

        private void UpdatePositionDisplay(int x, int y)
        {
            labelXValue.Text = x.ToString();
            labelYValue.Text = y.ToString();
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (_mouseHook != null)
            {
                _mouseHook.Stop();
                _mouseHook.Dispose();
            }
        }
    }
}
