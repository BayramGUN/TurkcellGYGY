using BookmateApp.Entities;
using BookmateApp.Infrastructure.Data;
using BookmateApp.Infrastructure.Repositories.RepsitoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmateApp.Infrastructure.Repositories.EFRepositoryImplementations;
public class EFUserRepository : IUserRepository
{
    private readonly BookmateAppDbContext _context;

    public EFUserRepository(BookmateAppDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(User entity)
    {
        await _context.Users.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<User>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<User?> GetAsync(Guid id)
    {
        var user = await _context.Users!.AsNoTracking().SingleOrDefaultAsync(user => user.Id == id);
        return user; 
    }

    public async Task<User> GetUserByUsername(string username)
    {
        var user = await _context.Users!.SingleOrDefaultAsync(
            entity => entity.Username == username);
        return user;
    }

    public async Task<bool> IsExistAsync(Guid id) =>
        await _context.Users.AsNoTracking().AnyAsync(entity => entity.Id == id);

    public Task UpdateAsync(User entity)
    {
        throw new NotImplementedException();
    }
}

