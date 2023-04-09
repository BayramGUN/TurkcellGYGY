using SchoolManagement.DataModule.Models;

namespace SchoolManagement.ClientModule.StudentClient;

public static class WriteStudent
{
    public static void SendToWrite(this Student student)
    {
        Console.WriteLine(
            $"Id:{student.Id} Name:{student.Name} Surname:{student.Surname} Number:{student.SchoolNumber} IdentityNumber: {student.IdentityNumber}" );
    }
}