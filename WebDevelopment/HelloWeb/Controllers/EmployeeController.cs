using HelloWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWeb.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            string[] employeeNames = { "Bishnu Rawal", "Sangyel Tenzing", "Sakshyam Shrestha", "SitaRam Panta" };

            return View(employeeNames);
        }

        // Assignment: Add new action here to render list of employee name and
        // his/her phone number
        // Hint: use dictionary data structure to hold all employees info
        public IActionResult EmployeeContacts()
        {
            List<Employee> employees = new();

            Employee employee1 = new();
            employee1.Name = "Sitaram Panta";
            employee1.Phone = 98492334434;
            employee1.Address = "Ktm";

            Employee employee2 = new();
            employee2.Name = "Sangyel Tenjing";
            employee2.Phone = 98412009431;
            employee2.Address = "Ktm";

            employees.Add(employee1);
            employees.Add(employee2);

            //Dictionary<long, string> employeeDetails = new()
            //{
            //    [98492334434] = "Sitaram Panta",
            //    [98412009431] = "Sangyel Tenjing",
            //    [98012009531] = "Prahlad Shakhya",
            //    [98021200943] = "Sakshyam Shrestha",
            //    [73942374234] = "Bishnu Rawal"
            //};

            return View(employees);
        }
    }
}
