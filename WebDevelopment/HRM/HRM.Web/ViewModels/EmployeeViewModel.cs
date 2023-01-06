using HRM.Web.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.ViewModels;

public class EmployeeViewModel
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

    public int DepartmentId { get; set; }
    public string? DepartmentName { get; set; }
    public int DesignationId { get; set; }
    public string? DesignationTitle { get; set; }
}
