namespace AlSafar.Domain.Dtos.TourCompany;

public class TourCompanyDto
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public List<string> Destinations { get; set; }
}