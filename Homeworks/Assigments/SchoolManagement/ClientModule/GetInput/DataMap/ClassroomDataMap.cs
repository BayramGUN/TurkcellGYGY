using SchoolManagement.DataModule.Models;

namespace SchoolManagement.ClientModule.GetInput.DataMap;

public class ClassroomDataMap
{
    public Classroom ClassroomInputToClassroom(GetClassroomInput classroomInput)
    {
        Classroom classroom = new Classroom {
            Id = new IdGenerator().GenarateId(),
            Name = classroomInput.Name,
        };
        return classroom;
    }
}
