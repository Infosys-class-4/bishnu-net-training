using System.ComponentModel.DataAnnotations;
namespace HRM.Models;

public class Employee
{    
    public int Id { get; set; }

    [Display(Name = "First Name")]
    [MinLength(2)]
    public string FirstName { get; set; } = string.Empty;

    [Display(Name = "Last Name")]
    public string LastName { get; set; } = string.Empty;

    public char Gender { get; set; } = 'M';
    public string Address { get; set; } = string.Empty;

    [Display(Name = "Date Of Birth")]
    public DateTime Dob { get; set; }

    public string Designation { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
}
