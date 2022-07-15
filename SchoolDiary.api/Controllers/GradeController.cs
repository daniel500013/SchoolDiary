using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GradeController : ControllerBase
    {
        private readonly GradeService GradeService;

        public GradeController(GradeService gradeService)
        {
            GradeService = gradeService;
        }

        [Authorize(Roles = "LocalAdmin,Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllGrades()
        {
            var grades = await GradeService.GetAllGrades();

            return Ok(grades);
        }

        [Authorize(Roles = "Teacher,Tutor,LocalAdmin,Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateGrade(GradeViewModel grade)
        {
            await GradeService.CreateGrade(grade);

            return Ok();
        }

        [Authorize(Roles = "Teacher,Tutor,LocalAdmin,Admin")]
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteGrade(int id)
        {
            await GradeService.DeleteGrade(id);

            return Ok();
        }
    }
}
