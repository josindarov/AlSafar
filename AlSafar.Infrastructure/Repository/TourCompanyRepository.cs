using AlSafar.Domain.Models.TourCompany;
using AlSafar.Infrastructure.DbContext;
using AlSafar.Infrastructure.Interface;

namespace AlSafar.Infrastructure.Repository;

public class TourCompanyRepository : ITourCompanyRepository
{
    private readonly AppDbContext _dbContext;

    public TourCompanyRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<TourCompany> AddTourCompanyAsync(TourCompany tourCompany)
    {
        var result = await _dbContext.TourCompanies.AddAsync(tourCompany);
        return result.Entity;
    }

    public async Task<TourCompany> GetTourCompanyById(int id)
    {
        TourCompany tourCompany =  _dbContext.TourCompanies
            .FirstOrDefault(o => o.Id == id);
        
        return tourCompany;
    }

    public IQueryable<TourCompany> GetAllTourCompanies()
    {
        return _dbContext.TourCompanies;
    }

    public async Task<TourCompany> RemoveTourCompanyAsync(TourCompany tourCompany)
    {
        _dbContext.TourCompanies.Remove(tourCompany);
        return tourCompany;
    }

    public async Task<TourCompany> UpdateTourCompanyAsync(int id, TourCompany tourCompany)
    {
        TourCompany updatedTourCompany = _dbContext.TourCompanies
            .FirstOrDefault(o => o.Id == id);

        updatedTourCompany.Name = tourCompany.Name;

        return updatedTourCompany;
    }
}