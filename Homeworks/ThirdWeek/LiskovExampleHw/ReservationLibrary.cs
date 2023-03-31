namespace LiskovExampleHw;

public static class ReservationLibrary 
{
    public static IValidation ValidationFactory(int roomCapacity, int? saloonCapacity)
    {
        if(saloonCapacity.HasValue) return new ConferanceRoomValidation();
        return new HotelRoomValidation();
    }
}