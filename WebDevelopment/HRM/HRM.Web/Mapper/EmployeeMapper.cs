using HRM.Models;
using HRM.ViewModels;

namespace HRM.Web.Mapper;
public static class EmployeeMapper
{
    public static EmployeeViewModel ToViewModel(this Employee employee) =>
        new()
        {
            Id = employee.Id,
            Address = employee.Address,
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            Gender = employee.Gender,
            Dob = employee.Dob,
            Bio = employee.Bio,
            ProfileImageName = employee.ProfileImageName,
            DepartmentName = employee.Department?.Name ?? "N/A",
            DesignationTitle = employee.Designation?.Title ?? "N/A"
        };

    public static List<EmployeeViewModel> ToViewModel(this List<Employee> employees) => 
        employees.Select(x => x.ToViewModel()).ToList();

    public static Employee ToModel(this EmployeeViewModel employeeViewModel) =>
        new()
        {
            Id = employeeViewModel.Id,
            Address = employeeViewModel.Address,
            FirstName = employeeViewModel.FirstName,
            LastName = employeeViewModel.LastName,
            Gender = employeeViewModel.Gender,
            Dob = employeeViewModel.Dob,
            Bio = employeeViewModel.Bio,
            ProfileImageName = employeeViewModel.ProfileImageName,
            DepartmentId = employeeViewModel.DepartmentId,
            DesignationId = employeeViewModel.DesignationId
        };

    public static List<Employee> ToModel(this List<EmployeeViewModel> employeeViewModels) =>
        employeeViewModels.Select(x => x.ToModel()).ToList();
}
