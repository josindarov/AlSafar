using AlSafar.Domain.Models.Employee;
using AlSafar.Infrastructure.DbContext;
using AlSafar.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace AlSafar.Infrastructure.Repository;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly AppDbContext _dbContext;

    public EmployeeRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<Employee> AddEmployeeAsync(Employee employee)
    {
        var result = await _dbContext.Employees.AddAsync(employee);
        await _dbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Employee?> GetEmployeeByIdAsync(int id)
    {
        Employee? employee = await _dbContext.Employees
            .FirstOrDefaultAsync(o => o.Id == id);

        return employee;
    }

    public IQueryable<Employee> GetAllEmployee()
    {
        return _dbContext.Employees;
    }

    public async Task<Employee> RemoveEmployeeAsync(Employee employee)
    {
        _dbContext.Employees.Remove(employee);
        await _dbContext.SaveChangesAsync();
        return employee;
    }

    public async Task<Employee?> UpdateEmployeeAsync(int id, Employee employee)
    {
        Employee? updatedEmployee = await _dbContext.Employees
            .FirstOrDefaultAsync(o => o.Id == id);

        if (updatedEmployee != null)
        {
            updatedEmployee.Name = employee.Name;
            updatedEmployee.Role = employee.Role;
            await _dbContext.SaveChangesAsync();
            return updatedEmployee;
        }

        return null;
    }
}