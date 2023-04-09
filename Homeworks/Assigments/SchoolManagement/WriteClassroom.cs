using SchoolManagement.DataModule.Models;

namespace SchoolManagement.ClientModule.ClassroomClient;

public static class WriteData
{
    public static void SendClassroomToWrite(this Classroom classroom)
    {
        Console.WriteLine($"Id:{classroom.Id} Name:{classroom.Name}" );
    }
}