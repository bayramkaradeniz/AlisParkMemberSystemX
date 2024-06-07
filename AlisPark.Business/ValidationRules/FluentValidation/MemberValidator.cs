using AlisPark.Entities.Concrete;
using FluentValidation;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AlisPark.Business.ValidationRules.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        //fluent validation
        public MemberValidator()
        {
            RuleFor(p => p.Balance).NotEmpty();
            RuleFor(p => p.MemberMail).Must(BeValidEmail).WithMessage("Geçerli bir e-posta adresi giriniz.");

            RuleFor(p => p.Balance).GreaterThan(-1).WithMessage("The Balance cannot be negative.");
            RuleFor(p => p.Balance).Must(BeAnInteger).WithMessage("Product stock must be an integer number.");
        }

        private bool BeValidEmail(string email)
        {
            return email.Contains("@");
        }

        private bool BeAnInteger(decimal price)
        {
            return price % 1 != 0;
        }
    }
   
}
