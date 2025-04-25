using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Core.Models
{
    public class GamePublisher
    {

        public GamePublisher() { }
        public GamePublisher(Guid gameId, Guid publisherId) 
        { 
            GameId = gameId;
            PublisherId = publisherId;
        }

        public Guid GameId { get; set; }

        public Game Game { get; set; }

        public Guid PublisherId { get; set; }

        public Publisher PublisherEntity { get;set; }

        public static (GamePublisher gamePublisher, string error) Create(Guid gameId, Guid publisherId)
        {
            var error = string.Empty;

            if (gameId == Guid.Empty)
            {
                error = "Укажите идентификатор игры";
            }

            if (publisherId == Guid.Empty)
            {
                error = "Укажите идентификатор издателя";
            }

            var gamePublisher = new GamePublisher(gameId, publisherId);

            return (gamePublisher, error);
        }
    }
}
