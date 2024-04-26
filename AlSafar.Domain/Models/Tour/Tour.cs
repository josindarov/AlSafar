using System.Text.Json.Serialization;

namespace AlSafar.Domain.Models.Tour;

public class Tour
{
    public int Id { get; set; }

    public string? Destination { get; set; }

    public decimal Duration { get; set; }

    public decimal Price { get; set; }

    public int HotelId { get; set; }
    
    [JsonIgnore]
    public Hotel.Hotel? Hotel { get; set; }

    public int FlightId { get; set; }
    
    [JsonIgnore]
    public Flight.Flight? Flight { get; set; }

    public int TourCompanyId { get; set; }

    [JsonIgnore]
    public TourCompany.TourCompany? TourCompany { get; set; }
    
    [JsonIgnore]
    public ICollection<Client.Client>? Clients { get; set; }
}