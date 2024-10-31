using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataBaseSQLConnectDemo
{
    public class SQLServerConnect
    {
        public static void ExecuteSQL()
        {
            // SQL Server connection code here
            //string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
            string connectionString = "Server=.,13834;DataBase=CourseManageDB;Uid=sa;Pwd=922605ai";
            // Create a connection object
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            // Open the connection
            connection.Open();
            // Execute the SQL query
            string sql = "SELECT @@VERSION";
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(sql, connection);
            System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader();
            // Read the result
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
            }
            // Close the connection
            connection.Close();
        }

        public static void ExecuteSingleResultSQL()
        {
            //1.连接数据库
            string connectionString = "Server=.,13834;DataBase=CourseManageDB;Uid=sa;Pwd=922605ai";
            SqlConnection connection = new SqlConnection(connectionString);
            //定义SQL语句
            string sql = "SELECT COUNT(*) as 课程总数 FROM Course";
            //2.创建SqlCommand对象，为什么不一创建就执行能，这样Command对象可以复用，也可以在后面用的时候在调。
            SqlCommand command = new SqlCommand(sql, connection);
            //3.打开数据库连接
            connection.Open();
            //4.通过Command对象执行SQL语句
            object result = command.ExecuteScalar();
            Console.WriteLine("课程总数：" + result);
            //5.关闭数据库连接
            connection.Close();
        }
    }
}
