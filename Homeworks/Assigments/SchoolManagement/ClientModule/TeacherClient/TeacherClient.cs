using SchoolManagement.ClientModule.GetInput;
using SchoolManagement.ClientModule.GetInput.DataMap;
using SchoolManagement.DataModule.Models;
using SchoolManagement.ServiceModule.Services.TeacherService;

namespace SchoolManagement.ClientModule.TeacherClient;

public class TeacherClient
{
    private readonly ITeacherService? _service;
    public TeacherClient(ITeacherService service)
    {
        _service = service;
    }
    
    public List<Teacher> GetAllTeachers() => _service!.GetAll();
    public Teacher GetTeacherById(int id) => _service!.GetById(id); 
    
    public void RemoveTeacher(int id) => _service!.Romove(id);
    
    public void RemoveTeacherByName(string name) => _service!.RemovePersonByName(name);


    public void UpdateTeacher(int id, GetTeacherInput updateTeacherInput)
    {
        var teacher = new TeacherDataMap().TeacherInputToTeacher(updateTeacherInput);
        try
        {
            _service!.Update(id, teacher);
        }
        catch(Exception er)
        {
            Console.WriteLine(er.Message);
        }
    }
    public void AddTeacher(GetTeacherInput teacherInput)
    {
        
        var teacher = new TeacherDataMap().TeacherInputToTeacher(teacherInput);
        try
        {
            _service!.Add(teacher);
        }
        catch(Exception er)
        {
            Console.WriteLine(er.Message);
        }
    }
}
