using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Core.Abstractions
{
    public interface IGameDevelopRepository
    {
        Task<Guid> Add(GameDeveloper gameDeveloper);

        Task<Guid> Update(Guid gameId, Game developId);
    }
}
