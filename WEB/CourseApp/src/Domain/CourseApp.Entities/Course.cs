namespace CourseApp.Entities
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public string? ImagePath { get; set; }
        public decimal Price { get; set; }
        public int TotalHours { get; set; }
        public int CategoryId { get; set; }
        public byte? Rating { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Category Category { get; set; }
    }
}