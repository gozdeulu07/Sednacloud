using MediatR;
using SednaReservationAPI.Application.Features.Queries.Room;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.RoomType
{
    public class GetAllRoomTypesQueryHandler : IRequestHandler<GetAllRoomTypesQueryRequest, List<GetAllRoomTypesQueryResponse>>
    {
        private readonly IRoomTypeReadRepository _roomTypeReadRepository;

        public GetAllRoomTypesQueryHandler(IRoomTypeReadRepository roomTypeReadRepository)
        {
            _roomTypeReadRepository = roomTypeReadRepository;
        }

        public Task<List<GetAllRoomTypesQueryResponse>> Handle(GetAllRoomTypesQueryRequest request, CancellationToken cancellationToken)
        {
            var roomType = _roomTypeReadRepository.GetAll().Select(r => new GetAllRoomTypesQueryResponse
            {
                Id = r.Id.ToString(),
                Name = r.Name,
                Description = r.Description,
                ImageUrl = r.ImageUrl

            }).ToList(); // getByIdFonksiyonunu kullanarak id parametresini gönderip odemenin icine bilgileri aktardık



            return Task.FromResult(roomType);
        }
    }

    public class GetAllRoomTypesQueryRequest : IRequest<List<GetAllRoomTypesQueryResponse>>
    {
    }

    public class GetAllRoomTypesQueryResponse
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }

    //tek

    public class GetByIdRoomTypeQueryHandler : IRequestHandler<GetByIdRoomTypeQueryRequest, GetByIdRoomTypeQueryResponse>
    {

        private readonly IRoomTypeReadRepository _RoomTypeReadRepository;

        public GetByIdRoomTypeQueryHandler(IRoomTypeReadRepository roomTypeReadRepository)
        {
            _RoomTypeReadRepository = roomTypeReadRepository;
        }

        public async Task<GetByIdRoomTypeQueryResponse> Handle(GetByIdRoomTypeQueryRequest request, CancellationToken cancellationToken)
        {
            var r = await _RoomTypeReadRepository.GetByIdAsync(request.Id);
            var response = new GetByIdRoomTypeQueryResponse
            {
                Id = r.Id.ToString(),
                Name = r.Name,
                Description = r.Description,
                ImageUrl = r.ImageUrl
            };

            return response;
        }
    }
    

public class GetByIdRoomTypeQueryRequest : IRequest<GetByIdRoomTypeQueryResponse>
{
    public string Id { get; set; }

}

public class GetByIdRoomTypeQueryResponse
{
    public string Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
}
}

