using SchoolManagement.DataModule.Models;
using SchoolManagement.ServiceModule.Services.PersonService;

namespace SchoolManagement.ServiceModule.Services.HomeworkService;

public interface IHomeworkService : IService<Homework>
{
    public string SendHomework(int fromId, int toId);
}