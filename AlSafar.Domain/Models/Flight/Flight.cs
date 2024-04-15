using System.Text.Json.Serialization;

namespace AlSafar.Domain.Models.Flight;

public class Flight
{
    public Guid Id { get; set; }

    public string? GateNumber { get; set; }

    public DateTime FlightTime { get; set; }
    
    [JsonIgnore]
    public ICollection<Tour.Tour>? Tours { get; set; }
}