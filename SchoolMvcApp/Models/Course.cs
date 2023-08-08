namespace SchoolMvcApp.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string CourseDescription { get; set; } = string.Empty;   
        public ICollection<Student> Students { get; set; }

    }
}
