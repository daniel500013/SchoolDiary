using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolDiary.api.Dto;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MarkController : ControllerBase
    {
        private readonly MarkService MarkService;

        public MarkController(MarkService markService)
        {
            MarkService = markService;
        }

        /// <summary>
        /// Returns list of marks
        /// </summary>
        [Authorize(Roles = "Parent,Tutor,LocalAdmin,Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllMarks()
        {
            var marks = await MarkService.GetAllMarks();

            return Ok(marks);
        }

        /// <summary>
        /// Returns list of marks by class
        /// </summary>
        [Authorize(Roles = "Parent,Teacher,Tutor,LocalAdmin,Admin")]
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetClassMarks(int id)
        {
            var marks = await MarkService.GetClassMarks(id);

            return Ok(marks);
        }

        /// <summary>
        /// Returns list of user marks specify by uuid
        /// </summary>
        [Authorize(Roles = "Student,Parent,Tutor,LocalAdmin,Admin")]
        [HttpGet]
        [Route("{uuid:Guid}")]
        public async Task<IActionResult> GetUserMarks(Guid uuid)
        {
            var marks = await MarkService.GetUserMarks(uuid);

            return Ok(marks);
        }

        /// <summary>
        /// Create mark in diary
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Mark
        ///     {
        ///        "present": true - set person present
        ///     }
        ///
        /// </remarks>
        [Authorize(Roles = "Teacher,Tutor,LocalAdmin,Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateMark([FromBody]MarkDto mark)
        {
            await MarkService.AddMark(mark);

            return Ok();
        }

        /// <summary>
        /// Returns list of user to update
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Mark
        ///     {
        ///        "Lesson": "Physics" - Lesson whos you want to change mark
        ///        "Day": 1 - Day of lesson whos you want to change
        ///        "Hour": 3 - Hour of lesson whos you want to change
        ///        "Class": 1 - Class where you want to change marks
        ///        "Date": 2018-01-01H00:00:00 - Date where you want change marks
        ///     }
        ///
        /// </remarks>
        [Authorize(Roles = "Teacher,Tutor,LocalAdmin,Admin")]
        [HttpPut]
        public async Task<IActionResult> ChangeMark([FromBody]MarkChangeDto changeMarkDto)
        {
            var Users = await MarkService.GetChangeMarksUsers(changeMarkDto);

            return Ok(Users);
        }

        /// <summary>
        /// Change mark in diary by id
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Mark
        ///     {
        ///        "present": true - set person present
        ///     }
        ///
        /// </remarks>
        [Authorize(Roles = "Teacher,Tutor,LocalAdmin,Admin")]
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeMark(int id, [FromBody]MarkDto markDto)
        {
            await MarkService.ChangeMark(id, markDto);

            return Ok();
        }

        /// <summary>
        /// Remove mark from diary by specify id
        /// </summary>
        [Authorize(Roles = "LocalAdmin,Admin")]
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteMark(int id)
        {
            await MarkService.DeleteMark(id);

            return Ok();
        }
    }
}
