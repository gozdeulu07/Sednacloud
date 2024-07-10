using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Customer.GetByIdCustomer
{
    public class GetByIdCustomerQueryHandler : IRequestHandler<GetByIdCustomerQueryRequest, GetByIdCustomerQueryResponse>
    {
        Task<GetByIdCustomerQueryResponse> IRequestHandler<GetByIdCustomerQueryRequest, GetByIdCustomerQueryResponse>.Handle(GetByIdCustomerQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
