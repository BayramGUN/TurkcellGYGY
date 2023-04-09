namespace SchoolManagement.ServiceModule.Services;

public interface IService<T>
{
    public List<T> GetAll();    
    public T GetById(int id); 
    public void Update(int id, T entity);
    public void Romove(int id);  
    public void Add(T entity); 
}
