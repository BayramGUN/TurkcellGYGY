namespace LiskovExampleHw;

public interface IValidation
{
    public bool IsDayValid();
    public bool IsAvailableValid();
    public bool IsCapacityValid();
}