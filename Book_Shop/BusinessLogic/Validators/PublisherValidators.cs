using DataAccess.Entities;
using FluentValidation;

namespace Book_Shop.Validators
{
    public class PublisherValidators:AbstractValidator<Publisher>
    {
        public PublisherValidators()
        {
            RuleFor(x => x.PublisherName)
                .NotEmpty()
                .NotNull().WithMessage("PubliserName is required.")
                .MinimumLength(2)
                .MaximumLength(50);
        }
    }
}
