using BookmateApp.Entities;
using BookmateApp.Infrastructure.Repositories.RepsitoryInterfaces;
using BookmateApp.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmateApp.Services.ServiceImplementations;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<User> ValidateUser(string username, string password)
    {
        var user = _userRepository.GetUserByUserName(username);
        if(password.Equals())
    }
}

