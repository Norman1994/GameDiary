using GameDiary.Core.Abstractions;
using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Bll.Services
{
    public class GameDeveloperService : IGameDeveloperService
    {
        private readonly IGameDevelopRepository _gameDevelopRepository;

        public GameDeveloperService(IGameDevelopRepository gameDevelopRepository)
        {
            _gameDevelopRepository = gameDevelopRepository;
        }

        public async Task AddGameDeveloper(GameDeveloper gameDeveloper)
        {
            await _gameDevelopRepository.Add(gameDeveloper);
        }

        public Task<Guid> UpdateGameDeveloper(Guid gameId, Game developId)
        {
            throw new NotImplementedException();
        }
    }
}
