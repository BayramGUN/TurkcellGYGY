using CourseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Infrastructure.Repositories;
public class FakeCategoryRepository : ICategoryRepository
{
    private List<Category> _categories;
    public FakeCategoryRepository()
    {
        _categories = new ()
        {
            new()
            {
                Id = 1,
                Name = "Category Test -x"
            },
            new()
            {
                Id = 2,
                Name = "Category Test -y"
            },
            new()
            {
                Id = 3,
                Name = "Category Test -z"
            },
            new()
            {
                Id = 4,
                Name = "Category Test -q"
            }
        };
    }
    public Category? Get(int id)
    {
        throw new NotImplementedException();
    }
    public IList<Category?> GetAll()
    {
        return _categories;
    }
    public Task<IList<Category?>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
    public IList<Category> GetAllWithPredicate(Expression<Func<Category, bool>> predicate)
    {
        throw new NotImplementedException();
    }
    public Task<Category?> GetAsync(int id)
    {
        throw new NotImplementedException();
    }
    public IEnumerable<Category> GetCategorysByCategory(int categoryId)
    {
        throw new NotImplementedException();
    }
    public IEnumerable<Category> GetCategorysByName(string name)
    {
        throw new NotImplementedException();
    }
}
