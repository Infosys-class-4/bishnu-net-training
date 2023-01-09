using HRM.Web.Enums;
using Microsoft.SqlServer.Server;
using System.ComponentModel.DataAnnotations;

namespace HRM.ViewModels;

public class EmployeeViewModel
{
    public int Id { get; set; }

    [Display(Name = "First Name")]
    [MinLength(2)]
    public string FirstName { get; set; } = string.Empty;

    [Display(Name = "Last Name"), MinLength(2)]
    public string LastName { get; set; } = string.Empty;

    [Required, Range(1, 3)]
    public Gender Gender { get; set; } = Gender.Male;

    public string? Address { get; set; }

    [Display(Name = "Date Of Birth"), DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "dd-MM-yyyy")]
    public DateTime? Dob { get; set; }
    
    public string? Bio { get; set; } = string.Empty;

    [Display(Name = "Upload Your Avatar")]
    public IFormFile ProfileImage { get; set; }
    public string? ProfileImageName { get; set; }

    public int DepartmentId { get; set; }

    [Display(Name = "Department")]
    public string? DepartmentName { get; set; }

    public int DesignationId { get; set; }
    
    [Display(Name = "Designation")]
    public string? DesignationTitle { get; set; }
}
