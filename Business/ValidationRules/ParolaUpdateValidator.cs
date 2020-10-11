using DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class ParolaUpdateValidator : AbstractValidator<ParolaUpdateDTO>
    {
        public ParolaUpdateValidator()
        {
            RuleFor(i => i.Parola).NotNull().WithMessage("Parola alanı boş geçilemez");
            RuleFor(i => i.Parola1).NotNull().WithMessage("Parola onay alanı boş geçilemez");
            RuleFor(i => i.Parola).Equal(i => i.Parola1).WithMessage("Parolalar aynı olmalıdır");
        }
    }
}
