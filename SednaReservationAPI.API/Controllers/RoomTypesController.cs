using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SednaReservationAPI.Application.Repositories;

namespace SednaReservationAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypesController : ControllerBase
    {
        private readonly IRoomTypeReadRepository _roomTypeReadRepository;
        private readonly IRoomTypeWriteRepository _roomTypeWriteRepository;
        private readonly IMediator _mediator;

        public RoomTypesController(IRoomTypeReadRepository roomTypeReadRepository, IRoomTypeWriteRepository roomTypeWriteRepository, IMediator mediator)
        {
            _roomTypeReadRepository = roomTypeReadRepository;
            _roomTypeWriteRepository = roomTypeWriteRepository;
            _mediator = mediator;
        }
    }
}
