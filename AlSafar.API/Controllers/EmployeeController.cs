using AlSafar.Domain.Models.Employee;
using AlSafar.Infrastructure.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AlSafar.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    [HttpGet]
    public List<Employee> GetAllEmployee()
    {
        return _employeeRepository.GetAllEmployee().ToList();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Employee>> GetEmployeeByIdAsync(int id)
    {
        Employee? employee = await _employeeRepository.GetEmployeeByIdAsync(id);
        return Ok(employee);
    }

    [HttpPost]
    public async Task<ActionResult<Employee>> PostEmployeeAsync(Employee employee)
    {
        Employee addedEmployee = await _employeeRepository.AddEmployeeAsync(employee);
        return Ok(addedEmployee);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Employee>> RemoveEmployeeAsync(int id)
    {
        Employee? employee = await _employeeRepository.GetEmployeeByIdAsync(id);
        return await _employeeRepository.RemoveEmployeeAsync(employee);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Employee>> UpdateEmployeeAsync(int id, Employee employee)
    {
        Employee updatedEmployee = await _employeeRepository.UpdateEmployeeAsync(id, employee);
        return Ok(updatedEmployee);
    }
}