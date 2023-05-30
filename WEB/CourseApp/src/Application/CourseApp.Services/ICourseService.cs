using CourseApp.DTOs.Responses;

namespace CourseApp.Services
{
    public interface ICourseService
    {
        IEnumerable<CourseDisplayResponse> GetCourseDisplayResponses();
        IEnumerable<CourseDisplayResponse> GetCoursesByCategory(int categoryId);
        CourseDisplayResponse GetCourseDisplayResponse(int id);
    }
}