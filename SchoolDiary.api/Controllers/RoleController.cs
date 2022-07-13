using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class RoleController : ControllerBase
    {
        private readonly RoleService RoleService;

        public RoleController(RoleService roleService)
        {
            RoleService = roleService;
        }

        /// <summary>
        /// Return list of roles
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = await RoleService.GetRoles();

            return Ok(roles);
        }

        /// <summary>
        /// Adds role to user
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Role
        ///     {
        ///        "UserUUID": "sample-uuid" - User uuid whose you want to change role
        ///        "RoleID": 3 - Role who's you want to assign to user
        ///     }
        ///
        /// </remarks>
        [HttpPost]
        public async Task<IActionResult> AssingRoleToUser(Guid UserUUID, int RoleID)
        {
            await RoleService.AssignUserRole(UserUUID, RoleID);

            return Ok();
        }

        /// <summary>
        /// Replace user role by another typed role
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Role/{id}
        ///     {
        ///        "id": 1 - Role whos you want to change
        ///        "UserUUID": "sample-uuid" - User uuid whose you want to change role
        ///        "NewRoleID": 3 - Role where you want to replace instead of old role
        ///     }
        ///
        /// </remarks>
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeRoleUser(int id, Guid UserUUID, int NewRoleID)
        {
            await RoleService.ChangeUserRole(UserUUID, id, NewRoleID);

            return Ok();
        }

        /// <summary>
        /// Delete user role
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /Role/{id}
        ///     {
        ///        "id": 1 - Role whos you want to delete
        ///        "UserUUID": "sample-uuid" - User uuid where you want to delete role
        ///     }
        ///
        /// </remarks>
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteRoleUser(int id, Guid UserUUID)
        {
            await RoleService.RemoveUserRole(UserUUID, id);

            return Ok();
        }
    }
}
