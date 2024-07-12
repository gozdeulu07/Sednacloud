using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SednaReservationAPI.Application.Features.Commands.Customer.CreateCustomer;
using SednaReservationAPI.Application.Features.Queries.Customer.GetAllCustomer;
using SednaReservationAPI.Application.Features.Queries.Customer.GetByIdCustomer;
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
        private readonly IMediator _mediator;

        public CustomersController(ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository, IMediator mediator)
        {
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
            _mediator = mediator;
        }
    }
}
