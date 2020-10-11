using DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class RaporUpdateValidator : AbstractValidator<RaporUpdateDTO>
    {
        public RaporUpdateValidator()
        {
            RuleFor(i => i.Id).NotNull();
            RuleFor(i => i.Icerik).NotNull().WithMessage("İçerik alanı boş geçilemez");
        }
    }
}
