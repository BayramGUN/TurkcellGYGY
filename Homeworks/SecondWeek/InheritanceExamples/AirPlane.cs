namespace InheritanceExamples;

public class AirPlane
{
    public string Model { get; set; }
    public float MotorPower { get; set; }
    public void GetOil()
    {
        Console.WriteLine("Getting oil");
    }
    public virtual void GetReadyToFlight()
    {
        Console.WriteLine("Getting ready to flight");
    }
}

public class PassengerPlane : AirPlane
{
    public string Type { get; set; }
    public int PessengerCapacity { get; set; }
    public virtual void GetReadyToFlight()
    {
        Console.WriteLine("Passenger luggage loading...");
    }
}
public class CargoPlane : AirPlane
{
    public decimal CargoVolume { get; set; }

    public virtual void GetReadyToFlight()
    {
        Console.WriteLine("Getting cargo");
    }
}

public class Jet : AirPlane
{

}
public class BussinessJet : Jet
{

}
public class MilitaryJet : Jet
{

}
public class Fighter : MilitaryJet
{

}

public class F16 : Fighter
{

}

public class PropellerPlane : AirPlane
{
    
}
