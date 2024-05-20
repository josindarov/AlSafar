namespace AlSafar.Domain.Dtos.Employee;

public class EmployeeDto
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Role { get; set; }

    public int TourCompanyId { get; set; }

    public string CompanyName { get; set; }
}