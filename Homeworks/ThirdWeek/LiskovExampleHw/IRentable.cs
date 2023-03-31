namespace LiskovExampleHw;

public interface IRentable
{
    public DateTime RentedDayFrom { get; set; }
    public DateTime RentedDayTo { get; set; }
}