namespace SchoolMvcApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }  = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }= string.Empty;
        public ICollection<Course> Courses { get; set; }

                                         
    }
}
