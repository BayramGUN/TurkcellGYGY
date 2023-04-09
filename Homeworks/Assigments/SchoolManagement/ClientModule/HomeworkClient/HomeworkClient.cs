using SchoolManagement.ClientModule.GetInput;
using SchoolManagement.ClientModule.GetInput.DataMap;
using SchoolManagement.DataModule.Models;
using SchoolManagement.ServiceModule.Services.HomeworkService;

namespace SchoolManagement.ClientModule.HomeworkClient;

public class HomeworkClient
{
    private readonly IHomeworkService? _service;
    public HomeworkClient(IHomeworkService service)
    {
        _service = service;
    }
    
    public List<Homework> GetAllHomeworks() => _service!.GetAll();
    public Homework GetHomeworkById(int id) => _service!.GetById(id); 
    
    public void RemoveHomework(int id) => _service!.Romove(id);

    public void UpdateHomework(int id, GetHomeworkInput updateHomeworkInput)
    {
        var Homework = new HomeworkDataMap().HomeworkInputToHomework(updateHomeworkInput);
        try
        {
            _service!.Update(id, Homework);
        }
        catch(Exception er)
        {
            Console.WriteLine(er.Message);
        }
    }
    public void AddHomework(GetHomeworkInput homeworkInput)
    {
        
        var homework = new HomeworkDataMap().HomeworkInputToHomework(homeworkInput);
        try
        {
            _service!.Add(homework);
        }
        catch(Exception er)
        {
            Console.WriteLine(er.Message);
        }
    }
}
