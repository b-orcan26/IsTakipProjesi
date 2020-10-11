using DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class RolEkleValidator : AbstractValidator<RolEkleDTO>
    {
        public RolEkleValidator()
        {
            RuleFor(i => i.RolAdi).NotNull().WithMessage("Rol adı boş geçilemez");
        }
    }
}
