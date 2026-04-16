namespace seatwork2._2
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
            labelTitle = new Label();
            labelX = new Label();
            labelY = new Label();
            labelXValue = new Label();
            labelYValue = new Label();
            buttonToggle = new Button();
            groupBoxInfo = new GroupBox();
            groupBoxInfo.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(244, 36);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "全局鼠标位置监视器";
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(labelYValue);
            groupBoxInfo.Controls.Add(labelY);
            groupBoxInfo.Controls.Add(labelXValue);
            groupBoxInfo.Controls.Add(labelX);
            groupBoxInfo.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxInfo.Location = new Point(12, 60);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(360, 120);
            groupBoxInfo.TabIndex = 1;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "鼠标坐标";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelX.Location = new Point(20, 35);
            labelX.Name = "labelX";
            labelX.Size = new Size(35, 31);
            labelX.TabIndex = 0;
            labelX.Text = "X:";
            // 
            // labelXValue
            // 
            labelXValue.AutoSize = true;
            labelXValue.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelXValue.Location = new Point(61, 35);
            labelXValue.Name = "labelXValue";
            labelXValue.Size = new Size(24, 31);
            labelXValue.TabIndex = 1;
            labelXValue.Text = "0";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelY.Location = new Point(20, 75);
            labelY.Name = "labelY";
            labelY.Size = new Size(35, 31);
            labelY.TabIndex = 2;
            labelY.Text = "Y:";
            // 
            // labelYValue
            // 
            labelYValue.AutoSize = true;
            labelYValue.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelYValue.Location = new Point(61, 75);
            labelYValue.Name = "labelYValue";
            labelYValue.Size = new Size(24, 31);
            labelYValue.TabIndex = 3;
            labelYValue.Text = "0";
            // 
            // buttonToggle
            // 
            buttonToggle.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonToggle.Location = new Point(12, 200);
            buttonToggle.Name = "buttonToggle";
            buttonToggle.Size = new Size(360, 50);
            buttonToggle.TabIndex = 2;
            buttonToggle.Text = "开始监视";
            buttonToggle.UseVisualStyleBackColor = true;
            buttonToggle.Click += buttonToggle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 271);
            Controls.Add(buttonToggle);
            Controls.Add(groupBoxInfo);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "鼠标位置监视器";
            FormClosing += Form1_FormClosing;
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelX;
        private Label labelY;
        private Label labelXValue;
        private Label labelYValue;
        private Button buttonToggle;
        private GroupBox groupBoxInfo;
    }
}
