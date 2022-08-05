﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolDiary.api.Dto;

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

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetUsersByClass(int id)
        {
            var users = await ClassManagerService.GetUsersByClass(id);

            return Ok(users);
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
        public async Task<IActionResult> AssignUserToClass(ClassManagerDto classManagerDto)
        {
            await ClassManagerService.AssignPersonToClass(classManagerDto);

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
        public async Task<IActionResult> ChangeUserClass(int id, ClassManagerDto classManagerDto)
        {
            await ClassManagerService.ChangePersonClass(id, classManagerDto);

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
