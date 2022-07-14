using Microsoft.AspNetCore.Identity;
using SchoolDiary.api.ViewModel;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SchoolDiary.api.Service
{
    public class AccountService
    {
        private readonly DiaryDbContext DiaryDbContext;
        private readonly IPasswordHasher<LoginViewModel> PasswordHasher;
        private readonly JwtData Auth;

        public AccountService(DiaryDbContext diaryDbContext, IPasswordHasher<LoginViewModel> passwordHasher, JwtData auth)
        {
            DiaryDbContext = diaryDbContext;
            PasswordHasher = passwordHasher;
            Auth = auth;
        }

        public async Task<List<PersonViewModel>> GetAllUsers()
        {
            var users = await DiaryDbContext.Person.ToListAsync();

            var PersonViewModel = new List<PersonViewModel>();

            for (int i = 0; i < users.Count; i++)
            {
                PersonViewModel.Add(new PersonViewModel()
                {
                    UserUUID = users[i].UserUUID,
                    FirstName = users[i].FirstName,
                    LastName = users[i].LastName,
                    Address = users[i].Address,
                    City = users[i].City,
                    Email = users[i].Email,
                    Phone = users[i].Phone,
                    ZipCode = users[i].ZipCode,
                });
            }

            return PersonViewModel;
        }

        public async Task Register(LoginViewModel User)
        {
            if (User is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var EmailValidation = new EmailAddressAttribute().IsValid(User.Email);

            if (!EmailValidation)
            {
                throw new InvalidDataException("Wrong email format");
            }

            var EmailExist = await DiaryDbContext.Person
                .Where(x => x.Email == User.Email)
                .ToListAsync();

            if (EmailExist.Count >= 1)
            {
                throw new ArgumentNullException("Email already exist");
            }

            var PasswordHash = PasswordHasher.HashPassword(User, User.Password);

            var UserUUID = Guid.NewGuid();

            await DiaryDbContext.Person.AddAsync(new Model.Person()
            {
                UserUUID = UserUUID,
                Email = User.Email,
                PasswordHash = PasswordHash
            });

            await DiaryDbContext.PersonRole.AddAsync(new PersonRole()
            {
                FK_UserUUID = UserUUID,
                FK_RoleID = 1
            });

            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task<string> Login(LoginViewModel UserModel)
        {
            if (UserModel is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var User = await DiaryDbContext.Person
                .Include(x => x.Roles)
                .ThenInclude(x => x.Role)
                .SingleOrDefaultAsync(x => x.Email == UserModel.Email);

            if (User is null)
            {
                throw new ArgumentNullException("Invalid data");
            }

            var Password = PasswordHasher.VerifyHashedPassword(UserModel, User.PasswordHash, UserModel.Password);

            if (Password == PasswordVerificationResult.Failed)
            {
                throw new ArgumentOutOfRangeException("Invalid email or password");
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, User.UserUUID.ToString()),
                new Claim(ClaimTypes.Name, User.Email)
            };

            foreach (var role in User.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.Role.Name));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Auth.Key));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddHours(10);

            var token = new JwtSecurityToken(Auth.Issuer,
                Auth.Issuer,
                claims,
                expires: expires,
                signingCredentials: cred);

            var tokenHandler = new JwtSecurityTokenHandler();

            return tokenHandler.WriteToken(token);
        }
    }
}
