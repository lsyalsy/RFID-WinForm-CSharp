﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿namespace seatwork3
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
            lblTitle = new Label();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblRfidNum = new Label();
            txtRfidNum = new TextBox();
            lblYue = new Label();
            txtYue = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnRefresh = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("微软雅黑", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(320, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(316, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "学生信息管理系统";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblId
            // 
            lblId.Location = new Point(30, 60);
            lblId.Name = "lblId";
            lblId.Size = new Size(50, 20);
            lblId.TabIndex = 1;
            lblId.Text = "学号:";
            // 
            // txtId
            // 
            txtId.Location = new Point(80, 60);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 30);
            txtId.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.Location = new Point(250, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 3;
            lblName.Text = "姓名:";
            // 
            // txtName
            // 
            txtName.Location = new Point(300, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 30);
            txtName.TabIndex = 4;
            // 
            // lblRfidNum
            // 
            lblRfidNum.Location = new Point(470, 60);
            lblRfidNum.Name = "lblRfidNum";
            lblRfidNum.Size = new Size(60, 20);
            lblRfidNum.TabIndex = 5;
            lblRfidNum.Text = "RFID号:";
            // 
            // txtRfidNum
            // 
            txtRfidNum.Location = new Point(530, 60);
            txtRfidNum.Name = "txtRfidNum";
            txtRfidNum.Size = new Size(150, 30);
            txtRfidNum.TabIndex = 6;
            // 
            // lblYue
            // 
            lblYue.Location = new Point(700, 60);
            lblYue.Name = "lblYue";
            lblYue.Size = new Size(50, 20);
            lblYue.TabIndex = 7;
            lblYue.Text = "余额:";
            // 
            // txtYue
            // 
            txtYue.Location = new Point(750, 60);
            txtYue.Name = "txtYue";
            txtYue.Size = new Size(100, 30);
            txtYue.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Location = new Point(30, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "添加";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightBlue;
            btnUpdate.Location = new Point(130, 100);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 30);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "修改";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Location = new Point(230, 100);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 30);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Khaki;
            btnSearch.Location = new Point(330, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 30);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "查询";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += BtnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Location = new Point(430, 100);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(80, 30);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "刷新";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeight = 34;
            dataGridView.Location = new Point(30, 150);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(820, 400);
            dataGridView.TabIndex = 14;
            dataGridView.CellClick += DataGridView_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 650);
            Controls.Add(dataGridView);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtYue);
            Controls.Add(lblYue);
            Controls.Add(txtRfidNum);
            Controls.Add(lblRfidNum);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(lblTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "学生信息管理系统";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRfidNum;
        private System.Windows.Forms.TextBox txtYue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRfidNum;
        private System.Windows.Forms.Label lblYue;
    }
}