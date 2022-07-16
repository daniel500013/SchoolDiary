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

        /// <summary>
        /// Return list of Mark assign to lessons
        /// </summary>
        [Authorize(Roles = "LocalAdmin,Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllAssignMarkToUser()
        {
            var marks = await MarkManagerService.GetAll();

            return Ok(marks);
        }

        /// <summary>
        /// Assign Mark to lesson
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /MarkManager
        ///     {
        ///        "fK_LessonID": 1, - ID of lesson whos you want to assign
        ///        "fK_MarkID": 2 - ID of mark whos you want to assign
        ///     }
        ///
        /// </remarks>
        [Authorize(Roles = "Teacher,Tutor,LocalAdmin,Admin")]
        [HttpPost]
        public async Task<IActionResult> AssignMarkToUser(LessonMarkViewModel mark)
        {
            await MarkManagerService.AssignMark(mark);

            return Ok();
        }

        /// <summary>
        /// Change mark assign to lesson
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /MarkManager/{id}
        ///     {
        ///        "fK_LessonID": 1, - ID of lesson whos you want to assign
        ///        "fK_MarkID": 2 - ID of mark whos you want to assign
        ///     }
        ///
        /// </remarks>
        [Authorize(Roles = "Teacher,Tutor,LocalAdmin,Admin")]
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeAssignMarkToUser(int id, LessonMarkViewModel mark)
        {
            await MarkManagerService.ChangeAssign(id, mark);

            return Ok();
        }

        /// <summary>
        /// Delete mark assign
        /// </summary>
        [Authorize(Roles = "Teacher,Tutor,LocalAdmin,Admin")]
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteAssignMarkToUser(int id)
        {
            await MarkManagerService.DeleteAssign(id);

            return Ok();
        }
    }
}
