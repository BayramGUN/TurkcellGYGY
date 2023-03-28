namespace UsingDelegate;

public class FilterHelper
{

    // public delegate bool criteria(int item);
    public List<int> Filter (List<int> numbers, Func<int, bool> criteria/*filterFunction*/)
    {
        List<int> filtered = new ();
        {
            foreach (var number in numbers)
            {
                if(criteria(number)) 
                    filtered.Add(number);
            }
        }
        return filtered;
    }
}