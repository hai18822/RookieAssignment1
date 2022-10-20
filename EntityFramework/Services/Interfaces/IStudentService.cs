using EntityFramework.DTOs;

namespace EntityFramework.Services.Interfaces
{
    public interface IStudentService
    {
        AddStudentResponse Create(AddStudentRequest createModel);
    }
}