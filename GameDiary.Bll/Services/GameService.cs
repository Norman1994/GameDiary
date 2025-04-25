using GameDiary.Core.Abstractions;
using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Bll.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        { 
            _gameRepository = gameRepository;        
        }

        public async Task<Guid> AddGame(Game game)
        {
            return await _gameRepository.Create(game);
        }

        public async Task<Guid> DeleteDeveloper(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Game>> GetAllGames()
        {
            return await _gameRepository.Get();
        }

        public async Task<Guid> UpdateGame(Guid id, string name, decimal rating, GameStatus status, bool isLoving)
        {
            throw new NotImplementedException();
        }
    }
}
