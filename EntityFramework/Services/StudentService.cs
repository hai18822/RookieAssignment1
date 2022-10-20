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

            var student = _studentRepository.Create(createStudent);//luu vao db

            _studentRepository.SaveChange();//luu vao db

            return new AddStudentResponse
            {
                Id = student.Id,
                FirstName = student.FirstName
            };
        }

        public IEnumerable<GetStudentResponse> GetAll()
        {
            var list = _studentRepository.GetAll(x => true).Select(student => new GetStudentResponse
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                City = student.City,
                State = student.State
            });

            _studentRepository.SaveChange();

            return list;
        }

        public UpdateStudentResponse Update(int id, UpdateStudentRequest updateModel)
        {
            var student = _studentRepository.Get(student => student.Id == id);

            if (student == null) return null;

            student.FirstName = updateModel.FirstName;
            student.LastName = updateModel.LastName;
            student.City = updateModel.City;
            student.State = updateModel.State;

            var updateStudent = _studentRepository.Update(student);

            _studentRepository.SaveChange();

            return new UpdateStudentResponse
            {
                FirstName = updateStudent.FirstName,
                LastName = updateStudent.LastName,
                City = updateStudent.City,
                State = updateStudent.State
            };
        }
        public bool Delete(int id)
        {
            var deleteStudent = _studentRepository.Get(student => student.Id == id);

            if (deleteStudent == null) return false;

            bool isSucceeded = _studentRepository.Delete(deleteStudent);

            _studentRepository.SaveChange();

            return isSucceeded;
        }

        public GetStudentResponse Get(int id)
        {
            var student = _studentRepository.Get(student => student.Id == id);

            return new GetStudentResponse
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    City = student.City,
                    State = student.State
                };
        }
    }
}