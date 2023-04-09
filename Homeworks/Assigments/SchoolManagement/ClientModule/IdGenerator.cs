namespace SchoolManagement.ClientModule;


public class IdGenerator
{
    private int id = 1;
    public int GenerateId()
    {
        return id++;
    }
}