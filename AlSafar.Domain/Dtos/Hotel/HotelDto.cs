namespace AlSafar.Domain.Dtos.Hotel;

public class HotelDto
{
    public int Id { get; set; }

    public string? HotelName { get; set; }

    public int NumberOfStars { get; set; }

    public decimal Price { get; set; }

    public string? Location { get; set; }
}