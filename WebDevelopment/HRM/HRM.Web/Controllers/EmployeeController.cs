using HRM.Models;
using HRM.Web.Data;
using HRM.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace HRM.Web.Controllers;
public class EmployeeController : Controller
{
    HRMDbContext db = new();
    public IActionResult Index()
    {
        if (db.Employees == null)
            return Problem("Employees dbset don't exist");

        var employees = db.Employees.ToList();

        return View(employees);
    }

    public async Task<IActionResult> Add()
    {
        var departments = await db.Departments.ToListAsync();
        var selectListItems = departments.Select(x => new SelectListItem { Text = x.Name, Value = x.Name });
        ViewData["DepartmentList"] = selectListItems;

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(Employee employee)
    {
        if (ModelState.IsValid)
        {
            // Save image to "profiles" folder
            var file = employee.ProfileImage;
            var fileName = file.FileName;  //my.photo.jpg
            var indexOfDot = fileName.LastIndexOf(".");
            var fileExtenstion = fileName.Substring(indexOfDot);
            var filePath = $"~/images/profiles/{Guid.NewGuid()}{fileExtenstion}";
            
            using var stream = System.IO.File.Create(filePath);            
            file.CopyTo(stream);

            // Add employee record to db
            employee.ProfileImageName = filePath;

            await db.Employees.AddAsync(employee);
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        return View(employee);
    }

    public IActionResult Edit(int? id)
    {
        if (id == null)
            return NotFound();

        var employee = db.Find<Employee>(id);
        if (employee is null)
            return NotFound();

        return View(employee);
    }

    [HttpPost]
    public IActionResult Edit(Employee employee)
    {
        db.Employees.Update(employee);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var employee = db.Find<Employee>(id);
        return View(employee);
    }

    [HttpPost]
    public async Task<IActionResult> Delete(Employee employee)
    {
        db.Employees.Remove(employee);
        await db.SaveChangesAsync();

        return RedirectToAction("Index");
    }
}
