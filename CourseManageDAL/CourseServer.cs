using CourseManageDAL.Helper;
using CourseManageModels;
using MySql.Data.MySqlClient;

namespace CourseManageDAL
{
    public class CourseServer
    {
        private readonly MySQLHelper mysqlHelper = new MySQLHelper();

        //以下方法，存在一个问题：单引号使用起来非常麻烦，同时还有可能有注入式攻击的危险
        //微软针对以上方式，有两个解决方案：第一，使用带参数的SQL语句，第二使用存储过程
        //public int AddCourse(Course course)
        //{
        //    string sql = $"insert into course (CourseName, CourseContent, ClassHour, Credit, CategoryId,  TeacherId)";
        //    sql += $"values ('{course.CourseName}', '{course.CourseContent}', '{course.ClassHour}', '{course.Credit}', '{course.CategoryId}', '{course.TeacherId}')";
        //    return mysqlHelper.Update(sql);
        //}

        public int AddCourse(Course course)
        {
            //定义sql语句,并解析实体数据
            string sql = " insert into Course(CourseName, CourseContent, ClassHour, Credit, CategoryId, TeacherId)";
            sql += " values(@CourseName, @CourseContent, @ClassHour, @Credit, @CategoryId, @TeacherId)";
            //封装SQL语句中的参数
            MySqlParameter[] param = new MySqlParameter[]
                {
                    new MySqlParameter("@CourseName",course.CourseName),
                    new MySqlParameter("@CourseContent",course.CourseContent),
                    new MySqlParameter("@ClassHour",course.ClassHour),
                    new MySqlParameter("@Credit",course.Credit),
                    new MySqlParameter("@CategoryId",course.CategoryId),
                    new MySqlParameter("@TeacherId",course.TeacherId),
                };
            //执行带参数的SQL语句
            return mysqlHelper.Update(sql, param);
        }
    }
}
