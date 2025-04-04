using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Dao.Entities
{
    public class GamePublisherEntity
    {
        public Guid GameId { get; set; }

        public GameEntity GameEntity { get; set; }

        public Guid PublisherId { get; set; }

        public PublisherEntity PublisherEntity { get; set; }
    }
}
