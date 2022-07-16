using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly LessonService LessonService;

        public LessonController(LessonService lessonService)
        {
            LessonService = lessonService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLessons()
        {
            var lessons = await LessonService.GetAllLessons();

            return Ok(lessons);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLesson(LessonViewModel lesson)
        {
            await LessonService.CreateLesson(lesson);

            return Ok();
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeLesson(int id, LessonViewModel lesson)
        {
            await LessonService.ChangeLesson(id, lesson);

            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteLesson(int id)
        {
            await LessonService.DeleteLesson(id);

            return Ok();
        }
    }
}
