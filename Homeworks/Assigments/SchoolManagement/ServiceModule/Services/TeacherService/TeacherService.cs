
using SchoolManagement.DataModule.DataProviders;
using SchoolManagement.DataModule.Models;

namespace SchoolManagement.ServiceModule.Services.TeacherService;

public class TeacherService : ITeacherService
{
    private readonly IDataProvider<Teacher> _teacherProvider;
    public TeacherService(ITeacherDataProvider teacherDataProvider)
    {
        _teacherProvider = teacherDataProvider;
    }
    
    public Teacher GetByIdentityNumber(long identityNumber)
    {

        var teacher = _teacherProvider.ReadData()?.FirstOrDefault(e => e.IdentityNumber == identityNumber);
        if(teacher is null)
            throw new ArgumentNullException("No teacher found with this identity number!");
        return teacher;
    }
    public List<Teacher> GetAll()
    {
        var teachers = _teacherProvider.ReadData();
        if(teachers is null)
            throw new ArgumentNullException("No teachers here!");
        return teachers;
    }

    public Teacher GetById(int id)
    {
        var teacher = _teacherProvider.ReadData()?.SingleOrDefault(e => e.Id == id);
         if(teacher is null)
            throw new ArgumentNullException("No teacher found with this identity number!");
        return teacher;
    }

    public List<Teacher> GetPeopleByNameOrSurname(string name)
    {
        var foundedteachers = _teacherProvider.ReadData()?.FindAll(e => e.Name == name).ToList();
        if (foundedteachers is null)
            throw new ArgumentNullException("No teacher found with this name or surname!");
        return foundedteachers;
    }
    public List<Teacher> GetTeachersByBranch(string branch)
    {
        var foundedteachers = _teacherProvider.ReadData()?.FindAll(e => e.Branch == branch).ToList();
        if (foundedteachers is null)
            throw new ArgumentNullException($"No teacher found with {branch} branch!");
        return foundedteachers;
    }

    public void RemovePersonByName(string name)
    {
        var remove = _teacherProvider.ReadData()?.FirstOrDefault(e => e.Name == name);
        if(remove is null)
            throw new ArgumentNullException($"No teacher found with {name}!");
        _teacherProvider?.RemoveData(remove);
    }

    public void Romove(int id)
    {
        var remove = _teacherProvider.ReadData()?.FirstOrDefault(e => e.Id == id);
        if(remove is null)
            throw new ArgumentNullException($"No teacher found with {id}!");
        _teacherProvider?.RemoveData(remove);
    }

    public void Update(int id, Teacher updateTeacher)
    {
        var teachers = _teacherProvider?.ReadData();
        var Teacher = teachers?.FirstOrDefault(e => e.Id == id);
        Teacher!.Name = updateTeacher.Name;
        Teacher!.Surname = updateTeacher.Surname;
        Teacher!.Branch = updateTeacher.Branch;
        Teacher!.IdentityNumber = updateTeacher.IdentityNumber;
    }

    public void Add(Teacher teacher)
    {
        _teacherProvider.WriteData(teacher);
    }
}