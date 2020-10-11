using DTO;
using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class RaporAddValidator : AbstractValidator<RaporAddDTO>
    {
        public RaporAddValidator()
        {
            RuleFor(i => i.Icerik).NotNull().WithMessage("İçerik alanı boş geçilemez");
        }
    }
}
