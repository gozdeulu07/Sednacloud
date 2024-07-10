using MediatR;
using Microsoft.AspNetCore.Mvc;
using SednaReservationAPI.Application.Features.Queries.Room;
using SednaReservationAPI.Application.Repositories;

namespace SednaReservationAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {

        private readonly IRoomReadRepository _roomReadRepository;
        private readonly IRoomWriteRepository _roomWriteRepository;
        private readonly IMediator _mediator;

        public RoomController(IRoomReadRepository roomReadRepository, IRoomWriteRepository roomWriteRepository, IMediator mediator)
        {
            _roomReadRepository = roomReadRepository;
            _roomWriteRepository = roomWriteRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> getRoom([FromQuery] GetAllRoomQueryRequest getAllRoomQueryRequest)
        {
            List<GetAllRoomQueryResponse> response = await _mediator.Send(getAllRoomQueryRequest);
            return Ok(response);

        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> getRoomById([FromQuery] GetByIdRoomQueryRequest getByIdRoomQueryRequest)
        {
            GetByIdRoomQueryResponse response = await _mediator.Send(getByIdRoomQueryRequest);
            return Ok(response);

        }
        
    }
}
