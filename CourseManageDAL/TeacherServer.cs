using CourseManageDAL.Helper;
using CourseManageModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManageDAL
{
    public class TeacherServer
    {
        private readonly MySQLHelper mysqlHelper = new MySQLHelper();

        /// <summary>
        /// 讲师登录
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public Teacher TeacherLogin(Teacher teacher)
        {
            //【1】封装SQL语句
            string sql = $"select TeacherName,TeacherId from Teacher where loginAccount='{teacher.LoginAccount}' and LoginPwd='{teacher.LoginPWD}'";

            //【2】提交查询
            MySqlDataReader reader = mysqlHelper.GetReader(sql);

            //【3】判断登录是否正确，如果正确我们就封装ID和Name
            if (reader.Read())
            {
                teacher.TeacherId = (int)reader["TeacherId"];
                teacher.TeacherName = reader["TeacherName"].ToString();
            }
            else
            {
                teacher = null;//表示当前账号或密码不正确
            }
            //关闭资源
            reader.Close();
            return teacher;
        }

    }
}
