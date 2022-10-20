using EntityFramework.DTOs;

namespace EntityFramework.Services.Interfaces
{
    public interface IStudentService
    {
        AddStudentResponse Create(AddStudentRequest createModel);
        IEnumerable<GetStudentResponse> GetAll();
        GetStudentResponse Get(int id);
        UpdateStudentResponse Update(int id, UpdateStudentRequest updateStudent);
        bool Delete(int id);
    }
}