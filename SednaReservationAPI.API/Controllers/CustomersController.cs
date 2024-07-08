using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SednaReservationAPI.Application.Repositories;
using SednaReservationAPI.Domain.Entities;

namespace SednaReservationAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;

        private readonly IHotelReadRepository _hotelReadRepository;
        private readonly IHotelWriteRepository _hotelWriteRepository;
        public CustomersController(ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository, IHotelReadRepository hotelReadRepository, IHotelWriteRepository hotelWriteRepository)
        {
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;

            _hotelReadRepository = hotelReadRepository;
            _hotelWriteRepository = hotelWriteRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Hotel hotel = await _hotelReadRepository.GetByIdAsync("779be4b6-6000-429f-820e-6c27b67749f9");
            hotel.Address = ("Side/Manavgat/Antalya");
            _hotelWriteRepository.SaveAsync();
            return Ok("Hotel Address Updated Successfully!");
        }
    }
}
