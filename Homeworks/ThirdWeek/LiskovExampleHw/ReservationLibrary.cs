namespace LiskovExampleHw;

public static class ReservationLibrary 
{
    public static IReservable ReservationFactory()
    {

        return new HotelRoomReservation();
    }
}