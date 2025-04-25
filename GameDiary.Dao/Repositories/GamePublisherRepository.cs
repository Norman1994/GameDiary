using GameDiary.Core.Abstractions;
using GameDiary.Core.Models;
using GameDiary.Dao.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Dao.Repositories
{
    public class GamePublisherRepository : IGamePublisherRepository
    {
        private readonly GameDiaryDbContext _dbContext;

        public GamePublisherRepository(GameDiaryDbContext dbContext) 
        { 
            _dbContext = dbContext;
        }

        public async Task AddGamePublisher(GamePublisher gamePublisher)
        {
            var gamePublisherEntity = new GamePublisherEntity
            {
                GameId = gamePublisher.GameId,
                PublisherId = gamePublisher.PublisherId
            };

            await _dbContext.GamePublisherEntities.AddAsync(gamePublisherEntity);
            await _dbContext.SaveChangesAsync();
        }

        public Task<Guid> UpdateGamePublisher(Guid gameId, Game publisherId)
        {
            throw new NotImplementedException();
        }
    }
}
