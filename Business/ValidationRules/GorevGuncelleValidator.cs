using DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class GorevGuncelleValidator : AbstractValidator<GorevGuncelleDTO>
    {
        public GorevGuncelleValidator()
        {
            RuleFor(i => i.Id).NotNull();
            RuleFor(i => i.Tanim).NotEmpty().WithMessage("Tanım alanı boş geçilemez");
            RuleFor(i => i.Aciklama).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
