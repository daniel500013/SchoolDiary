using Microsoft.AspNetCore.Identity;
using SchoolDiary.api.Dto;
using SchoolDiary.api.Exceptions;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SchoolDiary.api.Service
{
    public class AccountService
    {
        private readonly DiaryDbContext DiaryDbContext;
        private readonly IPasswordHasher<LoginDto> PasswordHasher;
        private readonly JwtData Auth;

        public AccountService(DiaryDbContext diaryDbContext, IPasswordHasher<LoginDto> passwordHasher, JwtData auth)
        {
            DiaryDbContext = diaryDbContext;
            PasswordHasher = passwordHasher;
            Auth = auth;
        }

        public async Task<List<PersonViewModel>> GetAllUsers()
        {
            var users = await DiaryDbContext.Person.ToListAsync();

            return users.Select(t => new PersonViewModel()
                {
                    UserUUID = t.UserUUID,
                    FirstName = t.FirstName,
                    LastName = t.LastName,
                    Address = t.Address,
                    City = t.City,
                    Email = t.Email,
                    Phone = t.Phone,
                    ZipCode = t.ZipCode,
                })
                .ToList();
        }

        public async Task Register(LoginDto user)
        {
            if (user is null)
            {
                throw new Exceptions.InvalidDataException("Invalid data");
            }

            var emailValidation = new EmailAddressAttribute().IsValid(user.Email);

            if (!emailValidation)
            {
                throw new InvalidEmailException("Wrong email format");
            }

            var emailExist = await DiaryDbContext.Person
                .Where(x => x.Email == user.Email)
                .ToListAsync();

            if (emailExist.Count >= 1)
            {
                throw new InvalidEmailException("Email already exist");
            }

            var passwordHash = PasswordHasher.HashPassword(user, user.Password);

            var userUuid = Guid.NewGuid();

            await DiaryDbContext.Person.AddAsync(new Model.Person()
            {
                UserUUID = userUuid,
                Email = user.Email,
                PasswordHash = passwordHash
            });

            await DiaryDbContext.PersonRole.AddAsync(new PersonRole()
            {
                FK_UserUUID = userUuid,
                FK_RoleID = 1
            });

            await DiaryDbContext.PersonClass.AddAsync(new PersonClass()
            {
                FK_UserUUID = userUuid,
                FK_ClassID = 1
            });

            await DiaryDbContext.SaveChangesAsync();
        }

        public async Task<string> Login(LoginDto userModel)
        {
            if (userModel is null)
            {
                throw new Exceptions.InvalidDataException("Invalid data");
            }

            var user = await DiaryDbContext.Person
                .Include(x => x.Roles)!
                .ThenInclude(x => x.Role)
                .SingleOrDefaultAsync(x => x.Email == userModel.Email);

            if (user is null)
            {
                throw new Exceptions.InvalidDataException("Invalid data");
            }

            var password = PasswordHasher.VerifyHashedPassword(userModel, user.PasswordHash, userModel.Password);

            if (password == PasswordVerificationResult.Failed)
            {
                throw new LoginException("Invalid email or password");
            }

            var userClass = await DiaryDbContext.PersonClass
                .Include(x => x.Class)
                .SingleOrDefaultAsync(x => x.FK_UserUUID == user.UserUUID);

            if (userClass is null)
            {
                throw new LoginException("No class assignment");
            }

            var claims = new List<Claim>()
            {
                new Claim("uuid", user.UserUUID.ToString()),
                new Claim(ClaimTypes.Name, user.Email),
                new Claim("Class", userClass.Class?.ClassNumber.ToString() ?? string.Empty)
            };

            foreach (var role in user.Roles)
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
