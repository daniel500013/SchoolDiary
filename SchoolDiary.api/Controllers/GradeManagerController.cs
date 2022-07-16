using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeManagerController : ControllerBase
    {
        private readonly GradeManagerService GradeManagerService;
        public GradeManagerController(GradeManagerService gradeManagerService)
        {
            GradeManagerService = gradeManagerService;
        }

        /// <summary>
        /// Return assign between grade and lesson
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllLessonGrades()
        {
            var grades = await GradeManagerService.GetAllUsersGrades();

            return Ok(grades);
        }

        /// <summary>
        /// Create Grade-Lesson assign in diary
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> AssignGradeToLesson(GradeManagerViewModel grade)
        {
            await GradeManagerService.AssignGradeToLesson(grade);

            return Ok();
        }

        /// <summary>
        /// Change Grade-Lesson assign in diary by id
        /// </summary>
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeAssignGradeToLesson(int id, GradeManagerViewModel grade)
        {
            await GradeManagerService.ChangeAssignGradeToLesson(id, grade);

            return Ok();
        }

        /// <summary>
        /// Remove Grade-Lesson assign from diary
        /// </summary>
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteAssignGradeToLesson(int id)
        {
            await GradeManagerService.RemoveAssignGradeToLesson(id);

            return Ok();
        }
    }
}
