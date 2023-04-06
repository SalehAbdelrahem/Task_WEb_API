using Domain;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace MyDBContext
{
    public class TaskDbContext:DbContext
    {

        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}