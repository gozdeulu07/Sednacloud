using MediatR;
using SednaReservationAPI.Application.Repositories;
using SednaReservationAPI.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Customer.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommandRequest, CreateCustomerCommandResponse>
    {
        private readonly ICustomerWriteRepository _customerWriteRepository;

        public CreateCustomerCommandHandler(ICustomerWriteRepository customerWriteRepository)
        {
            _customerWriteRepository = customerWriteRepository;
        }

        public async Task<CreateCustomerCommandResponse> Handle(CreateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var customer = new Customer
            {
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                Phone = request.Phone,
                Age = request.Age,
                Gender = request.Gender
            };

            await _customerWriteRepository.AddAsync(customer);
            await _customerWriteRepository.SaveAsync();

            return new CreateCustomerCommandResponse
            {
                Success = true,
                Message = "Customer created successfully."
            };
        }
    }
}
