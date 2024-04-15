using System.Text.Json.Serialization;

namespace AlSafar.Domain.Models.Tour;

public class Tour
{
    public Guid Id { get; set; }

    public string? Destination { get; set; }

    public decimal Duration { get; set; }

    public decimal Price { get; set; }

    public Guid HotelId { get; set; }
    
    [JsonIgnore]
    public Hotel.Hotel? Hotel { get; set; }

    public Guid FlightId { get; set; }
    
    [JsonIgnore]
    public Flight.Flight? Flight { get; set; }

    public Guid TourCompanyId { get; set; }

    [JsonIgnore]
    public TourCompany.TourCompany? TourCompany { get; set; }
}