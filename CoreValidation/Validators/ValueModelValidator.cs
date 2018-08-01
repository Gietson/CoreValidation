using CoreValidation.Models;
using FluentValidation;

namespace CoreValidation.Validators
{
    public class ValueModelValidator : AbstractValidator<ValueModel>
    {
        public ValueModelValidator()
        {
            RuleFor(reg => reg.Id).NotEmpty();
            RuleFor(reg => reg.Value).NotEmpty();
            RuleFor(reg => reg.IsActive).NotEmpty();
        }
    }
}