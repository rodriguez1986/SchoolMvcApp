using Microsoft.EntityFrameworkCore;
using SchoolMvcApp.Models;

namespace SchoolMvcApp.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
