using MediatR;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Room.CreateRoom
{
    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommandRequest, CreateRoomCommandResponse>
    {
        readonly IRoomWriteRepository _roomWriteRepository;

        public CreateRoomCommandHandler(IRoomWriteRepository roomWriteRepository)
        {
            _roomWriteRepository = roomWriteRepository;
        }

        public async Task<CreateRoomCommandResponse> Handle(CreateRoomCommandRequest request, CancellationToken cancellationToken)
        {
            await _roomWriteRepository.AddAsync(new Domain.Entities.Room
            {
                HotelId = request.HotelId,
                RoomTypeId = request.RoomTypeId,
                BaseAdultPrice = request.BaseAdultPrice,
                BaseChildPrice = request.BaseChildPrice,
                Status = request.Status
            });

            await _roomWriteRepository.SaveAsync();
            return new();
        }
    }
}
