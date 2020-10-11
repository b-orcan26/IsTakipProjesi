using DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class UserUpdateValidator : AbstractValidator<UserUpdateDTO>
    {
        public UserUpdateValidator()
        {
            RuleFor(i => i.Ad).NotNull().WithMessage("Ad alanı boş geçilemez");
            RuleFor(i => i.Soyad).NotNull().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(i => i.Id).NotNull();
        }
    }
}
