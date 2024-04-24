using AlSafar.Domain.Models.Flight;
using AlSafar.Infrastructure.Interface;

namespace AlSafar.Infrastructure.Repository;

public class FlightRepository : IFlightRepository
{
    public async Task<Flight> AddFlightAsync(Flight flight)
    {
        throw new NotImplementedException();
    }

    public async Task<Flight> GetFlightByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Flight> GetAllFlights()
    {
        throw new NotImplementedException();
    }

    public async Task<Flight> RemoveFlightAsync(Flight flight)
    {
        throw new NotImplementedException();
    }

    public async Task<Flight> UpdateFlightAsync(Flight flight)
    {
        throw new NotImplementedException();
    }
}