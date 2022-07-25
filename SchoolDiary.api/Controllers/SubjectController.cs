using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var subjects = await SubjectService.GetAllSubjects();

            return Ok(subjects);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var subjects = await SubjectService.GetSubjectById(id);

            return Ok(subjects);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SubjectViewModel subject)
        {
            await SubjectService.CreateSubject(subject);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] SubjectViewModel subject)
        {
            await SubjectService.PutSubject(id, subject);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await SubjectService.DeleteSubject(id);

            return Ok();
        }
    }
}
