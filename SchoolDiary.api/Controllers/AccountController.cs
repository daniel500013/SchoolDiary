using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolDiary.api.Service;
using SchoolDiary.api.ViewModel;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AccountService AccountService;

        public AccountController(AccountService AccountService)
        {
            this.AccountService = AccountService;
        }

        /// <summary>
        /// Return all users
        /// </summary>
        [HttpGet]
        [Authorize(Roles = "LocalAdmin,Admin")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await AccountService.GetAllUsers();

            return Ok(users);
        }

        /// <summary>
        /// Register user in diary
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Register
        ///     {
        ///        "email": "admin@admin.com", - user email to register/login
        ///        "password": "admin" - user password
        ///     }
        ///
        /// </remarks>
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] LoginViewModel model)
        {
            await AccountService.Register(model);

            return Ok();
        }

        /// <summary>
        /// Login users and authenticate by return JWT token
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Login
        ///     {
        ///        "email": "admin@admin.com", - user email to register/login
        ///        "password": "admin" - user password
        ///     }
        ///
        /// </remarks>
        [HttpPost]
        [Produces("application/json")]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            var token = await AccountService.Login(model);

            return Ok(token);
        }
    }
}
