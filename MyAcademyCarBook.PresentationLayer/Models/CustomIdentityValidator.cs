using Microsoft.AspNetCore.Identity;

namespace MyAcademyCarBook.PresentationLayer.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresLower",
                Description = "Lütfen en az bir tane küçük harf giriniz"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUppe",
                Description = "Lütfen en az bir tane büyük harf giriniz"
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresDigit",
                Description = "Lütfen en az bir tane rakam harf giriniz"
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description = $"Lütfen en az {length} karakter giriş yapınız"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Lütfen en az 1 tane sembol giriş yapınız"
            };
        }
    }
}
