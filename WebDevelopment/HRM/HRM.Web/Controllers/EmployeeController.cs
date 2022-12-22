using HRM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace HRM.Web.Controllers;
public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        var employees = FetchEmployees();
        
        return View(employees);
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Employee employee)
    {
        // Do something with employee
        return RedirectToAction("Index");
    }

    List<Employee> FetchEmployees()
    {
        string connectionString =
            @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=HRM_Test;Integrated Security=true";

        string query = "select * from employee";
        List<Employee> employees = new();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var employee = new Employee();
                    employee.FirstName = reader.GetString(1);
                    employee.LastName = reader.GetString(2);
                    employee.Address = reader.GetString(3);
                    employee.Gender = char.Parse(reader.GetString(4));
                    employee.Dob = reader.GetDateTime(5);

                    employees.Add(employee);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        return employees;
    }
}
