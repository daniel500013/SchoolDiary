using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolDiary.api.Service;

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

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            AccountService.Register();

            return Ok();
        }
    }
}
