﻿using Microsoft.EntityFrameworkCore;
using Movies.Data.Data;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Data.Repositories
{
    
    public class EFPlayerRepository : IPlayerRepository
    {
        private readonly MoviesDbContext moviesDbContext;

        public EFPlayerRepository(MoviesDbContext moviesDbContext)
        {
            this.moviesDbContext = moviesDbContext;
        }

        public void Create(Player entity)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(Player entity)
        {
            await moviesDbContext.Players.AddAsync(entity);
            await moviesDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existing = await moviesDbContext.Players.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
            moviesDbContext.Players.Remove(existing);
            await moviesDbContext.SaveChangesAsync();
        }

        public async Task<ICollection<Player>> GetAllAsync()
        {
            return await moviesDbContext.Players.ToListAsync();
        }

        public async Task<Player?> GetByIdAsync(int id)
        {
            return await moviesDbContext.Players.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public Task UpdateAsync(Player entity)
        {
            throw new NotImplementedException();
        }
    }
}
