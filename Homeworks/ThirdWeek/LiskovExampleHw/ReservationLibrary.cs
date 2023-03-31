namespace LiskovExampleHw;

public static class ReservationLibrary 
{
    public static IValidation _validation;
    public ReservationLibrary(IValdiation validation)
    {
        _validation = validation;
    } 
    public static IReservable ReservationFactory(int? roomCapacity, int? saloonCapacity)
    {
        if(roomCapacity.HasValue) return new HotelRoomValidation();
        if(saloonCapacity.HasValue) return new ConferanceRoomValidation();
    }
}