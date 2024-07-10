using MediatR;
using Microsoft.AspNetCore.Mvc;
using SednaReservationAPI.Application.Features.Queries.Reservation;
using SednaReservationAPI.Application.Features.Queries.Room;
using SednaReservationAPI.Application.Repositories;
using SednaReservationAPI.Persistence.Repositories;

namespace SednaReservationAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationReadRepository _ReadRepository;
        private readonly IReservationWriteRepository _WriteRepository;
        private readonly IMediator _mediator;

        public ReservationController(IReservationReadRepository readRepository, IReservationWriteRepository writeRepository, IMediator mediator)
        {
            _ReadRepository = readRepository;
            _WriteRepository = writeRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllReservationQueryRequest getAllReservationQueryRequest) 
        {
            List<GetAllReservationQueryResponse> response = await _mediator.Send(getAllReservationQueryRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromQuery]GetByIdReservationQueryRequest getByIdReservationQueryRequest)
        {

            GetByIdReservationQueryResponse response = await _mediator.Send(getByIdReservationQueryRequest);
            return Ok(response);
        }

    }
}
