using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class DatabaseBackupRestoreService
    {
        private readonly string _connectionString;

        public DatabaseBackupRestoreService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Sao lưu cơ sở dữ liệu
        public void BackupDatabase(string backupFilePath)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = $"BACKUP DATABASE [QLVLXD] TO DISK = '{backupFilePath}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Khôi phục cơ sở dữ liệu
        public void RestoreDatabase(string backupFilePath)
        {
            var builder = new SqlConnectionStringBuilder(_connectionString)
            {
                InitialCatalog = "master" // Kết nối tới master DB
            };

            string restoreQuery = $@"
        ALTER DATABASE QLVLXD SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
        RESTORE DATABASE QLVLXD FROM DISK = '{backupFilePath}' WITH REPLACE;
        ALTER DATABASE QLVLXD SET MULTI_USER;
    ";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(restoreQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi phục hồi: " + ex.Message);
                }
            }
        }

        // Phương thức thực thi câu lệnh SQL
        private void ExecuteSqlQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
        }
    }
}
