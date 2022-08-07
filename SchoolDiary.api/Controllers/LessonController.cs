using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolDiary.api.Dto;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LessonController : ControllerBase
    {
        private readonly LessonService LessonService;

        public LessonController(LessonService lessonService)
        {
            LessonService = lessonService;
        }

        /// <summary>
        /// Return list of lessons
        /// </summary>
        [Authorize(Roles = "LocalAdmin,Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllLessons()
        {
            var lessons = await LessonService.GetAllLessons();

            return Ok(lessons);
        }

        /// <summary>
        /// Return list of lessons for class specify by id
        /// </summary>
        [Authorize(Roles = "Student,Parent,Teacher,Tutor,LocalAdmin,Admin")]
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetClassLessons(int id)
        {
            var lessons = await LessonService.GetClassLessons(id);

            return Ok(lessons);
        }

        /// <summary>
        /// Create lesson in diary
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Lesson
        ///     {
        ///        "name": "Physics", - Name of lesson
        ///        "day": 1, - Day of lesson, 1 - Monday, 5 - Friday 
        ///        "hour": 3 - Hour of lesson
        ///     }
        ///
        /// </remarks>
        [Authorize(Roles = "LocalAdmin,Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateLesson([FromBody]LessonDto lesson)
        {
            await LessonService.CreateLesson(lesson);

            return Ok();
        }

        /// <summary>
        /// Change lesson in diary by specify id
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Lesson/{id}
        ///     {
        ///        "name": "Physics", - Name of lesson
        ///        "day": 1, - Day of lesson, 1 - Monday, 5 - Friday 
        ///        "hour": 3 - Hour of lesson
        ///     }
        ///
        /// </remarks>
        [Authorize(Roles = "LocalAdmin,Admin")]
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeLesson(int id, [FromBody]LessonDto lesson)
        {
            await LessonService.ChangeLesson(id, lesson);

            return Ok();
        }

        /// <summary>
        /// Delete lesson from diary by specify id
        /// </summary>
        [Authorize(Roles = "LocalAdmin,Admin")]
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteLesson(int id)
        {
            await LessonService.DeleteLesson(id);

            return Ok();
        }
    }
}
