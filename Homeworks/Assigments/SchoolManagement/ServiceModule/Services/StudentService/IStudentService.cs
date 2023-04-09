using SchoolManagement.DataModule.Models;
using SchoolManagement.ServiceModule.Services.PersonService;

namespace SchoolManagement.ServiceModule.Services.StudentService;

public interface IStudentService : IService<Student>, IPersonService<Student>
{
    public Student GetStudentBySchoolNumber(int studentNumber);
    public void AddCourseToStudent(int id, Course course);
}