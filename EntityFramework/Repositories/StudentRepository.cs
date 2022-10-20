using EntityFramework.Models;
using EntityFramework.Repositories.Interfaces;

namespace EntityFramework.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(StudentContext context) : base(context)
        {
        }
    }
}