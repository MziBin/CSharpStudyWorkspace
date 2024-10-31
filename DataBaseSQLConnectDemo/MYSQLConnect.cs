using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace DataBaseSQLConnectDemo
{
    public class MYSQLConnect
    {
        //读取配置文件中的MySQL连接字符串,方便后面更改数据库,注意connectionStrings的位置
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MySQLDB"].ToString();

        //MYSQL的简单查询
        public static void ExecuteMySQL()
        {
            //1.连接数据库
            string connectionString = "server=localhost;user id=root;password=922605ai;database=coursemanagedb";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                //2.创建command对象
                string sql = "SELECT COUNT(*) as 课程总数 FROM Course";
                MySqlCommand command = new MySqlCommand(sql, connection);
                //注意，前面的都没有和数据库打交道，只是创建了命令对象，还没有执行命令，只有执行命令后才会和数据库打交道
                //3.打开连接
                connection.Open();
                //4.执行命令并返回结果
                object result = command.ExecuteScalar();
                Console.WriteLine("课程总数：" + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //5.关闭连接
                connection.Close();
            }
        }

        public static void ExcecuteReader()
        {
            //1.连接数据库
            string connectionString = "server=localhost;user id=root;password=922605ai;database=coursemanagedb";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                //2.创建command对象
                string sql = "SELECT CourseName,CourseContent,ClassHour FROM Course WHERE CourseId<1020";
                MySqlCommand command = new MySqlCommand(sql, connection);
                //注意，前面的都没有和数据库打交道，只是创建了命令对象，还没有执行命令，只有执行命令后才会和数据库打交道
                //3.打开连接
                connection.Open();
                //4.执行命令并返回结果
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //下面两种方式都可以获取数据
                    Console.WriteLine($"课程名称：{reader["CourseName"]}\t课程内容：{reader["CourseContent"]}\t课时：{reader["ClassHour"]}");
                    Console.WriteLine($"课程名称：{reader[0]}\t课程内容：{reader[1]}\t课时：{reader[2]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //5.关闭连接
                connection.Close();
            }
        }

        //MYSQL的插入、更新、删除操作封装
        public static int ExcecuteUpdate(string sql)
        {
            //1.连接数据库
            MySqlConnection connection = new MySqlConnection(connectionString);
            //2.创建command对象
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                //3.打开连接
                connection.Open();
                //4.执行命令并返回结果,但是在返回前，还是会执行finally
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //不写throw，会出错，没有返回语句return
                throw new Exception("执行ExcecuteUpdate语句时出错：" + ex.Message);
            }
            finally
            {
                //5.关闭连接
                connection.Close();
            }
        }

        //MYSQL查询一个值
        public static Object ExcecuteSigleSelect(string sql)
        {
            //1.连接数据库
            MySqlConnection connection = new MySqlConnection(connectionString);
            //2.创建command对象
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                //3.打开连接
                connection.Open();
                //4.执行命令并返回结果,但是在返回前，还是会执行finally
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //不写throw，会出错，没有返回语句return
                throw new Exception("执行ExcecuteUpdate语句时出错：" + ex.Message);
            }
            finally
            {
                //5.关闭连接
                connection.Close();
            }
        }

        //MYSQL查询一个值
        public static MySqlDataReader ExcecuteReader(string sql)
        {
            //1.连接数据库
            MySqlConnection connection = new MySqlConnection(connectionString);
            //2.创建command对象
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                //3.打开连接
                connection.Open();
                //4.执行命令并返回结果,并且在返回前，会自动关闭连接，不需要手动关闭
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //不写throw，会出错，没有返回语句return
                throw new Exception("执行ExcecuteUpdate语句时出错：" + ex.Message);
            }
            //finally
            //{
            //    //5.关闭连接
            //    connection.Close();
            //}
        }
    }
}
