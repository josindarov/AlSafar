using System.Text.Json.Serialization;

namespace AlSafar.Domain.Models.Hotel;

public class Hotel
{
    public int Id { get; set; }

    public string? HotelName { get; set; }

    public int NumberOfStars { get; set; }

    public decimal Price { get; set; }

    public string? Location { get; set; }

    [JsonIgnore]
    public ICollection<Tour.Tour>? Tours { get; set; }
}