
namespace LiskovExampleHw;

public static class ValidationLibrary 
{
    public static SuitForFour suit = new SuitForFour();
    public static MeetingRoom meeting = new MeetingRoom();
    public static ConferenceRoom conference = new ConferenceRoom();
    
    public static IValidation ValidationFactory(int capacityNeed)
    {
        if(capacityNeed > suit.GetCapacity() && capacityNeed <= meeting.GetCapacity()) 
            return new MeetingRoomValidation();
        else if(capacityNeed > meeting.GetCapacity() && capacityNeed <= conference.GetCapacity()) 
            return new ConferenceRoomValidation();
        
        return new SuitValidation();
    }
}