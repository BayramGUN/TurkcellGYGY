
namespace LiskovExampleHw;

public static class ValidationLibrary 
{
    public static IValidation ValidationFactory(int capacityNeed)
    {
        if(capacityNeed > 6 && capacityNeed <= 150) 
            return new MeetingRoomValidation();
        if(capacityNeed > 150 && capacityNeed <= 500) 
            return new ConferanceRoomValidation();
        
        return new SuitValidation();
    }
}