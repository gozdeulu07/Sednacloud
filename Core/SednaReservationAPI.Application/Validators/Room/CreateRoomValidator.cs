using FluentValidation;
using SednaReservationAPI.Application.Features.Commands.Room.CreateRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Validators.Room
{
    public class CreateRoomValidator : AbstractValidator<CreateRoomCommandRequest>
    {
        public CreateRoomValidator()
        {
            RuleFor(room => room.HotelId)
                .NotEmpty()
                .WithMessage("Please do not leave Hotel ID blank!")
                .NotNull()
                .WithMessage("Hotel ID cannot be null!");

            RuleFor(room => room.RoomTypeId)
                .NotEmpty()
                .WithMessage("Please do not leave Room Type ID blank!")
                .NotNull()
                .WithMessage("Room Type ID cannot be null!");

            RuleFor(room => room.BaseChildPrice)
                .NotEmpty()
                .WithMessage("Please do not leave base child price blank!")
                .NotNull()
                .WithMessage("Base child price cannot be null!")
                .GreaterThan(0)
                .WithMessage("Base child price cannot be less than 0!");

            RuleFor(room => room.BaseAdultPrice)
                .NotEmpty()
                .WithMessage("Please do not leave base adult price blank!")
                .NotNull()
                .WithMessage("Base adult price cannot be null!")
                .GreaterThan(0)
                .WithMessage("Base adult price cannot be less than 0!");

            RuleFor(room => room.Status)
                .NotEmpty()
                .WithMessage("Please do not leave status blank!")
                .NotNull()
                .WithMessage("Status cannot be null!");
        }
    }
}
