using HRM.Models;
using HRM.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HRM.Web.Controllers;
public class EmployeeController : Controller
{
    HRMDbContext db = new();
    public IActionResult Index()
    {
        if (db.Employees == null)
            return Problem("Employees dbset don't exist");

        var employees = db.Employees.Include(e => e.Department).Include(e => e.Designation).ToList();

        return View(employees);
    }

    public async Task<IActionResult> Add()
    {
        var departments = await db.Departments.ToListAsync();
        var selectListItems = departments.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
        ViewData["DepartmentList"] = selectListItems;

        var designations = await db.Designations
            .Select(d => new SelectListItem { Text = d.Title, Value = d.Id.ToString() }).ToListAsync();
        ViewData["DesignationList"] = designations;

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(Employee employee)
    {
        if (ModelState.IsValid)
        {
            var profileRelativePath = SaveProfileImage(employee.ProfileImage);
            // Add employee record to db
            employee.ProfileImageName = profileRelativePath;

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
        if (ModelState.IsValid)
        {
            var relativePath = SaveProfileImage(employee.ProfileImage);
            employee.ProfileImageName = relativePath;

            db.Employees.Update(employee);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        return View(employee);
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

    private string SaveProfileImage(IFormFile file)
    {
        // Save image to "profiles" folder        
        var fileName = file.FileName;  //my.photo.jpg
        var indexOfDot = fileName.LastIndexOf(".");
        var fileExtenstion = fileName.Substring(indexOfDot);
        var profileRelativePath = $"images/profiles/{Guid.NewGuid()}{fileExtenstion}";
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", profileRelativePath);

        using var stream = System.IO.File.Create(filePath);
        file.CopyTo(stream);

        return profileRelativePath;
    }
}
