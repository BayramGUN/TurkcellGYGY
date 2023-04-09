using SchoolManagement.DataModule.Models;
using SchoolManagement.ServiceModule.Services.PersonService;

namespace SchoolManagement.ServiceModule.Services.StudentService;

public interface IStudentService : IService<Student>, IPersonService<Student>
{
    public Student GetStudentBySchoolNumber(int studentNumber);
    // Spublic void AddCourseToStudent(int id, int courseId);
    public void GiveHomeworkToStudent(int id, int homeworkId);

}