using HRM.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Web.Data
{
    public class HRMDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }        
    }
}
