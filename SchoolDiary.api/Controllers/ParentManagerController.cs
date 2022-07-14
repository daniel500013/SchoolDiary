using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentManagerController : ControllerBase
    {
        private readonly ParentManagerService ParentManagerService;

        public ParentManagerController(ParentManagerService parentManagerService)
        {
            ParentManagerService = parentManagerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPersonParent()
        {
            var paretns = await ParentManagerService.GetAllPersonParent();

            return Ok(paretns);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePersonParent(Guid UserUUID, int ParentID)
        {
            await ParentManagerService.AssignParentToUser(UserUUID, ParentID);

            return Ok();
        }

        [HttpPost]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangePersonParent(int id, int ParentID)
        {
            await ParentManagerService.ChangeUserParent(id, ParentID);

            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeletePersonParent(int id)
        {
            await ParentManagerService.DeleteParentFromUser(id);

            return Ok();
        }
    }
}
