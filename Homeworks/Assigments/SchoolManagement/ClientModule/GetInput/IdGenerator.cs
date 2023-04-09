namespace SchoolManagement.ClientModule.GetInput;


public class IdGenerator
{
    private int id;
    
    public int GenarateId()
    {
        Random random = new Random();
        return random.Next(1000);
    }
}