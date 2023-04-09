using SchoolManagement.ClientModule.Validations;

namespace SchoolManagement.ClientModule.GetInput;

public abstract class GetPersonInput
{
    public string? Name;
    public string? Surname;
    public long IdentityNumber;
    public virtual void GetAllInputs()
    {
        this.Name = "Enter name: ".GetString();
        while(!Name.IsNameOrSurnameValid())
        {
            Console.WriteLine($"name input must contain only alphabetic characters");
            this.Name = "Enter name (again):".GetString();
        }
        this.Surname = "Enter surname: ".GetString();
        while(!Surname.IsNameOrSurnameValid())
        {
            Console.WriteLine($"surname input must contain only alphabetic characters");
            this.Surname = "Enter surname (again): ".GetString();
        }
        
        this.IdentityNumber = "Enter identity number: ".GetLong();
        while(!IdentityNumber.IsIdentityNumberValid())
        {
            Console.WriteLine($"identity number value must be from 9999999999 to 99999999999");
            
            this.IdentityNumber = "Enter identity number(again): ".GetLong();
        }
    }

}
public class GetStudentInput : GetPersonInput
{
    public int StudentNumber { get; set; }

    public override void GetAllInputs()
    {
        base.GetAllInputs();
        this.StudentNumber = "Enter student school number: ".GetInt();
    }
}
public class GetTeacherInput : GetPersonInput
{
    public string? Branch { get; set; }
    public override void GetAllInputs()
    {
        base.GetAllInputs();
        this.Branch = "Enter branch of teacher: ".GetString();
    }
}