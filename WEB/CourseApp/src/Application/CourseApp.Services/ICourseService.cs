using CourseApp.DTOs.Responses;

namespace CourseApp.Services
{
    public interface ICourseService
    {
        IEnumerable<CourseDisplayResponse> GetCourseDisplayResponses();
    }
}