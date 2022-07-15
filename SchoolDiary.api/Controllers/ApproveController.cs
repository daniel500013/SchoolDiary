using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApproveController : ControllerBase
    {
        private readonly ApproveService ApproveService;

        public ApproveController(ApproveService approveService)
        {
            ApproveService = approveService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllApproves()
        {
            var approves = await ApproveService.GetAllApprove();

            return Ok(approves);
        }

        [HttpPost]
        public async Task<IActionResult> CreateApprove(ApproveViewModel approve)
        {
            await ApproveService.CreateApprove(approve);

            return Ok();
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeApprove(int id, ApproveViewModel approve)
        {
            await ApproveService.ChangeApprove(id, approve);

            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteApprove(int id)
        {
            await ApproveService.DeleteApprove(id);

            return Ok();
        }
    }
}
