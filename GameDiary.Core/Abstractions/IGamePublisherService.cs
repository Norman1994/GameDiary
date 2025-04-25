using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Core.Abstractions
{
    public interface IGamePublisherService
    {
        Task AddGamePublisher(GamePublisher gamePublisher);

        Task<Guid> UpdateGamePublisher(Guid gameId, Game publisherId);
    }
}
