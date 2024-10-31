using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataBaseSQLConnectDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SQLServer的连接
            //SQLServerConnect.ExecuteSQL();
            //SQLServerConnect.ExecuteSingleResultSQL();

            //MySQL的连接
            //MYSQLConnect.ExecuteMySQL();
            //MYSQLConnect.ExcecuteReader();
            string sql = $"insert into Course(CourseName, CourseContent, ClassHour, Credit, CategoryId, TeacherId) values('.Net/C#上位机开发VIP课程09', 'C#基础/OOP/SQL/WinFORM/ASP.NET/WPF/WCF', '500', '10', '11', '1001')";
            //MYSQLConnect.ExcecuteUpdate(sql);
            //Console.WriteLine(MYSQLConnect.ExcecuteSigleSelect("select count(*) from course") );
            sql = "select * from course";
            MySqlDataReader reader = MYSQLConnect.ExcecuteReader(sql);
            while (reader.Read())
            {
                Console.WriteLine($"课程名称：{reader[0]}\t课程内容：{reader[1]}\t课时：{reader[2]}");
            }
            //会话关闭，释放资源，数据库连接也会关闭
            reader.Close();
        }
    }
}
