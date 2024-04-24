using AlSafar.Domain.Models.Tour;
using AlSafar.Domain.Models.TourCompany;

namespace AlSafar.Infrastructure.Interface;

public interface ITourRepository
{
    Task<Tour> AddTourAsync(Tour tour);
    Task<Tour> GetTourById(int id);
    IQueryable<Tour> GetAllTours();
    Task<Tour> RemoveTourAsync(Tour tour);
    Task<Tour> UpdateTourAsync(Tour tour);
}