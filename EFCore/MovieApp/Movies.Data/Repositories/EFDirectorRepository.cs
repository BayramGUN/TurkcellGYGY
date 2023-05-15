using Microsoft.EntityFrameworkCore;
using Movies.Data.Data;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Data.Repositories
{
    public class EFDirectorRepository : IDirectorRepository
    {
        private readonly MoviesDbContext moviesDbContext;

        public EFDirectorRepository(MoviesDbContext moviesDbContext)
        {
            this.moviesDbContext = moviesDbContext;
        }

        public void Create(Director entity)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(Director entity)
        {
            await moviesDbContext.Directors.AddAsync(entity);
            await moviesDbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Director>> GetAllAsync()
        {
            return await moviesDbContext.Directors.AsNoTracking().ToListAsync();
        }

        public async Task<Director?> GetByIdAsync(int id)
        {
            return await moviesDbContext.Directors.AsNoTracking().FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task UpdateAsync(Director entity)
        {
            moviesDbContext.Directors.Update(entity);
            await moviesDbContext.SaveChangesAsync();
        }
    }
}
