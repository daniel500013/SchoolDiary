using Microsoft.AspNetCore.Identity;
using SchoolDiary.api.ViewModel;
using System.ComponentModel.DataAnnotations;

namespace SchoolDiary.api.Service
{
    public class AccountService
    {
        private readonly DiaryDbContext DiaryDbContext;
        private readonly IPasswordHasher<LoginViewModel> PasswordHasher;

        public AccountService(DiaryDbContext diaryDbContext, IPasswordHasher<LoginViewModel> passwordHasher)
        {
            this.DiaryDbContext = diaryDbContext;
            this.PasswordHasher = passwordHasher;
        }

        public async Task Register(LoginViewModel User)
        {
            if (User is null)
            {
                throw new ArgumentNullException("Invalid login data");
            }

            var EmailValidation = new EmailAddressAttribute().IsValid(User.Email);

            if (!EmailValidation)
            {
                throw new InvalidDataException("Wrong email format");
            }

            var PasswordHash = PasswordHasher.HashPassword(User, User.Password);

            await DiaryDbContext.Person.AddAsync(new Model.Person()
            {
                UserUUID = Guid.NewGuid(),
                Email = User.Email,
                PasswordHash = PasswordHash
            });

            await DiaryDbContext.SaveChangesAsync();
        }
    }
}
