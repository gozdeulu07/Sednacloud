using MediatR;
using Microsoft.AspNetCore.Mvc;
using SednaReservationAPI.Application.Features.Queries.Room;
using SednaReservationAPI.Application.Features.Queries.RoomType;
using SednaReservationAPI.Application.Repositories;
using SednaReservationAPI.Persistence.Repositories;

namespace SednaReservationAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
     
        private readonly IRoomTypeReadRepository _roomTypeReadRepository;
        private readonly IRoomTypeWriteRepository _roomTypeWriteRepository;
        private readonly IMediator _mediator;

        public RoomTypeController(IRoomTypeReadRepository roomTypeReadRepository, IRoomTypeWriteRepository roomTypeWriteRepository, IMediator mediator)
        {
            _roomTypeReadRepository = roomTypeReadRepository;
            _roomTypeWriteRepository = roomTypeWriteRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllRoomTypesQueryRequest getAllRoomTypesQueryRequest)
        {
            List<GetAllRoomTypesQueryResponse> response = await _mediator.Send(getAllRoomTypesQueryRequest);
          return Ok(response);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromQuery] GetByIdRoomTypeQueryRequest getByIdRoomTypeQueryRequest)
        {
            GetByIdRoomTypeQueryResponse response=  await _mediator.Send(getByIdRoomTypeQueryRequest);
            return Ok(response);

        }
    }
}
