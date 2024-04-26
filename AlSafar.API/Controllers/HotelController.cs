using AlSafar.Domain.Models.Hotel;
using AlSafar.Infrastructure.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AlSafar.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelController : ControllerBase
{
    private readonly IHotelRepository _hotelRepository;

    public HotelController(IHotelRepository hotelRepository)
    {
        _hotelRepository = hotelRepository;
    }
    
    [HttpGet]
    public List<Hotel> GetAllHotels()
    {
        return _hotelRepository.GetAllHotels().ToList();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Hotel>> GetHotelById(int id)
    {
        Hotel hotel = await _hotelRepository.GetHotelByIdAsync(id);
        return Ok(hotel);
    }

    [HttpPost]
    public async Task<ActionResult<Hotel>> PostHotelAsync(Hotel hotel)
    {
        Hotel addedHotel = await _hotelRepository.AddHotelAsync(hotel);
        return Ok(addedHotel);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Hotel>> DeleteHotelAsync(int id)
    {
        Hotel hotel = await _hotelRepository.GetHotelByIdAsync(id);
        return await _hotelRepository.RemoveHotelAsync(hotel);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Hotel>> UpdateHotelAsync(int id, Hotel hotel)
    {
        Hotel updatedHotel = await _hotelRepository.UpdateHotelAsync(id, hotel);
        return Ok(updatedHotel);
    }
}