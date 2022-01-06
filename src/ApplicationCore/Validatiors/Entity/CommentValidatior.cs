using ApplicationCore.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Validatiors.Entity
{
    public class CommentValidatior : AbstractValidator<Comment>
    {
        static readonly int maxLength = 1000;

        readonly string notNullMessage = "Bu Değerin Girilmesi Zorunludur.";
        readonly string maxLengthMessage = $"Bu Değer Max {maxLength} Uzunluğunda Olmalıdır.";

        public CommentValidatior()
        {
            RuleFor(x => x.Content)
                .NotNull().WithMessage(notNullMessage)
                .NotEmpty().WithMessage(notNullMessage)
                .MaximumLength(maxLength).WithMessage(maxLengthMessage);
        }
    }
}
