using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkManagerController : ControllerBase
    {
        private readonly MarkManagerService MarkManagerService;
        
        public MarkManagerController(MarkManagerService markManagerService)
        {
            MarkManagerService = markManagerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAssignMarkToUser()
        {
            var marks = await MarkManagerService.GetAll();

            return Ok(marks);
        }

        [HttpPost]
        public async Task<IActionResult> AssignMarkToUser(LessonMarkViewModel mark)
        {
            await MarkManagerService.AssignMark(mark);

            return Ok();
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeAssignMarkToUser(int id, LessonMarkViewModel mark)
        {
            await MarkManagerService.ChangeAssign(id, mark);

            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteAssignMarkToUser(int id)
        {
            await MarkManagerService.DeleteAssign(id);

            return Ok();
        }
    }
}
