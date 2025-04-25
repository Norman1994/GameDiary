using GameDiary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Dao.Entities
{
    public class GameEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Rating { get; set; }

        public GameStatus Status { get; set; }

        public bool IsLoving { get; set; }

        public List<GameDeveloperEntity> GameDevelopers { get; set; } = new();

        public List<GamePublisherEntity> GamePublishers { get; set; } = new();
    }
}
