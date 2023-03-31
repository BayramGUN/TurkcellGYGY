namespace LiskovExampleHw;



public class HotelRoom
{
    public int Capacity { get; set; }
    public bool IsAvailable { get; set; }

}

public class ConferanceRoom : HotelRoom
{
}
