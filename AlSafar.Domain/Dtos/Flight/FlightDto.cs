namespace AlSafar.Domain.Dtos.Flight;

public class FlightDto
{
    public int Id { get; set; }

    public string? GateNumber { get; set; }

    public DateTime FlightTime { get; set; }
}