using System.Data;

namespace seatwork3
{
    public partial class Form1 : Form
    {
        private DatabaseManager dbManager;

        public Form1()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            LoadAllStudents();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            int id = int.Parse(txtId.Text.Trim());
            string name = txtName.Text.Trim();
            int rfidNum = int.Parse(txtRfidNum.Text.Trim());
            int yue = int.Parse(txtYue.Text.Trim());

            if (dbManager.AddStudent(id, name, rfidNum, yue))
            {
                MessageBox.Show("学生信息添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadAllStudents();
            }
            else
            {
                MessageBox.Show("添加失败，请检查输入或学号是否已存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            int id = int.Parse(txtId.Text.Trim());
            string name = txtName.Text.Trim();
            int rfidNum = int.Parse(txtRfidNum.Text.Trim());
            int yue = int.Parse(txtYue.Text.Trim());

            if (dbManager.UpdateStudent(id, name, rfidNum, yue))
            {
                MessageBox.Show("学生信息更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadAllStudents();
            }
            else
            {
                MessageBox.Show("更新失败，可能该学号的学生不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                MessageBox.Show("请输入要删除的学生学号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return;
            }

            int id = int.Parse(txtId.Text.Trim());

            DialogResult result = MessageBox.Show($"确定要删除学号为 {id} 的学生信息吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dbManager.DeleteStudent(id))
                {
                    MessageBox.Show("学生信息删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                    LoadAllStudents();
                }
                else
                {
                    MessageBox.Show("删除失败，可能该学号的学生不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                MessageBox.Show("请输入要查询的学生学号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return;
            }

            int id = int.Parse(txtId.Text.Trim());
            DataTable dt = dbManager.GetStudentById(id);

            if (dt.Rows.Count > 0) 
            {
                dataGridView.DataSource = dt;
                MessageBox.Show($"找到学号为 {id} 的学生信息！", "查询结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"未找到学号为 {id} 的学生信息！", "查询结果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridView.DataSource = null;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllStudents();
            ClearInputs();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                txtId.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["NAME"].Value.ToString();
                txtRfidNum.Text = row.Cells["RFIDNUM"].Value.ToString();
                txtYue.Text = row.Cells["YUE"].Value.ToString();
            }
        }

        private void LoadAllStudents()
        {
            DataTable dt = dbManager.GetAllStudents();
            dataGridView.DataSource = dt;
        }

        private void ClearInputs()
        {
            txtId.Clear();
            txtName.Clear();
            txtRfidNum.Clear();
            txtYue.Clear();
            txtId.Focus();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                MessageBox.Show("请输入学号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("请输入姓名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtRfidNum.Text.Trim()))
            {
                MessageBox.Show("请输入RFID号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRfidNum.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtYue.Text.Trim()))
            {
                MessageBox.Show("请输入余额！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYue.Focus();
                return false;
            }

            // 验证输入的数据类型
            if (!int.TryParse(txtId.Text.Trim(), out _))
            {
                MessageBox.Show("学号必须是整数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return false;
            }

            if (!int.TryParse(txtRfidNum.Text.Trim(), out _))
            {
                MessageBox.Show("RFID号必须是整数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRfidNum.Focus();
                return false;
            }

            if (!int.TryParse(txtYue.Text.Trim(), out _))
            {
                MessageBox.Show("余额必须是整数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYue.Focus();
                return false;
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
