using FluentValidation;
using SednaReservationAPI.Application.Features.Commands.Payment.CreatePayment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Validators.Payment
{
    public class CreatePaymentValidator : AbstractValidator<CreatePaymentCommandRequest>
    {
        public CreatePaymentValidator()
        {
            RuleFor(p => p.ReservationId)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave Reservation ID blank or null!");

            RuleFor(p => p.Amount)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave amount blank!")
                .Must(BeValidAmount)
                    .WithMessage("Please enter valid amount!");

            RuleFor(p => p.Status)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave status blank!");

            RuleFor(p => p.PaymentMethod)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave payment method blank!")
                .Must(BeValidPayment)
                    .WithMessage("Please enter valid payment method!");

            RuleFor(p => p.Date)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave date blank!")
                .Must(BeValidDate)
                    .WithMessage("Please enter valid blank!");
        }

        private static bool BeValidAmount(decimal amount)
        {
            return amount > 0;
        }

        private static bool BeValidDate(DateTime date)
        {
            return date >= DateTime.Now;
        }

        private static bool BeValidPayment(string method)
        {
            string[] validMethods = new string[]
            {
                "Credit Card",
                "Debit Card",
                "PayPal",
                "Bank Transfer",
                "Bitcoin",
                "Apple Pay",
                "Google Pay",
                "Amazon Pay",
                "Check",
                "Cash"
            };

            return validMethods.Contains(method);
        }
    }
}
