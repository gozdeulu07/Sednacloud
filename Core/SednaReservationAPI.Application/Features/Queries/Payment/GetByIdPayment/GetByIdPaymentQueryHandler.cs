using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Payment.GetByIdPayment
{
    public class GetByIdPaymentQueryHandler : IRequestHandler<GetByIdPaymentQueryRequest, GetByIdPaymentQueryResponse>
    {
        public Task<GetByIdPaymentQueryResponse> Handle(GetByIdPaymentQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
