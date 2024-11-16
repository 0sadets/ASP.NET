using FluentValidation;
using DataAccess.Entities;

namespace Book_Shop.Validators
{
    public class AuthorValidators:AbstractValidator<Author>
    {
        public AuthorValidators()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .NotNull().WithMessage("FirstName is required.")
                .MinimumLength(2)
                .MaximumLength(50);
            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull().WithMessage("LastName is required.")
                .MinimumLength(2)
                .MaximumLength(255);
            RuleFor(x => x.Biography)
                .NotEmpty()
                .NotNull().WithMessage("Biography is required.")
                .MinimumLength(2)
                .MaximumLength(4000).WithMessage("Description must not exceed 4000 characters.");

        }
    }
}
