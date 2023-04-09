namespace SchoolManagement.ClientModule.Validations;

public static class ClassroomInputValidation
{
    
    public static bool IsClassroomValid(this char name) => 
    (char.IsLetter(name)) ? true : false;
}