using HRM.Models;
using HRM.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Web.Data
{
    public class HRMDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=HRM;Integrated Security=true");
        }
    }
}
