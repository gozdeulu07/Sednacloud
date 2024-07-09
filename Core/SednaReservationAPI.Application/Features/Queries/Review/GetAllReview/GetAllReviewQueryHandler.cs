using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Review.GetAllReview
{
    public class GetAllReviewQueryHandler : IRequestHandler<GetAllReviewQueryRequest, GetAllReviewQueryResponse>
    {
        Task<GetAllReviewQueryResponse> IRequestHandler<GetAllReviewQueryRequest, GetAllReviewQueryResponse>.Handle(GetAllReviewQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}