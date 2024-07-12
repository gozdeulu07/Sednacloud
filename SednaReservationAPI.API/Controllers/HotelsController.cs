using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SednaReservationAPI.Application.Features.Queries.Hotel.GetAllHotel;
using SednaReservationAPI.Application.Repositories;

namespace SednaReservationAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelReadRepository _hotelReadRepository;
        private readonly IHotelWriteRepository _hotelWriteRepository;
        private readonly IMediator _mediator;

        public HotelsController(IHotelReadRepository hotelReadRepository, IHotelWriteRepository hotelWriteRepository, IMediator mediator)
        {
            _hotelReadRepository = hotelReadRepository;
            _hotelWriteRepository = hotelWriteRepository;
            _mediator = mediator;
        }
    }
}
