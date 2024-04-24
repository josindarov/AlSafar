using AlSafar.Domain.Models.Hotel;

namespace AlSafar.Infrastructure.Interface;

public interface IHotelRepository
{
    Task<Hotel> AddHotelAsync(Hotel hotel);
    Task<Hotel> GetHotelByIdAsync(int id);
    IQueryable<Hotel> GetAllHotels();
    Task<Hotel> RemoveHotelAsync(Hotel hotel);
    Task<Hotel> UpdateHotelAsync(Hotel hotel);
}