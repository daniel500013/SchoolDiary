using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        public GradeController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetAllGrades()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateGrade()
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> ChangeGrade()
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteGrade()
        {
            return Ok();
        }
    }
}
