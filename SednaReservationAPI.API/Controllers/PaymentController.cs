using MediatR;
using Microsoft.AspNetCore.Mvc;
using SednaReservationAPI.Application.Features.Queries.Payment;
using SednaReservationAPI.Application.Repositories;

namespace SednaReservationAPI.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentReadRepository _paymentReadRepository;
        private readonly IPaymentWriteRepository _paymentWriteRepository;
        readonly private IMediator _mediator;

        public PaymentController(IPaymentReadRepository paymentReadRepository, IPaymentWriteRepository paymentWriteRepository, IMediator mediator)
        {
            _paymentReadRepository = paymentReadRepository;
            _paymentWriteRepository = paymentWriteRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllPaymentQueryRequest getAllPaymentQueryRequest)
        {
            List<GetAllPaymentQueryResponse> response = await _mediator.Send(getAllPaymentQueryRequest);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>GetByID([FromQuery] GetByIdPaymentQueryRequest getByIdPaymentQueryRequest)
        {
            GetByIdPaymentQueryResponse response = await _mediator.Send(getByIdPaymentQueryRequest);
            return Ok(response);
        }

    }
}
