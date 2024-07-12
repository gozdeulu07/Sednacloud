using MediatR;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Review.CreateReview
{
    public class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommandRequest, CreateReviewCommandResponse>
    {
        readonly IReviewWriteRepository _reviewWriteRepository;

        public CreateReviewCommandHandler(IReviewWriteRepository reviewWriteRepository)
        {
            _reviewWriteRepository = reviewWriteRepository;
        }
        public async Task<CreateReviewCommandResponse> Handle(CreateReviewCommandRequest request, CancellationToken cancellationToken)
        {
            await _reviewWriteRepository.AddAsync(new Domain.Entities.Review
            {
                HotelId = request.HotelId,
                UserId = request.UserId,
                Rating = request.Rating,
                Comment = request.Comment,
            });

            await _reviewWriteRepository.SaveAsync();
            return new();
        }
    }
}
