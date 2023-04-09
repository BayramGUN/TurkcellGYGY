using SchoolManagement.DataModule.DataProviders;
using SchoolManagement.DataModule.Models;
using SchoolManagement.ServiceModule.Services.StudentService;
using SchoolManagement.ServiceModule.Services.TeacherService;

namespace SchoolManagement.ServiceModule.Services.ClassroomService;

public class ClassroomService : IClassroomService
{
    private readonly IClassroomDataProvider _classroomProvider;
    private readonly IStudentService _studentService;
    private readonly ITeacherService _teacherService;
    public ClassroomService(
            IClassroomDataProvider classroomDataProvider,
            IStudentService studentService,
            ITeacherService teacherService
        )
    {
        _classroomProvider = classroomDataProvider;
        _studentService = studentService;
        _teacherService = teacherService;
    }
    public void Add(Classroom classroom) => _classroomProvider.WriteData(classroom);


    public void AddStudentInToClassroom(char name, int studentId)
    {
        var classroom = _classroomProvider!.ReadData()?.FirstOrDefault(e => e.Name == name);
        var student = _studentService!.GetById(studentId);
        if(student is not null)
            classroom?.Students!.Add(student);
    }

    public List<Classroom> GetAll()
    {
        var classrooms = _classroomProvider.ReadData();
        if(classrooms is null)
            throw new ArgumentNullException("No classrooms here!");
        return classrooms;
    }

    public Classroom GetById(int id)
    {
        var classroom = _classroomProvider.ReadData()?.SingleOrDefault(e => e.Id == id);
        if(classroom is null)
            throw new ArgumentNullException("No classroom found with this identity number!");
        return classroom;
    }

    public void Romove(int id)
    {
        var remove = _classroomProvider.ReadData()!.FirstOrDefault(e => e.Id == id);
        if(remove is null)
            throw new ArgumentNullException($"No classroom found with this {id} number!");
        _classroomProvider?.RemoveData(remove);
    }

    public void Update(int id, Classroom updateClassroom)
    {
        var classroom = _classroomProvider!.ReadData()?.FirstOrDefault(e => e.Id == id);;
        classroom!.Name = updateClassroom.Name;
        classroom!.Teacher = updateClassroom.Teacher;
    }
    public void AssignTeacherToClassroom(char name, int teacherId)
    {
        var classroom = _classroomProvider!.ReadData()?.FirstOrDefault(e => e.Name == name);
        var teacher = _teacherService.GetById(teacherId);
        classroom!.Teacher = teacher;
    }
    public Student GetStudentInClassroom(int id, char classroomName)
    {
        var classroom = _classroomProvider!.ReadData()?.FirstOrDefault(e => e.Name == classroomName);
        var studentInClass = classroom!.Students?.SingleOrDefault(e => e.Id == id);
        if(studentInClass is null)
            throw new ArgumentNullException($"there is no student with this {id} number!");
        return studentInClass;
    }
}