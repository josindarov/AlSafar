using System.Text.Json.Serialization;

namespace AlSafar.Domain.Models.Employee;

public class Employee
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Role { get; set; }

    public Guid TourCompanyId { get; set; }
    
    [JsonIgnore]
    public TourCompany.TourCompany? TourCompany { get; set; }
}