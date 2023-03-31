namespace LiskovExampleHw;

public class HotelRoomValidation : IValidation
{
    //private HotelRoom hotelRoom = new HotelRoom();
    public HotelRoomValidation()
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
public class ConferanceRoomValidation : IValidation
{
    public ConferanceRoomValidation()
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