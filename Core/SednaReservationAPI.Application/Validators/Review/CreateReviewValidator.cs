using FluentValidation;
using SednaReservationAPI.Application.Features.Commands.Review.CreateReview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Validators.Review
{
    public class CreateReviewValidator : AbstractValidator<CreateReviewCommandRequest>
    {
        public CreateReviewValidator()
        {
            RuleFor(rev => rev.HotelId)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave Hotel ID blank or null!");

            RuleFor(rev => rev.UserId)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave User ID blank or null!");

            RuleFor(rev => rev.Rating)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave rating blank or null!")
                .Must(BeValidRating)
                    .WithMessage("Please enter rating between 0-5!");

            RuleFor(rev => rev.Comment)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave comment blank or null!")
                .Must((rev, comment) => BeValidComment(comment, rev.Rating))
                    .WithMessage("Valid rating and at least 3 letters necessary for comment!");
        }

        private static bool BeValidRating(float rating)
        {
            return rating >= 0 && rating <= 5;
        }

        private static bool BeValidComment(string? comment, float rating)
        {
            if (string.IsNullOrEmpty(comment))
                return false;

            return BeValidRating(rating) && comment.Length >= 3;
        }
    }
}
