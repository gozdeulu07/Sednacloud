using FluentValidation;
using SednaReservationAPI.Application.Features.Commands.RoomType.CreateRoomType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Validators.RoomType
{
    public class CreateRoomTypeValidator : AbstractValidator<CreateRoomTypeCommandRequest>
    {
        public CreateRoomTypeValidator()
        {
            RuleFor(roomType => roomType.Name)
                .NotEmpty()
                    .WithMessage("Please do not leave room type ampty!")
                .NotNull()
                    .WithMessage("Room type cannot be null!")
                .Length(2, 50)
                    .WithMessage("Please enter room type name with length 2-30!")
                .Must(BeValidRoomType)
                    .WithMessage("Please enter valid room type!");

            RuleFor(roomType => roomType.Description)
                .NotEmpty()
                .WithMessage("Please do not leave description blank!")
                .NotNull()
                .WithMessage("Description cannot be null!");

            RuleFor(roomType => roomType.ImageUrl)
                .NotEmpty()
                .WithMessage("Please do not leave Image URL blank!")
                .NotNull()
                .WithMessage("Image URL cannot be null!")
                .Must(BeValidUrl)
                .WithMessage("Please enter valid Image URL!");

        }
        private static bool BeValidRoomType(string roomType)
        {
            string[] hotelRoomTypes = new string[]
            {
                "Single Room",
                "Double Room",
                "Suite",
                "Deluxe Room",
                "Family Room",
                "Executive Room",
                "Twin Room",
                "Studio",
                "Penthouse",
                "Accessible Room"
            };
            if (hotelRoomTypes.Contains(roomType))
                return true;
            return false;

        }

        private static bool BeValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
    }
}
