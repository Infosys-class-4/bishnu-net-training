using HRM.Models;
using HRM.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly HRMDbContext dbContext;

        public EmployeesController(HRMDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<List<Employee>> Get()
        {
            var employees = await dbContext.Employees.ToListAsync();
            return employees;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> Get(int id)
        {
            var employee = await dbContext.Employees.FindAsync(id);
            if (employee is null)
                return NotFound();

            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Employee employee)
        {
            await dbContext.Employees.AddAsync(employee);
            await dbContext.SaveChangesAsync();
            return CreatedAtAction("Get", employee.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Employee employee)
        {
            dbContext.Employees.Update(employee);
            await dbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var employee = dbContext.Employees.Find(id);
            dbContext.Employees.Remove(employee);
            await dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
