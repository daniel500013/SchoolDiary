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
        /// Returns list of marks
        /// </summary>
        [Authorize(Roles = "Parent,Tutor,LocalAdmin,Admin")]
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetClassMarks(int id)
        {
            var marks = await MarkService.GetClassMarks(id);

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
        [Authorize(Roles = "Tutor,LocalAdmin,Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateMark([FromBody]MarkDto mark)
        {
            await MarkService.AddMark(mark);

            return Ok();
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
        [Authorize(Roles = "Tutor,LocalAdmin,Admin")]
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeMark(int id, [FromBody]MarkDto mark)
        {
            await MarkService.ChangeMark(id, mark);

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
