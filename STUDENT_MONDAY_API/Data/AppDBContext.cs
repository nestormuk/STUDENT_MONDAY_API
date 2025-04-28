using Microsoft.EntityFrameworkCore;
using STUDENT_MONDAY_API.Models;

namespace STUDENT_MONDAY_API.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        // variable to handle request operations

        public DbSet<Student>  Students { get; set; }


    }


}
