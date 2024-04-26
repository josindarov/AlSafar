using AlSafar.Domain.Models.Flight;
using AlSafar.Domain.Models.Tour;
using AlSafar.Infrastructure.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AlSafar.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TourController : ControllerBase
{
    private readonly ITourRepository _tourRepository;

    public TourController(ITourRepository tourRepository)
    {
        _tourRepository = tourRepository;
    }
    
    [HttpGet]
    public List<Tour> GetAllTours()
    {
        return _tourRepository.GetAllTours().ToList();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Tour>> GetTourById(int id)
    {
        Tour tour = await _tourRepository.GetTourById(id);
        return Ok(tour);
    }

    [HttpPost]
    public async Task<ActionResult<Tour>> PostTourAsync(Tour tour)
    {
        Tour addedTour = await _tourRepository.AddTourAsync(tour);
        return Ok(addedTour);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Tour>> DeleteTourAsync(int id)
    {
        Tour tour = await _tourRepository.GetTourById(id);
        return await _tourRepository.RemoveTourAsync(tour);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Flight>> UpdateTourAsync(int id, Tour tour)
    {
        Tour updatedTour = await _tourRepository.UpdateTourAsync(id, tour);
        return Ok(updatedTour);
    }
}