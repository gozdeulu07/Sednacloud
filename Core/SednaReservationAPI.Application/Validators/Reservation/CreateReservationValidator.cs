using FluentValidation;
using SednaReservationAPI.Application.Features.Commands.Reservation.CreateReservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Validators.Reservation
{
    public class CreateReservationValidator : AbstractValidator<CreateReservationCommandRequest>
    {
        public CreateReservationValidator()
        {
            RuleFor(r => r.UserId)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave User ID blank or null!");

            RuleFor(r => r.RoomId)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave Room ID blank or null!");

            RuleFor(r => r.Status)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave status blank or null!");

            RuleFor(r => r.TotalPrice)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave amount blank!")
                .GreaterThanOrEqualTo(0)
                    .WithMessage("Please enter valid amount!");

            RuleFor(r => r.CheckIn)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave check-in date!")
                .Must(BeValidCheckIn)
                    .WithMessage("Please enter valid check-in date!");

            RuleFor(r => r.CheckOut)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave check-out date!")
                .Must((reservation, checkout) => BeValidCheckOut(checkout, reservation.CheckIn))
                    .WithMessage("Please enter valid check-out date!");
        }

        private static bool BeValidCheckIn(DateTime checkin)
        {
            return checkin >= DateTime.Now.Date;
        }

        private static bool BeValidCheckOut(DateTime checkout, DateTime checkin)
        {
            return checkout > checkin;
        }
    }
}
