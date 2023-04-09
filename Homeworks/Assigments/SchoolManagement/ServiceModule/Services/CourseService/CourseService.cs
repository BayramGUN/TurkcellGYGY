using SchoolManagement.DataModule.DataProviders;
using SchoolManagement.DataModule.Models;
using SchoolManagement.ServiceModule.Services.CourseService;

namespace SchoolManagement.ServiceModule.Services.CourseService;

public class CourseService : ICourseService
{
    private readonly IDataProvider<Course> _courseProvider;
    public CourseService(ICourseDataProvider courseDataProvider)
    {
        _courseProvider = courseDataProvider;
    }
    public void Add(Course course)
    {
        _courseProvider.WriteData(course);
    }

    public List<Course> GetAll()
    {
        var courses = _courseProvider.ReadData();
        if(courses is null)
            throw new ArgumentNullException("No courses here!");
        return courses;
    }

    public Course GetById(int id)
    {
        var course = _courseProvider.ReadData()?.SingleOrDefault(e => e.Id == id);
        if(course is null)
            throw new ArgumentNullException("No course found with this identity number!");
        return course;
    }

    public void Romove(int id)
    {
        var remove = _courseProvider.ReadData()!.FirstOrDefault(e => e.Id == id);
        if(remove is null)
            throw new ArgumentNullException($"No course found with this {id} number!");
        _courseProvider?.RemoveData(remove);
    }

    public void Update(int id, Course updateCourse)
    {
        var course = _courseProvider?.ReadData()!.FirstOrDefault(e => e.Id == id);;
        course!.Grade = updateCourse.Grade;
        course!.Name = updateCourse.Name;
    }
}