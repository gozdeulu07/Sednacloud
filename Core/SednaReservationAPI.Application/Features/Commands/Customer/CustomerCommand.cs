using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Customer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommandRequest, CreateCustomerCommandResponse>
    {
        public Task<CreateCustomerCommandResponse> Handle(CreateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class CreateCustomerCommandRequest : IRequest<CreateCustomerCommandResponse>
    {
    }

    public class CreateCustomerCommandResponse
    {
    }


    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommandRequest, DeleteCustomerCommandResponse>
    {
        public Task<DeleteCustomerCommandResponse> Handle(DeleteCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class DeleteCustomerCommandRequest : IRequest<DeleteCustomerCommandResponse>
    {
    }
  
    public class DeleteCustomerCommandResponse
    {
    }


    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommandRequest, UpdateCustomerCommandResponse>
    {
        public Task<UpdateCustomerCommandResponse> Handle(UpdateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class UpdateCustomerCommandRequest : IRequest<UpdateCustomerCommandResponse>
    {
    }
    public class UpdateCustomerCommandResponse
    {
    }
}


