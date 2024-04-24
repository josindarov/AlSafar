using AlSafar.Domain.Models.TourCompany;
using AlSafar.Infrastructure.Interface;

namespace AlSafar.Infrastructure.Repository;

public class TourCompanyRepository : ITourCompanyRepository
{
    public async Task<TourCompany> AddTourCompanyAsync(TourCompany tourCompany)
    {
        throw new NotImplementedException();
    }

    public async Task<TourCompany> GetTourCompanyById(int id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TourCompany> GetAllTourCompanies()
    {
        throw new NotImplementedException();
    }

    public async Task<TourCompany> RemoveTourCompanyAsync(TourCompany tourCompany)
    {
        throw new NotImplementedException();
    }

    public async Task<TourCompany> UpdateTourCompanyAsync(TourCompany tourCompany)
    {
        throw new NotImplementedException();
    }
}