using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Course 实体类
    /// </summary>
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseContent { get; set; }
        public int ClassHour { get; set; }
        public int  Credit { get; set; }
        public int CategoryId { get; set; }
        public int TeacherId { get; set; }
    }
}
