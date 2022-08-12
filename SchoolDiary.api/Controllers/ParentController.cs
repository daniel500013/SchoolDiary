using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolDiary.api.Dto;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Tutor,LocalAdmin,Admin")]
    public class ParentController : ControllerBase
    {
        private readonly ParentService ParentService;

        public ParentController(ParentService parentService)
        {
            ParentService = parentService;
        }

        /// <summary>
        /// Return list of parents
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllParents()
        {
            var parents = await ParentService.GetAllParents();

            return Ok(parents);
        }

        [HttpGet]
        [Route("{uuid:Guid}")]
        public async Task<IActionResult> GetUserParents(Guid uuid)
        {
            var parents = await ParentService.GetUserParents(uuid);

            return Ok(parents);
        }

        /// <summary>
        /// Add parent to diary
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Role
        ///     {
        ///        "firstName": "Tom", - Parent first name
        ///        "lastName": "Jones", - Parent last name
        ///        "email": "tom.jones@gmail.com", - Parent email
        ///        "phone": "123456789" - Parent phone number
        ///     }
        ///
        /// </remarks>
        [HttpPost]
        public async Task<IActionResult> AddParent([FromBody]ParentDto parent)
        {
            await ParentService.CreateParent(parent);

            return Ok();
        }

        /// <summary>
        /// Modify parent specify by id
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Role/{id}
        ///     {
        ///        "firstName": "Tom", - Parent first name
        ///        "lastName": "Jones", - Parent last name
        ///        "email": "tom.jones@gmail.com", - Parent email
        ///        "phone": "123456789" - Parent phone number
        ///     }
        ///
        /// </remarks>
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ChangeParent(int id, [FromBody]ParentDto parent)
        {
            await ParentService.ChangeParent(id, parent);

            return Ok();
        }

        /// <summary>
        /// Remove parent from diary by id
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /Role/{id}
        ///     {
        ///        "id": 1, - id of parent whose you want to remove
        ///     }
        ///
        /// </remarks>
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteParent(int id)
        {
            await ParentService.DeleteParent(id);

            return Ok();
        }
    }
}
