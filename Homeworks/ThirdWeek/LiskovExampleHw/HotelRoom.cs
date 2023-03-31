namespace LiskovExampleHw;



public class HotelRoom
{
    public ICapacity? Capacity { get; set; }
    public bool IsAvailable { get; set; }

}
public interface ICapacity
{
    public int GetCapacity();
}

public class ConferenceRoom : HotelRoom, ICapacity
{
    public int GetCapacity()
    {
        return 500;
    }
}
public class MeetingRoom : HotelRoom, ICapacity
{
    public int GetCapacity()
    {
        return 150;
    }
}
public class SuitForOne : HotelRoom, ICapacity
{
    public int GetCapacity()
    {
        return 1;
    }
}
public class SuitForTwo : HotelRoom, ICapacity
{
    public int GetCapacity()
    {
        return 2;
    }
}
public class SuitForFour : HotelRoom, ICapacity
{
    public int GetCapacity()
    {
        return 4;
    }
}