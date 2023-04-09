using SchoolManagement.DataModule.Models;
using SchoolManagement.ServiceModule.Services.PersonService;

namespace SchoolManagement.ServiceModule.Services.TeacherService;

public interface ITeacherService : IService<Teacher>, IPersonService<Teacher>
{
    public List<Teacher> GetTeachersByBranch(string branch);
}