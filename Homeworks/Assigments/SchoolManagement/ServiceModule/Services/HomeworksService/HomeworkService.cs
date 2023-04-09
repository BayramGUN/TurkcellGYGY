
using SchoolManagement.DataModule.DataProviders;
using SchoolManagement.DataModule.Models;

namespace SchoolManagement.ServiceModule.Services.HomeworkService;

public class HomeworkService : IHomeworkService
{
    private readonly IDataProvider<Homework>? _homeworkProvider;
    private readonly IDataProvider<Teacher> _teacherProvider = new TeacherDataProvider();
    private readonly IDataProvider<Student> _studentProvider = new StudentDataProvider();
    public HomeworkService(IHomeworkDataProvider homeworkDataProvider)
    {
        _homeworkProvider = homeworkDataProvider;
    }

    public void Add(Homework entity)
    {
        _homeworkProvider!.WriteData(entity);
    }

    public List<Homework> GetAll()
    {
        throw new NotImplementedException();
    }

    public Homework GetById(int id) => _homeworkProvider!.ReadData()?.SingleOrDefault(e => e.Id == id);

    public void Romove(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(int id, Homework entity)
    {
        throw new NotImplementedException();
    }
    public string SendHomework(int fromId, int toId)
    {
        string? studentName = _studentProvider!.ReadData()!.FirstOrDefault(e => e.Id == fromId)?.Name;
        string? teacherName = _teacherProvider!.ReadData()!.FirstOrDefault(e => e.Id == toId)?.Name;
        return studentName + " to " + teacherName;
    }
}