using BookmateApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BookmateApp.Infrastructure.Repositories.RepsitoryInterfaces;

public interface IUserRepository : IRepository<User>
{
    Task<User> GetUserByUsername(string username);
}

