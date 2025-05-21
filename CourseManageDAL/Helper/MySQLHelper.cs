using CourseManageModels;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CourseManageDAL.Helper
{
    public class MySQLHelper
    {
        //配置文件路劲
        static private string ConfigPath = "E:\\ZeXi\\CSharpCode\\CSharpStudyWorkspace\\Config\\MYSQLConfig.ini";

        //读取配置文件中的MySQL连接字符串,方便后面更改数据库,注意connectionStrings的位置.net core中没有app.config配置文件
        //private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MySQLDB"].ToString();
        //string connectionString = "server=localhost;user id=root;password=922605ai;database=coursemanagedb";
        //string connectionString = "Server=localhost;Database=coursemanagedb;User=root;Password=922605ai;Pooling=true;Min Pool Size=5;Max Pool Size=20;Connection Lifetime=300";
        //Server=localhost;Database=coursemanagedb;User=coursemanagedb;Password=root;Pooling=True;Min Pool Size=0;Max Pool Size=0;Connection Lifetime = 0
        static string connectionString = ReaderMYSQLConfig(ConfigPath).GetConnectionString();


        /// <summary>
        /// 返回读取的配置文件
        /// </summary>
        /// <param name="configPath"></param>
        /// <returns></returns>
        public static MYSQLConfig ReaderMYSQLConfig(string configPath)
        {
            //MYSQLConfig mYSQLConfig = new MYSQLConfig()
            //{
            //    Server = IniConfigHelper.ReadIniData("MYSQL参数", "Server", "", ConfigPath),
            //    Database = IniConfigHelper.ReadIniData("MYSQL参数", "Database", "", ConfigPath),
            //    User = IniConfigHelper.ReadIniData("MYSQL参数", "User", "", ConfigPath),
            //    Password = IniConfigHelper.ReadIniData("MYSQL参数", "Password", "", ConfigPath),
            //    Pooling = Convert.ToBoolean(IniConfigHelper.ReadIniData("MYSQL参数", "Pooling", "", ConfigPath)),
            //    MinPoolSize = Convert.ToInt32(IniConfigHelper.ReadIniData("MYSQL参数", "MinPoolSize", "", ConfigPath)),
            //    MaxPoolSize = Convert.ToInt32(IniConfigHelper.ReadIniData("MYSQL参数", "MaxPoolSize", "", ConfigPath)),
            //    ConnectionLifetime = Convert.ToInt32(IniConfigHelper.ReadIniData("MYSQL参数", "ConnectionLifetime", "", ConfigPath))
            //};

            IConfigurationRoot configuration = new ConfigurationBuilder()
           .AddIniFile(ConfigPath)
           .Build();

            string username = configuration["Settings:Username"];
            string password = configuration["Settings:Password"];

            MYSQLConfig mYSQLConfig = new MYSQLConfig();

            mYSQLConfig.Server = configuration["MYSQL参数:Server"];
            mYSQLConfig.Database = configuration["MYSQL参数:Database"];
            mYSQLConfig.User = configuration["MYSQL参数:User"];
            mYSQLConfig.Password = configuration["MYSQL参数:Password"];
            mYSQLConfig.Pooling = Convert.ToBoolean(configuration["MYSQL参数:Pooling"] );
            mYSQLConfig.MinPoolSize = Convert.ToInt32(configuration["MYSQL参数:Min Pool Size"]);
            mYSQLConfig.MaxPoolSize = Convert.ToInt32(configuration["MYSQL参数:Max Pool Size"]);
            mYSQLConfig.ConnectionLifetime = Convert.ToInt32(configuration["MYSQL参数:Connection Lifetime"]);

            return mYSQLConfig;
        }

        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="parameters">默认赋值了，可传可不传</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int Update(string sql, MySqlParameter[] parameters = null)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(sql, connection);
            //添加参数值
            if (parameters != null)
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

        /// <summary>
        /// 执行一个结果集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public MySqlDataReader GetReader(string sql)
        {
            //创建连接数据库的对象，但是还没启动，要open
            MySqlConnection connection = new MySqlConnection(connectionString);
            //创建执行SQL的对象
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                //连接数据库
                connection.Open();
                //执行SQL，是一个参数，它告诉数据库执行命令后，当读取器关闭时，关联的数据库连接也自动关闭。这有助于确保数据库连接得到正确的管理，避免资源泄漏。
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //可以在这个地方捕获ex对象相关信息，然后保存到日志文件中...
                throw new Exception("执行 public static SqlDataReader GetReader(string sql)发生异常：" + ex.Message);
            }
        }

    }
}
