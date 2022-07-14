using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassManagerController : ControllerBase
    {
        private readonly ClassManagerService ClassManagerService;

        public ClassManagerController(ClassManagerService classManagerService)
        {
            ClassManagerService = classManagerService;
        }

        /// <summary>
        /// Return Person-Class List
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllUserClassRelation()
        {
            var userClasses = await ClassManagerService.GetPersonClass();

            return Ok(userClasses);
        }

        /// <summary>
        /// Assign person to class
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> AssignUserToClass(Guid UserUUID, int ClassID)
        {
            await ClassManagerService.AssignPersonToClass(UserUUID, ClassID);

            return Ok();
        }

        /// <summary>
        /// Change person class
        /// </summary>
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeUserClass(Guid UserUUID, int id, int ClassID)
        {
            await ClassManagerService.ChangePersonClass(UserUUID, id, ClassID);

            return Ok();
        }

        /// <summary>
        /// Delete person from class
        /// </summary>
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeUserClass(int id)
        {
            await ClassManagerService.RemovePersonFromClass(id);

            return Ok();
        }
    }
}
