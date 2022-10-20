using EntityFramework.DTOs;
using EntityFramework.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
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
    }
}