using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManageModels
{
    /// <summary>
    /// 讲师
    /// </summary>
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string LoginAccount { get; set; }
        public string LoginPWD { get; set; }
        public string TeacherName { get; set; }
        public string PhoneNumber { get; set; }
        public string NowAddress { get; set; }
    }
}
