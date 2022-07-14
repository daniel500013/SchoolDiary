using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "LocalAdmin,Admin")]
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
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /ClassManager
        ///     {
        ///        "UserUUID": "sample-uuid", - UUID of person whos you want to assign class
        ///        "ClassID": 1 - ClassID of class whose you want to assign to user
        ///     }
        ///
        /// </remarks>
        [HttpPost]
        public async Task<IActionResult> AssignUserToClass(Guid UserUUID, int ClassID)
        {
            await ClassManagerService.AssignPersonToClass(UserUUID, ClassID);

            return Ok();
        }

        /// <summary>
        /// Change person class
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /ClassManager/{id}
        ///     {
        ///        "UserUUID": "sample-uuid", - UUID of person whos you want to change
        ///        "id": 1 - ID whos you want to change
        ///        "ClassID": 1 - New ID whos you want to assign to user
        ///     }
        ///
        /// </remarks>
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
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /ClassManager/{id}
        ///     {
        ///        "id": 1 - ID of record whose you want to delete
        ///     }
        ///
        /// </remarks>
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeUserClass(int id)
        {
            await ClassManagerService.RemovePersonFromClass(id);

            return Ok();
        }
    }
}
