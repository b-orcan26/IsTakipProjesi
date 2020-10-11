using DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class UserAddValidator : AbstractValidator<UserAddDTO>
    {
        public UserAddValidator()
        {
            RuleFor(i => i.Ad).NotNull().WithMessage("Ad alanı boş geçilemez");
            RuleFor(i => i.Soyad).NotNull().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(i => i.KullaniciAdi).NotNull().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(i => i.Parola).NotNull().WithMessage("Parola alanı boş geçilemez");
        }
    }
}
