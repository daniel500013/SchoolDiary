using Microsoft.AspNetCore.Identity;
using SchoolDiary.api.ViewModel;

namespace SchoolDiary.api.Service
{
    public class AccountService
    {
        private readonly DiaryDbContext diaryDbContext;
        private readonly IPasswordHasher<LoginViewModel> passwordHasher;

        public AccountService(DiaryDbContext diaryDbContext, IPasswordHasher<LoginViewModel> passwordHasher)
        {
            this.diaryDbContext = diaryDbContext;
            this.passwordHasher = passwordHasher;
        }

        public async Task Register(LoginViewModel login)
        {
            if (login is null)
            {
                throw new ArgumentNullException("Invalid login data");
            }

            var passwordHash = passwordHasher.HashPassword(login, login.Password);

            await diaryDbContext.Person.AddAsync(new Model.Person()
            {
                UserUUID = Guid.NewGuid(),
                Email = login.Email,
                PasswordHashed = passwordHash
            });

            await diaryDbContext.SaveChangesAsync();
        }
    }
}
