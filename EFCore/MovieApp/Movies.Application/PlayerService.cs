using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;
using Movies.Data.Repositories;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application
{
    public class PlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        public async Task<IEnumerable<PlayerListResponse>> GetPlayers()
        {
            var players = await _playerRepository.GetAllAsync();
            return players.Select(p => new PlayerListResponse
            {
                Name = p.Name,
                Lastname = p.LastName,
                Info = p.Info,
            });
        }
        public async Task<int> CreateNewPlayer(CreatePlayerRequest request)
        {
            Player player = new ()
            {
                Name = request.Name,
                LastName = request.Lastname,
                Info = request.Info,
            };
            await _playerRepository.CreateAsync(player);
            return player.Id;
        }
    }
}
