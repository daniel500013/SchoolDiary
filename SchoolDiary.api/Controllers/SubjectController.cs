using Microsoft.AspNetCore.Mvc;
using SchoolDiary.api.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly SubjectService SubjectService;

        public SubjectController(SubjectService subjectService)
        {
            SubjectService = subjectService;
        }

        /// <summary>
        /// Return all subjects in diary
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var subjects = await SubjectService.GetAllSubjects();

            return Ok(subjects);
        }

        /// <summary>
        /// Return specify subjects in diary by specify ids
        /// </summary>
        [HttpGet("{Class}")]
        public async Task<IActionResult> Get(int Class)
        {
            var subjects = await SubjectService.GetSubjectByClass(Class);

            return Ok(subjects);
        }

        /// <summary>
        /// Create subject in diary
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Subject
        ///     {
        ///        "teacher": 1, - Teacher ID assigned to lesson
        ///        "class": 9, - Class ID assigned to lesson
        ///        "lesson": 4 - Lesson ID assigned to lesson
        ///     }
        ///
        /// </remarks>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]SubjectDto subject)
        {
            await SubjectService.CreateSubject(subject);

            return Ok();
        }

        /// <summary>
        /// Change subject in diary
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Subject/{id}
        ///     {
        ///        "teacher": 1, - Teacher ID assigned to lesson
        ///        "class": 9, - Class ID assigned to lesson
        ///        "lesson": 4 - Lesson ID assigned to lesson
        ///     }
        ///
        /// </remarks>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]SubjectDto subject)
        {
            await SubjectService.PutSubject(id, subject);

            return Ok();
        }

        /// <summary>
        /// Delete subject from diary
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await SubjectService.DeleteSubject(id);

            return Ok();
        }
    }
}
