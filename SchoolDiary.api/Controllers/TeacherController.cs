using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TeacherController : ControllerBase
    {
        private readonly TeacherService TeacherService;

        public TeacherController(TeacherService teacherService)
        {
            TeacherService = teacherService;
        }

        /// <summary>
        /// Returns list of teachers
        /// </summary>
        [Authorize(Roles = "Parent,Tutor,LocalAdmin,Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllTeachers()
        {
            var teachers = await TeacherService.GetAllTeacher();

            return Ok(teachers);
        }

        /// <summary>
        /// Add teacher to diary
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Teacher
        ///     {
        ///        "firstName": "Jon", - First name of teacher
        ///        "lastName": "Testman", - Last name of teacher
        ///        "gender": true, - Gernder of teacher. 1 - Male, 0 - Female
        ///        "email": "jon.testman@gmail.com", - Teacher email
        ///        "phone": "123456789" - Teacher phone
        ///     }
        ///
        /// </remarks>
        [Authorize(Roles = "LocalAdmin,Admin")]
        [HttpPost]
        public async Task<IActionResult> AddTeacher(TeacherViewModel teacher)
        {
            await TeacherService.AddTeacher(teacher);

            return Ok();
        }

        /// <summary>
        /// Change teacher information by specify id
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Teacher/{id}
        ///     {
        ///        "firstName": "Jon", - First name of teacher
        ///        "lastName": "Testman", - Last name of teacher
        ///        "gender": true, - Gernder of teacher. 1 - Male, 0 - Female
        ///        "email": "jon.testman@gmail.com", - Teacher email
        ///        "phone": "123456789" - Teacher phone
        ///     }
        ///
        /// </remarks>
        [Authorize(Roles = "LocalAdmin,Admin")]
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeTeacher(int id, TeacherViewModel teacher)
        {
            await TeacherService.ChangeTeacher(id, teacher);

            return Ok();
        }

        /// <summary>
        /// Delete teacher from diary by specify id
        /// </summary>
        [Authorize(Roles = "LocalAdmin,Admin")]
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            await TeacherService.DeleteTeacher(id);

            return Ok();
        }
    }
}
