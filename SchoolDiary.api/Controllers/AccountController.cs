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

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(LoginViewModel model)
        {
            await AccountService.Register(model);

            return Ok();
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var token = await AccountService.Login(model);

            return Ok(token);
        }
    }
}
