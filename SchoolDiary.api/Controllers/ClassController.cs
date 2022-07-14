using Microsoft.AspNetCore.Http;
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

        [HttpGet]
        public async Task<IActionResult> GetAllClass()
        {
            var Classes = await ClassService.GetAllClass();

            return Ok(Classes);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClass(ClassViewModel Class)
        {
            await ClassService.CreateClass(Class);

            return Ok();
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> PutClass(int id, ClassViewModel Class)
        {
            await ClassService.ChangeClass(id, Class);

            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteClass(int id)
        {
            await ClassService.DeleteClass(id);

            return Ok();
        }
    }
}
