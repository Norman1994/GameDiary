using AutoMapper;
using GameDiary.Core.Abstractions;
using GameDiary.Core.Models;
using GameDiary.Dao.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Dao.Repositories
{
    public class GameRepository : IGameRepository
    {
        public GameDiaryDbContext _dbContext;
        public readonly IMapper _mapper;

        public GameRepository(GameDiaryDbContext dbContext, IMapper mapper)
        { 
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Create(Game game)
        {
            var gameEntity = new GameEntity { 
                Id = game.Id,
                Name = game.Name,
                Rating = game.Rating,
                IsLoving = game.IsLoving,
                Status = game.Status
            };

            await _dbContext.Games.AddAsync(gameEntity);
            await _dbContext.SaveChangesAsync();

            return gameEntity.Id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Game>> Get()
        {
            var gameEntities = await _dbContext.Games
            .Include(g => g.GameDevelopers).ThenInclude(d => d.DevelopEntity)
            .Include(g => g.GamePublishers).ThenInclude(p => p.PublisherEntity)
            .AsNoTracking()
            .ToListAsync();

            return _mapper.Map<List<Game>>(gameEntities);
        }

        public async Task<Guid> Update(Guid id, string name, decimal rating, GameStatus status, bool isLoving)
        {
            throw new NotImplementedException();
        }
    }
}
