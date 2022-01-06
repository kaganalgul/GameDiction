using ApplicationCore.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Validatiors.Entity
{
    public class TopicValidatior : AbstractValidator<Topic>
    {
        static readonly int maxLength = 250;

        readonly string notNullMessage = "Bu Değerin Girilmesi Zorunludur.";
        readonly string maxLengthMessage = $"Bu Değer Max {maxLength} Uzunluğunda Olmalıdır.";

        public TopicValidatior()
        {
            RuleFor(x => x.Title)
                .NotNull().WithMessage(notNullMessage)
                .NotEmpty().WithMessage(notNullMessage)
                .MaximumLength(maxLength).WithMessage(maxLengthMessage);
        }
    }
}
