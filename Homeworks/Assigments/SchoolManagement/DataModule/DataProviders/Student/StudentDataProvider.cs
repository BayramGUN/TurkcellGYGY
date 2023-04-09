using SchoolManagement.DataModule.Models;

namespace SchoolManagement.DataModule.DataProviders;

public class StudentDataProvider : IStudentDataProvider
{
    private List<Student>? _students { get; set; }

    public StudentDataProvider()
    {
        _students = new List<Student>();
    }

    public void WriteData(Student student)
    {
        _students?.Add(student);
    }
    

    public List<Student>? ReadData()
    {
        return _students;
    }
    public void RemoveData(Student student)
    {
        _students?.Remove(student);
    }
}