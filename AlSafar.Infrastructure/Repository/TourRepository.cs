using AlSafar.Domain.Models.Tour;
using AlSafar.Infrastructure.Interface;

namespace AlSafar.Infrastructure.Repository;

public class TourRepository : ITourRepository
{
    public async Task<Tour> AddTourAsync(Tour tour)
    {
        throw new NotImplementedException();
    }

    public async Task<Tour> GetTourById(int id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Tour> GetAllTours()
    {
        throw new NotImplementedException();
    }

    public async Task<Tour> RemoveTourAsync(Tour tour)
    {
        throw new NotImplementedException();
    }

    public async Task<Tour> UpdateTourAsync(Tour tour)
    {
        throw new NotImplementedException();
    }
}