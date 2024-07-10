using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SednaReservationAPI.Application.Features.Commands.Hotel.CreateHotel;
using SednaReservationAPI.Application.Features.Commands.Hotel.DeleteHotel;
using SednaReservationAPI.Application.Features.Commands.RoomType.DeleteRoomType;
using SednaReservationAPI.Application.Features.Queries.Hotel;
using SednaReservationAPI.Application.Repositories;
using SednaReservationAPI.Domain.Entities;
using SednaReservationAPI.Persistence.Repositories;

namespace SednaReservationAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelWriteRepository _hotelWriterepository;
        private readonly IHotelReadRepository _hotelReadRepository;
        readonly private IMediator _mediator;
        public HotelController(IHotelWriteRepository hotelWriterepository, IHotelReadRepository hotelReadRepository, IMediator mediator)
        {
            _hotelWriterepository = hotelWriterepository;
            _hotelReadRepository = hotelReadRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllHotelQueryRequest getAllHotelQueryRequest)
        {
            List<GetAllHotelQueryResponse> response = await _mediator.Send(getAllHotelQueryRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromQuery]GetByIdHotelQueryRequest getByIdHotelQueryRequest)
        {
           GetByIdHotelQueryResponse response = await _mediator.Send(getByIdHotelQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateHotelCommandRequest createHotelCommandRequest)
        {
            CreateHotelCommandResponse response = await _mediator.Send(createHotelCommandRequest);
            return StatusCode(201);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(DeleteHotelCommandRequest deleteHotelCommandRequest)
        {

            DeleteHotelCommandResponse response = await _mediator.Send(deleteHotelCommandRequest);
            return Ok();
        }


    }
}
