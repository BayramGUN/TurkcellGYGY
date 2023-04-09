namespace SchoolManagement.ClientModule;

public abstract class RequestPrinter
{
    public abstract string Request { get; }
    public virtual void PrintRequest(string option)
    {
        Console.WriteLine($"{this.Request} {option}");
    }
}

public class AddRequest : RequestPrinter
{
    public override string Request => "Add"; 
}

public class GetRequest : RequestPrinter
{
    public override string Request => "Get";

}
public class GetAllRequest : RequestPrinter
{
    public override string Request => "Get all";

}
public class RemoveRequest : RequestPrinter
{
    public override string Request => "Remove";
}
public class UpdateRequest : RequestPrinter
{
    public override string Request => "Update";
}