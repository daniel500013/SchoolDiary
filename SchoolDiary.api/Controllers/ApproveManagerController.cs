using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApproveManagerController : ControllerBase
    {
        private readonly ApproveManagerService ApproveManagerService;
        
        public ApproveManagerController(ApproveManagerService approvemanagerService)
        {
            ApproveManagerService = approvemanagerService;
        }

        /// <summary>
        /// Return Lesson-Approve List
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllLessonApprove()
        {
            var approves = await ApproveManagerService.GetAllLessonApprove();

            return Ok(approves);
        }

        /// <summary>
        /// Assign Lesson-Approve in diary
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /ApproveManager
        ///     {
        ///        "fK_LessonID": 1, - Lesson ID to assign approve
        ///        "fK_ApproveID": 2 - Approve ID whos you want to assign
        ///     }
        ///
        /// </remarks>
        [HttpPost]
        public async Task<IActionResult> AssignApproveToLesson(ApproveManagerViewModel approve)
        {
            await ApproveManagerService.AssignApproveToLesson(approve);

            return Ok();
        }

        /// <summary>
        /// Change Lesson-Approve in diary
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /ApproveManager/{id}
        ///     {
        ///        "fK_LessonID": 1, - Lesson ID to assign approve
        ///        "fK_ApproveID": 2 - Approve ID whos you want to assign
        ///     }
        ///
        /// </remarks>
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeAssignApproveToLesson(int id, ApproveManagerViewModel approve)
        {
            await ApproveManagerService.ChangeAssignApproveToLesson(id, approve);

            return Ok();
        }

        /// <summary>
        /// Delete Lesson-Approve from diary
        /// </summary>
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteAssignApproveToLesson(int id)
        {
            await ApproveManagerService.DeleteAssignApproveToLesson(id);

            return Ok();
        }
    }
}
