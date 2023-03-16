namespace AbstractClassVSInterface;

public abstract class Document
{
    public string Title { get; set; }
    public string Owner { get; set; }
    public abstract void Save();
    public abstract void Open();
    // public abstract void Print();
    public void Copy(string from, string to) 
    {
        Console.WriteLine($"copied from '{from}' address to '{to}' address");
    }
}

public interface IPrintable
{
    public void Print();
}

public class PdfDocument : Document
{
    public override void Save()
    {
        Console.WriteLine("PDF document is saved");
    }
    public override void Open()
    {
        Console.WriteLine("PDF document is opened");
    }
    
}
public class ExcelDocument : Document, IPrintable
{
    public override void Save()
    {
        Console.WriteLine("Excel document is saved");
    }
    public override void Open()
    {
        Console.WriteLine("Excel document is opened");
    }
    public void Print()
    {
        Console.WriteLine("Excel document is printed");
    }

}
public class WordDocument : Document, IPrintable
{
    public override void Save()
    {
        Console.WriteLine("Word document is saved");
    }
    public override void Open()
    {
        Console.WriteLine("Word document is opened");
    }
    public void Print()
    {
        Console.WriteLine("Word document is printed");
    }
}

public class PrintDocumentComponent
{
    public void Print(IPrintable document)
    {
        document.Print();
    }
}