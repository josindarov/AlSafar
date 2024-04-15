using System.Text.Json.Serialization;

namespace AlSafar.Domain.Models.Client;

public class Client
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }

    public int Age { get; set; }

    public string? PassportId { get; set; }

    public string? Email { get; set; }

    public bool Verified { get; set; } = false;
    
    public Guid TourCompanyId { get; set; }

    [JsonIgnore]
    public TourCompany.TourCompany? TourCompany { get; set; }
}