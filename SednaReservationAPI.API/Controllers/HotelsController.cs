using Microsoft.AspNetCore.Mvc;
using SednaReservationAPI.Application.Features.Commands.Hotel.CreateHotel;
using SednaReservationAPI.Application.Features.Commands.Hotel.DeleteHotel;
using SednaReservationAPI.Application.Features.Commands.Hotel.UpdateHotel;
using SednaReservationAPI.Application.Features.Queries.Hotel.GetAllHotel;
using SednaReservationAPI.Application.Features.Queries.Hotel.GetByIdHotel;
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

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllHotelQueryRequest getAllHotelQueryRequest)
        {
            GetAllHotelQueryResponse response = await _mediator.Send(getAllHotelQueryRequest);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdHotelQueryRequest getByIdHotelQueryRequest)
        {
            GetByIdHotelQueryResponse response = await _mediator.Send(getByIdHotelQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateHotelCommandRequest createHotelCommandRequest)
        {
            CreateHotelCommandResponse response = await _mediator.Send(createHotelCommandRequest);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] DeleteHotelCommandRequest deleteHotelCommandRequest)
        {

            DeleteHotelCommandResponse response = await _mediator.Send(deleteHotelCommandRequest);
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateHotelCommandRequest updateHotelCommandRequest)
        {
            UpdateHotelCommandResponse response = await _mediator.Send(updateHotelCommandRequest);
            return Ok(response);
        }
    }
}
