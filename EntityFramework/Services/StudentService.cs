using EntityFramework.DTOs;
using EntityFramework.Models;
using EntityFramework.Repositories.Interfaces;
using EntityFramework.Services.Interfaces;

namespace EntityFramework.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public AddStudentResponse Create(AddStudentRequest createModel)
        {
            var createStudent = new Student
            {
                FirstName = createModel.FirstName,
                LastName = createModel.LastName,
                City = createModel.City,
                State = createModel.State
            };

            var student = _studentRepository.Create(createStudent);

            _studentRepository.SaveChange();

            return new AddStudentResponse
            {
                Id = student.Id,
                FirstName = student.FirstName
            };
        }
    }
}