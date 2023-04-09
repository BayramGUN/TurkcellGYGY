using SchoolManagement.DataModule.Models;

namespace SchoolManagement.ClientModule.GetInput.DataMap;

public class TeacherDataMap
{
    public Teacher TeacherInputToTeacher(GetTeacherInput teacherInput)
    {
        Teacher teacher = new Teacher {
            Id = new IdGenerator().GenarateId(),
            Name = teacherInput.Name,
            Surname = teacherInput.Surname,
            IdentityNumber = teacherInput.IdentityNumber,
            Branch = teacherInput.Branch
        };
        return teacher;
    }
}
