using FluentValidation;
using SednaReservationAPI.Application.Features.Commands.Customer.CreateCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Validators.Customer
{
    public class CreateCustomerValidator : AbstractValidator<CreateCustomerCommandRequest>
    {
        public CreateCustomerValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave username blank!")
                .Length(2, 30)
                    .WithMessage("Please enter username with length between 2-30");

            RuleFor(c => c.Phone)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave phone number blank!")
                .Length(10, 11)
                    .WithMessage("Please enter valid phone number!");

            RuleFor(c => c.Password)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave password blank!")
                .Must(BeAValidPassword)
                    .WithMessage("Please enter valid password!");


            RuleFor(c => c.Age)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please do not leave age blank!")
                .GreaterThan(0)
                .WithMessage("Your age can't be less than 0!")
                .Must(BeAValidAge)
                .WithMessage("Please enter valid age!");


            RuleFor(c => c.Email)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please fo not leave mail blank!")
                .Must(BeAValidMail)
                    .WithMessage("Please enter valid mail!");

            RuleFor(c => c.Gender)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave gender blank!")
                .Must(BeAValidGender)
                    .WithMessage("Please enter valid gender!");
        }
        private static bool BeAValidGender(string gender)
        {
            if (string.IsNullOrEmpty(gender))
                return false;

            string[] validGenders = { "male", "female" };
            string lowerCaseGender = gender.ToLower();
            return (validGenders.Contains(lowerCaseGender));
        }

        private static bool BeAValidMail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private static bool BeAValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length <= 0)
            {
                return false;
            }

            bool isCap = false, isNum = false, isPunc = false;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                    isNum = true;
                else if (char.IsUpper(c))
                    isCap = true;
                else if (char.IsPunctuation(c) || char.IsSymbol(c))
                    isPunc = true;
            }
            return isNum && isCap && isPunc;
        }


        private static bool BeAValidAge(int age)
        {
            return age > 8;
        }
    }
}
