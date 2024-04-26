using AlSafar.Domain.Models.Flight;
using AlSafar.Infrastructure.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AlSafar.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FlightController : ControllerBase
{
    private readonly IFlightRepository _flightRepository;

    public FlightController(IFlightRepository flightRepository)
    {
        _flightRepository = flightRepository;
    }

    [HttpGet]
    public List<Flight> GetAllFlights()
    {
        return _flightRepository.GetAllFlights().ToList();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Flight>> GetFlightById(int id)
    {
        Flight flight = await _flightRepository.GetFlightByIdAsync(id);
        return Ok(flight);
    }

    [HttpPost]
    public async Task<ActionResult<Flight>> PostFlightAsync(Flight flight)
    {
        Flight addedFlight = await _flightRepository.AddFlightAsync(flight);
        return Ok(addedFlight);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Flight>> DeleteFlightAsync(int id)
    {
        Flight flight = await _flightRepository.GetFlightByIdAsync(id);
        return await _flightRepository.RemoveFlightAsync(flight);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Flight>> UpdateFlightAsync(int id, Flight flight)
    {
        Flight updatedFlight = await _flightRepository.UpdateFlightAsync(id, flight);
        return Ok(updatedFlight);
    }
}