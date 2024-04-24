using AlSafar.Domain.Models.Employee;

namespace AlSafar.Infrastructure.Interface;

public interface IEmployeeRepository
{
    Task<Employee> AddEmployeeAsync(Employee employee);
    Task<Employee?> GetEmployeeByIdAsync(int id);
    IQueryable<Employee> GetAllEmployee();
    Task<Employee> RemoveEmployeeAsync(Employee employee);
    Task<Employee?> UpdateEmployeeAsync(int id, Employee employee);
}