namespace LiskovExampleHw;

public interface IValidation
{
    public bool IsDayValid(DateTime from, DateTime? to);
    public bool IsAvailableValid();
    public bool IsCapacityValid();
}