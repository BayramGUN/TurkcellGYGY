using SchoolManagement.DataModule.Models;

namespace SchoolManagement.DataModule.DataProviders;

public class ClassroomDataProvider : IClassroomDataProvider
{
    private readonly List<Classroom>? _classrooms;
    
    public ClassroomDataProvider()
    {
        _classrooms = new List<Classroom>();
    }
    public void WriteData(Classroom classroom)
    {
        _classrooms?.Add(classroom);
    }

    public List<Classroom>? ReadData()
    {
        return _classrooms;
    }

    public void RemoveData(Classroom classroom)
    {
        _classrooms?.Remove(classroom);
    }
}