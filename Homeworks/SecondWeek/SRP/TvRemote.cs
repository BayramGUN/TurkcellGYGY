namespace SRP;



public class TvRemote : ITvRemote

{
    public string Brand { get; set; }
    public string Model { get; set; }

    public void ChangeChannel()
    {
        Console.WriteLine("Channel Cahnged");
    }

    public void CloseTv()
    {
        Console.WriteLine("Tv closed");
    }

    public void OpenTv()
    {
        Console.WriteLine("Tv opened");
    }

    public void TakePhoto()
    {
        Console.WriteLine("A Tv Remote should not take photo!");
    }

    public void VolumeDown()
    {
        Console.WriteLine("Volume downed");
    }

    public void VolumeUp()
    {
        Console.WriteLine("Volume upped");
    }
}

public interface ITvRemote
{
    void OpenTv();
    void CloseTv();
    void ChangeChannel();
    void VolumeUp();
    void VolumeDown();
    void TakePhoto(); // TV Remote does not have a mission like this in its responsibilty.
}