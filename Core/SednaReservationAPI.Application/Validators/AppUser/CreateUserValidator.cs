using FluentValidation;
using SednaReservationAPI.Application.Features.Commands.Customer.CreateCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Validators.AppUser
{
    public class CreateUserValidator : AbstractValidator<CreateCustomerCommandRequest>
    {
        public CreateUserValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave username blank!")
                .Length(2, 30)
                    .WithMessage("Please enter name with length between 2-30!");

            RuleFor(u => u.Phone)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave phone number blank!")
                .Length(10, 11)
                    .WithMessage("Please enter valid phone number!");

            RuleFor(u => u.Password)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave password blank!")
                .Must(BeValidPassword)
                    .WithMessage("Please enter valid password!");


            RuleFor(u => u.Age)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please do not leave age blank!")
                .GreaterThan(0)
                .WithMessage("Your age can't be less than 0!")
                .Must(BeValidAge)
                .WithMessage("Please enter valid age!");


            RuleFor(u => u.Email)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave mail blank!")
                .Must(BeValidMail)
                    .WithMessage("Please enter valid mail!");

            RuleFor(u => u.Gender)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave gender blank!")
                .Must(BeValidGender)
                    .WithMessage("Please enter valid gender!");
        }
        private static bool BeValidGender(string gender)
        {
            if (string.IsNullOrEmpty(gender))
                return false;

            string[] validGenders = { "male", "female" };
            string lowerCaseGender = gender.ToLower();
            return (validGenders.Contains(lowerCaseGender));
        }
        private static bool BeValidMail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private static bool BeValidPassword(string password)
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


        private static bool BeValidAge(int age)
        {
            return age > 8;
        }
    }
}
