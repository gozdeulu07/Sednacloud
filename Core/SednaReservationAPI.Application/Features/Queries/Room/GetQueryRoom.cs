using MediatR;
using SednaReservationAPI.Application.Features.Queries.Review;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Room
{
    public class GetAllRoomQueryHandler : IRequestHandler<GetAllRoomQueryRequest, List<GetAllRoomQueryResponse>>
    {
        private readonly IRoomReadRepository _roomReadRepository;

        public GetAllRoomQueryHandler(IRoomReadRepository roomReadRepository)
        {
            _roomReadRepository = roomReadRepository;
        }

        public Task<List<GetAllRoomQueryResponse>> Handle(GetAllRoomQueryRequest request, CancellationToken cancellationToken)
        {
            var room = _roomReadRepository.GetAll().Select(r => new GetAllRoomQueryResponse
            {
                Id = r.Id.ToString(),
                HotelId = r.HotelId,
                RoomTypeId = r.RoomTypeId,
                BasePrice = r.BasePrice,
                Status = r.Status

            }).ToList(); // getByIdFonksiyonunu kullanarak id parametresini gönderip odemenin icine bilgileri aktardık



            return Task.FromResult(room);
        }
    }


    public class GetAllRoomQueryRequest : IRequest<List<GetAllRoomQueryResponse>>
    {

    }

    public class GetAllRoomQueryResponse
    {   public string? Id {  get; set; }
        public string? HotelId { get; set; }
        public string? RoomTypeId { get; set; }
        public decimal BasePrice { get; set; }
        public string? Status { get; set; }
    }


    //tekil

    public class GetByIdRoomQueryHandler : IRequestHandler<GetByIdRoomQueryRequest, GetByIdRoomQueryResponse>
    {
        private readonly IRoomReadRepository _roomReadRepository;

        public GetByIdRoomQueryHandler(IRoomReadRepository roomReadRepository)
        {
            _roomReadRepository = roomReadRepository;
        }

        public async Task<GetByIdRoomQueryResponse> Handle(GetByIdRoomQueryRequest request, CancellationToken cancellationToken)
        {
            var r = await _roomReadRepository.GetByIdAsync(request.Id);
            var response = new GetByIdRoomQueryResponse
            {
                Id = r.Id.ToString(),
                HotelId = r.HotelId,
                RoomTypeId = r.RoomTypeId,
                BasePrice = r.BasePrice,
                Status = r.Status
            };

            return response;
        }
    }
   

    public class GetByIdRoomQueryRequest : IRequest<GetByIdRoomQueryResponse>
    {
    public string Id { get; set; }
    }

    public class GetByIdRoomQueryResponse
    {
        public string? Id { get; set; }
        public string? HotelId { get; set; }
        public string? RoomTypeId { get; set; }
        public decimal BasePrice { get; set; }
        public string? Status { get; set; }
    }
}
