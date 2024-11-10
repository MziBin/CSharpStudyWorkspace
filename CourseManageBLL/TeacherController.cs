using CourseManageDAL;
using CourseManageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManageBLL
{
    public class TeacherController
    {
        private TeacherServer teacherServer = new TeacherServer();

        public Teacher TeacherLogin(Teacher teacher)
        {
            return teacherServer.TeacherLogin(teacher);
        }

    }
}
