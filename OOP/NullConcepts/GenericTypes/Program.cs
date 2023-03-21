// See https://aka.ms/new-console-template for more information

using System.Collections;
/* Console.WriteLine("Hello, World!");

ArrayList words = new ArrayList();

words.Add(15);

Console.WriteLine((int)words[0]);  */

GenericPoint<decimal> dec = new GenericPoint<T>();

T GetTypeOfGeneric<T>(T type)
{
    return type.GetType().Name;
}
public class GenericPoint<T> 
    where T : struct
{
    public T X { get; set; }
    public T Y { get; set; }
    public T Z { get; set; }

    public void Reset()
    {
        X = default(T);
        Y = default(T);
        Z = default(T);
    }
}

