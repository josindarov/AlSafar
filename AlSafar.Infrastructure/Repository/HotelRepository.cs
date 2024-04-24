using AlSafar.Domain.Models.Hotel;
using AlSafar.Infrastructure.Interface;

namespace AlSafar.Infrastructure.Repository;

public class HotelRepository : IHotelRepository
{
    public async Task<Hotel> AddHotelAsync(Hotel hotel)
    {
        throw new NotImplementedException();
    }

    public async Task<Hotel> GetHotelByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Hotel> GetAllHotels()
    {
        throw new NotImplementedException();
    }

    public async Task<Hotel> RemoveHotelAsync(Hotel hotel)
    {
        throw new NotImplementedException();
    }

    public async Task<Hotel> UpdateHotelAsync(Hotel hotel)
    {
        throw new NotImplementedException();
    }
}