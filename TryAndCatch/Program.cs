// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

try
{

    Console.WriteLine("Sayi gir ula");
    var sayiBir = Convert.ToInt32(Console.ReadLine());
    Console.Write(" gibi bir hata oluştu");

    Console.WriteLine("Bir sayi daha gir bea");
    int sayiIki = Convert.ToInt32(Console.ReadLine());
    
    int bolum = sayiBir / sayiIki;

    Console.WriteLine($"Bolme isleminin sonucu: {bolum}");
}
catch (System.FormatException)
{
    
    Console.WriteLine("ergeen ergen sayi gir ergen");
}
catch (DivideByZeroException) 
{
    Console.WriteLine("matematik ogrenmeniz rica olunur");
}
catch(Exception ex) 
{
    Console.WriteLine($"{ex.Message} gibi bir hata oluştu");
}
finally
{
    Console.Write("illa calisacak");
}