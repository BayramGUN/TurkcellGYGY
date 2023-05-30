using CourseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Infrastructure.Repositories;
public class FakeCourseRepository : ICourseRepository
{
    private List<Course> _courses;
    public FakeCourseRepository()
    {
        _courses = new ()
        {
            new()
            {
                Id = 1,
                Name = "Course Test -x",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 99,
                TotalHours = 20,
                CategoryId = 1
            },
            new()
            {
                Id = 2,
                Name = "Course Test -y",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 120,
                TotalHours = 20,
                CategoryId = 1
            },
            new()
            {
                Id = 3,
                Name = "Course Test -z",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 45,
                TotalHours = 20,
                CategoryId = 1
            },
            new()
            {
                Id = 4,
                Name = "Course Test -q",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 34,
                TotalHours = 20,
                CategoryId = 1
            },
            new()
            {
                Id = 11,
                Name = "Course Test -xa",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 99,
                TotalHours = 20,
                CategoryId = 4
            },
            new()
            {
                Id = 12,
                Name = "Course Test -ya",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 120,
                TotalHours = 20,
                CategoryId = 4
            },
            new()
            {
                Id = 13,
                Name = "Course Test -za",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 45,
                TotalHours = 20,
                CategoryId = 4
            },
            new()
            {
                Id = 14,
                Name = "Course Test -qa",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 34,
                TotalHours = 20,
                CategoryId = 4
            },
            new()
            {
                Id = 21,
                Name = "Course Test -xb",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 99,
                TotalHours = 20,
                CategoryId = 3
            },
            new()
            {
                Id = 22,
                Name = "Course Test -yb",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 120,
                TotalHours = 20,
                CategoryId = 3
            },
            new()
            {
                Id = 23,
                Name = "Course Test -zb",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 45,
                TotalHours = 20,
                CategoryId = 3
            },
            new()
            {
                Id = 24,
                Name = "Course Test -qb",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 34,
                TotalHours = 20,
                CategoryId = 3
            },
            new()
            {
                Id = 31,
                Name = "Course Test -xz",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 99,
                TotalHours = 20,
                CategoryId = 3
            },
            new()
            {
                Id = 32,
                Name = "Course Test -yz",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 120,
                TotalHours = 20,
                CategoryId = 1
            },
            new()
            {
                Id = 33,
                Name = "Course Test -zz",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 45,
                TotalHours = 20,
                CategoryId = 2
            },
            new()
            {
                Id = 34,
                Name = "Course Test -qz",
                Description = "Description Test",
                Title = "Title Test",
                Rating = 4,
                Price = 34,
                TotalHours = 20,
                CategoryId = 2
            }
        };
    }
    public Course? Get(int id)
    {
        return _courses.FirstOrDefault(course => course.Id == id);
    }
    public IList<Course?> GetAll()
    {
        return _courses.ToList();
    }
    public Task<IList<Course?>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
    public IList<Course> GetAllWithPredicate(Expression<Func<Course, bool>> predicate)
    {
        throw new NotImplementedException();
    }
    public Task<Course?> GetAsync(int id)
    {
        throw new NotImplementedException();
    }
    public IEnumerable<Course> GetCoursesByCategory(int categoryId)
    {
        return _courses.Where(c => c.CategoryId == categoryId).AsEnumerable();
    }
    public IEnumerable<Course> GetCoursesByName(string name)
    {
        throw new NotImplementedException();
    }
}
