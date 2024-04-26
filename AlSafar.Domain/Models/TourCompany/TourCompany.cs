using System.Text.Json.Serialization;

namespace AlSafar.Domain.Models.TourCompany;

public class TourCompany
{
    public int Id { get; set; }

    public string? Name { get; set; }

    [JsonIgnore]
    public ICollection<Tour.Tour>? Tours { get; set; }

    [JsonIgnore]
    public ICollection<Employee.Employee>? Employees { get; set; }
}