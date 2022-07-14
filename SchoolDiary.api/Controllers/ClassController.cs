﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolDiary.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly ClassService ClassService;

        public ClassController(ClassService classService)
        {
            ClassService = classService;
        }

        /// <summary>
        /// Returns list of classes
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllClass()
        {
            var Classes = await ClassService.GetAllClass();

            return Ok(Classes);
        }

        /// <summary>
        /// Create class in diary
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Class
        ///     {
        ///        "classNumber": 1, - Number of class whose you want to add
        ///        "profile": "PZ", - Class profile
        ///        "description": "Sample description of class" - Class description
        ///     }
        ///
        /// </remarks>
        [HttpPost]
        public async Task<IActionResult> CreateClass(ClassViewModel Class)
        {
            await ClassService.CreateClass(Class);

            return Ok();
        }

        /// <summary>
        /// Change class in diary by specify id
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Class/{id}
        ///     {
        ///        "classNumber": 1, - Number of class whose you want to add
        ///        "profile": "PZ", - Class profile
        ///        "description": "Sample description of class" - Class description
        ///     }
        ///
        /// </remarks>
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> PutClass(int id, ClassViewModel Class)
        {
            await ClassService.ChangeClass(id, Class);

            return Ok();
        }

        /// <summary>
        /// Remove class from diary
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /Class/{id}
        ///     {
        ///        "id": 1, - ID of class whose you want to delete
        ///     }
        ///
        /// </remarks>
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteClass(int id)
        {
            await ClassService.DeleteClass(id);

            return Ok();
        }
    }
}