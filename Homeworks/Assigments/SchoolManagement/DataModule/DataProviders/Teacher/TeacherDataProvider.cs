using SchoolManagement.DataModule.Models;

namespace SchoolManagement.DataModule.DataProviders;

public class TeacherDataProvider : ITeacherDataProvider
{
    private List<Teacher>? _teachers { get; set; }

    public TeacherDataProvider()
    {
        _teachers = new List<Teacher>();
    }

    public void WriteData(Teacher Teacher)
    {
        _teachers?.Add(Teacher);
    }
   
    public void RemoveData(Teacher teacher)
    {
        _teachers?.Remove(teacher);
    }
    public List<Teacher>? ReadData()
    {
        return _teachers;
    }
}