using SchoolManagement.DataModule.DataProviders;
using SchoolManagement.DataModule.Models;


namespace SchoolManagement.ServiceModule.Services.ClassroomService;

public class ClassroomService : IClassroomService
{
    private readonly IClassroomDataProvider _classroomProvider;
    public ClassroomService(IClassroomDataProvider classroomDataProvider)
    {
        _classroomProvider = classroomDataProvider;
    }
    public void Add(Classroom classroom)
    {
        _classroomProvider.WriteData(classroom);
    }

    public void AddStudentToClassroom(char name, Student student)
    {
        var classroom = _classroomProvider!.ReadData()?.FirstOrDefault(e => e.Name == name);
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
    public void AssignTeacherToClassroom(char name, Teacher teacher)
    {
        var classroom = _classroomProvider!.ReadData()?.FirstOrDefault(e => e.Name == name);;
        classroom!.Teacher = teacher;
    }
}