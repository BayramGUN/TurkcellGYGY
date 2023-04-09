namespace SchoolManagement.DataModule.Models;

public class Classroom
{
    public int Id { get; set; }
    public char? Name { get; set; }
    public Teacher? Teacher { get; set; }
    public List<Student>? Students { get; set; }
}