using FluentValidation;
using DataAccess.Entities;
namespace Book_Shop.Validators
{
    public class BookValidators:AbstractValidator<Book>
    {
        public BookValidators()
        {
            RuleFor(x=>x.Title)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .WithMessage("Fild is required");
            RuleFor(x => x.ISBN)
                 .NotEmpty()
                 .NotNull()
                 .MinimumLength(9)
                 .WithMessage("Fild is required");
            RuleFor(a=>a.PaperPrice)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Value {PropertyName} is incorrect.{PropertyName}" +
                " must be bigger than 0");
            RuleFor(a => a.EBookPrice)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Value {PropertyName} is incorrect.{PropertyName}" +
                " must be bigger than 0");
            RuleFor(x => x.Description)
                 .NotEmpty()
                 .NotNull().WithMessage("Description is required.")
                 .WithMessage("Fild is required")
                 .MaximumLength(4000).WithMessage("Description must not exceed 4000 characters.");
            RuleFor(a => a.Count)
                .NotNull().WithMessage("Count is required.")
                .GreaterThanOrEqualTo(0)
                .WithMessage("Value {PropertyName} is incorrect.{PropertyName}" +
                " must be bigger than 0");
            RuleFor(x => x.Year)
                .NotNull().WithMessage("Year is required.")  
                .GreaterThanOrEqualTo(0).WithMessage("Year cannot be negative.");
            RuleFor(x => x.ImagePath)
                .Must(LinkMustBeAUri)
                .WithMessage("{PropertyName} has incorrect URL format");
            RuleFor(x => x.Language)
                .NotEmpty().WithMessage("Language is required.");
            RuleFor(x => x.NumberOfPages)
                .NotNull().WithMessage("Number of pages is required.") 
                .GreaterThanOrEqualTo(0).WithMessage("Number of pages cannot be negative.");


        }
        private static bool LinkMustBeAUri(string? link)
        {
            if (string.IsNullOrWhiteSpace(link))
            {
                return false;
            }

            //Courtesy of @Pure.Krome's comment and https://stackoverflow.com/a/25654227/563532
            Uri outUri;
            return Uri.TryCreate(link, UriKind.Absolute, out outUri)
                   && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps);
        }
    }
}
