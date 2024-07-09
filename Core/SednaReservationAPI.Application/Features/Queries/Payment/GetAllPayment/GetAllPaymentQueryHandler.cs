using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Payment.GetAllPayment
{
    public class GetAllPaymentQueryHandler : IRequestHandler<GetAllPaymentQueryRequest, GetAllPaymentQueryResponse>
    {
        Task<GetAllPaymentQueryResponse> IRequestHandler<GetAllPaymentQueryRequest, GetAllPaymentQueryResponse>.Handle(GetAllPaymentQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
