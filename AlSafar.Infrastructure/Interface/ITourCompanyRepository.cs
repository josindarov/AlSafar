using AlSafar.Domain.Models.TourCompany;

namespace AlSafar.Infrastructure.Interface;

public interface ITourCompanyRepository
{
    Task<TourCompany> AddTourCompanyAsync(TourCompany tourCompany);
    Task<TourCompany> GetTourCompanyById(int id);
    IQueryable<TourCompany> GetAllTourCompanies();
    Task<TourCompany> RemoveTourCompanyAsync(TourCompany tourCompany);
    Task<TourCompany> UpdateTourCompanyAsync(int id, TourCompany tourCompany);
}