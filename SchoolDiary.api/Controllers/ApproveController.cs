using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ApproveController : ControllerBase
    {
        private readonly ApproveService ApproveService;

        public ApproveController(ApproveService approveService)
        {
            ApproveService = approveService;
        }

        /// <summary>
        /// Return list of approves
        /// </summary>
        [Authorize(Roles = "Tutor,LocalAdmin,Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllApproves()
        {
            var approves = await ApproveService.GetAllApprove();

            return Ok(approves);
        }

        /// <summary>
        /// Create Approve in diary
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Approve
        ///     {
        ///        "positive": true, - Positivity of approve
        ///        "description": "Approve desc" - Approve description
        ///     }
        ///
        /// </remarks>
        [Authorize(Roles = "Teacher,Tutor,LocalAdmin,Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateApprove(ApproveViewModel approve)
        {
            await ApproveService.CreateApprove(approve);

            return Ok();
        }

        /// <summary>
        /// Change Approve in diary by specify id
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Approve/{id}
        ///     {
        ///        "positive": true, - Positivity of approve
        ///        "description": "Approve desc" - Approve description
        ///     }
        ///
        /// </remarks>
        [Authorize(Roles = "Teacher,Tutor,LocalAdmin,Admin")]
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeApprove(int id, ApproveViewModel approve)
        {
            await ApproveService.ChangeApprove(id, approve);

            return Ok();
        }

        /// <summary>
        /// Remove Approve from diary by specify id
        /// </summary>
        [Authorize(Roles = "Teacher,Tutor,LocalAdmin,Admin")]
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteApprove(int id)
        {
            await ApproveService.DeleteApprove(id);

            return Ok();
        }
    }
}
