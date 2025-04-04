using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDiary.Dao.Entities
{
    public class GameDeveloperEntity
    {
        public Guid GameId { get; set; }

        public GameEntity GameEntity { get; set; }

        public Guid DeveloperId { get; set; }

        public DevelopEntity DevelopEntity { get; set; }
    }
}
