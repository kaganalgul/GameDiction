using ApplicationCore.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Validatiors.Entity
{
    public class NewsValidatior : AbstractValidator<News>
    {
        static readonly int maxTitleLength = 250;
        static readonly int maxContentLength = 250;

        readonly string notNullMessage = "Bu Değerin Girilmesi Zorunludur.";
        readonly string maxTitleLengthMessage = $"Bu Değer Max {maxTitleLength} Uzunluğunda Olmalıdır.";
        readonly string maxContentLengthMessage = $"Bu Değer Max {maxContentLength} Uzunluğunda Olmalıdır.";

        public NewsValidatior()
        {
            RuleFor(x => x.Title)
                .NotNull().WithMessage(notNullMessage)
                .NotEmpty().WithMessage(notNullMessage)
                .MaximumLength(maxTitleLength).WithMessage(maxTitleLengthMessage);

            RuleFor(x => x.Content)
                .NotNull().WithMessage(notNullMessage)
                .NotEmpty().WithMessage(notNullMessage)
                .MaximumLength(maxContentLength).WithMessage(maxContentLengthMessage);
        }
    }
}
