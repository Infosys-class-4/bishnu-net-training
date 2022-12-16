using HRM.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Web.Controllers;
public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        // List of employees
        Employee e1 = new()
        {
            FirstName = "Bishnu",
            LastName = "Rawal",
            Address = "Ktm",
            Gender = 'M',
            Dob = new DateTime(1960, 12, 12),
            Department = "R&D1",
            Designation = "Software Developer"
        };
        Employee e2 = new()
        {
            FirstName = "Krishna",
            LastName = "Rawal",
            Address = "Bhaktapur",
            Gender = 'F',
            Dob = new DateTime(1970, 12, 12),
            Department = "Compliance",
            Designation = "Legal Advisor"
        };

        List<Employee> employees = new() { e1, e2 };

        return View(employees);
    }
}
