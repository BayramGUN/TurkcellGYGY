namespace SchoolManagement.ClientModule.Validations;

public static class ClassroomInputValidation
{
    
    public static string IsClassroomValid(this char name) => 
    (char.IsLetter(name)) ? "Classroom name is valid" : "Classroom name is not valid";
}