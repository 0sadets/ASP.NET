using FluentValidation;
using DataAccess.Entities;

namespace Book_Shop.Validators
{
    public class CustomerValidators:AbstractValidator<Customer>
    {
        public CustomerValidators()
        {
            //RuleFor(x => x.FirstName)
            //    .NotEmpty()
            //    .NotNull().WithMessage("FirstName is required.")
            //    .MinimumLength(2)
            //    .MaximumLength(50);
            //RuleFor(x => x.LastName)
            //    .NotEmpty()
            //    .NotNull().WithMessage("Lastname is required.")
            //    .MinimumLength(2)
            //    .MaximumLength(50);
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");
            //RuleFor(x => x.Phone)
            //    .NotEmpty().WithMessage("Phone number is required.")
            //    .Matches(@"^\+?\d{10}$").WithMessage("Invalid phone number format.");

            //RuleFor(x => x.Address)
            //    .NotEmpty().WithMessage("Address is required.");
        }
    }
}
