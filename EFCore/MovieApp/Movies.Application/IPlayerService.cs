using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application;

public interface IPlayerService
{
    Task<IEnumerable<PlayerListResponse>> GetPlayers();
    Task<int> CreateNewPlayer(CreatePlayerRequest request);
}

