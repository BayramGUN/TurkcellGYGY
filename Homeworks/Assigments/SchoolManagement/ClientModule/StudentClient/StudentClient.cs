using SchoolManagement.ClientModule.GetInput;
using SchoolManagement.ClientModule.GetInput.DataMap;
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
    
    public List<Student> GetAllStudents() => _service!.GetAll();
    public Student GetStudentById(int id) => _service!.GetById(id); 
    
    public void RemoveStudent(int id) => _service!.Romove(id);
    
    public void RemoveStudentByName(string name) => _service!.RemovePersonByName(name);

    public void AddCourse(int id, string courseName)
    {
        var student = _service!.GetById(id);
        var course = new DataModule.Models.Course(){
            Id = new IdGenerator().GenarateId(),
            Name = courseName,

        };
        student?.Courses!.Add(course);
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
    public void GiveHomework(int id, int homeworkId)
    {
        _service!.GiveHomeworkToStudent(id, homeworkId);
    }
}
