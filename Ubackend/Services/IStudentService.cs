using Ubackend.Models;

namespace Ubackend.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudentsWithCurso();
        IEnumerable<Student> GetStudentsWithNoCurso();
    }
}
