namespace AlSafar.Domain.Dtos.Tour;

public class TourDto
{
    public int Id { get; set; }

    public string? Destination { get; set; }

    public decimal Duration { get; set; }

    public decimal Price { get; set; }

    public string HotelDestination { get; set; }
    
    public DateTime FlightTime { get; set; }

    public string CompanyName { get; set; }
    
    public List<string> Clients { get; set; }
}