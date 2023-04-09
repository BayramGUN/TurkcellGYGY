using SchoolManagement.ClientModule.Validations;


namespace SchoolManagement.ClientModule.GetInput;
public class GetHomeworkInput
{
    public string? Title;
    public virtual void GetAllInputs()
    {
        while(!"Enter Homework name: ".GetString().IsNameOrSurnameValid())
            Console.WriteLine("Homework title must be single alphabetic character!");  
    }
}
