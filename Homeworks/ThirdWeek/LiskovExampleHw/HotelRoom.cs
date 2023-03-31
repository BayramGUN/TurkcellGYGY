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

public class ConferenceRoom : ICapacity
{
    public int GetCapacity()
    {
        return 500;
    }
}
public class MeetingRoom : ICapacity
{
    public int GetCapacity()
    {
        return 150;
    }
}
public class SuitForOne : ICapacity
{
    public int GetCapacity()
    {
        return 1;
    }
}
public class SuitForTwo : ICapacity
{
    public int GetCapacity()
    {
        return 2;
    }
}
public class SuitForFour : ICapacity
{
    public int GetCapacity()
    {
        return 4;
    }
}