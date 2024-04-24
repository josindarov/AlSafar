using AlSafar.Domain.Models.Employee;
using AlSafar.Infrastructure.Interface;

namespace AlSafar.Infrastructure.Repository;

public class EmployeeRepository : IEmployeeRepository
{
    public async Task<Employee> AddEmployeeAsync(Employee employee)
    {
        throw new NotImplementedException();
    }

    public async Task<Employee> GetEmployeeByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Employee> GetAllEmployee()
    {
        throw new NotImplementedException();
    }

    public async Task<Employee> RemoveEmployeeAsync(Employee employee)
    {
        throw new NotImplementedException();
    }

    public async Task<Employee> UpdateEmployeeAsync(Employee employee)
    {
        throw new NotImplementedException();
    }
}