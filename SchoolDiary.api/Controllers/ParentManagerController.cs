using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentManagerController : ControllerBase
    {
        private readonly ParentManagerService ParentManagerService;

        public ParentManagerController(ParentManagerService parentManagerService)
        {
            ParentManagerService = parentManagerService;
        }

        /// <summary>
        /// Return list of Person Parent correlation
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllPersonParent()
        {
            var paretns = await ParentManagerService.GetAllPersonParent();

            return Ok(paretns);
        }

        /// <summary>
        /// Create new person-parent correlation
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /ParentManager
        ///     {
        ///        "UserUUID": "sample-uuid" - User uuid where you want to assign parent
        ///        "ParentID": 3 - Parent id whos you want to assign to user
        ///     }
        ///
        /// </remarks>
        [HttpPost]
        public async Task<IActionResult> CreatePersonParent(Guid UserUUID, int ParentID)
        {
            await ParentManagerService.AssignParentToUser(UserUUID, ParentID);

            return Ok();
        }

        /// <summary>
        /// Change person-parent correlation
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /ParentManager/{id}
        ///     {
        ///        "id": 5 - id of relation person-parent whos you want to change
        ///        "ParentID": 3 - Parent id whos you want to change
        ///     }
        ///
        /// </remarks>
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangePersonParent(int id, int ParentID)
        {
            await ParentManagerService.ChangeUserParent(id, ParentID);

            return Ok();
        }

        /// <summary>
        /// Delete person-parent correlation
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /ParentManager/{id}
        ///     {
        ///        "id": 5 - id of relation person-parent whos you want to delete
        ///     }
        /// </remarks>
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeletePersonParent(int id)
        {
            await ParentManagerService.DeleteParentFromUser(id);

            return Ok();
        }
    }
}
