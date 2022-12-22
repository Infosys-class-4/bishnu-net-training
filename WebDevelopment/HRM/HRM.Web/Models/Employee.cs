namespace HRM.Models;
public class Employee
{    
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public char Gender { get; set; } = 'M';
    public string Address { get; set; } = string.Empty;
    public DateTime Dob { get; set; }
    public string Designation { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
}
