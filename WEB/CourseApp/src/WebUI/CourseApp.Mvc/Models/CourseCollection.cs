using CourseApp.DTOs.Responses;

namespace CourseApp.Mvc.Models;

public class CourseCollection
{
    public List<CourseItem> CourseItems { get; set; } = new List<CourseItem>();

        public void ClearAll() => CourseItems.Clear();
        public decimal TotalCoursePrice() => CourseItems.Sum(item => (decimal)item.Course.Price * item.Quantity);

        public int TotalCoursesCount() => CourseItems.Sum(p => p.Quantity);

        public void AddNewCourse(CourseItem courseItem)
        {
            var exists = CourseItems.FirstOrDefault(c => c.Course.Id == courseItem.Course.Id);
            if (exists is not null)
            {
                //var existingCourse = CourseItems.FirstOrDefault(c => c.Course.Id == courseItem.Course.Id);
                exists.Quantity += courseItem.Quantity;
            }
            else
            {
                CourseItems.Add(courseItem);
            }

        }
}

public class CourseItem 
{
    public CourseDisplayResponse Course { get; set; } = null!;
    public int Quantity { get; set; }
    public bool? IsAppliedCoupon { get; set; }
}