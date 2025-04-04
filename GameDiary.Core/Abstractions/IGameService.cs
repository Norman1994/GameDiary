using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Core.Abstractions
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();

        Task<Guid> AddGame(Game game);

        Task<Guid> UpdateGame(Guid id, string name, decimal rating, GameStatus status, bool isLoving);

        Task<Guid> DeleteDeveloper(Guid id);
    }
}
