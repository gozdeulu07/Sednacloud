using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Review.DeleteReview
{
    public class DeleteReviewCommandHandler : IRequestHandler<DeleteReviewCommandRequest, DeleteReviewCommandResponse>
    {
        public Task<DeleteReviewCommandResponse> Handle(DeleteReviewCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
