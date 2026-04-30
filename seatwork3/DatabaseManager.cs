using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace seatwork3
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager()
        {
            // 使用当前目录下的数据库文件
            string dbPath = Path.Combine(Application.StartupPath, "student.db");
            connectionString = $"Data Source={dbPath};Version=3;";
            
            // 创建数据库和表
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                // 创建学生表
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS STUDENT (
                        ID INTEGER PRIMARY KEY NOT NULL,
                        NAME TEXT NOT NULL,
                        RFIDNUM INTEGER NOT NULL,
                        YUE INTEGER NOT NULL
                    )";
                
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // 添加学生
        public bool AddStudent(int id, string name, int rfidNum, int yue)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    
                    string insertQuery = "INSERT INTO STUDENT (ID, NAME, RFIDNUM, YUE) VALUES (@id, @name, @rfidNum, @yue)";
                    
                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@rfidNum", rfidNum);
                        command.Parameters.AddWithValue("@yue", yue);
                        
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加学生时出错: {ex.Message}");
                return false;
            }
        }

        // 查询所有学生
        public DataTable GetAllStudents()
        {
            var dataTable = new DataTable();
            
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    
                    string selectQuery = "SELECT ID, NAME, RFIDNUM, YUE FROM STUDENT ORDER BY ID";
                    
                    using (var adapter = new SQLiteDataAdapter(selectQuery, connection))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查询学生数据时出错: {ex.Message}");
            }
            
            return dataTable;
        }

        // 根据ID查询学生
        public DataTable GetStudentById(int id)
        {
            var dataTable = new DataTable();
            
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    
                    string selectQuery = "SELECT ID, NAME, RFIDNUM, YUE FROM STUDENT WHERE ID = @id";
                    
                    using (var command = new SQLiteCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查询学生数据时出错: {ex.Message}");
            }
            
            return dataTable;
        }

        // 更新学生信息
        public bool UpdateStudent(int id, string name, int rfidNum, int yue)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    
                    string updateQuery = "UPDATE STUDENT SET NAME = @name, RFIDNUM = @rfidNum, YUE = @yue WHERE ID = @id";
                    
                    using (var command = new SQLiteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@rfidNum", rfidNum);
                        command.Parameters.AddWithValue("@yue", yue);
                        
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新学生信息时出错: {ex.Message}");
                return false;
            }
        }

        // 删除学生
        public bool DeleteStudent(int id)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    
                    string deleteQuery = "DELETE FROM STUDENT WHERE ID = @id";
                    
                    using (var command = new SQLiteCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除学生信息时出错: {ex.Message}");
                return false;
            }
        }

        // 检查学号是否存在
        public bool IsStudentIdExists(int id)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    
                    string query = "SELECT COUNT(*) FROM STUDENT WHERE ID = @id";
                    
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"检查学号时出错: {ex.Message}");
                return false;
            }
        }

        // 修改学号（如果新学号不存在）
        public bool UpdateStudentId(int oldId, int newId)
        {
            try
            {
                // 检查新学号是否已存在
                if (IsStudentIdExists(newId))
                {
                    MessageBox.Show($"学号 {newId} 已存在，无法修改！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    
                    // 使用事务确保数据一致性
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // 先插入新记录
                            string insertQuery = @"
                                INSERT INTO STUDENT (ID, NAME, RFIDNUM, YUE) 
                                SELECT @newId, NAME, RFIDNUM, YUE FROM STUDENT WHERE ID = @oldId";
                            
                            using (var insertCommand = new SQLiteCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@newId", newId);
                                insertCommand.Parameters.AddWithValue("@oldId", oldId);
                                insertCommand.ExecuteNonQuery();
                            }

                            // 删除旧记录
                            string deleteQuery = "DELETE FROM STUDENT WHERE ID = @oldId";
                            
                            using (var deleteCommand = new SQLiteCommand(deleteQuery, connection))
                            {
                                deleteCommand.Parameters.AddWithValue("@oldId", oldId);
                                deleteCommand.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改学号时出错: {ex.Message}");
                return false;
            }
        }
    }
}