using MediatR;
using SednaReservationAPI.Application.Features.Queries.Payment;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Reservation
{
    public class GetAllReservationQueryHandler : IRequestHandler<GetAllReservationQueryRequest, List<GetAllReservationQueryResponse>>
    {
        readonly IReservationReadRepository _reservationReadRepository;

        public GetAllReservationQueryHandler(IReservationReadRepository reservationReadRepository)
        {
            _reservationReadRepository = reservationReadRepository;
        }

        public Task<List<GetAllReservationQueryResponse>> Handle(GetAllReservationQueryRequest request, CancellationToken cancellationToken)
        {
            var rezervation = _reservationReadRepository.GetAll(false)
              .Select(r => new GetAllReservationQueryResponse
              {
                  Id = r.Id.ToString(),
                  UserId = r.UserId,
                  RoomId = r.RoomId,
                  CheckIn = r.CheckIn,
                  CheckOut = r.CheckOut,
                  TotalPrice = r.TotalPrice,
                  Status = r.Status
              })
              .ToList();

            return Task.FromResult(rezervation);
        }
    }
    public class GetAllReservationQueryRequest : IRequest<List<GetAllReservationQueryResponse>>
    {
    }
    public class GetAllReservationQueryResponse
    {   public string? Id { get; set; }
        public string? UserId { get; set; }
        public string? RoomId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalPrice { get; set; }
        public string? Status { get; set; }
    }


    // Tek rezervasyın görüntüleme

    public class GetByIdReservationQueryHandler : IRequestHandler<GetByIdReservationQueryRequest, GetByIdReservationQueryResponse>
    {
        readonly IReservationReadRepository _reservationReadRepository;

        public GetByIdReservationQueryHandler(IReservationReadRepository reservationReadRepository)
        {
            _reservationReadRepository = reservationReadRepository;
        }

        public async Task<GetByIdReservationQueryResponse> Handle(GetByIdReservationQueryRequest request, CancellationToken cancellationToken)
        {
            var r = await _reservationReadRepository.GetByIdAsync(request.Id); // getByIdFonksiyonunu kullanarak id parametresini gönderip odemenin icine bilgileri aktardık

            var response = new GetByIdReservationQueryResponse
            {
                Id = r.Id.ToString(),
                UserId = r.UserId,
                RoomId = r.RoomId,
                CheckIn = r.CheckIn,
                CheckOut = r.CheckOut,
                TotalPrice = r.TotalPrice,
                Status = r.Status
            };

            return response;
        }
    }

    public class GetByIdReservationQueryRequest : IRequest<GetByIdReservationQueryResponse>
    {
        public string Id {  get; set; } = string.Empty;

    }

    public class GetByIdReservationQueryResponse
    {
        public string? Id { get; set; }
        public string? UserId { get; set; }
        public string? RoomId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalPrice { get; set; }
        public string? Status { get; set; }
    }

}
