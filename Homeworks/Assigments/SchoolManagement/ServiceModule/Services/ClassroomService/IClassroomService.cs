using SchoolManagement.DataModule.Models;
using SchoolManagement.ServiceModule.Services.PersonService;

namespace SchoolManagement.ServiceModule.Services.ClassroomService;

public interface IClassroomService : IService<Classroom>
{
    public Classroom GetByName(char name);
    public List<Student> GetStudentsByName(char name);
    public void AddStudentInToClassroom(char name, int studentId);
    public void AssignTeacherToClassroom(char name, int teacherId);
    public Student GetStudentInClassroom(int id, char classroom);
    
}