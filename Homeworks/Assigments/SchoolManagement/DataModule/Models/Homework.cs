namespace SchoolManagement.DataModule.Models;

public class Homework
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public Teacher? Teacher { get; set; }
}