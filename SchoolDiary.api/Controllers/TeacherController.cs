using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly TeacherService TeacherService;

        public TeacherController(TeacherService teacherService)
        {
            TeacherService = teacherService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeachers()
        {
            var teachers = await TeacherService.GetAllTeacher();

            return Ok(teachers);
        }

        [HttpPost]
        public async Task<IActionResult> AddTeacher(TeacherViewModel teacher)
        {
            await TeacherService.AddTeacher(teacher);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> ChangeTeacher(int id, TeacherViewModel teacher)
        {
            await TeacherService.ChangeTeacher(id, teacher);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            await TeacherService.DeleteTeacher(id);

            return Ok();
        }
    }
}
