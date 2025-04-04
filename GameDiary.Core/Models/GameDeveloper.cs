using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameDiary.Core.Models
{
    public class GameDeveloper
    {
        public GameDeveloper(Guid gameId, Guid developId) 
        { 
            GameId = gameId;
            DevelopId = developId;  
        }  

        public Guid GameId { get; set; }

        public Game Game { get; set; } 

        public Guid DevelopId { get; set; } 

        public Developer Developer { get; set; }

        public static (GameDeveloper gameDeveloper, string error) Create(Guid gameId, Guid developId)
        {
            var error = string.Empty;

            if (gameId == Guid.Empty)
            {
                error = "Укажите идентификатор игры";
            }

            if (developId == Guid.Empty)
            {
                error = "Укажите идентификатор разработчика";
            }

            var gameDeveloper = new GameDeveloper(gameId, developId);

            return (gameDeveloper, error);
        }

    }
}
