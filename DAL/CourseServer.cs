using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CourseServer
    {
        private MySQLHelper mysqlHelper = new MySQLHelper();

        public int AddCourse(Course course)
        {
            string sql = $"insert into course (CourseName, CourseContent, ClassHour, Credit, CategoryId,  TeacherId)";
            sql += $"values ('{course.CourseName}', '{course.CourseContent}', '{course.ClassHour}', '{course.Credit}', '{course.CategoryId}', '{course.TeacherId}')";
            return mysqlHelper.Update(sql);
        }
    }
}
