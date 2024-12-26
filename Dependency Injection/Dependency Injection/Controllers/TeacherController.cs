using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Dependency_Injection.Models;

namespace Dependency_Injection.Controllers
{
    [ApiController]// Bu sınıfın bir API controller olduğunu belirtir
    [Route("api/[controller]")]// URL rotasını belirler - "TeacherController" için "/Teacher" olur
    public class TeacherController : ControllerBase
    {

        private readonly ClassRoom _clasroom;

        public TeacherController(ClassRoom classRoom)
        {
            _clasroom = classRoom;
        }

        [HttpGet]
        public IActionResult GetTeacherInfo()
        {
            return Ok(_clasroom.GetTeacherInfo());
        }

    }
}
