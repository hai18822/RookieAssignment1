using EntityFramework.DTOs;
using EntityFramework.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public AddStudentResponse Add([FromBody] AddStudentRequest addRequest){
            return _studentService.Create(addRequest);
        }

        [HttpGet]
        public IEnumerable<GetStudentResponse> GetAll(){
            return _studentService.GetAll();
        }

        [HttpPut("UpdateStudent/{id}")]
        public UpdateStudentResponse? Update(int id, [FromBody] UpdateStudentRequest requestModel)
        {
            return _studentService.Update(id, requestModel);
        }

        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
            return _studentService.Delete(id);
        }
    }
}