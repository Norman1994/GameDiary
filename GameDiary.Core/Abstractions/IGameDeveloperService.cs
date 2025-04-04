using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Core.Abstractions
{
    public interface IGameDeveloperService
    {
        Task<Guid> AddGameDeveloper(GameDeveloper gameDeveloper);

        Task<Guid> UpdateGameDeveloper(Guid gameId, Game developId);
    }
}
