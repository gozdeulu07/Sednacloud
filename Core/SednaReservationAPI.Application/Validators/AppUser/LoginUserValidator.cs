using FluentValidation;
using SednaReservationAPI.Application.Features.Commands.AppUser.LoginUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Validators.AppUser
{
    public class LoginUserValidator : AbstractValidator<LoginUserCommandRequest>
    {
        public LoginUserValidator()
        {
            RuleFor(l => l.UsernameOrEmail)
            .NotEmpty()
            .NotNull()
                .WithMessage("Please do not leave username or mail blank!")
            .Must(BeValidUsernameOrMail)
                    .WithMessage("Please enter valid username or mail!");

            RuleFor(l => l.Password)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please do not leave password blank!")
                .Must(BeValidPassword)
                    .WithMessage("Please enter valid password!");
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

        private static bool BeValidUsernameOrMail(string nameOrMail)
        {
            if (string.IsNullOrEmpty(nameOrMail))
                return false;
            else if (nameOrMail.Contains('@'))
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(nameOrMail, emailPattern);
            }
            else
            {
                return (nameOrMail.Length <= 30 && nameOrMail.Length >= 2);
            }
        }
    }
}
