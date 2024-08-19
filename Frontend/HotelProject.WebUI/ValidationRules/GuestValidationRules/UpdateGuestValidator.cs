﻿using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator: AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim alanı boş geçilemez.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız.");
            RuleFor(x => x.Surname).NotEmpty().MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri girişi yapınız.");
            RuleFor(x => x.City).NotEmpty().MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapınız.");
            RuleFor(x => x.Name).NotEmpty().MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız.");
            RuleFor(x => x.Surname).NotEmpty().MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız.");
            RuleFor(x => x.City).NotEmpty().MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız.");
        }
    }
}