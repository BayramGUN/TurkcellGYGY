namespace DILifeTime.Models;

public interface IGuidGenerator
{
    Guid Guid { get; }
}

public interface ISingletonGuid : IGuidGenerator
{
    
}
public interface ITransientGuid : IGuidGenerator
{
    
}
public interface IScopedGuid : IGuidGenerator
{
    
}

public class Singleton : ISingletonGuid
{
    public Guid Guid {get; private set;}
    public Singleton()
    {
        Guid = Guid.NewGuid();
    }
}
public class Transient : ITransientGuid
{
    public Guid Guid {get; private set;}
    public Transient()
    {
        Guid = Guid.NewGuid();
    }
    
}
public class Scoped : IScopedGuid
{
    public Guid Guid {get; private set;}
    public Scoped()
    {
        Guid = Guid.NewGuid();
    }
    
}

public class GuidService
{
    public ISingletonGuid Singleton { get; set;}
    public ITransientGuid Transient { get; set;}
    public IScopedGuid Scoped { get; set;}

    public GuidService(
        ITransientGuid transient,
        IScopedGuid scoped,
        ISingletonGuid singleton
    )
    {
        this.Scoped = scoped;
        this.Singleton = singleton;
        this.Transient = transient;
    }
}