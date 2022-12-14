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

        //Assignment: Add new action here to render list of employee name and his/her phone number
        // Hint: use disctionary data structure to hold all employees info

    }
}
