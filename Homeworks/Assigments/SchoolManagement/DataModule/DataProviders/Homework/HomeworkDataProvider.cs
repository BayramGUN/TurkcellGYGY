using SchoolManagement.DataModule.Models;

namespace SchoolManagement.DataModule.DataProviders;

public class HomeworkDataProvider : IHomeworkDataProvider
{
    private List<Homework>? _homeworks { get; set; }

    public HomeworkDataProvider()
    {
        _homeworks = new List<Homework>();
    }

    public void WriteData(Homework homework)
    {
        _homeworks?.Add(homework);
    }
    

    public List<Homework>? ReadData()
    {
        return _homeworks;
    }
    public void RemoveData(Homework homework)
    {
        _homeworks?.Remove(homework);
    }
}