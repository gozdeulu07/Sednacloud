using MediatR;
using SednaReservationAPI.Application.Features.Queries.Reservation;
using SednaReservationAPI.Application.Repositories;
using SednaReservationAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Review
{
    public class GetAllReviewQueryHandler : IRequestHandler<GetAllReviewQueryRequest, List<GetAllReviewQueryResponse>>
    {
        private readonly IReviewReadRepository _reviewReadRepository;

        public GetAllReviewQueryHandler(IReviewReadRepository reviewReadRepository)
        {
            _reviewReadRepository = reviewReadRepository;
        }

        public Task<List<GetAllReviewQueryResponse>> Handle(GetAllReviewQueryRequest request, CancellationToken cancellationToken)
        {
            var review = _reviewReadRepository.GetAll().Select(r => new GetAllReviewQueryResponse
            {
                Id = r.Id.ToString(),
                HotelId = r.HotelId,
                UserId = r.UserId,
                Rating = r.Rating,
                Comment = r.Comment

            }).ToList(); // getByIdFonksiyonunu kullanarak id parametresini gönderip odemenin icine bilgileri aktardık

          

            return Task.FromResult(review);
        }
    }

    public class GetAllReviewQueryRequest : IRequest<List<GetAllReviewQueryResponse>>
    {
      
    }

    public class GetAllReviewQueryResponse
    {
        public string Id { get; set; }
        public Guid HotelId { get; set; }
        public Guid UserId { get; set; }
        public float Rating { get; set; }
        public string? Comment { get; set; }
    }

    public class GetByIdReviewQueryHandler : IRequestHandler<GetByIdReviewQueryRequest, GetByIdReviewQueryResponse>
    {

        private readonly IReviewReadRepository _reviewReadRepository;

        public GetByIdReviewQueryHandler(IReviewReadRepository reviewReadRepository)
        {
            _reviewReadRepository = reviewReadRepository;
        }

        public async Task<GetByIdReviewQueryResponse> Handle(GetByIdReviewQueryRequest request, CancellationToken cancellationToken)
        {
            var r = await _reviewReadRepository.GetByIdAsync(request.Id);
            var response = new GetByIdReviewQueryResponse
            {
                Id = r.Id.ToString(),
                HotelId = r.HotelId,
                UserId = r.UserId,
                Rating = r.Rating,
                Comment = r.Comment
            };

            return response;
        }
    }

    public class GetByIdReviewQueryRequest : IRequest<GetByIdReviewQueryResponse>
    {
        public string Id { get; set; }
    }

    public class GetByIdReviewQueryResponse
    {

        public string Id { get; set; }
        public Guid HotelId { get; set; }
        public Guid UserId { get; set; }
        public float Rating { get; set; }
        public string? Comment { get; set; }
    }
}
