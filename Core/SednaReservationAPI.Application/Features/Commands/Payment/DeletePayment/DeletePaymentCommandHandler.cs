using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Payment.DeletePayment
{
    public class DeletePaymentCommandHandler : IRequestHandler<DeletePaymentCommandRequest, DeletePaymentCommandResponse>
    {
        public Task<DeletePaymentCommandResponse> Handle(DeletePaymentCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
