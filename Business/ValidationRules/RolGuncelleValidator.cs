using DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class RolGuncelleValidator : AbstractValidator<RolGuncelleDTO>
    {
        public RolGuncelleValidator()
        {
            RuleFor(i => i.RolAdi).NotNull().WithMessage("Rol adı boş geçilemez");
            RuleFor(i => i.Id).NotNull();
        }
    }
}
