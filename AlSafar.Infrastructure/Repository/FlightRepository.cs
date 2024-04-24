using AlSafar.Domain.Models.Flight;
using AlSafar.Infrastructure.DbContext;
using AlSafar.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace AlSafar.Infrastructure.Repository;

public class FlightRepository : IFlightRepository
{
    private readonly AppDbContext _dbContext;

    public FlightRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<Flight> AddFlightAsync(Flight flight)
    {
        var result = await _dbContext.Flights.AddAsync(flight);
        return result.Entity;
    }

    public async Task<Flight?> GetFlightByIdAsync(int id)
    {
        Flight? flight = await _dbContext.Flights
            .FirstOrDefaultAsync(o => o.Id == id);

        return flight;
    }

    public IQueryable<Flight> GetAllFlights()
    {
        return _dbContext.Flights;
    }

    public async Task<Flight> RemoveFlightAsync(Flight flight)
    {
        _dbContext.Flights.Remove(flight);
        return flight;
    }

    public async Task<Flight> UpdateFlightAsync(int id, Flight flight)
    {
        Flight? updatedFlight = await _dbContext.Flights
            .FirstOrDefaultAsync(o => o.Id == id);

        updatedFlight.GateNumber = flight.GateNumber;
        return updatedFlight;
    }
}