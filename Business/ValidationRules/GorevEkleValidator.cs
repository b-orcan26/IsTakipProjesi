using DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class GorevEkleValidator : AbstractValidator<GorevEkleDTO>
    {
        public GorevEkleValidator()
        {
            RuleFor(i => i.Tanim).NotEmpty().WithMessage("Tanım alanı boş geçilemez");
            RuleFor(i => i.Aciklama).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
