namespace LiskovExampleHw;

public class SuitValidation : IValidation
{

    public SuitValidation()
    {

    }
    public bool IsDayValid(DateTime from, DateTime? to)
    {
        if (from < DateTime.Now || from < DateTime.MinValue)
            return false;
        else if(to.HasValue & ((to < DateTime.Now) || to > DateTime.MaxValue))
            return false;
        return true;
    }
    public bool IsAvailableValid()
    {
        return true;
    }
    public bool IsCapacityValid()
    {
        return true;
    }
}
public class ConferenceRoomValidation : IValidation
{
    public ConferenceRoomValidation()
    {
        
    }
    public bool IsDayValid(DateTime from, DateTime? to)
    {

        return true; 
    }
    public bool IsAvailableValid()
    {

        return true; 
    }
    public bool IsCapacityValid()
    {

        return true; 
    }
}
public class MeetingRoomValidation : IValidation
{
    public MeetingRoomValidation()
    {
        
    }
    public bool IsDayValid(DateTime from, DateTime? to)
    {

        return true; 
    }
    public bool IsAvailableValid()
    {

        return true; 
    }
    public bool IsCapacityValid()
    {

        return true; 
    }
}