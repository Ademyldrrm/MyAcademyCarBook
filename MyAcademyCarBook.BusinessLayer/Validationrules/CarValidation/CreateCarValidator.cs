using FluentValidation;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.Validationrules.CarValidation
{
    public class CreateCarValidator:AbstractValidator<Car>
    {
        public CreateCarValidator()
        {
            RuleFor(x => x.Model).NotEmpty().WithMessage("Model Alanını Boş Geçemezsiniz");
            RuleFor(x => x.CarCategoryID).NotEmpty().WithMessage("Car Categori id Alanını Boş Geçemezsiniz");
            RuleFor(x => x.BrandID).NotEmpty().WithMessage("Brand id Alanını Boş Geçemezsiniz");
            RuleFor(x => x.CarStatusID).NotEmpty().WithMessage("Car Status id Alanını Boş Geçemezsiniz");
            RuleFor(x => x.Model).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.Model).MaximumLength(20).WithMessage("Lütfen en faz 20 karakter girişi yapınız");
        }
    }
}
