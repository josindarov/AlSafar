namespace AlSafar.Domain.Dtos.Client;

public class ClientDto
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }

    public int Age { get; set; }

    public string? PassportId { get; set; }

    public string? Email { get; set; }

    public bool Verified { get; set; } = false;

    public string Destination { get; set; }
}