namespace OpenClosePrinciple;

public class Television
{
    public string? Name { get; set; }
    public string? Model { get; set; }
    public double Inc { get; set; }
    public IPanelType? Panel { get; set; }
    public int Resolution { get; set; }
}

public class SmartTv : Television
{
    public IOperatingSystem? OperatingSystem { get; set; }  
}


public interface IPanelType
{
    public void ShowImageOn();
}
public interface IOperatingSystem
{
    public void ConnectWiFi();
    public void ConnectBluetooth();
    public void ScreenShare();
}

public class AndroidTv : IOperatingSystem
{

    public void ConnectBluetooth()
    {
        throw new NotImplementedException();
    }

    public void ConnectWiFi()
    {
        throw new NotImplementedException();
    }

    
    

    public void ScreenShare()
    {
        throw new NotImplementedException();
    }
    public void ConnectSmartThings()
    {
        Console.WriteLine("Android Tv Connected SmartThings App from One UI");
    }
}

public class WebOSTv : IOperatingSystem
{

    public void ConnectBluetooth()
    {
        throw new NotImplementedException();
    }

    public void ConnectWiFi()
    {
        throw new NotImplementedException();
    }

    

    public void ScreenShare()
    {
        throw new NotImplementedException();
    }

    public void ConnectHomeKit()
    {
        Console.WriteLine("WebOS Tv Connected a HomeKit App from iOS");
    }
}

public class LedPanel : IPanelType
{
    
    public void ShowImageOn()
    {
        Console.WriteLine("image showing on LED Panel");
    }
}

public class OLedPanel : IPanelType
{
    public void ShowImageOn()
    {
        Console.WriteLine("image showing on OLED Panel");
    }
}

public class Tube : IPanelType
{
    public void ShowImageOn()
    {
        Console.WriteLine("image showing on Tube Screen");
    }
}
public class LCD : IPanelType
{
    public void ShowImageOn()
    {
        Console.WriteLine("image showing on LCD Panel");
    }
    
}
