using ApplicationCore.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Validatiors.Entity
{
    public class CategoryValidatior : AbstractValidator<Category>
    {
        static readonly int maxLength = 50;

        readonly string notNullMessage = "Bu Değerin Girilmesi Zorunludur.";
        readonly string maxLengthMessage = $"Bu Değer Max {maxLength} Uzunluğunda Olmalıdır.";

        public CategoryValidatior()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage(notNullMessage)
                .NotEmpty().WithMessage(notNullMessage)
                .MaximumLength(maxLength).WithMessage(maxLengthMessage);
        }        
    }
}
