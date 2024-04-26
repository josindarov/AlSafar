using System.Text.Json.Serialization;

namespace AlSafar.Domain.Models.Client;

public class Client
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }

    public int Age { get; set; }

    public string? PassportId { get; set; }

    public string? Email { get; set; }

    public bool Verified { get; set; } = false;
    
    public int TourId { get; set; }

    [JsonIgnore]
    public Tour.Tour? Tour { get; set; }
}