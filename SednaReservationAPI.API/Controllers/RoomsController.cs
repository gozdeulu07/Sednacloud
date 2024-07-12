using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SednaReservationAPI.Application.Repositories;

namespace SednaReservationAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomReadRepository _roomReadRepository;
        private readonly IRoomWriteRepository _roomWriteRepository;
        private readonly IMediator _mediator;

        public RoomsController(IRoomReadRepository roomReadRepository, IRoomWriteRepository roomWriteRepository, IMediator mediator)
        {
            _roomReadRepository = roomReadRepository;
            _roomWriteRepository = roomWriteRepository;
            _mediator = mediator;
        }
    }
}
