using GameDiary.Core.Abstractions;
using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Bll.Services
{
    public class GamePublisherService : IGamePublisherService
    {
        private readonly IGamePublisherRepository _gamePublisherRepository;

        public GamePublisherService(IGamePublisherRepository gamePublisherRepository) 
        { 
            _gamePublisherRepository = gamePublisherRepository;
        }

        public async Task AddGamePublisher(GamePublisher gamePublisher)
        {
            await _gamePublisherRepository.AddGamePublisher(gamePublisher);
        }

        public Task<Guid> UpdateGamePublisher(Guid gameId, Game publisherId)
        {
            throw new NotImplementedException();
        }
    }
}
