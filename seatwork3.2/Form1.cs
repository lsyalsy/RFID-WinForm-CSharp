using System.Data;
using System.Data.SQLite;

namespace seatwork3._2
{
    public partial class Form1 : Form
    {
        private SQLiteConnection? connection;
        private string connectionString = @"Data Source=C:\Users\16677\Desktop\study\RFIDC#\seatwork3.2\bin\Debug\class2402.sql;Version=3;";

        public Form1()
        {
            InitializeComponent();
            this.button1.Click += Button1_Click;
            this.button2.Click += Button2_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SQLiteConnection(connectionString);
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    textBox1.Text = "连接成功！";
                }
                else
                {
                    textBox1.Text = "连接失败！";
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = "连接失败：" + ex.Message;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection == null || connection.State != ConnectionState.Open)
                {
                    textBox1.Text = "请先连接数据库！";
                    return;
                }

              
                string selectAllQuery = "SELECT * FROM calss2402 ORDER BY CASE WHEN NAME LIKE '%罗舜游%' THEN 0 ELSE 1 END, Id;";
                using (var cmd = new SQLiteCommand(selectAllQuery, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        var result = new System.Text.StringBuilder();
                        
                        // 添加表头
                        result.AppendLine("数据库表: calss2402");
                        result.AppendLine("=========================");
                        
                        // 动态获取列名
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            result.Append(reader.GetName(i).PadRight(12));
                        }
                        result.AppendLine();
                        result.AppendLine("-------------------------");
                        
                        // 显示数据
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                result.Append(reader[i]?.ToString().PadRight(12));
                            }
                            result.AppendLine();
                        }
                        
                        textBox1.Text = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = "查询失败：" + ex.Message;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            connection?.Close();
            connection?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
