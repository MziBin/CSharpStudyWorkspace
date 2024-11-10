using CourseManageDAL;
using CourseManageModels;

namespace CourseManageBLL
{
    public class CourseController
    {
        private CourseServer courseService = new CourseServer();

        public int AddCourse(Course course)
        {
            return courseService.AddCourse(course);
        }
    }
}
