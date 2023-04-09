using SchoolManagement.ClientModule.Validations;


namespace SchoolManagement.ClientModule.GetInput;
public class GetClassroomInput
{
    public char Name;
    public virtual void GetAllInputs()
    {
        this.Name = "Enter classroom name: ".GetChar();
        while(!this.Name.IsClassroomValid())
        {
            Console.WriteLine("Classroom name must be single alphabetic character!");
            this.Name = "Enter classroom name: ".GetChar();  
        }
    }
}
