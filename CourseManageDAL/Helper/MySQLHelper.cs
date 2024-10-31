using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManageDAL.Helper
{
    public class MySQLHelper
    {
        //读取配置文件中的MySQL连接字符串,方便后面更改数据库,注意connectionStrings的位置
        //private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MySQLDB"].ToString();
        string connectionString = "server=localhost;user id=root;password=922605ai;database=coursemanagedb";

        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int Update(string sql, MySqlParameter[] parameters = null)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(sql, connection);
            //添加参数值
            if (parameters!= null)
            {
                command.Parameters.AddRange(parameters);
            }
            try
            {
                connection.Open();
                int rows = command.ExecuteNonQuery();
                connection.Close();
                return rows;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
