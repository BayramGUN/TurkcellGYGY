using SchoolManagement.ClientModule.GetInput;
using SchoolManagement.ClientModule.GetInput.DataMap;
using SchoolManagement.ClientModule.Validations;
using SchoolManagement.DataModule.Models;
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
    public List<Student> GetAllStudents()
    {
        return _service!.GetAll();
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
}
