

using CourseApp.DTOs.Responses;

namespace CourseApp.Mvc.Models;

public class PaginationCourseViewModel
{
    public IEnumerable<CourseDisplayResponse> Courses { get; set; } = null!;
    public PagingInfo PagingInfo { get; set; } = null!;
}