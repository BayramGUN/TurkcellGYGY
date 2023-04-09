namespace SchoolManagement.DataModule.Models;

public class Student : Person
{
    public int Id { get; set; }
    public int SchoolNumber { get; set; }
    public List<Course>? Courses { get; set; } = new List<Course>();
    public List<Homework>? Homeworks { get; set; } = new List<Homework>();

}
