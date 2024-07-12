﻿using MediatR;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Room.GetByIdRoom
{
    public class GetByIdRoomQueryHandler : IRequestHandler<GetByIdRoomQueryRequest, GetByIdRoomQueryResponse>
    {
        readonly IRoomReadRepository _roomReadRepository;

        public GetByIdRoomQueryHandler(IRoomReadRepository roomReadRepository)
        {
            _roomReadRepository = roomReadRepository;
        }

        public async Task<GetByIdRoomQueryResponse> Handle(GetByIdRoomQueryRequest request, CancellationToken cancellationToken)
        {
            var room = await _roomReadRepository.GetByIdAsync(request.Id,false);
            var response = new GetByIdRoomQueryResponse
            {
                Id = room.Id.ToString(),
                HotelId = room.HotelId,
                RoomTypeId = room.RoomTypeId,
                BasePrice = room.BasePrice,
                Status = room.Status
            };

            return response;
        }
    }
}
