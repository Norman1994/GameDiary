using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Core.Abstractions
{
    public interface IGameRepository
    {
        Task<List<Game>> Get();

        Task<Guid> Create(Game game);

        Task<Guid> Update(Guid id, string name, decimal rating, GameStatus status, bool isLoving);

        Task<Guid> Delete(Guid id);
    }
}
