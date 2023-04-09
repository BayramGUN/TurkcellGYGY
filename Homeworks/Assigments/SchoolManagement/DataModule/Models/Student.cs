namespace SchoolManagement.DataModule.Models;

public class Student : Person
{
    public int Id { get; set; }
    public int SchoolNumber { get; set; }
    public List<Course>? Courses { get; set; }
}
