using AlSafar.Domain.Models.TourCompany;
using AlSafar.Infrastructure.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AlSafar.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    private readonly ITourCompanyRepository _tourCompanyRepository;

    public HomeController(ITourCompanyRepository tourCompanyRepository)
    {
        _tourCompanyRepository = tourCompanyRepository;
    }

    [HttpGet]
    public List<TourCompany?> GetTourCompanies()
    {
        return _tourCompanyRepository.GetAllTourCompanies().ToList();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TourCompany>> GetTourCompanyByIdAsync(int id)
    {
        TourCompany? tourCompany = await _tourCompanyRepository
            .GetTourCompanyById(id);

        return Ok(tourCompany);
    }

    [HttpPost]
    public async Task<ActionResult<TourCompany>> PostTourCompanyAsync(TourCompany? tourCompany)
    {
        TourCompany? addedTourCompany = await _tourCompanyRepository
            .AddTourCompanyAsync(tourCompany);

        return Ok(addedTourCompany);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<TourCompany>> DeleteTourCompanyAsync(int id)
    {
        TourCompany? tourCompany = await _tourCompanyRepository
            .GetTourCompanyById(id);

        return await _tourCompanyRepository.RemoveTourCompanyAsync(tourCompany);
    }

    [HttpPut]
    public async Task<ActionResult<TourCompany>> UpdateTourCompanyAsync(int id, TourCompany tourCompany)
    {
        return await _tourCompanyRepository.UpdateTourCompanyAsync(id, tourCompany);
    }
}