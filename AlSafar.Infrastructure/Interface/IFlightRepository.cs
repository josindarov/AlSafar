using AlSafar.Domain.Models.Flight;

namespace AlSafar.Infrastructure.Interface;

public interface IFlightRepository
{
    Task<Flight> AddFlightAsync(Flight flight);
    Task<Flight?> GetFlightByIdAsync(int id);
    IQueryable<Flight> GetAllFlights();
    Task<Flight> RemoveFlightAsync(Flight flight);
    Task<Flight> UpdateFlightAsync(int id, Flight flight);
}