namespace CounterStrike;

public class Weapon
{
    public string? Name { get; set; } = string.Empty;
    public int Range { get; set; }
    public int Damage { get; set; }
    public int Weight { get; set; }
    public string? Species { get; set; } = string.Empty;

    public void Attack()
    {
        Console.WriteLine($"Attacking to the enemy with {Name}, damage: {Damage}");
    }
    public virtual void GetReadyToAttack()
    {
        Console.WriteLine("Blade in upright position");
    }
}

public class Gun : Weapon
{
    public int NumberOfBullet { get; set; }
    public int CapacityOfCharger { get; set; }
    public int BounceWape { get; set; }

    // Polimorphism examples in the inheritance lesson:
    // virtual methods is on the base class

    public virtual void Reload()
    {
        Console.WriteLine("Reload animation is displaying");
    }
    public override void GetReadyToAttack()
    {
        Console.WriteLine("Taking aim at!");
    }
}

public class Pistol : Gun
{

    //overrided virtual method 
    public override void Reload()
    {
        Console.WriteLine("Pistol reload animation is displaying");
    }
    public bool HasSupprasor { get; set; }
}

public class DesertEagle : Pistol
{
    public DesertEagle()
    {
        Name = "Desert Eagle";
        Damage = 20;
    }
}

public class Rifle : Gun
{
    public bool HasBinoculars { get; set; }
    //overrided virtual method 
    public override void Reload()
    {
        Console.WriteLine("Rifle reload animation is displaying");
    }
    //overrided virtual method 
    public override void GetReadyToAttack()
    {
        Console.WriteLine("Aim with binocular");
    }
}

public class Ak47 : Rifle
{
    public Ak47()
    {
        Name = "AK-47 Kalashnikov";
        Damage = 40;
    }
}

