using AlSafar.Domain.Models.Tour;
using AlSafar.Infrastructure.DbContext;
using AlSafar.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace AlSafar.Infrastructure.Repository;

public class TourRepository : ITourRepository
{
    private readonly AppDbContext _dbContext;

    public TourRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<Tour> AddTourAsync(Tour tour)
    {
        var result = await _dbContext.Tours.AddAsync(tour);
        await _dbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Tour> GetTourById(int id)
    {
        Tour? tour = await _dbContext.Tours
            .FirstOrDefaultAsync(o => o.Id == id);

        return tour;
    }

    public IQueryable<Tour> GetAllTours()
    {
        return _dbContext.Tours;
    }

    public async Task<Tour> RemoveTourAsync(Tour tour)
    {
        _dbContext.Tours.Remove(tour);
        await _dbContext.SaveChangesAsync();
        return tour;
    }

    public async Task<Tour?> UpdateTourAsync(int id, Tour tour)
    {
        Tour? updatedTour = await _dbContext.Tours
            .FirstOrDefaultAsync(o => o.Id == id);

        if (updatedTour != null)
        {
            updatedTour.Destination = tour.Destination;
            updatedTour.Duration = tour.Duration;
            updatedTour.Price = tour.Price;
            await _dbContext.SaveChangesAsync();
            return updatedTour;
        }

        return null;
    }
}