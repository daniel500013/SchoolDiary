using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolDiary.api.Dto;

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

        /// <summary>
        /// Return list of grades
        /// </summary>
        [Authorize(Roles = "LocalAdmin,Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllGrades()
        {
            var grades = await GradeService.GetAllGrades();

            return Ok(grades);
        }

        /// <summary>
        /// Create grade in diary
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Grade
        ///     {
        ///        "gradeValue": 5, - Grade value 
        ///        "weight": 2, - Weight of grade
        ///        "description": "History of rome" - Description of grade
        ///     }
        ///
        /// </remarks>
        [Authorize(Roles = "Teacher,Tutor,LocalAdmin,Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateGrade([FromBody]GradeDto grade)
        {
            await GradeService.CreateGrade(grade);

            return Ok();
        }

        /// <summary>
        /// Remove grade from diary
        /// </summary>
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
