namespace CourseManageModels
{
    /// <summary>
    /// 课程
    /// </summary>
    [Serializable]
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseContent { get; set; }
        public int ClassHour { get; set; }
        public int Credit { get; set; }
        public int CategoryId { get; set; }
        public int TeacherId { get; set; }
    }
}
