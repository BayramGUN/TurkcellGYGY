using SchoolManagement.DataModule.Models;
using SchoolManagement.ServiceModule.Services.PersonService;

namespace SchoolManagement.ServiceModule.Services.ClassroomService;

public interface IClassroomService : IService<Classroom>
{
    public void AddStudentToClassroom(char name, Student student);
    public void AssignTeacherToClassroom(char name, Teacher teacher);
}