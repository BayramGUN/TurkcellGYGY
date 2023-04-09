using SchoolManagement.ClientModule.GetInput;
using SchoolManagement.ClientModule.GetInput.DataMap;
using SchoolManagement.ServiceModule.Services.StudentService;

namespace SchoolManagement.ClientModule.StudentClient;

public class StudentClient
{
    private readonly IStudentService? _service;
    public StudentClient(IStudentService service)
    {
        _service = service;
    }
    public void AddStudent(GetStudentInput studentInput)
    {
        
        var student = new StudentDataMap().StudentInputToStudent(studentInput);
        try
        {
            _service!.Add(student);
        }
        catch(Exception er)
        {
            Console.WriteLine(er.Message);
        }
    }
    public void GetAllStudents()
    {
        _service!.GetAll().ForEach(e => e.SendToWrite());
    }
    public void GetStudentById(int id)
    {
        var student = _service!.GetById(id);
        student.SendToWrite(); 
    }
    public void UpdateStudent(int id, GetStudentInput updateStudentInput)
    {
        var student = new StudentDataMap().StudentInputToStudent(updateStudentInput);
        try
        {
            _service!.Update(id, student);
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
            _service!.Romove(id);
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
            _service!.RemovePersonByName(name);
        }
        catch(Exception er)
        {
            Console.WriteLine(er.Message);
        }
    }
}
