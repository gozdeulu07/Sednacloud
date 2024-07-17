using FluentValidation;
using SednaReservationAPI.Application.Features.Commands.Hotel.CreateHotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Validators.Hotel
{
    public class CreateHotelValidator : AbstractValidator<CreateHotelCommandRequest>
    {
        public CreateHotelValidator()
        {
            RuleFor(h => h.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave hotel name blank!")
                .Length(2, 30)
                    .WithMessage("Please enter hotel name with length between 2-30!");

            RuleFor(h => h.Phone)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave phone number blank!")
                .Length(10, 11)
                    .WithMessage("Please enter valid phone number!");

            RuleFor(h => h.Address)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave address blank!");

            RuleFor(h => h.Description)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave description blank!");

            RuleFor(h => h.Email)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave mail blank!")
                .Must(BeValidMail)
                    .WithMessage("Please enter valid mail!");

            RuleFor(h => h.ImageUrl)
                .NotEmpty()
                .WithMessage("Please do not leave Image URL blank!")
                .NotNull()
                .WithMessage("Image URL cannot be null!")
                .Must(BeValidUrl)
                .WithMessage("Please enter valid Image URL!");

            RuleFor(h => h.StarRating)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave star rating blank!");
                //.Must(BeValidRating)
                //    .WithMessage("Please enter valid star rating!");
        }
        private static bool BeValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        private static bool BeValidRating(int rating)
        {
            return rating >= 0 && rating <= 5;
        }

        private static bool BeValidMail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
