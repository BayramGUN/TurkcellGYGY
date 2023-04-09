using SchoolManagement.DataModule.Models;

namespace SchoolManagement.ServiceModule.Services.PersonService;

public interface IPersonService<T>
{
    public List<T> GetPeopleByNameOrSurname(string name);
    public void RemovePersonByName(string name);
    public T GetByIdentityNumber(long identity);
}