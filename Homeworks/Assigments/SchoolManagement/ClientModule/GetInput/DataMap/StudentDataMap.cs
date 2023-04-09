using SchoolManagement.DataModule.Models;

namespace SchoolManagement.ClientModule.GetInput.DataMap;

public class StudentDataMap
{
    public Student StudentInputToStudent(GetStudentInput studentInput)
    {
        Student student = new Student {
            Id = new IdGenerator().GenarateId(),
            Name = studentInput.Name,
            Surname = studentInput.Surname,
            IdentityNumber = studentInput.IdentityNumber,
            SchoolNumber = studentInput.StudentNumber
        };
        return student;
    }
}
