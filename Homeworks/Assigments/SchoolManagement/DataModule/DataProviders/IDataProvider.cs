namespace SchoolManagement.DataModule.DataProviders;

public interface IDataProvider<T> where T : class
{
    public List<T>? ReadData();
    public void WriteData(T data);
    public void RemoveData(T data);
}