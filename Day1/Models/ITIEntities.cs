
using Microsoft.EntityFrameworkCore;

namespace Day1.Models
{
    public class ITIEntities:DbContext
    {
        public ITIEntities():base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=ITIEnterPrice; Trusted_Connection=True; encrypt=False");
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
