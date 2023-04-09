using SchoolManagement.DataModule.Models;

namespace SchoolManagement.ClientModule.GetInput.DataMap;

public class HomeworkDataMap
{
    public Homework HomeworkInputToHomework(GetHomeworkInput homeworkInput)
    {
        Homework homework = new Homework {
            Id = new IdGenerator().GenarateId(),
            Title = homeworkInput.Title,
        };
        return homework;
    }
}
