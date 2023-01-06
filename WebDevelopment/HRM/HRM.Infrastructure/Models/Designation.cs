using HRM.Web.Enums;

namespace HRM.Models;
public class Designation
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public Role Role { get; set; }

    public List<Employee>? Employees { get; set; }
}
