using SchoolManagement.ClientModule.GetInput;
using SchoolManagement.ClientModule.GetInput.DataMap;
using SchoolManagement.DataModule.Models;
using SchoolManagement.ServiceModule.Services.ClassroomService;
using SchoolManagement.ServiceModule.Services.StudentService;

namespace SchoolManagement.ClientModule.ClassroomClient;

public class ClassroomClient
{
    private readonly IClassroomService? _classroomService;
    public ClassroomClient(IClassroomService classroomService)
    {
        _classroomService = classroomService;
    }
    public void AddClassroom(GetClassroomInput classroomInput)
    {
        
        var classroom = new ClassroomDataMap().ClassroomInputToClassroom(classroomInput);
        try
        {
            _classroomService!.Add(classroom);
        }
        catch(Exception er)
        {
            Console.WriteLine(er.Message);
        }
    }
    public List<Classroom> GetAllClassrooms() => _classroomService!.GetAll();
    public void AddStudentToClassroom(char classroomName, int studentId) =>
         _classroomService!.AddStudentInToClassroom(classroomName, studentId);
    
    public Student FindStudentInClassroom(int id, char name) => 
        _classroomService!.GetStudentInClassroom(id, name);
    public void AddTeacherToClassroom(int id, char name) =>
        _classroomService!.AssignTeacherToClassroom(name, id);
    /* public void UpdateStudent(int id, GetStudentInput updateStudentInput)
    {
        var student = new StudentDataMap().StudentInputToStudent(updateStudentInput);
        try
        {
            _classroomService!.Update(id, student);
        }
        catch(Exception er)
        {
            Console.WriteLine(er.Message);
        }
    }
    public void RemoveStudent(int id)
    {
        try
        {
            _classroomService!.Romove(id);
        }
        catch(Exception er)
        {
            Console.WriteLine(er.Message);
        }
    }
    public void RemoveStudentByName(string name)
    {
        try
        {
            _classroomService!.RemovePersonByName(name);
        }
        catch(Exception er)
        {
            Console.WriteLine(er.Message);
        }
    } */
}
