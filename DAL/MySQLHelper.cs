using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class MySQLHelper
    {
        //读取配置文件中的MySQL连接字符串,方便后面更改数据库,注意connectionStrings的位置,是在主项目中的app.config中
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MySQLDB"].ToString();

        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int Update(string sql)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(sql, connection);
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
