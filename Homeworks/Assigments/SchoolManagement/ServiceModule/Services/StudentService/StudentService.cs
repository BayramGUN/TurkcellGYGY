using SchoolManagement.DataModule.DataProviders;
using SchoolManagement.DataModule.Models;

namespace SchoolManagement.ServiceModule.Services.StudentService;
 
public class StudentService : IStudentService
{
    private readonly IDataProvider<Student> _studentProvider;
    public StudentService(IStudentDataProvider studentDataProvider)
    {
        _studentProvider = studentDataProvider;
    }
    public Student GetByIdentityNumber(long identityNumber)
    {

        var student = _studentProvider.ReadData()?.FirstOrDefault(e => e.IdentityNumber == identityNumber);
        if(student is null)
            throw new ArgumentNullException("No student found with this identity number!");
        return student;
    }
    public List<Student> GetAll()
    {
        var students = _studentProvider.ReadData();
        if(students is null)
            throw new ArgumentNullException("No students here!");
        return students;
    }

    public Student GetById(int id)
    {
        var student = _studentProvider.ReadData()?.SingleOrDefault(e => e.Id == id);
        if(student is null)
            throw new ArgumentNullException("No student found with this identity number!");
        return student;
    }

    

    public List<Student> GetPeopleByNameOrSurname(string name)
    {
        var foundedStudents = _studentProvider.ReadData()?.FindAll(e => e.Name == name).ToList();
        if (foundedStudents is null)
            throw new ArgumentNullException($"No student found with this {name}!");
        return foundedStudents;
    }

    public Student GetStudentBySchoolNumber(int studentNumber)
    {
        var student = _studentProvider.ReadData()?.FirstOrDefault(e => e.SchoolNumber == studentNumber);
        if(student is null)
            throw new ArgumentNullException($"No student found with this {studentNumber} number!");
        return student;
    }

    public void RemovePersonByName(string name)
    {
        var remove = _studentProvider.ReadData()!.FirstOrDefault(e => e.Name == name);
        if(remove is null)
            throw new ArgumentNullException($"No student found with this {name} number!");
        _studentProvider?.RemoveData(remove);
    }

    public void Romove(int id)
    {
        var remove = _studentProvider.ReadData()!.FirstOrDefault(e => e.Id == id);
        if(remove is null)
            throw new ArgumentNullException($"No student found with this {id} number!");
        _studentProvider?.RemoveData(remove);
    }

    public void Update(int id, Student updateStudent)
    {
        var student = _studentProvider?.ReadData()!.FirstOrDefault(e => e.Id == id);;
        student!.Name = updateStudent.Name;
        student!.Surname = updateStudent.Surname;
        student!.SchoolNumber = updateStudent.SchoolNumber;
        student!.IdentityNumber = updateStudent.IdentityNumber;
    }

    public void AddCourseToStudent(int id, Course course)
    {
        var student = _studentProvider.ReadData()!.FirstOrDefault(e => e.Id == id);
        student!.Courses?.Add(course);
    }

    public void Add(Student student)
    {
        _studentProvider.WriteData(student);
    }
}