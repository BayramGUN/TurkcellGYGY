using CourseApp.DTOs.Responses;

namespace CourseApp.Services;
public interface ICategoryService
{
    IEnumerable<CategoryDisplayResponse> GetCategoryDisplayResponses();
}
