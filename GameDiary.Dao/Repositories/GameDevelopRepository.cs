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
    public class GameDevelopRepository : IGameDevelopRepository
    {
        private readonly GameDiaryDbContext _context;

        public GameDevelopRepository(GameDiaryDbContext context)
        { 
            _context = context;
        }

        public async Task Add(GameDeveloper gameDeveloper)
        {
            var gameDevelopEnitity = new GameDeveloperEntity { 
                GameId = gameDeveloper.GameId,
                DeveloperId = gameDeveloper.DevelopId
            };

            await _context.GameDeveloperEntities.AddAsync(gameDevelopEnitity);
            await _context.SaveChangesAsync();
        }

        public Task<Guid> Update(Guid gameId, Game developId)
        {
            throw new NotImplementedException();
        }
    }
}
