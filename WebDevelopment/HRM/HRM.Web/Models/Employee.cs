using HRM.Web.Enums;
using HRM.Web.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Models;

public class Employee
{    
    public int Id { get; set; }

    [Display(Name = "First Name")]
    [MinLength(2)]
    public string FirstName { get; set; } = string.Empty;

    [Display(Name = "Last Name")]
    public string LastName { get; set; } = string.Empty;

    public Gender Gender { get; set; } = Gender.Male;
    public string? Address { get; set; }

    [Display(Name = "Date Of Birth")]
    public DateTime? Dob { get; set; }
    public string? Bio { get; set; } = string.Empty;

    [NotMapped]
    public IFormFile ProfileImage { get; set; }

    public string? ProfileImageName { get; set; }

    public Department? Department { get; set; }
    public int DepartmentId { get; set; }

    public Designation? Designation { get; set; }
    public int DesignationId { get; set; }
}
