using AlSafar.Domain.Models.Hotel;
using AlSafar.Infrastructure.DbContext;
using AlSafar.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace AlSafar.Infrastructure.Repository;

public class HotelRepository : IHotelRepository
{
    private readonly AppDbContext _dbContext;

    public HotelRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<Hotel> AddHotelAsync(Hotel hotel)
    {
        var result = await _dbContext.Hotels.AddAsync(hotel);
        await _dbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Hotel> GetHotelByIdAsync(int id)
    {
        Hotel? hotel = await _dbContext.Hotels
            .FirstOrDefaultAsync(o => o.Id == id);

        return hotel;
    }

    public IQueryable<Hotel> GetAllHotels()
    {
        return _dbContext.Hotels;
    }

    public async Task<Hotel> RemoveHotelAsync(Hotel hotel)
    {
        _dbContext.Hotels.Remove(hotel);
        await _dbContext.SaveChangesAsync();
        return hotel;
    }

    public async Task<Hotel?> UpdateHotelAsync(int id, Hotel hotel)
    {
        Hotel? updatedHotel = await _dbContext.Hotels
            .FirstOrDefaultAsync(o => o.Id == id);

        if (updatedHotel != null)
        {
            updatedHotel.HotelName = hotel.HotelName;
            updatedHotel.Location = hotel.Location;
            updatedHotel.NumberOfStars = hotel.NumberOfStars;
        }

        await _dbContext.SaveChangesAsync();
        return updatedHotel;
    }
}