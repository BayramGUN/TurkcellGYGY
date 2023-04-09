using SchoolManagement.DataModule.Models;

namespace SchoolManagement.DataModule.DataProviders;

public class CourseDataProvider : ICourseDataProvider
{
    private List<Course>? _courses { get; set; }

    public CourseDataProvider()
    {
        _courses = new List<Course>();
    }

    public void WriteData(Course course)
    {
        _courses?.Add(course);
    }
    

    public List<Course>? ReadData()
    {
        return _courses;
    }
    public void RemoveData(Course course)
    {
        _courses?.Remove(course);
    }
}