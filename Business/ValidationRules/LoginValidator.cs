using DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class LoginValidator : AbstractValidator<LoginDTO>
    {
        public LoginValidator()
        {
            RuleFor(i => i.KullaniciAdi).NotNull().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(i => i.Parola).NotNull().WithMessage("Parola alanı boş geçilemez");
        }
    }
}
