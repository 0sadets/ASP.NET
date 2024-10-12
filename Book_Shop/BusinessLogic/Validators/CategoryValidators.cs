using FluentValidation;
using DataAccess.Entities;

namespace Book_Shop.Validators
{
    public class CategoryValidators:AbstractValidator<Category>
    {
        public CategoryValidators()
        {
            RuleFor(x => x.CategoryName)
                .NotEmpty()
                .NotNull().WithMessage("Name is required.")
                .MinimumLength(2)
                .MaximumLength(50);
        }
    }
}
